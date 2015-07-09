SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_Insert]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_Insert]
	@ID_NHAN_VIEN numeric(18, 0),
	@ID_LOP_HOC numeric(18, 0),
	@QUA_MON nvarchar(1),
	@NGAY_LAP datetime,
	@NGAY_SUA datetime,
	@NGUOI_LAP nvarchar(50),
	@NGUOI_SUA nvarchar(50),
	@DA_XOA nvarchar(1),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[GD_DIEM]
(
	[ID_NHAN_VIEN],
	[ID_LOP_HOC],
	[QUA_MON],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
)
VALUES
(
	@ID_NHAN_VIEN,
	@ID_LOP_HOC,
	@QUA_MON,
	@NGAY_LAP,
	@NGAY_SUA,
	@NGUOI_LAP,
	@NGUOI_SUA,
	@DA_XOA
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_Update]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_Update]
	@ID numeric(18, 0),
	@ID_NHAN_VIEN numeric(18, 0),
	@ID_LOP_HOC numeric(18, 0),
	@QUA_MON nvarchar(1),
	@NGAY_LAP datetime,
	@NGAY_SUA datetime,
	@NGUOI_LAP nvarchar(50),
	@NGUOI_SUA nvarchar(50),
	@DA_XOA nvarchar(1)
AS
UPDATE [dbo].[GD_DIEM]
SET 
	[ID_NHAN_VIEN] = @ID_NHAN_VIEN,
	[ID_LOP_HOC] = @ID_LOP_HOC,
	[QUA_MON] = @QUA_MON,
	[NGAY_LAP] = @NGAY_LAP,
	[NGAY_SUA] = @NGAY_SUA,
	[NGUOI_LAP] = @NGUOI_LAP,
	[NGUOI_SUA] = @NGUOI_SUA,
	[DA_XOA] = @DA_XOA
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_UpdateAllWID_NHAN_VIENLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_UpdateAllWID_NHAN_VIENLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_UpdateAllWID_NHAN_VIENLogic]
	@ID_NHAN_VIEN numeric(18, 0),
	@ID_NHAN_VIENOld numeric(18, 0)
AS
UPDATE [dbo].[GD_DIEM]
SET
	[ID_NHAN_VIEN] = @ID_NHAN_VIEN
WHERE
	[ID_NHAN_VIEN] = @ID_NHAN_VIENOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_UpdateAllWID_LOP_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_UpdateAllWID_LOP_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_UpdateAllWID_LOP_HOCLogic]
	@ID_LOP_HOC numeric(18, 0),
	@ID_LOP_HOCOld numeric(18, 0)
AS
UPDATE [dbo].[GD_DIEM]
SET
	[ID_LOP_HOC] = @ID_LOP_HOC
WHERE
	[ID_LOP_HOC] = @ID_LOP_HOCOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_Delete]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[GD_DIEM]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_DeleteAllWID_NHAN_VIENLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_DeleteAllWID_NHAN_VIENLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_DeleteAllWID_NHAN_VIENLogic]
	@ID_NHAN_VIEN numeric(18, 0)
AS
DELETE
FROM [dbo].[GD_DIEM]
WHERE
	[ID_NHAN_VIEN] = @ID_NHAN_VIEN
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_DeleteAllWID_LOP_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_DeleteAllWID_LOP_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_DeleteAllWID_LOP_HOCLogic]
	@ID_LOP_HOC numeric(18, 0)
AS
DELETE
FROM [dbo].[GD_DIEM]
WHERE
	[ID_LOP_HOC] = @ID_LOP_HOC
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_IsUpdatable]
	@ID_NHAN_VIEN numeric(18, 0),
	@ID_LOP_HOC numeric(18, 0),
	@QUA_MON nvarchar(1),
	@NGAY_LAP datetime,
	@NGAY_SUA datetime,
	@NGUOI_LAP nvarchar(50),
	@NGUOI_SUA nvarchar(50),
	@DA_XOA nvarchar(1),
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
	declare @v_ID_NHAN_VIEN numeric(18, 0)
	declare @v_ID_LOP_HOC numeric(18, 0)
	declare @v_QUA_MON nvarchar(1)
	declare @v_NGAY_LAP datetime
	declare @v_NGAY_SUA datetime
	declare @v_NGUOI_LAP nvarchar(50)
	declare @v_NGUOI_SUA nvarchar(50)
	declare @v_DA_XOA nvarchar(1)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID_NHAN_VIEN = ID_NHAN_VIEN ,
	@v_ID_LOP_HOC = ID_LOP_HOC ,
	@v_QUA_MON = QUA_MON ,
	@v_NGAY_LAP = NGAY_LAP ,
	@v_NGAY_SUA = NGAY_SUA ,
	@v_NGUOI_LAP = NGUOI_LAP ,
	@v_NGUOI_SUA = NGUOI_SUA ,
	@v_DA_XOA = DA_XOA 
	 from GD_DIEM with (updlock, rowlock, nowait)
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
	isnull( @v_ID_NHAN_VIEN,dbo.C_Extrem_Number() ) <> isnull( @ID_NHAN_VIEN ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_LOP_HOC,dbo.C_Extrem_Number() ) <> isnull( @ID_LOP_HOC ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_QUA_MON,dbo.C_Extrem_Str() ) <> isnull( @QUA_MON ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NGAY_LAP,dbo.C_Extrem_Date() ) <> isnull( @NGAY_LAP ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_NGAY_SUA,dbo.C_Extrem_Date() ) <> isnull( @NGAY_SUA ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_NGUOI_LAP,dbo.C_Extrem_Str() ) <> isnull( @NGUOI_LAP ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NGUOI_SUA,dbo.C_Extrem_Str() ) <> isnull( @NGUOI_SUA ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_DA_XOA,dbo.C_Extrem_Str() ) <> isnull( @DA_XOA ,dbo.C_Extrem_Str() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[ID_NHAN_VIEN],
	[ID_LOP_HOC],
	[QUA_MON],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_DIEM]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_SelectAll]
AS
SELECT
	[ID],
	[ID_NHAN_VIEN],
	[ID_LOP_HOC],
	[QUA_MON],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_DIEM]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_SelectAllWID_NHAN_VIENLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_SelectAllWID_NHAN_VIENLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_SelectAllWID_NHAN_VIENLogic]
	@ID_NHAN_VIEN numeric(18, 0)
AS
SELECT
	[ID],
	[ID_NHAN_VIEN],
	[ID_LOP_HOC],
	[QUA_MON],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_DIEM]
WHERE
	[ID_NHAN_VIEN] = @ID_NHAN_VIEN
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_DIEM_SelectAllWID_LOP_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_DIEM_SelectAllWID_LOP_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_DIEM_SelectAllWID_LOP_HOCLogic]
	@ID_LOP_HOC numeric(18, 0)
AS
SELECT
	[ID],
	[ID_NHAN_VIEN],
	[ID_LOP_HOC],
	[QUA_MON],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_DIEM]
WHERE
	[ID_LOP_HOC] = @ID_LOP_HOC
GO

