SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_Insert]
	@ID_PHONG numeric(18, 0),
	@ID_HOC_PHAN numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_PHONG_HOC_PHAN]
(
	[ID_PHONG],
	[ID_HOC_PHAN]
)
VALUES
(
	@ID_PHONG,
	@ID_HOC_PHAN
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_Update]
	@ID numeric(18, 0),
	@ID_PHONG numeric(18, 0),
	@ID_HOC_PHAN numeric(18, 0)
AS
UPDATE [dbo].[DM_PHONG_HOC_PHAN]
SET 
	[ID_PHONG] = @ID_PHONG,
	[ID_HOC_PHAN] = @ID_HOC_PHAN
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_UpdateAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_UpdateAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_UpdateAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0),
	@ID_PHONGOld numeric(18, 0)
AS
UPDATE [dbo].[DM_PHONG_HOC_PHAN]
SET
	[ID_PHONG] = @ID_PHONG
WHERE
	[ID_PHONG] = @ID_PHONGOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_UpdateAllWID_HOC_PHANLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_UpdateAllWID_HOC_PHANLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_UpdateAllWID_HOC_PHANLogic]
	@ID_HOC_PHAN numeric(18, 0),
	@ID_HOC_PHANOld numeric(18, 0)
AS
UPDATE [dbo].[DM_PHONG_HOC_PHAN]
SET
	[ID_HOC_PHAN] = @ID_HOC_PHAN
WHERE
	[ID_HOC_PHAN] = @ID_HOC_PHANOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_PHONG_HOC_PHAN]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_DeleteAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_DeleteAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_DeleteAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_PHONG_HOC_PHAN]
WHERE
	[ID_PHONG] = @ID_PHONG
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_DeleteAllWID_HOC_PHANLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_DeleteAllWID_HOC_PHANLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_DeleteAllWID_HOC_PHANLogic]
	@ID_HOC_PHAN numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_PHONG_HOC_PHAN]
WHERE
	[ID_HOC_PHAN] = @ID_HOC_PHAN
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_IsUpdatable]
	@ID_PHONG numeric(18, 0),
	@ID_HOC_PHAN numeric(18, 0),
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
	declare @v_ID_HOC_PHAN numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID_PHONG = ID_PHONG ,
	@v_ID_HOC_PHAN = ID_HOC_PHAN 
	 from DM_PHONG_HOC_PHAN with (updlock, rowlock, nowait)
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
	isnull( @v_ID_HOC_PHAN,dbo.C_Extrem_Number() ) <> isnull( @ID_HOC_PHAN ,dbo.C_Extrem_Number() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_HOC_PHAN]
FROM [dbo].[DM_PHONG_HOC_PHAN]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_SelectAll]
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_HOC_PHAN]
FROM [dbo].[DM_PHONG_HOC_PHAN]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_SelectAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_SelectAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_SelectAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0)
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_HOC_PHAN]
FROM [dbo].[DM_PHONG_HOC_PHAN]
WHERE
	[ID_PHONG] = @ID_PHONG
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_PHONG_HOC_PHAN_SelectAllWID_HOC_PHANLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_PHONG_HOC_PHAN_SelectAllWID_HOC_PHANLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_PHONG_HOC_PHAN_SelectAllWID_HOC_PHANLogic]
	@ID_HOC_PHAN numeric(18, 0)
AS
SELECT
	[ID],
	[ID_PHONG],
	[ID_HOC_PHAN]
FROM [dbo].[DM_PHONG_HOC_PHAN]
WHERE
	[ID_HOC_PHAN] = @ID_HOC_PHAN
GO

