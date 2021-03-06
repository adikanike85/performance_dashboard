IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_SCHEMA = 'eddsdbo' AND TABLE_NAME = 'QoS_DBCCLog')
BEGIN
EXEC('CREATE VIEW eddsdbo.QoS_DBCCLog
AS
SELECT
	[DatabaseName],
	[StartTime] AS DbccTime
FROM [dbo].[CommandLog]
WHERE CommandType = ''DBCC_CHECKDB''
	AND ErrorNumber = 0')
END