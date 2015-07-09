SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_Insert]
	@MA_HOC_PHAN nvarchar(35),
	@TEN_HOC_PHAN nvarchar(50),
	@SO_LUONG_YEU_CAU int,
	@BAT_BUOC_YN nvarchar(1),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_HOC_PHAN]
(
	[MA_HOC_PHAN],
	[TEN_HOC_PHAN],
	[SO_LUONG_YEU_CAU],
	[BAT_BUOC_YN]
)
VALUES
(
	@MA_HOC_PHAN,
	@TEN_HOC_PHAN,
	@SO_LUONG_YEU_CAU,
	@BAT_BUOC_YN
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_Update]
	@ID numeric(18, 0),
	@MA_HOC_PHAN nvarchar(35),
	@TEN_HOC_PHAN nvarchar(50),
	@SO_LUONG_YEU_CAU int,
	@BAT_BUOC_YN nvarchar(1)
AS
UPDATE [dbo].[DM_HOC_PHAN]
SET 
	[MA_HOC_PHAN] = @MA_HOC_PHAN,
	[TEN_HOC_PHAN] = @TEN_HOC_PHAN,
	[SO_LUONG_YEU_CAU] = @SO_LUONG_YEU_CAU,
	[BAT_BUOC_YN] = @BAT_BUOC_YN
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_HOC_PHAN]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_IsUpdatable]
	@MA_HOC_PHAN nvarchar(35),
	@TEN_HOC_PHAN nvarchar(50),
	@SO_LUONG_YEU_CAU int,
	@BAT_BUOC_YN nvarchar(1),
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
	declare @v_MA_HOC_PHAN nvarchar(35)
	declare @v_TEN_HOC_PHAN nvarchar(50)
	declare @v_SO_LUONG_YEU_CAU int
	declare @v_BAT_BUOC_YN nvarchar(1)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_MA_HOC_PHAN = MA_HOC_PHAN ,
	@v_TEN_HOC_PHAN = TEN_HOC_PHAN ,
	@v_SO_LUONG_YEU_CAU = SO_LUONG_YEU_CAU ,
	@v_BAT_BUOC_YN = BAT_BUOC_YN 
	 from DM_HOC_PHAN with (updlock, rowlock, nowait)
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
	isnull( @v_MA_HOC_PHAN,dbo.C_Extrem_Str() ) <> isnull( @MA_HOC_PHAN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TEN_HOC_PHAN,dbo.C_Extrem_Str() ) <> isnull( @TEN_HOC_PHAN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_SO_LUONG_YEU_CAU,dbo.C_Extrem_Str() ) <> isnull( @SO_LUONG_YEU_CAU ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_BAT_BUOC_YN,dbo.C_Extrem_Str() ) <> isnull( @BAT_BUOC_YN ,dbo.C_Extrem_Str() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[MA_HOC_PHAN],
	[TEN_HOC_PHAN],
	[SO_LUONG_YEU_CAU],
	[BAT_BUOC_YN]
FROM [dbo].[DM_HOC_PHAN]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_HOC_PHAN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_HOC_PHAN_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_HOC_PHAN_SelectAll]
AS
SELECT
	[ID],
	[MA_HOC_PHAN],
	[TEN_HOC_PHAN],
	[SO_LUONG_YEU_CAU],
	[BAT_BUOC_YN]
FROM [dbo].[DM_HOC_PHAN]
ORDER BY 
	[ID] ASC
GO

