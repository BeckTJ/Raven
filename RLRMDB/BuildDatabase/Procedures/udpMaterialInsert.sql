CREATE OR ALTER PROCEDURE Materials.MaterialInsert
    (@materialNumber AS INT,
    @materialName AS VARCHAR(50),
    @nameAbreviation AS VARCHAR(10),
    @permitNumber AS VARCHAR(25),
    @rawMaterialCode AS VARCHAR(3),
    @productCode AS VARCHAR(3),
    @carbonDrumRequired AS BIT,
    @carbonDrumDaysAllowed AS INT = NULL,
    @carbonDrumWeightAllowed AS INT = NULL,
    @batchManaged AS BIT,
    @requiresProcessOrder AS BIT,
    @unitOfIssue AS CHAR(2),
    @isRawMaterial AS BIT,
    @vendorName AS VARCHAR(25),
    @sequenceNumber AS INT)
AS
BEGIN TRAN MaterialInsert
BEGIN TRY 
INSERT INTO Materials.Material
    (MaterialName, MaterialNameAbreviation, PermitNumber, RawMaterialCode, ProductCode, CarbonDrumRequired, CarbonDrumDaysAllowed, CarbonDrumWeightAllowed)
VALUES(@materialName, @nameAbreviation, @permitNumber, @rawMaterialCode, @productCode, @carbonDrumRequired, @carbonDrumDaysAllowed, @carbonDrumWeightAllowed);

DECLARE @nameId AS INT
SET @nameId = (SELECT NameId
FROM Materials.Material
WHERE MaterialName = @materialName);

INSERT INTO Materials.MaterialNumber
    (MaterialNumber, NameId,  BatchManaged, RequiresProcessOrder, UnitOfIssue, IsRawMaterial)
VALUES(@materialNumber, @nameId,  @batchManaged, @requiresProcessOrder, @unitOfIssue, @isRawMaterial);

DECLARE @vendorId AS INT
IF EXISTS(SELECT VendorId
FROM Vendors.Vendor
WHERE VendorName = @vendorName)
BEGIN
    SET @vendorId =(SELECT VendorId
    FROM Vendors.Vendor
    WHERE VendorName = @vendorName);
END
ELSE
BEGIN
    INSERT INTO Vendors.Vendor
        (VendorName)
    VALUES(@vendorName);

    SET @vendorId =(SELECT vendorId
    FROM Vendors.Vendor
    WHERE vendorName = @vendorName);
END

DECLARE @sequenceId AS INT
SET @sequenceId =(SELECT sequenceId
FROM Distillation.ProductNumberSequence
WHERE sequenceIdStart = @sequenceNumber);

DECLARE @currentSequenceId AS INT
SET @currentSequenceId =(SELECT sequenceIdStart
FROM Distillation.ProductNumberSequence
WHERE sequenceId = @sequenceId);

INSERT INTO Materials.MaterialId
    (materialNumber, vendorId,sequenceId, currentSequenceId)
VALUES(@materialNumber, @vendorId, @sequenceId, @currentSequenceId);
COMMIT;

END TRY
BEGIN CATCH
    THROW;
    ROLLBACK;
END CATCH