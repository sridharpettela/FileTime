CREATE PROCEDURE [dbo].[FTSP_APILogging]
     @Host NVARCHAR(100)
	,@Headers NVARCHAR(500)
	,@StatusCode VARCHAR(50)
	,@RequestBody NVARCHAR(max)
	,@RequestedMethod NVARCHAR(max)
	,@UserHostAddress NVARCHAR(100)
	,@Useragent NVARCHAR(100)
	,@AbsoluteUri NVARCHAR(100)
	,@RequestType NVARCHAR(100)
AS
BEGIN
	INSERT INTO [dbo].[APILog] (
		[Host]
		,[Headers]
		,[StatusCode]
		,[TimeUtc]
		,[RequestBody]
		,[RequestedMethod]
		,[UserHostAddress]
		,[Useragent]
		,[AbsoluteUri]
		,[RequestType]
		)
	VALUES (
		@Host
		,@Headers
		,@StatusCode
		,getdate()
		,@RequestBody
		,@RequestedMethod
		,@UserHostAddress
		,@Useragent
		,@AbsoluteUri
		,@RequestType
		)
END

GO

