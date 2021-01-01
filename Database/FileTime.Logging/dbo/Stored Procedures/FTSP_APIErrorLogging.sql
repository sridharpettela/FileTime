CREATE PROCEDURE [dbo].[FTSP_APIErrorLogging]
 @Message nvarchar(max)
,@RequestMethod varchar(50)
,@RequestUri varchar(50)
,@TimeUtc datetime
as
begin

INSERT INTO [dbo].[APIError]
           (
            [Message]
           ,[RequestMethod]
           ,[RequestUri]
           ,[TimeUtc])
     VALUES
           (
            @Message 
           ,@RequestMethod 
           ,@RequestUri 
           ,@TimeUtc)
end


GO