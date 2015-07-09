SET NOCOUNT ON
GO
USE [Nhansu]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_Insert]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_Insert]
	@CONTACT_CODE nvarchar(50),
	@JOINED_DATE datetime,
	@PERIODOF_CONTACT nvarchar(50),
	@POST_ID numeric(18, 0),
	@EMPLOYEE_TYPE_ID numeric(18, 0),
	@DEPARTMENT nvarchar(50),
	@SAL decimal(18, 0),
	@EMPLOYEE_ID numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[CONTACT]
(
	[CONTACT_CODE],
	[JOINED_DATE],
	[PERIODOF_CONTACT],
	[POST_ID],
	[EMPLOYEE_TYPE_ID],
	[DEPARTMENT],
	[SAL],
	[EMPLOYEE_ID]
)
VALUES
(
	@CONTACT_CODE,
	@JOINED_DATE,
	@PERIODOF_CONTACT,
	@POST_ID,
	@EMPLOYEE_TYPE_ID,
	@DEPARTMENT,
	@SAL,
	@EMPLOYEE_ID
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_Update]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_Update]
	@ID numeric(18, 0),
	@CONTACT_CODE nvarchar(50),
	@JOINED_DATE datetime,
	@PERIODOF_CONTACT nvarchar(50),
	@POST_ID numeric(18, 0),
	@EMPLOYEE_TYPE_ID numeric(18, 0),
	@DEPARTMENT nvarchar(50),
	@SAL decimal(18, 0),
	@EMPLOYEE_ID numeric(18, 0)
AS
UPDATE [dbo].[CONTACT]
SET 
	[CONTACT_CODE] = @CONTACT_CODE,
	[JOINED_DATE] = @JOINED_DATE,
	[PERIODOF_CONTACT] = @PERIODOF_CONTACT,
	[POST_ID] = @POST_ID,
	[EMPLOYEE_TYPE_ID] = @EMPLOYEE_TYPE_ID,
	[DEPARTMENT] = @DEPARTMENT,
	[SAL] = @SAL,
	[EMPLOYEE_ID] = @EMPLOYEE_ID
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_UpdateAllWPOST_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_UpdateAllWPOST_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_UpdateAllWPOST_IDLogic]
	@POST_ID numeric(18, 0),
	@POST_IDOld numeric(18, 0)
AS
UPDATE [dbo].[CONTACT]
SET
	[POST_ID] = @POST_ID
WHERE
	[POST_ID] = @POST_IDOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_UpdateAllWEMPLOYEE_TYPE_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_UpdateAllWEMPLOYEE_TYPE_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_UpdateAllWEMPLOYEE_TYPE_IDLogic]
	@EMPLOYEE_TYPE_ID numeric(18, 0),
	@EMPLOYEE_TYPE_IDOld numeric(18, 0)
AS
UPDATE [dbo].[CONTACT]
SET
	[EMPLOYEE_TYPE_ID] = @EMPLOYEE_TYPE_ID
WHERE
	[EMPLOYEE_TYPE_ID] = @EMPLOYEE_TYPE_IDOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_UpdateAllWEMPLOYEE_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_UpdateAllWEMPLOYEE_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_UpdateAllWEMPLOYEE_IDLogic]
	@EMPLOYEE_ID numeric(18, 0),
	@EMPLOYEE_IDOld numeric(18, 0)
AS
UPDATE [dbo].[CONTACT]
SET
	[EMPLOYEE_ID] = @EMPLOYEE_ID
WHERE
	[EMPLOYEE_ID] = @EMPLOYEE_IDOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_Delete]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[CONTACT]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_DeleteAllWPOST_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_DeleteAllWPOST_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_DeleteAllWPOST_IDLogic]
	@POST_ID numeric(18, 0)
AS
DELETE
FROM [dbo].[CONTACT]
WHERE
	[POST_ID] = @POST_ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_DeleteAllWEMPLOYEE_TYPE_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_DeleteAllWEMPLOYEE_TYPE_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_DeleteAllWEMPLOYEE_TYPE_IDLogic]
	@EMPLOYEE_TYPE_ID numeric(18, 0)
AS
DELETE
FROM [dbo].[CONTACT]
WHERE
	[EMPLOYEE_TYPE_ID] = @EMPLOYEE_TYPE_ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_DeleteAllWEMPLOYEE_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_DeleteAllWEMPLOYEE_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_DeleteAllWEMPLOYEE_IDLogic]
	@EMPLOYEE_ID numeric(18, 0)
AS
DELETE
FROM [dbo].[CONTACT]
WHERE
	[EMPLOYEE_ID] = @EMPLOYEE_ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CONTACT_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CONTACT_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_CONTACT_IsUpdatable]
	@CONTACT_CODE nvarchar(50),
	@JOINED_DATE datetime,
	@PERIODOF_CONTACT nvarchar(50),
	@POST_ID numeric(18, 0),
	@EMPLOYEE_TYPE_ID numeric(18, 0),
	@DEPARTMENT nvarchar(50),
	@SAL decimal(18, 0),
	@EMPLOYEE_ID numeric(18, 0),
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||	a)thu lock neu khong lock duoc thi user khac dang lock 
||    b) neu khong co thi da bi xoa 
|| 2. xem co giong ban dau khong, neu khong giong thi da bi thay
*/
AS
BEGIN
/*********************************************
|| COMMON SETTINGS
**********************************************/
SET NOCOUNT ON
/**********************************************************
|| DECLARATION
***********************************************************/
	declare @v_CONTACT_CODE nvarchar(50)
	declare @v_JOINED_DATE datetime
	declare @v_PERIODOF_CONTACT nvarchar(50)
	declare @v_POST_ID numeric(18, 0)
	declare @v_EMPLOYEE_TYPE_ID numeric(18, 0)
	declare @v_DEPARTMENT nvarchar(50)
	declare @v_SAL decimal(18, 0)
	declare @v_EMPLOYEE_ID numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_CONTACT_CODE = CONTACT_CODE ,
	@v_JOINED_DATE = JOINED_DATE ,
	@v_PERIODOF_CONTACT = PERIODOF_CONTACT ,
	@v_POST_ID = POST_ID ,
	@v_EMPLOYEE_TYPE_ID = EMPLOYEE_TYPE_ID ,
	@v_DEPARTMENT = DEPARTMENT ,
	@v_SAL = SAL ,
	@v_EMPLOYEE_ID = EMPLOYEE_ID 
	 from CONTACT with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => du lieu da bi xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_CONTACT_CODE,dbo.C_Extrem_Str() ) <> isnull( @CONTACT_CODE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_JOINED_DATE,dbo.C_Extrem_Date() ) <> isnull( @JOINED_DATE ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_PERIODOF_CONTACT,dbo.C_Extrem_Str() ) <> isnull( @PERIODOF_CONTACT ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_POST_ID,dbo.C_Extrem_Number() ) <> isnull( @POST_ID ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_EMPLOYEE_TYPE_ID,dbo.C_Extrem_Number() ) <> isnull( @EMPLOYEE_TYPE_ID ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_DEPARTMENT,dbo.C_Extrem_Str() ) <> isnull( @DEPARTMENT ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_SAL,dbo.C_Extrem_Str() ) <> isnull( @SAL ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_EMPLOYEE_ID,dbo.C_Extrem_Number() ) <> isnull( @EMPLOYEE_ID ,dbo.C_Extrem_Number() ) 
	)
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_UPDATED()
		raiserror ('RECORD_CHANGED',16,1)
		goto ERROR_HANDLER
	end
		return
	/********************************************************* 
	|| ERROR HANDLING
	*********************************************************/
	ERROR_HANDLER:
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DEPARTMENT_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DEPARTMENT_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DEPARTMENT_Insert]
	@DEPARMENT_CODE nvarchar(255),
	@NAME nvarchar(255),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DEPARTMENT]
(
	[DEPARMENT_CODE],
	[NAME]
)
VALUES
(
	@DEPARMENT_CODE,
	@NAME
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DEPARTMENT_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DEPARTMENT_Update]
GO

CREATE PROCEDURE [dbo].[pr_DEPARTMENT_Update]
	@ID numeric(18, 0),
	@DEPARMENT_CODE nvarchar(255),
	@NAME nvarchar(255)
AS
UPDATE [dbo].[DEPARTMENT]
SET 
	[DEPARMENT_CODE] = @DEPARMENT_CODE,
	[NAME] = @NAME
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DEPARTMENT_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DEPARTMENT_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DEPARTMENT_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DEPARTMENT]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DEPARTMENT_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DEPARTMENT_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DEPARTMENT_IsUpdatable]
	@DEPARMENT_CODE nvarchar(255),
	@NAME nvarchar(255),
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||	a)thu lock neu khong lock duoc thi user khac dang lock 
||    b) neu khong co thi da bi xoa 
|| 2. xem co giong ban dau khong, neu khong giong thi da bi thay
*/
AS
BEGIN
/*********************************************
|| COMMON SETTINGS
**********************************************/
SET NOCOUNT ON
/**********************************************************
|| DECLARATION
***********************************************************/
	declare @v_DEPARMENT_CODE nvarchar(255)
	declare @v_NAME nvarchar(255)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_DEPARMENT_CODE = DEPARMENT_CODE ,
	@v_NAME = NAME 
	 from DEPARTMENT with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => du lieu da bi xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_DEPARMENT_CODE,dbo.C_Extrem_Str() ) <> isnull( @DEPARMENT_CODE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NAME,dbo.C_Extrem_Str() ) <> isnull( @NAME ,dbo.C_Extrem_Str() ) 
	)
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_UPDATED()
		raiserror ('RECORD_CHANGED',16,1)
		goto ERROR_HANDLER
	end
		return
	/********************************************************* 
	|| ERROR HANDLING
	*********************************************************/
	ERROR_HANDLER:
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_Insert]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_Insert]
	@EMPLOYEE_CODE nvarchar(50),
	@NAME nvarchar(255),
	@BIRTHDAY datetime,
	@MALE nvarchar(1),
	@PHONE nvarchar(255),
	@ADDRESS nvarchar(255),
	@QUALIFICATION nvarchar(255),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[EMPLOYEE]
(
	[EMPLOYEE_CODE],
	[NAME],
	[BIRTHDAY],
	[MALE],
	[PHONE],
	[ADDRESS],
	[QUALIFICATION]
)
VALUES
(
	@EMPLOYEE_CODE,
	@NAME,
	@BIRTHDAY,
	@MALE,
	@PHONE,
	@ADDRESS,
	@QUALIFICATION
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_Update]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_Update]
	@ID numeric(18, 0),
	@EMPLOYEE_CODE nvarchar(50),
	@NAME nvarchar(255),
	@BIRTHDAY datetime,
	@MALE nvarchar(1),
	@PHONE nvarchar(255),
	@ADDRESS nvarchar(255),
	@QUALIFICATION nvarchar(255)
AS
UPDATE [dbo].[EMPLOYEE]
SET 
	[EMPLOYEE_CODE] = @EMPLOYEE_CODE,
	[NAME] = @NAME,
	[BIRTHDAY] = @BIRTHDAY,
	[MALE] = @MALE,
	[PHONE] = @PHONE,
	[ADDRESS] = @ADDRESS,
	[QUALIFICATION] = @QUALIFICATION
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_Delete]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[EMPLOYEE]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_IsUpdatable]
	@EMPLOYEE_CODE nvarchar(50),
	@NAME nvarchar(255),
	@BIRTHDAY datetime,
	@MALE nvarchar(1),
	@PHONE nvarchar(255),
	@ADDRESS nvarchar(255),
	@QUALIFICATION nvarchar(255),
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||	a)thu lock neu khong lock duoc thi user khac dang lock 
||    b) neu khong co thi da bi xoa 
|| 2. xem co giong ban dau khong, neu khong giong thi da bi thay
*/
AS
BEGIN
/*********************************************
|| COMMON SETTINGS
**********************************************/
SET NOCOUNT ON
/**********************************************************
|| DECLARATION
***********************************************************/
	declare @v_EMPLOYEE_CODE nvarchar(50)
	declare @v_NAME nvarchar(255)
	declare @v_BIRTHDAY datetime
	declare @v_MALE nvarchar(1)
	declare @v_PHONE nvarchar(255)
	declare @v_ADDRESS nvarchar(255)
	declare @v_QUALIFICATION nvarchar(255)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_EMPLOYEE_CODE = EMPLOYEE_CODE ,
	@v_NAME = NAME ,
	@v_BIRTHDAY = BIRTHDAY ,
	@v_MALE = MALE ,
	@v_PHONE = PHONE ,
	@v_ADDRESS = ADDRESS ,
	@v_QUALIFICATION = QUALIFICATION 
	 from EMPLOYEE with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => du lieu da bi xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_EMPLOYEE_CODE,dbo.C_Extrem_Str() ) <> isnull( @EMPLOYEE_CODE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NAME,dbo.C_Extrem_Str() ) <> isnull( @NAME ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_BIRTHDAY,dbo.C_Extrem_Date() ) <> isnull( @BIRTHDAY ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_MALE,dbo.C_Extrem_Str() ) <> isnull( @MALE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_PHONE,dbo.C_Extrem_Str() ) <> isnull( @PHONE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ADDRESS,dbo.C_Extrem_Str() ) <> isnull( @ADDRESS ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_QUALIFICATION,dbo.C_Extrem_Str() ) <> isnull( @QUALIFICATION ,dbo.C_Extrem_Str() ) 
	)
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_UPDATED()
		raiserror ('RECORD_CHANGED',16,1)
		goto ERROR_HANDLER
	end
		return
	/********************************************************* 
	|| ERROR HANDLING
	*********************************************************/
	ERROR_HANDLER:
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_TYPE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_TYPE_Insert]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_TYPE_Insert]
	@EMPLOYEE_TYPE_CODE nvarchar(50),
	@NAME nvarchar(255),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[EMPLOYEE_TYPE]
(
	[EMPLOYEE_TYPE_CODE],
	[NAME]
)
VALUES
(
	@EMPLOYEE_TYPE_CODE,
	@NAME
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_TYPE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_TYPE_Update]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_TYPE_Update]
	@ID numeric(18, 0),
	@EMPLOYEE_TYPE_CODE nvarchar(50),
	@NAME nvarchar(255)
AS
UPDATE [dbo].[EMPLOYEE_TYPE]
SET 
	[EMPLOYEE_TYPE_CODE] = @EMPLOYEE_TYPE_CODE,
	[NAME] = @NAME
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_TYPE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_TYPE_Delete]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_TYPE_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[EMPLOYEE_TYPE]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_EMPLOYEE_TYPE_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_EMPLOYEE_TYPE_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_EMPLOYEE_TYPE_IsUpdatable]
	@EMPLOYEE_TYPE_CODE nvarchar(50),
	@NAME nvarchar(255),
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||	a)thu lock neu khong lock duoc thi user khac dang lock 
||    b) neu khong co thi da bi xoa 
|| 2. xem co giong ban dau khong, neu khong giong thi da bi thay
*/
AS
BEGIN
/*********************************************
|| COMMON SETTINGS
**********************************************/
SET NOCOUNT ON
/**********************************************************
|| DECLARATION
***********************************************************/
	declare @v_EMPLOYEE_TYPE_CODE nvarchar(50)
	declare @v_NAME nvarchar(255)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_EMPLOYEE_TYPE_CODE = EMPLOYEE_TYPE_CODE ,
	@v_NAME = NAME 
	 from EMPLOYEE_TYPE with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => du lieu da bi xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_EMPLOYEE_TYPE_CODE,dbo.C_Extrem_Str() ) <> isnull( @EMPLOYEE_TYPE_CODE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NAME,dbo.C_Extrem_Str() ) <> isnull( @NAME ,dbo.C_Extrem_Str() ) 
	)
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_UPDATED()
		raiserror ('RECORD_CHANGED',16,1)
		goto ERROR_HANDLER
	end
		return
	/********************************************************* 
	|| ERROR HANDLING
	*********************************************************/
	ERROR_HANDLER:
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_POST_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_POST_Insert]
GO

CREATE PROCEDURE [dbo].[pr_POST_Insert]
	@POST_CODE nvarchar(50),
	@NAME nvarchar(50),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[POST]
(
	[POST_CODE],
	[NAME]
)
VALUES
(
	@POST_CODE,
	@NAME
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_POST_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_POST_Update]
GO

CREATE PROCEDURE [dbo].[pr_POST_Update]
	@ID numeric(18, 0),
	@POST_CODE nvarchar(50),
	@NAME nvarchar(50)
AS
UPDATE [dbo].[POST]
SET 
	[POST_CODE] = @POST_CODE,
	[NAME] = @NAME
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_POST_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_POST_Delete]
GO

CREATE PROCEDURE [dbo].[pr_POST_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[POST]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_POST_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_POST_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_POST_IsUpdatable]
	@POST_CODE nvarchar(50),
	@NAME nvarchar(50),
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||	a)thu lock neu khong lock duoc thi user khac dang lock 
||    b) neu khong co thi da bi xoa 
|| 2. xem co giong ban dau khong, neu khong giong thi da bi thay
*/
AS
BEGIN
/*********************************************
|| COMMON SETTINGS
**********************************************/
SET NOCOUNT ON
/**********************************************************
|| DECLARATION
***********************************************************/
	declare @v_POST_CODE nvarchar(50)
	declare @v_NAME nvarchar(50)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_POST_CODE = POST_CODE ,
	@v_NAME = NAME 
	 from POST with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => du lieu da bi xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_POST_CODE,dbo.C_Extrem_Str() ) <> isnull( @POST_CODE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NAME,dbo.C_Extrem_Str() ) <> isnull( @NAME ,dbo.C_Extrem_Str() ) 
	)
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_UPDATED()
		raiserror ('RECORD_CHANGED',16,1)
		goto ERROR_HANDLER
	end
		return
	/********************************************************* 
	|| ERROR HANDLING
	*********************************************************/
	ERROR_HANDLER:
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_ROLL_CAST_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_ROLL_CAST_Insert]
GO

CREATE PROCEDURE [dbo].[pr_ROLL_CAST_Insert]
	@BREAK_DAY decimal(18, 0),
	@ADD_DAY decimal(18, 0),
	@TOTAL decimal(18, 0),
	@EMPLOYEE_ID numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[ROLL_CAST]
(
	[BREAK_DAY],
	[ADD_DAY],
	[TOTAL],
	[EMPLOYEE_ID]
)
VALUES
(
	@BREAK_DAY,
	@ADD_DAY,
	@TOTAL,
	@EMPLOYEE_ID
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_ROLL_CAST_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_ROLL_CAST_Update]
GO

CREATE PROCEDURE [dbo].[pr_ROLL_CAST_Update]
	@ID numeric(18, 0),
	@BREAK_DAY decimal(18, 0),
	@ADD_DAY decimal(18, 0),
	@TOTAL decimal(18, 0),
	@EMPLOYEE_ID numeric(18, 0)
AS
UPDATE [dbo].[ROLL_CAST]
SET 
	[BREAK_DAY] = @BREAK_DAY,
	[ADD_DAY] = @ADD_DAY,
	[TOTAL] = @TOTAL,
	[EMPLOYEE_ID] = @EMPLOYEE_ID
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_ROLL_CAST_UpdateAllWEMPLOYEE_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_ROLL_CAST_UpdateAllWEMPLOYEE_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_ROLL_CAST_UpdateAllWEMPLOYEE_IDLogic]
	@EMPLOYEE_ID numeric(18, 0),
	@EMPLOYEE_IDOld numeric(18, 0)
AS
UPDATE [dbo].[ROLL_CAST]
SET
	[EMPLOYEE_ID] = @EMPLOYEE_ID
WHERE
	[EMPLOYEE_ID] = @EMPLOYEE_IDOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_ROLL_CAST_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_ROLL_CAST_Delete]
GO

CREATE PROCEDURE [dbo].[pr_ROLL_CAST_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[ROLL_CAST]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_ROLL_CAST_DeleteAllWEMPLOYEE_IDLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_ROLL_CAST_DeleteAllWEMPLOYEE_IDLogic]
GO

CREATE PROCEDURE [dbo].[pr_ROLL_CAST_DeleteAllWEMPLOYEE_IDLogic]
	@EMPLOYEE_ID numeric(18, 0)
AS
DELETE
FROM [dbo].[ROLL_CAST]
WHERE
	[EMPLOYEE_ID] = @EMPLOYEE_ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_ROLL_CAST_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_ROLL_CAST_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_ROLL_CAST_IsUpdatable]
	@BREAK_DAY decimal(18, 0),
	@ADD_DAY decimal(18, 0),
	@TOTAL decimal(18, 0),
	@EMPLOYEE_ID numeric(18, 0),
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||	a)thu lock neu khong lock duoc thi user khac dang lock 
||    b) neu khong co thi da bi xoa 
|| 2. xem co giong ban dau khong, neu khong giong thi da bi thay
*/
AS
BEGIN
/*********************************************
|| COMMON SETTINGS
**********************************************/
SET NOCOUNT ON
/**********************************************************
|| DECLARATION
***********************************************************/
	declare @v_BREAK_DAY decimal(18, 0)
	declare @v_ADD_DAY decimal(18, 0)
	declare @v_TOTAL decimal(18, 0)
	declare @v_EMPLOYEE_ID numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_BREAK_DAY = BREAK_DAY ,
	@v_ADD_DAY = ADD_DAY ,
	@v_TOTAL = TOTAL ,
	@v_EMPLOYEE_ID = EMPLOYEE_ID 
	 from ROLL_CAST with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => du lieu da bi xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_BREAK_DAY, ) <> isnull( @BREAK_DAY , )  OR 
	isnull( @v_ADD_DAY, ) <> isnull( @ADD_DAY , )  OR 
	isnull( @v_TOTAL, ) <> isnull( @TOTAL , )  OR 
	isnull( @v_EMPLOYEE_ID,dbo.C_Extrem_Number() ) <> isnull( @EMPLOYEE_ID ,dbo.C_Extrem_Number() ) 
	)
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_UPDATED()
		raiserror ('RECORD_CHANGED',16,1)
		goto ERROR_HANDLER
	end
		return
	/********************************************************* 
	|| ERROR HANDLING
	*********************************************************/
	ERROR_HANDLER:
END
GO

