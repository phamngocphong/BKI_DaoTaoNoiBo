SET NOCOUNT ON
GO
USE [DAO_TAO_NOI_BO]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_Insert]
	@MA_NGACH nvarchar(35),
	@TEN_NGACH nvarchar(50),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_NGACH]
(
	[MA_NGACH],
	[TEN_NGACH]
)
VALUES
(
	@MA_NGACH,
	@TEN_NGACH
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_Update]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_Update]
	@ID numeric(18, 0),
	@MA_NGACH nvarchar(35),
	@TEN_NGACH nvarchar(50)
AS
UPDATE [dbo].[DM_NGACH]
SET 
	[MA_NGACH] = @MA_NGACH,
	[TEN_NGACH] = @TEN_NGACH
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_NGACH]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_IsUpdatable]
	@MA_NGACH nvarchar(35),
	@TEN_NGACH nvarchar(50),
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
	declare @v_MA_NGACH nvarchar(35)
	declare @v_TEN_NGACH nvarchar(50)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_MA_NGACH = MA_NGACH ,
	@v_TEN_NGACH = TEN_NGACH 
	 from DM_NGACH with (updlock, rowlock, nowait)
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
	isnull( @v_MA_NGACH,dbo.C_Extrem_Str() ) <> isnull( @MA_NGACH ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TEN_NGACH,dbo.C_Extrem_Str() ) <> isnull( @TEN_NGACH ,dbo.C_Extrem_Str() ) 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[MA_NGACH],
	[TEN_NGACH]
FROM [dbo].[DM_NGACH]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DM_NGACH_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DM_NGACH_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_DM_NGACH_SelectAll]
AS
SELECT
	[ID],
	[MA_NGACH],
	[TEN_NGACH]
FROM [dbo].[DM_NGACH]
ORDER BY 
	[ID] ASC
GO

