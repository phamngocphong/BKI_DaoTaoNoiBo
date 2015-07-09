SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_Insert]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_Insert]
	@MA_LOP_HOC nvarchar(35),
	@THOI_GIAN datetime,
	@DIA_DIEM nvarchar(250),
	@SO_LUONG int,
	@ID_MON_HOC numeric(18, 0),
	@NGAY_LAP datetime,
	@NGAY_SUA datetime,
	@NGUOI_LAP nvarchar(50),
	@NGUOI_SUA nvarchar(50),
	@DA_XOA nvarchar(1),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[GD_LOP_HOC]
(
	[MA_LOP_HOC],
	[THOI_GIAN],
	[DIA_DIEM],
	[SO_LUONG],
	[ID_MON_HOC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
)
VALUES
(
	@MA_LOP_HOC,
	@THOI_GIAN,
	@DIA_DIEM,
	@SO_LUONG,
	@ID_MON_HOC,
	@NGAY_LAP,
	@NGAY_SUA,
	@NGUOI_LAP,
	@NGUOI_SUA,
	@DA_XOA
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_Update]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_Update]
	@ID numeric(18, 0),
	@MA_LOP_HOC nvarchar(35),
	@THOI_GIAN datetime,
	@DIA_DIEM nvarchar(250),
	@SO_LUONG int,
	@ID_MON_HOC numeric(18, 0),
	@NGAY_LAP datetime,
	@NGAY_SUA datetime,
	@NGUOI_LAP nvarchar(50),
	@NGUOI_SUA nvarchar(50),
	@DA_XOA nvarchar(1)
AS
UPDATE [dbo].[GD_LOP_HOC]
SET 
	[MA_LOP_HOC] = @MA_LOP_HOC,
	[THOI_GIAN] = @THOI_GIAN,
	[DIA_DIEM] = @DIA_DIEM,
	[SO_LUONG] = @SO_LUONG,
	[ID_MON_HOC] = @ID_MON_HOC,
	[NGAY_LAP] = @NGAY_LAP,
	[NGAY_SUA] = @NGAY_SUA,
	[NGUOI_LAP] = @NGUOI_LAP,
	[NGUOI_SUA] = @NGUOI_SUA,
	[DA_XOA] = @DA_XOA
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_UpdateAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_UpdateAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_UpdateAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0),
	@ID_MON_HOCOld numeric(18, 0)
AS
UPDATE [dbo].[GD_LOP_HOC]
SET
	[ID_MON_HOC] = @ID_MON_HOC
WHERE
	[ID_MON_HOC] = @ID_MON_HOCOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_Delete]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[GD_LOP_HOC]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_DeleteAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_DeleteAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_DeleteAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
DELETE
FROM [dbo].[GD_LOP_HOC]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_IsUpdatable]
	@MA_LOP_HOC nvarchar(35),
	@THOI_GIAN datetime,
	@DIA_DIEM nvarchar(250),
	@SO_LUONG int,
	@ID_MON_HOC numeric(18, 0),
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
	declare @v_MA_LOP_HOC nvarchar(35)
	declare @v_THOI_GIAN datetime
	declare @v_DIA_DIEM nvarchar(250)
	declare @v_SO_LUONG int
	declare @v_ID_MON_HOC numeric(18, 0)
	declare @v_NGAY_LAP datetime
	declare @v_NGAY_SUA datetime
	declare @v_NGUOI_LAP nvarchar(50)
	declare @v_NGUOI_SUA nvarchar(50)
	declare @v_DA_XOA nvarchar(1)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_MA_LOP_HOC = MA_LOP_HOC ,
	@v_THOI_GIAN = THOI_GIAN ,
	@v_DIA_DIEM = DIA_DIEM ,
	@v_SO_LUONG = SO_LUONG ,
	@v_ID_MON_HOC = ID_MON_HOC ,
	@v_NGAY_LAP = NGAY_LAP ,
	@v_NGAY_SUA = NGAY_SUA ,
	@v_NGUOI_LAP = NGUOI_LAP ,
	@v_NGUOI_SUA = NGUOI_SUA ,
	@v_DA_XOA = DA_XOA 
	 from GD_LOP_HOC with (updlock, rowlock, nowait)
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
	isnull( @v_MA_LOP_HOC,dbo.C_Extrem_Str() ) <> isnull( @MA_LOP_HOC ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_THOI_GIAN,dbo.C_Extrem_Date() ) <> isnull( @THOI_GIAN ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_DIA_DIEM,dbo.C_Extrem_Str() ) <> isnull( @DIA_DIEM ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_SO_LUONG,dbo.C_Extrem_Str() ) <> isnull( @SO_LUONG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_MON_HOC,dbo.C_Extrem_Number() ) <> isnull( @ID_MON_HOC ,dbo.C_Extrem_Number() )  OR 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[MA_LOP_HOC],
	[THOI_GIAN],
	[DIA_DIEM],
	[SO_LUONG],
	[ID_MON_HOC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_LOP_HOC]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_SelectAll]
AS
SELECT
	[ID],
	[MA_LOP_HOC],
	[THOI_GIAN],
	[DIA_DIEM],
	[SO_LUONG],
	[ID_MON_HOC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_LOP_HOC]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_GD_LOP_HOC_SelectAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_GD_LOP_HOC_SelectAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_GD_LOP_HOC_SelectAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
SELECT
	[ID],
	[MA_LOP_HOC],
	[THOI_GIAN],
	[DIA_DIEM],
	[SO_LUONG],
	[ID_MON_HOC],
	[NGAY_LAP],
	[NGAY_SUA],
	[NGUOI_LAP],
	[NGUOI_SUA],
	[DA_XOA]
FROM [dbo].[GD_LOP_HOC]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

