SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_Insert]
	@ID_PHONG numeric(18, 0),
	@ID_DAI numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_PHONG_DAI]
(
	[ID_PHONG],
	[ID_DAI]
)
VALUES
(
	@ID_PHONG,
	@ID_DAI
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_Update]
	@ID numeric(18, 0),
	@ID_PHONG numeric(18, 0),
	@ID_DAI numeric(18, 0)
AS
UPDATE [dbo].[DM_PHONG_DAI]
SET 
	[ID_PHONG] = @ID_PHONG,
	[ID_DAI] = @ID_DAI
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_UpdateAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_UpdateAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_UpdateAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0),
	@ID_PHONGOld numeric(18, 0)
AS
UPDATE [dbo].[DM_PHONG_DAI]
SET
	[ID_PHONG] = @ID_PHONG
WHERE
	[ID_PHONG] = @ID_PHONGOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_UpdateAllWID_DAILogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_UpdateAllWID_DAILogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_UpdateAllWID_DAILogic]
	@ID_DAI numeric(18, 0),
	@ID_DAIOld numeric(18, 0)
AS
UPDATE [dbo].[DM_PHONG_DAI]
SET
	[ID_DAI] = @ID_DAI
WHERE
	[ID_DAI] = @ID_DAIOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_PHONG_DAI]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_DeleteAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_DeleteAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_DeleteAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_PHONG_DAI]
WHERE
	[ID_PHONG] = @ID_PHONG
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_DeleteAllWID_DAILogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_DeleteAllWID_DAILogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_DeleteAllWID_DAILogic]
	@ID_DAI numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_PHONG_DAI]
WHERE
	[ID_DAI] = @ID_DAI
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_IsUpdatable]
	@ID_PHONG numeric(18, 0),
	@ID_DAI numeric(18, 0),
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
	declare @v_ID_PHONG numeric(18, 0)
	declare @v_ID_DAI numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID_PHONG = ID_PHONG ,
	@v_ID_DAI = ID_DAI 
	 from DM_PHONG_DAI with (updlock, rowlock, nowait)
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
	isnull( @v_ID_PHONG,dbo.C_Extrem_Number() ) <> isnull( @ID_PHONG ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_DAI,dbo.C_Extrem_Number() ) <> isnull( @ID_DAI ,dbo.C_Extrem_Number() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_DAI]
FROM [dbo].[DM_PHONG_DAI]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_SelectAll]
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_DAI]
FROM [dbo].[DM_PHONG_DAI]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_SelectAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_SelectAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_SelectAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0)
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_DAI]
FROM [dbo].[DM_PHONG_DAI]
WHERE
	[ID_PHONG] = @ID_PHONG
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_DAI_SelectAllWID_DAILogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_DAI_SelectAllWID_DAILogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_DAI_SelectAllWID_DAILogic]
	@ID_DAI numeric(18, 0)
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_DAI]
FROM [dbo].[DM_PHONG_DAI]
WHERE
	[ID_DAI] = @ID_DAI
GO

