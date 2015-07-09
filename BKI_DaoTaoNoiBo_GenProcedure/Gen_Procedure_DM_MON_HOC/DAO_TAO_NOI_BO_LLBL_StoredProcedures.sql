SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_MON_HOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_MON_HOC_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_MON_HOC_Insert]
	@MA_MON_HOC nvarchar(35),
	@TEN_MON_HOC nvarchar(50),
	@DON_VI_GIANG_DAY nvarchar(35),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_MON_HOC]
(
	[MA_MON_HOC],
	[TEN_MON_HOC],
	[DON_VI_GIANG_DAY]
)
VALUES
(
	@MA_MON_HOC,
	@TEN_MON_HOC,
	@DON_VI_GIANG_DAY
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_MON_HOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_MON_HOC_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_MON_HOC_Update]
	@ID numeric(18, 0),
	@MA_MON_HOC nvarchar(35),
	@TEN_MON_HOC nvarchar(50),
	@DON_VI_GIANG_DAY nvarchar(35)
AS
UPDATE [dbo].[DM_MON_HOC]
SET 
	[MA_MON_HOC] = @MA_MON_HOC,
	[TEN_MON_HOC] = @TEN_MON_HOC,
	[DON_VI_GIANG_DAY] = @DON_VI_GIANG_DAY
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_MON_HOC_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_MON_HOC_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_MON_HOC_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_MON_HOC]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_MON_HOC_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_MON_HOC_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_MON_HOC_IsUpdatable]
	@MA_MON_HOC nvarchar(35),
	@TEN_MON_HOC nvarchar(50),
	@DON_VI_GIANG_DAY nvarchar(35),
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
	declare @v_MA_MON_HOC nvarchar(35)
	declare @v_TEN_MON_HOC nvarchar(50)
	declare @v_DON_VI_GIANG_DAY nvarchar(35)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_MA_MON_HOC = MA_MON_HOC ,
	@v_TEN_MON_HOC = TEN_MON_HOC ,
	@v_DON_VI_GIANG_DAY = DON_VI_GIANG_DAY 
	 from DM_MON_HOC with (updlock, rowlock, nowait)
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
	isnull( @v_MA_MON_HOC,dbo.C_Extrem_Str() ) <> isnull( @MA_MON_HOC ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TEN_MON_HOC,dbo.C_Extrem_Str() ) <> isnull( @TEN_MON_HOC ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_DON_VI_GIANG_DAY,dbo.C_Extrem_Str() ) <> isnull( @DON_VI_GIANG_DAY ,dbo.C_Extrem_Str() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_MON_HOC_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_MON_HOC_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_MON_HOC_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[MA_MON_HOC],
	[TEN_MON_HOC],
	[DON_VI_GIANG_DAY]
FROM [dbo].[DM_MON_HOC]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_MON_HOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_MON_HOC_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_MON_HOC_SelectAll]
AS
SELECT
	[ID],
	[MA_MON_HOC],
	[TEN_MON_HOC],
	[DON_VI_GIANG_DAY]
FROM [dbo].[DM_MON_HOC]
ORDER BY 
	[ID] ASC
GO

