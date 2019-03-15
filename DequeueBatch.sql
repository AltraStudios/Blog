CREATE PROCEDURE [dbo].[DequeueBatch] (
	@Tablename NVARCHAR(100)
	,@Columnname NVARCHAR(100)
	,@StartDateColumnName NVARCHAR(100)
	,@Where NVARCHAR(max)
	,@BatchSize INT
	,@NewStatus NVARCHAR(1)
	,@OldStatus NVARCHAR(1)
	)
AS
SET NOCOUNT ON

DECLARE @excestr NVARCHAR(max)

SET TRANSACTION ISOLATION LEVEL READ COMMITTED
SET @excestr = 'update top(' + str(@BatchSize) + ') ' + @Tablename + ' WITH (UPDLOCK, READPAST)
SET '+@Columnname+' = '+ @NewStatus+', '+ @StartDateColumnName + ' = GETUTCDATE() ' +'
OUTPUT inserted.*
FROM ' + @Tablename + ' 
WHERE '+@Columnname+' =  '+ @OldStatus + @Where



EXEC (@excestr)
