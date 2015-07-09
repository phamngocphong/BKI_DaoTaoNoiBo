SET NOCOUNT ON
GO
USE [eschool]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CTDT_DM_NGANH_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CTDT_DM_NGANH_Insert]
GO

CREATE PROCEDURE [dbo].[pr_CTDT_DM_NGANH_Insert]
	@ID numeric(18, 0),
	@MA nvarchar(15),
	@TEN nvarchar(50)
AS
INSERT [dbo].[CTDT_DM_NGANH]
(
	[ID],
	[MA],
	[TEN]
)
VALUES
(
	@ID,
	@MA,
	@TEN
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CTDT_DM_NGANH_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CTDT_DM_NGANH_Update]
GO

CREATE PROCEDURE [dbo].[pr_CTDT_DM_NGANH_Update]
	@ID numeric(18, 0),
	@MA nvarchar(15),
	@TEN nvarchar(50)
AS
UPDATE [dbo].[CTDT_DM_NGANH]
SET 
	[MA] = @MA,
	[TEN] = @TEN
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CTDT_DM_NGANH_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CTDT_DM_NGANH_Delete]
GO

CREATE PROCEDURE [dbo].[pr_CTDT_DM_NGANH_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[CTDT_DM_NGANH]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CTDT_DM_NGANH_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CTDT_DM_NGANH_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_CTDT_DM_NGANH_IsUpdatable]
	@ID numeric(18, 0),
	@MA nvarchar(15),
	@TEN nvarchar(50),
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||		a) neu khong co thi da bi xoa 
||      b) neu khong lock duoc thi user khac dang lock 
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
	declare @v_MA nvarchar(15)
	declare @v_TEN nvarchar(50)
	select 
	@v_ID = ID ,
	@v_MA = MA ,
	@v_TEN = TEN 
	 from CTDT_DM_NGANH with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => ai do xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_ID,dbo.C_Extrem_Number() ) <> isnull( @ID ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_MA,dbo.C_Extrem_Str() ) <> isnull( @MA ,dbo.C_Extrem_Str() )  OR 
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CTDT_DM_NGANH_SelectOne]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CTDT_DM_NGANH_SelectOne]
GO

CREATE PROCEDURE [dbo].[pr_CTDT_DM_NGANH_SelectOne]
	@ID numeric(18, 0)
AS
SELECT
	[ID],
	[MA],
	[TEN]
FROM [dbo].[CTDT_DM_NGANH]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CTDT_DM_NGANH_SelectOneWMALogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CTDT_DM_NGANH_SelectOneWMALogic]
GO

CREATE PROCEDURE [dbo].[pr_CTDT_DM_NGANH_SelectOneWMALogic]
	@MA nvarchar(15)
AS
SELECT
	[ID],
	[MA],
	[TEN]
FROM [dbo].[CTDT_DM_NGANH]
WHERE
	[MA] = @MA
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_CTDT_DM_NGANH_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_CTDT_DM_NGANH_SelectAll]
GO

CREATE PROCEDURE [dbo].[pr_CTDT_DM_NGANH_SelectAll]
AS
SELECT
	[ID],
	[MA],
	[TEN]
FROM [dbo].[CTDT_DM_NGANH]
ORDER BY 
	[ID] ASC
GO

