USE EDDSPerformance
GO

IF NOT EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'QoS_SourceDatetime' AND TABLE_SCHEMA = N'EDDSDBO') 
BEGIN
	CREATE TABLE [eddsdbo].QoS_SourceDatetime
	(
		QSDID  INT IDENTITY ( 1 , 1 ),
		[quotidian] [datetime] NULL
	)
END
GO