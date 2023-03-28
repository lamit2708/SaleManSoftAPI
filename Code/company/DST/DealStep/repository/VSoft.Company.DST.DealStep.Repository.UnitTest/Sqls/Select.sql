﻿SELECT TOP (1000) 
Id, 
Note,
Description,
CreatedDate,
BranchId, 
DealStepId, 
DealStepCode, 
DealStepFullName, 
DealStepTreatmentPlanId as OrderId, 
DealStepTreatmentPlanServiceId as OrderItemId, 
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

FROM [VGS_DRV_ERP_GLB_TES].[dbo].[DealStepTreatmentPlanServiceHistory]
where DealStepId = 'DRV1-9084' and CreatedAppComputerName = 'WIN-DEV-7285' and DealStepTreatmentPlanServiceId = '37554'
order by [Id] desc