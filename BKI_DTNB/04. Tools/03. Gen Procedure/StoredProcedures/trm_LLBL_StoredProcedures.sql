SET NOCOUNT ON
GO
USE [trm]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CM_DM_TU_DIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CM_DM_TU_DIEN_Insert]
GO

CREATE PROCEDURE [dbo].[pr_CM_DM_TU_DIEN_Insert]
	@MA_TU_DIEN nvarchar(50),
	@ID_LOAI_TU_DIEN numeric(18, 0),
	@TEN_NGAN nvarchar(250),
	@TEN nvarchar(250),
	@GHI_CHU nvarchar(250),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[CM_DM_TU_DIEN]
(
	[MA_TU_DIEN],
	[ID_LOAI_TU_DIEN],
	[TEN_NGAN],
	[TEN],
	[GHI_CHU]
)
VALUES
(
	@MA_TU_DIEN,
	@ID_LOAI_TU_DIEN,
	@TEN_NGAN,
	@TEN,
	@GHI_CHU
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CM_DM_TU_DIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CM_DM_TU_DIEN_Update]
GO

CREATE PROCEDURE [dbo].[pr_CM_DM_TU_DIEN_Update]
	@ID numeric(18, 0),
	@MA_TU_DIEN nvarchar(50),
	@ID_LOAI_TU_DIEN numeric(18, 0),
	@TEN_NGAN nvarchar(250),
	@TEN nvarchar(250),
	@GHI_CHU nvarchar(250)
AS
UPDATE [dbo].[CM_DM_TU_DIEN]
SET 
	[MA_TU_DIEN] = @MA_TU_DIEN,
	[ID_LOAI_TU_DIEN] = @ID_LOAI_TU_DIEN,
	[TEN_NGAN] = @TEN_NGAN,
	[TEN] = @TEN,
	[GHI_CHU] = @GHI_CHU
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CM_DM_TU_DIEN_UpdateAllWID_LOAI_TU_DIENLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CM_DM_TU_DIEN_UpdateAllWID_LOAI_TU_DIENLogic]
GO

CREATE PROCEDURE [dbo].[pr_CM_DM_TU_DIEN_UpdateAllWID_LOAI_TU_DIENLogic]
	@ID_LOAI_TU_DIEN numeric(18, 0),
	@ID_LOAI_TU_DIENOld numeric(18, 0)
AS
UPDATE [dbo].[CM_DM_TU_DIEN]
SET
	[ID_LOAI_TU_DIEN] = @ID_LOAI_TU_DIEN
WHERE
	[ID_LOAI_TU_DIEN] = @ID_LOAI_TU_DIENOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CM_DM_TU_DIEN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CM_DM_TU_DIEN_Delete]
GO

CREATE PROCEDURE [dbo].[pr_CM_DM_TU_DIEN_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[CM_DM_TU_DIEN]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CM_DM_TU_DIEN_DeleteAllWID_LOAI_TU_DIENLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CM_DM_TU_DIEN_DeleteAllWID_LOAI_TU_DIENLogic]
GO

CREATE PROCEDURE [dbo].[pr_CM_DM_TU_DIEN_DeleteAllWID_LOAI_TU_DIENLogic]
	@ID_LOAI_TU_DIEN numeric(18, 0)
AS
DELETE
FROM [dbo].[CM_DM_TU_DIEN]
WHERE
	[ID_LOAI_TU_DIEN] = @ID_LOAI_TU_DIEN
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CM_DM_TU_DIEN_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CM_DM_TU_DIEN_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_CM_DM_TU_DIEN_IsUpdatable]
	@MA_TU_DIEN nvarchar(50),
	@ID_LOAI_TU_DIEN numeric(18, 0),
	@TEN_NGAN nvarchar(250),
	@TEN nvarchar(250),
	@GHI_CHU nvarchar(250),
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
	declare @v_MA_TU_DIEN nvarchar(50)
	declare @v_ID_LOAI_TU_DIEN numeric(18, 0)
	declare @v_TEN_NGAN nvarchar(250)
	declare @v_TEN nvarchar(250)
	declare @v_GHI_CHU nvarchar(250)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_MA_TU_DIEN = MA_TU_DIEN ,
	@v_ID_LOAI_TU_DIEN = ID_LOAI_TU_DIEN ,
	@v_TEN_NGAN = TEN_NGAN ,
	@v_TEN = TEN ,
	@v_GHI_CHU = GHI_CHU 
	 from CM_DM_TU_DIEN with (updlock, rowlock, nowait)
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
	isnull( @v_MA_TU_DIEN,dbo.C_Extrem_Str() ) <> isnull( @MA_TU_DIEN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_LOAI_TU_DIEN,dbo.C_Extrem_Number() ) <> isnull( @ID_LOAI_TU_DIEN ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TEN_NGAN,dbo.C_Extrem_Str() ) <> isnull( @TEN_NGAN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TEN,dbo.C_Extrem_Str() ) <> isnull( @TEN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_GHI_CHU,dbo.C_Extrem_Str() ) <> isnull( @GHI_CHU ,dbo.C_Extrem_Str() ) 
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

