-- =============================================
-- Author:		<Sridhar Pettela>
-- Create date: <30th Aug 2020>
-- Description:	<Get the Filer details and update the filer details>
-- =============================================
CREATE PROCEDURE FTSP_GetAndUpdateFiler
	@emailAddress nvarchar(500),
	@efmFilerId nvarchar(50),
	@password  nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @UserSince DATETIME = NULL

	SELECT @UserSince = UserSince FROM [dbo].[Filer] WHERE EmailAddress = @emailAddress 

	Update [dbo].[Filer] SET EFMUserId = @efmFilerId, [Password] = @password, LastLogin=GETDATE(), UserSince=@UserSince WHERE EmailAddress = @emailAddress 

    -- Insert statements for procedure here
	SELECT [Id]
      ,[FirstName]
      ,[LastName]
      ,[MiddleName]
      ,[EmailAddress]
      ,[EFMUserId]
      ,[Password]
      ,[SecurityQuestion]
      ,[SecurityAnswer]
      ,[Roles]
      ,[IsApproved]
      ,[IsActive]
      ,[IsLockedOut]
      ,[ActiveIndicator]
      ,[LastUpdateFromEFM]
      ,[LastLogin]
      ,[LastLoginToEFM]
      ,[UserSince]
      ,[FTUserSince]
      ,[FilingAcceptedNotification]
      ,[FilingRejectedNotification]
      ,[FilingSubmitedNotification]
      ,[FilingFailedNotification]
      ,[ServiceStatusNotification]
      ,[eFileTexasNotiPref]
      ,[FirmSubmissionsWaitingOnClerkReview]
      ,[FirmSubmissionsReturnedByTheClerk]
      ,[RestrictFiling]
      ,[RestrictFilingComment]
      ,[ShowWelcomePageAtLogin]
      ,[Firm_id]
      ,[Attoney_id]
      ,[HeardAboutFiletime]
      ,[ReferrerEmailAddress]
      ,[Other]
      ,[ActivationLink]
      ,[PasswordResetLink]
      ,[LastFilingUpdateFromEFM]
  FROM [dbo].[Filer] WHERE EmailAddress = @emailAddress
END