SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_Insert]
	@ID_MON_HOC numeric(18, 0),
	@MA_VERSION nvarchar(35),
	@LOAI_THOI_GIAN_HET_HAN nvarchar(15),
	@AP_DUNG_TU datetime,
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_VERSION_MON_HOC]
(
	[ID_MON_HOC],
	[MA_VERSION],
	[LOAI_THOI_GIAN_HET_HAN],
	[AP_DUNG_TU]
)
VALUES
(
	@ID_MON_HOC,
	@MA_VERSION,
	@LOAI_THOI_GIAN_HET_HAN,
	@AP_DUNG_TU
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_Update]
	@ID numeric(18, 0),
	@ID_MON_HOC numeric(18, 0),
	@MA_VERSION nvarchar(35),
	@LOAI_THOI_GIAN_HET_HAN nvarchar(15),
	@AP_DUNG_TU datetime
AS
UPDATE [dbo].[DM_VERSION_MON_HOC]
SET 
	[ID_MON_HOC] = @ID_MON_HOC,
	[MA_VERSION] = @MA_VERSION,
	[LOAI_THOI_GIAN_HET_HAN] = @LOAI_THOI_GIAN_HET_HAN,
	[AP_DUNG_TU] = @AP_DUNG_TU
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_UpdateAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_UpdateAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_UpdateAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0),
	@ID_MON_HOCOld numeric(18, 0)
AS
UPDATE [dbo].[DM_VERSION_MON_HOC]
SET
	[ID_MON_HOC] = @ID_MON_HOC
WHERE
	[ID_MON_HOC] = @ID_MON_HOCOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_VERSION_MON_HOC]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_DeleteAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_DeleteAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_DeleteAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
DELETE
FROM [dbo].[DM_VERSION_MON_HOC]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_IsUpdatable]
	@ID_MON_HOC numeric(18, 0),
	@MA_VERSION nvarchar(35),
	@LOAI_THOI_GIAN_HET_HAN nvarchar(15),
	@AP_DUNG_TU datetime,
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
	declare @v_MA_VERSION nvarchar(35)
	declare @v_LOAI_THOI_GIAN_HET_HAN nvarchar(15)
	declare @v_AP_DUNG_TU datetime
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID_MON_HOC = ID_MON_HOC ,
	@v_MA_VERSION = MA_VERSION ,
	@v_LOAI_THOI_GIAN_HET_HAN = LOAI_THOI_GIAN_HET_HAN ,
	@v_AP_DUNG_TU = AP_DUNG_TU 
	 from DM_VERSION_MON_HOC with (updlock, rowlock, nowait)
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
	isnull( @v_MA_VERSION,dbo.C_Extrem_Str() ) <> isnull( @MA_VERSION ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_LOAI_THOI_GIAN_HET_HAN,dbo.C_Extrem_Str() ) <> isnull( @LOAI_THOI_GIAN_HET_HAN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_AP_DUNG_TU,dbo.C_Extrem_Date() ) <> isnull( @AP_DUNG_TU ,dbo.C_Extrem_Date() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[ID_MON_HOC],
	[MA_VERSION],
	[LOAI_THOI_GIAN_HET_HAN],
	[AP_DUNG_TU]
FROM [dbo].[DM_VERSION_MON_HOC]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_SelectAll]
AS
SELECT
	[ID],
	[ID_MON_HOC],
	[MA_VERSION],
	[LOAI_THOI_GIAN_HET_HAN],
	[AP_DUNG_TU]
FROM [dbo].[DM_VERSION_MON_HOC]
ORDER BY 
	[ID] ASC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_VERSION_MON_HOC_SelectAllWID_MON_HOCLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_VERSION_MON_HOC_SelectAllWID_MON_HOCLogic]
GO

CREATE PROCEDURE [dbo].[pr_DM_VERSION_MON_HOC_SelectAllWID_MON_HOCLogic]
	@ID_MON_HOC numeric(18, 0)
AS
SELECT
	[ID],
	[ID_MON_HOC],
	[MA_VERSION],
	[LOAI_THOI_GIAN_HET_HAN],
	[AP_DUNG_TU]
FROM [dbo].[DM_VERSION_MON_HOC]
WHERE
	[ID_MON_HOC] = @ID_MON_HOC
GO

