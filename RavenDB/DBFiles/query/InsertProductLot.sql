EXEC Distillation.UpdateProduction 58245, 3211234, 999123123, 9999999999, NULL

DECLaRE @sampleDate DATE
SET @sampleDate = '2022-05-03'

EXEC QualityControl.SubmitSample 'LOT222222', 9999999999, @sampleDate 

select * from Distillation.Production
select * from QualityControl.SampleSubmit