SET NOCOUNT ON
GO
USE [BKI_KHO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_V_DM_KHO_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_V_DM_KHO_Insert]
GO

CREATE PROCEDURE [dbo].[pr_V_DM_KHO_Insert]
	@ID numeric(18, 0),
	@MA_KHO nvarchar(15),
	@TEN_KHO nvarchar(250),
	@DIA_CHI nvarchar(250),
	@DIEN_THOAI varchar(15),
	@ID_NHAN_VIEN numeric(18, 0),
	@GHI_CHU nvarchar(250),
	@HO_DEM nvarchar(50),
	@TEN nvarchar(50)
AS
INSERT [dbo].[V_DM_KHO]
(
	[ID],
	[MA_KHO],
	[TEN_KHO],
	[DIA_CHI],
	[DIEN_THOAI],
	[ID_NHAN_VIEN],
	[GHI_CHU],
	[HO_DEM],
	[TEN]
)
VALUES
(
	@ID,
	@MA_KHO,
	@TEN_KHO,
	@DIA_CHI,
	@DIEN_THOAI,
	@ID_NHAN_VIEN,
	@GHI_CHU,
	@HO_DEM,
	@TEN
)
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_V_DM_KHO_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_V_DM_KHO_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_V_DM_KHO_IsUpdatable]
	@ID numeric(18, 0),
	@MA_KHO nvarchar(15),
	@TEN_KHO nvarchar(250),
	@DIA_CHI nvarchar(250),
	@DIEN_THOAI varchar(15),
	@ID_NHAN_VIEN numeric(18, 0),
	@GHI_CHU nvarchar(250),
	@HO_DEM nvarchar(50),
	@TEN nvarchar(50),
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
	declare @v_MA_KHO nvarchar(15)
	declare @v_TEN_KHO nvarchar(250)
	declare @v_DIA_CHI nvarchar(250)
	declare @v_DIEN_THOAI varchar(15)
	declare @v_ID_NHAN_VIEN numeric(18, 0)
	declare @v_GHI_CHU nvarchar(250)
	declare @v_HO_DEM nvarchar(50)
	declare @v_TEN nvarchar(50)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID = ID ,
	@v_MA_KHO = MA_KHO ,
	@v_TEN_KHO = TEN_KHO ,
	@v_DIA_CHI = DIA_CHI ,
	@v_DIEN_THOAI = DIEN_THOAI ,
	@v_ID_NHAN_VIEN = ID_NHAN_VIEN ,
	@v_GHI_CHU = GHI_CHU ,
	@v_HO_DEM = HO_DEM ,
	@v_TEN = TEN 
	 from V_DM_KHO with (updlock, rowlock, nowait)
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
	isnull( @v_MA_KHO,dbo.C_Extrem_Str() ) <> isnull( @MA_KHO ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TEN_KHO,dbo.C_Extrem_Str() ) <> isnull( @TEN_KHO ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_DIA_CHI,dbo.C_Extrem_Str() ) <> isnull( @DIA_CHI ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_DIEN_THOAI,dbo.C_Extrem_Str() ) <> isnull( @DIEN_THOAI ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_NHAN_VIEN,dbo.C_Extrem_Number() ) <> isnull( @ID_NHAN_VIEN ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_GHI_CHU,dbo.C_Extrem_Str() ) <> isnull( @GHI_CHU ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_HO_DEM,dbo.C_Extrem_Str() ) <> isnull( @HO_DEM ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TEN,dbo.C_Extrem_Str() ) <> isnull( @TEN ,dbo.C_Extrem_Str() ) 
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

