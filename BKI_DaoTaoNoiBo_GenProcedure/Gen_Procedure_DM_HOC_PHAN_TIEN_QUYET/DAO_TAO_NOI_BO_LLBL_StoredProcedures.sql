SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Insert]
	@ID_MON_HOC numeric(18, 0),
	@ID_MON_HOC_TIEN_QUYET numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_HOC_PHAN_TIEN_QUYET]
(
	[ID_MON_HOC],
	[ID_MON_HOC_TIEN_QUYET]
)
VALUES
(
	@ID_MON_HOC,
	@ID_MON_HOC_TIEN_QUYET
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Update]
	@ID numeric(18, 0),
	@ID_MON_HOC numeric(18, 0),
	@ID_MON_HOC_TIEN_QUYET numeric(18, 0)
AS
UPDATE [dbo].[DM_HOC_PHAN_TIEN_QUYET]
SET 
	[ID_MON_HOC] = @ID_MON_HOC,
	[ID_MON_HOC_TIEN_QUYET] = @ID_MON_HOC_TIEN_QUYET
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_UpdateAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_UpdateAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_UpdateAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0),
	@ID_MON_HOCOld numeric(18, 0)
AS
UPDATE [dbo].[DM_HOC_PHAN_TIEN_QUYET]
SET
	[ID_MON_HOC] = @ID_MON_HOC
WHERE
	[ID_MON_HOC] = @ID_MON_HOCOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_UpdateAllWID_MON_HOC_TIEN_QUYETLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_UpdateAllWID_MON_HOC_TIEN_QUYETLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_UpdateAllWID_MON_HOC_TIEN_QUYETLogic]
	@ID_MON_HOC_TIEN_QUYET numeric(18, 0),
	@ID_MON_HOC_TIEN_QUYETOld numeric(18, 0)
AS
UPDATE [dbo].[DM_HOC_PHAN_TIEN_QUYET]
SET
	[ID_MON_HOC_TIEN_QUYET] = @ID_MON_HOC_TIEN_QUYET
WHERE
	[ID_MON_HOC_TIEN_QUYET] = @ID_MON_HOC_TIEN_QUYETOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_HOC_PHAN_TIEN_QUYET]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_DeleteAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_DeleteAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_DeleteAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_HOC_PHAN_TIEN_QUYET]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_DeleteAllWID_MON_HOC_TIEN_QUYETLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_DeleteAllWID_MON_HOC_TIEN_QUYETLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_DeleteAllWID_MON_HOC_TIEN_QUYETLogic]
	@ID_MON_HOC_TIEN_QUYET numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_HOC_PHAN_TIEN_QUYET]
WHERE
	[ID_MON_HOC_TIEN_QUYET] = @ID_MON_HOC_TIEN_QUYET
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_IsUpdatable]
	@ID_MON_HOC numeric(18, 0),
	@ID_MON_HOC_TIEN_QUYET numeric(18, 0),
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
	declare @v_ID_MON_HOC numeric(18, 0)
	declare @v_ID_MON_HOC_TIEN_QUYET numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID_MON_HOC = ID_MON_HOC ,
	@v_ID_MON_HOC_TIEN_QUYET = ID_MON_HOC_TIEN_QUYET 
	 from DM_HOC_PHAN_TIEN_QUYET with (updlock, rowlock, nowait)
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
	isnull( @v_ID_MON_HOC,dbo.C_Extrem_Number() ) <> isnull( @ID_MON_HOC ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_MON_HOC_TIEN_QUYET,dbo.C_Extrem_Number() ) <> isnull( @ID_MON_HOC_TIEN_QUYET ,dbo.C_Extrem_Number() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[ID_MON_HOC],
	[ID_MON_HOC_TIEN_QUYET]
FROM [dbo].[DM_HOC_PHAN_TIEN_QUYET]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAll]
AS
SELECT
	[ID],
	[ID_MON_HOC],
	[ID_MON_HOC_TIEN_QUYET]
FROM [dbo].[DM_HOC_PHAN_TIEN_QUYET]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
SELECT
	[ID],
	[ID_MON_HOC],
	[ID_MON_HOC_TIEN_QUYET]
FROM [dbo].[DM_HOC_PHAN_TIEN_QUYET]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAllWID_MON_HOC_TIEN_QUYETLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAllWID_MON_HOC_TIEN_QUYETLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_TIEN_QUYET_SelectAllWID_MON_HOC_TIEN_QUYETLogic]
	@ID_MON_HOC_TIEN_QUYET numeric(18, 0)
AS
SELECT
	[ID],
	[ID_MON_HOC],
	[ID_MON_HOC_TIEN_QUYET]
FROM [dbo].[DM_HOC_PHAN_TIEN_QUYET]
WHERE
	[ID_MON_HOC_TIEN_QUYET] = @ID_MON_HOC_TIEN_QUYET
GO

