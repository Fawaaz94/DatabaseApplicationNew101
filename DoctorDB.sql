USE [DoctorDB]
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 2018/11/09 13:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ChangePassword]
	@Username varchar(50),
	@Password varchar(32),
	@Email varchar(100),
	@ContactNo varchar(15)
AS

BEGIN
	IF EXISTS(SELECT count(*) FROM ULogin WHERE Username = @Username)
		IF((SELECT count(*) FROM ULogin WHERE Email = @Email OR ContactNo = @ContactNo) = 1)
			BEGIN
				UPDATE ULogin SET UPassword = @Password WHERE Username = @Username
				SELECT 'Password Changed Succesfully' as UserTest
			END
		ELSE 
			SELECT 'Check Not Passed' AS UserTest
	ELSE
		SELECT 'Check Not Passed' AS UserTest
END;