CREATE OR ALTER PROCEDURE QualityControl.SubmitSample
    (@sampleNumber AS CHAR(8), @lotNumber AS NUMERIC, @sampleDate DATE)
AS

DECLARE @id VARCHAR(10)
DECLARE @productId VARCHAR(10)

SET @id = (SELECT ProductLotNumber FROM Distillation.Production
            WHERE InspectionLotNumber = @lotNumber)

set @productId = Distillation.UpdateProductId(@id,@sampleDate)

INSERT INTO QualityControl.SampleSubmit(SampleSubmitNumber, InspectionLotNumber, SampleDate)
VALUES
    (@sampleNumber, @lotNumber, @sampleDate);
UPDATE Distillation.Production
SET SampleSubmitNumber = (SELECT SampleSubmitNumber FROM QualityControl.SampleSubmit
                            WHERE SampleSubmitNumber = @sampleNumber),
    ProductLotNumber = @productId
WHERE InspectionLotNumber = @lotNumber

GO

    CREATE OR ALTER PROCEDURE Distillation.SetRawMaterial(
    @materialNumber INT,
    @vendor CHAR(25),
    @vendorBatchNumber VARCHAR(25) = NULL,
    @inspectionLotNumber NUMERIC = NULL,
    @sapBatchNumber INT = NULL,
    @sampleSubmitNumber CHAR(8),
    @containerNumber CHAR(7) = NULL,
    @numberOfDrums INT = 1,
    @drumWeight DECIMAL(6,2) = NULL,
    @sampleDate DATE    
)
AS

    EXEC QualityControl.SubmitSample @sampleSubmitNumber,@inspectionlotNumber,@sampleDate;
    EXEC Materials.AddVendorBatch @vendor, @vendorBatchNumber, @materialNumber, @numberOfDrums;
    EXEC Distillation.RawMaterialUpdate @materialNumber, @vendorBatchNumber,@inspectionLotNumber,@sapBatchNumber,@sampleSubmitNumber,@sampleDate,@containerNumber,@numberOfDrums,@drumWeight
GO

   CREATE OR ALTER PROCEDURE InsertRawMaterial
AS
BEGIN

    CREATE TABLE #rawMaterial(
        Id INT IDENTITY(1,1),
        SampleDate DATE,
        MaterialNumber INT,
        Vendor VARCHAR(25),
        VendorBatchNumber VARCHAR(25),
        SapBatchNumber INT,
        InspectionLotNumber NUMERIC,
        ContainerNumber CHAR(7),
        SampleSubmitNumber CHAR(8),
        Quantity INT,
        DrumWeight DECIMAL(6,2),

    )
 
    
    BULK INSERT #rawMaterial FROM '..\..\usr\raven\buildfiles\BuildFiles\RawMaterialData.csv'
    WITH(
        FORMAT = 'csv',
        FIRSTROW = 2,
        FIELDTERMINATOR = ',',
        ROWTERMINATOR = '\n',
        KEEPNULLS
    )

            DECLARE @materialNumber INT
            DECLARE @vendor VARCHAR(25)
            DECLARE @vendorBatchNumber VARCHAR(25)
            DECLARE @inspectionLotNumber NUMERIC
            DECLARE @sapBatchNumber INT
            DECLARE @sampleSubmitNumber CHAR(8)
            DECLARE @containerNumber CHAR(7)
            DECLARE @numberOfDrums INT
            DECLARE @drumWeight DECIMAL(6,2)
            DECLARE @sampleDate DATE
            DECLARE @rows INT
            DECLARE @index INT
            
            SET @rows = (SELECT COUNT(*) FROM #rawMaterial)
            SET @index = 1

            WHILE(@index <= @rows)
                BEGIN
                SET @materialNumber = (select materialnumber from #rawMaterial where id = @index)
                SET @vendor = (select vendor from #rawMaterial where id = @index)
                SET @vendorBatchNumber = (select VendorBatchNumber from #rawMaterial where id = @index)
                SET @inspectionLotNumber = (select InspectionLotNumber from #rawMaterial where id = @index)
                SET @sapBatchNumber = (select SapBatchNumber from #rawMaterial where id = @index)
                SET @sampleSubmitNumber = (select SampleSubmitNumber from #rawMaterial where id = @index)
                SET @containerNumber = (select ContainerNumber from #rawMaterial where id = @index)
                SET @numberOfDrums = (select Quantity from #rawMaterial where id = @index)
                SET @drumWeight = (select drumWeight from #rawMaterial where id = @index)
                SET @sampleDate = (select SampleDate from #rawMaterial where id = @index)

                EXEC Distillation.SetRawMaterial @materialNumber, @vendor, @vendorBatchNumber, @inspectionLotNumber, @sapBatchNumber, @sampleSubmitNumber, @containerNumber, @numberOfDrums, @drumWeight, @sampleDate
                
                SET @index += 1
                END
                
END
GO
