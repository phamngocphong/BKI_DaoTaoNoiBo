SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_Insert]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_Insert]
	@ID numeric(18, 0),
	@ID_NHAN_SU numeric(18, 0),
	@ID_GD_DIEM numeric(18, 0),
	@SO_CHUNG_CHI nvarchar(35),
	@NGAY_BAT_DAU datetime,
	@NGAY_KET_THUC datetime,
	@NGAY_LAP datetime,
	@NGAY_SUA datetime,
	@NGUOI_LAP nvarchar(50),
	@NGUOI_SUA nvarchar(50),
	@DA_XOA nvarchar(1)
AS
INSERT [dbo].[GD_CHUNG_CHI]
(
	[ID],
	[ID_NHAN_SU],
	[ID_GD_DIEM],
	[SO_CHUNG_CHI],
	[NGAY_BAT_DAU],
	[NGAY_KET_THUC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
)
VALUES
(
	@ID,
	@ID_NHAN_SU,
	@ID_GD_DIEM,
	@SO_CHUNG_CHI,
	@NGAY_BAT_DAU,
	@NGAY_KET_THUC,
	@NGAY_LAP,
	@NGAY_SUA,
	@NGUOI_LAP,
	@NGUOI_SUA,
	@DA_XOA
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_Update]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_Update]
	@ID numeric(18, 0),
	@ID_NHAN_SU numeric(18, 0),
	@ID_GD_DIEM numeric(18, 0),
	@SO_CHUNG_CHI nvarchar(35),
	@NGAY_BAT_DAU datetime,
	@NGAY_KET_THUC datetime,
	@NGAY_LAP datetime,
	@NGAY_SUA datetime,
	@NGUOI_LAP nvarchar(50),
	@NGUOI_SUA nvarchar(50),
	@DA_XOA nvarchar(1)
AS
UPDATE [dbo].[GD_CHUNG_CHI]
SET 
	[ID_NHAN_SU] = @ID_NHAN_SU,
	[ID_GD_DIEM] = @ID_GD_DIEM,
	[SO_CHUNG_CHI] = @SO_CHUNG_CHI,
	[NGAY_BAT_DAU] = @NGAY_BAT_DAU,
	[NGAY_KET_THUC] = @NGAY_KET_THUC,
	[NGAY_LAP] = @NGAY_LAP,
	[NGAY_SUA] = @NGAY_SUA,
	[NGUOI_LAP] = @NGUOI_LAP,
	[NGUOI_SUA] = @NGUOI_SUA,
	[DA_XOA] = @DA_XOA
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_UpdateAllWID_NHAN_SULogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_UpdateAllWID_NHAN_SULogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_UpdateAllWID_NHAN_SULogic]
	@ID_NHAN_SU numeric(18, 0),
	@ID_NHAN_SUOld numeric(18, 0)
AS
UPDATE [dbo].[GD_CHUNG_CHI]
SET
	[ID_NHAN_SU] = @ID_NHAN_SU
WHERE
	[ID_NHAN_SU] = @ID_NHAN_SUOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_UpdateAllWID_GD_DIEMLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_UpdateAllWID_GD_DIEMLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_UpdateAllWID_GD_DIEMLogic]
	@ID_GD_DIEM numeric(18, 0),
	@ID_GD_DIEMOld numeric(18, 0)
AS
UPDATE [dbo].[GD_CHUNG_CHI]
SET
	[ID_GD_DIEM] = @ID_GD_DIEM
WHERE
	[ID_GD_DIEM] = @ID_GD_DIEMOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_Delete]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[GD_CHUNG_CHI]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_DeleteAllWID_NHAN_SULogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_DeleteAllWID_NHAN_SULogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_DeleteAllWID_NHAN_SULogic]
	@ID_NHAN_SU numeric(18, 0)
AS
DELETE
FROM [dbo].[GD_CHUNG_CHI]
WHERE
	[ID_NHAN_SU] = @ID_NHAN_SU
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_DeleteAllWID_GD_DIEMLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_DeleteAllWID_GD_DIEMLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_DeleteAllWID_GD_DIEMLogic]
	@ID_GD_DIEM numeric(18, 0)
AS
DELETE
FROM [dbo].[GD_CHUNG_CHI]
WHERE
	[ID_GD_DIEM] = @ID_GD_DIEM
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_IsUpdatable]
	@ID numeric(18, 0),
	@ID_NHAN_SU numeric(18, 0),
	@ID_GD_DIEM numeric(18, 0),
	@SO_CHUNG_CHI nvarchar(35),
	@NGAY_BAT_DAU datetime,
	@NGAY_KET_THUC datetime,
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
	declare @v_ID numeric(18, 0)
	declare @v_ID_NHAN_SU numeric(18, 0)
	declare @v_ID_GD_DIEM numeric(18, 0)
	declare @v_SO_CHUNG_CHI nvarchar(35)
	declare @v_NGAY_BAT_DAU datetime
	declare @v_NGAY_KET_THUC datetime
	declare @v_NGAY_LAP datetime
	declare @v_NGAY_SUA datetime
	declare @v_NGUOI_LAP nvarchar(50)
	declare @v_NGUOI_SUA nvarchar(50)
	declare @v_DA_XOA nvarchar(1)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID = ID ,
	@v_ID_NHAN_SU = ID_NHAN_SU ,
	@v_ID_GD_DIEM = ID_GD_DIEM ,
	@v_SO_CHUNG_CHI = SO_CHUNG_CHI ,
	@v_NGAY_BAT_DAU = NGAY_BAT_DAU ,
	@v_NGAY_KET_THUC = NGAY_KET_THUC ,
	@v_NGAY_LAP = NGAY_LAP ,
	@v_NGAY_SUA = NGAY_SUA ,
	@v_NGUOI_LAP = NGUOI_LAP ,
	@v_NGUOI_SUA = NGUOI_SUA ,
	@v_DA_XOA = DA_XOA 
	 from GD_CHUNG_CHI with (updlock, rowlock, nowait)
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
	isnull( @v_ID,dbo.C_Extrem_Number() ) <> isnull( @ID ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_NHAN_SU,dbo.C_Extrem_Number() ) <> isnull( @ID_NHAN_SU ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_GD_DIEM,dbo.C_Extrem_Number() ) <> isnull( @ID_GD_DIEM ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_SO_CHUNG_CHI,dbo.C_Extrem_Str() ) <> isnull( @SO_CHUNG_CHI ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NGAY_BAT_DAU,dbo.C_Extrem_Date() ) <> isnull( @NGAY_BAT_DAU ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_NGAY_KET_THUC,dbo.C_Extrem_Date() ) <> isnull( @NGAY_KET_THUC ,dbo.C_Extrem_Date() )  OR 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[ID_NHAN_SU],
	[ID_GD_DIEM],
	[SO_CHUNG_CHI],
	[NGAY_BAT_DAU],
	[NGAY_KET_THUC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_CHUNG_CHI]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_SelectAll]
AS
SELECT
	[ID],
	[ID_NHAN_SU],
	[ID_GD_DIEM],
	[SO_CHUNG_CHI],
	[NGAY_BAT_DAU],
	[NGAY_KET_THUC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_CHUNG_CHI]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_SelectAllWID_NHAN_SULogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_SelectAllWID_NHAN_SULogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_SelectAllWID_NHAN_SULogic]
	@ID_NHAN_SU numeric(18, 0)
AS
SELECT
	[ID],
	[ID_NHAN_SU],
	[ID_GD_DIEM],
	[SO_CHUNG_CHI],
	[NGAY_BAT_DAU],
	[NGAY_KET_THUC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_CHUNG_CHI]
WHERE
	[ID_NHAN_SU] = @ID_NHAN_SU
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_CHUNG_CHI_SelectAllWID_GD_DIEMLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_CHUNG_CHI_SelectAllWID_GD_DIEMLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_CHUNG_CHI_SelectAllWID_GD_DIEMLogic]
	@ID_GD_DIEM numeric(18, 0)
AS
SELECT
	[ID],
	[ID_NHAN_SU],
	[ID_GD_DIEM],
	[SO_CHUNG_CHI],
	[NGAY_BAT_DAU],
	[NGAY_KET_THUC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_CHUNG_CHI]
WHERE
	[ID_GD_DIEM] = @ID_GD_DIEM
GO

