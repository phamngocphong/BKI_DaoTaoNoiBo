SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_Insert]
	@ID_HOC_PHAN numeric(18, 0),
	@ID_MON_HOC numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_HOC_PHAN_MON_HOC]
(
	[ID_HOC_PHAN],
	[ID_MON_HOC]
)
VALUES
(
	@ID_HOC_PHAN,
	@ID_MON_HOC
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_Update]
	@ID numeric(18, 0),
	@ID_HOC_PHAN numeric(18, 0),
	@ID_MON_HOC numeric(18, 0)
AS
UPDATE [dbo].[DM_HOC_PHAN_MON_HOC]
SET 
	[ID_HOC_PHAN] = @ID_HOC_PHAN,
	[ID_MON_HOC] = @ID_MON_HOC
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_HOC_PHANLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_HOC_PHANLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_HOC_PHANLogic]
	@ID_HOC_PHAN numeric(18, 0),
	@ID_HOC_PHANOld numeric(18, 0)
AS
UPDATE [dbo].[DM_HOC_PHAN_MON_HOC]
SET
	[ID_HOC_PHAN] = @ID_HOC_PHAN
WHERE
	[ID_HOC_PHAN] = @ID_HOC_PHANOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0),
	@ID_MON_HOCOld numeric(18, 0)
AS
UPDATE [dbo].[DM_HOC_PHAN_MON_HOC]
SET
	[ID_MON_HOC] = @ID_MON_HOC
WHERE
	[ID_MON_HOC] = @ID_MON_HOCOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_HOC_PHAN_MON_HOC]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_HOC_PHANLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_HOC_PHANLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_HOC_PHANLogic]
	@ID_HOC_PHAN numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_HOC_PHAN_MON_HOC]
WHERE
	[ID_HOC_PHAN] = @ID_HOC_PHAN
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_HOC_PHAN_MON_HOC]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_IsUpdatable]
	@ID_HOC_PHAN numeric(18, 0),
	@ID_MON_HOC numeric(18, 0),
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
	declare @v_ID_HOC_PHAN numeric(18, 0)
	declare @v_ID_MON_HOC numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID_HOC_PHAN = ID_HOC_PHAN ,
	@v_ID_MON_HOC = ID_MON_HOC 
	 from DM_HOC_PHAN_MON_HOC with (updlock, rowlock, nowait)
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
	isnull( @v_ID_HOC_PHAN,dbo.C_Extrem_Number() ) <> isnull( @ID_HOC_PHAN ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_MON_HOC,dbo.C_Extrem_Number() ) <> isnull( @ID_MON_HOC ,dbo.C_Extrem_Number() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[ID_HOC_PHAN],
	[ID_MON_HOC]
FROM [dbo].[DM_HOC_PHAN_MON_HOC]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAll]
AS
SELECT
	[ID],
	[ID_HOC_PHAN],
	[ID_MON_HOC]
FROM [dbo].[DM_HOC_PHAN_MON_HOC]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_HOC_PHANLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_HOC_PHANLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_HOC_PHANLogic]
	@ID_HOC_PHAN numeric(18, 0)
AS
SELECT
	[ID],
	[ID_HOC_PHAN],
	[ID_MON_HOC]
FROM [dbo].[DM_HOC_PHAN_MON_HOC]
WHERE
	[ID_HOC_PHAN] = @ID_HOC_PHAN
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
SELECT
	[ID],
	[ID_HOC_PHAN],
	[ID_MON_HOC]
FROM [dbo].[DM_HOC_PHAN_MON_HOC]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

