SELECT TOP (1000) 
Id, 
Note,
Description,
CreatedDate,
BranchId, 
OrderId, 
OrderCode, 
OrderFullName, 
OrderTreatmentPlanId as OrderId, 
OrderTreatmentPlanServiceId as OrderItemId, 
TeethId, 
TeethName, 



TreatmentContentName as RawStepName,
IsDoctorMain,
DoctorUsername,
DoctorFullName,

IsAssistantMain,
AssistantUsername,
AssistantFullName,

IsFinish as IsFinishStage,
FinishDate as FinishStageDate,
IsFinishTreatment as IsFinishProcess,
CreatedAppComputerName,
UpdatedAppComputerName,

IsActive

FROM [VGS_DRV_ERP_GLB_TES].[dbo].[OrderTreatmentPlanServiceHistory]
where OrderId = 'DRV1-9084' and CreatedAppComputerName = 'WIN-DEV-7285' and OrderTreatmentPlanServiceId = '37554'
order by [Id] desc