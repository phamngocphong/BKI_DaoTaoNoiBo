SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_Insert]
	@KHU_VUC numeric(18, 0),
	@ID_NGACH numeric(18, 0),
	@ID_PHONG numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_NGACH_PHONG]
(
	[KHU_VUC],
	[ID_NGACH],
	[ID_PHONG]
)
VALUES
(
	@KHU_VUC,
	@ID_NGACH,
	@ID_PHONG
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_Update]
	@ID numeric(18, 0),
	@KHU_VUC numeric(18, 0),
	@ID_NGACH numeric(18, 0),
	@ID_PHONG numeric(18, 0)
AS
UPDATE [dbo].[DM_NGACH_PHONG]
SET 
	[KHU_VUC] = @KHU_VUC,
	[ID_NGACH] = @ID_NGACH,
	[ID_PHONG] = @ID_PHONG
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_UpdateAllWID_NGACHLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_UpdateAllWID_NGACHLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_UpdateAllWID_NGACHLogic]
	@ID_NGACH numeric(18, 0),
	@ID_NGACHOld numeric(18, 0)
AS
UPDATE [dbo].[DM_NGACH_PHONG]
SET
	[ID_NGACH] = @ID_NGACH
WHERE
	[ID_NGACH] = @ID_NGACHOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_UpdateAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_UpdateAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_UpdateAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0),
	@ID_PHONGOld numeric(18, 0)
AS
UPDATE [dbo].[DM_NGACH_PHONG]
SET
	[ID_PHONG] = @ID_PHONG
WHERE
	[ID_PHONG] = @ID_PHONGOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_NGACH_PHONG]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_DeleteAllWID_NGACHLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_DeleteAllWID_NGACHLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_DeleteAllWID_NGACHLogic]
	@ID_NGACH numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_NGACH_PHONG]
WHERE
	[ID_NGACH] = @ID_NGACH
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_DeleteAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_DeleteAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_DeleteAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_NGACH_PHONG]
WHERE
	[ID_PHONG] = @ID_PHONG
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_IsUpdatable]
	@KHU_VUC numeric(18, 0),
	@ID_NGACH numeric(18, 0),
	@ID_PHONG numeric(18, 0),
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
	declare @v_KHU_VUC numeric(18, 0)
	declare @v_ID_NGACH numeric(18, 0)
	declare @v_ID_PHONG numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_KHU_VUC = KHU_VUC ,
	@v_ID_NGACH = ID_NGACH ,
	@v_ID_PHONG = ID_PHONG 
	 from DM_NGACH_PHONG with (updlock, rowlock, nowait)
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
	isnull( @v_KHU_VUC,dbo.C_Extrem_Number() ) <> isnull( @KHU_VUC ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_NGACH,dbo.C_Extrem_Number() ) <> isnull( @ID_NGACH ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_PHONG,dbo.C_Extrem_Number() ) <> isnull( @ID_PHONG ,dbo.C_Extrem_Number() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[KHU_VUC],
	[ID_NGACH],
	[ID_PHONG]
FROM [dbo].[DM_NGACH_PHONG]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_SelectAll]
AS
SELECT
	[ID],
	[KHU_VUC],
	[ID_NGACH],
	[ID_PHONG]
FROM [dbo].[DM_NGACH_PHONG]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_SelectAllWID_NGACHLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_SelectAllWID_NGACHLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_SelectAllWID_NGACHLogic]
	@ID_NGACH numeric(18, 0)
AS
SELECT
	[ID],
	[KHU_VUC],
	[ID_NGACH],
	[ID_PHONG]
FROM [dbo].[DM_NGACH_PHONG]
WHERE
	[ID_NGACH] = @ID_NGACH
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_PHONG_SelectAllWID_PHONGLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_PHONG_SelectAllWID_PHONGLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_PHONG_SelectAllWID_PHONGLogic]
	@ID_PHONG numeric(18, 0)
AS
SELECT
	[ID],
	[KHU_VUC],
	[ID_NGACH],
	[ID_PHONG]
FROM [dbo].[DM_NGACH_PHONG]
WHERE
	[ID_PHONG] = @ID_PHONG
GO

