SET NOCOUNT ON
GO
USE [Auctionthudo]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DAI_LY_REGISTER_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DAI_LY_REGISTER_Insert]
GO

CREATE PROCEDURE [dbo].[pr_DAI_LY_REGISTER_Insert]
	@ID_DM_DAI_LY numeric(18, 0),
	@ID_REGISTER numeric(18, 0),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DAI_LY_REGISTER]
(
	[ID_DM_DAI_LY],
	[ID_REGISTER]
)
VALUES
(
	@ID_DM_DAI_LY,
	@ID_REGISTER
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DAI_LY_REGISTER_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DAI_LY_REGISTER_Update]
GO

CREATE PROCEDURE [dbo].[pr_DAI_LY_REGISTER_Update]
	@ID numeric(18, 0),
	@ID_DM_DAI_LY numeric(18, 0),
	@ID_REGISTER numeric(18, 0)
AS
UPDATE [dbo].[DAI_LY_REGISTER]
SET 
	[ID_DM_DAI_LY] = @ID_DM_DAI_LY,
	[ID_REGISTER] = @ID_REGISTER
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DAI_LY_REGISTER_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DAI_LY_REGISTER_Delete]
GO

CREATE PROCEDURE [dbo].[pr_DAI_LY_REGISTER_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DAI_LY_REGISTER]
WHERE
	[ID] = @ID
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_DAI_LY_REGISTER_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_DAI_LY_REGISTER_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_DAI_LY_REGISTER_IsUpdatable]
	@ID_DM_DAI_LY numeric(18, 0),
	@ID_REGISTER numeric(18, 0),
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
	declare @v_ID_DM_DAI_LY numeric(18, 0)
	declare @v_ID_REGISTER numeric(18, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID_DM_DAI_LY = ID_DM_DAI_LY ,
	@v_ID_REGISTER = ID_REGISTER 
	 from DAI_LY_REGISTER with (updlock, rowlock, nowait)
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
	isnull( @v_ID_DM_DAI_LY,dbo.C_Extrem_Number() ) <> isnull( @ID_DM_DAI_LY ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_REGISTER,dbo.C_Extrem_Number() ) <> isnull( @ID_REGISTER ,dbo.C_Extrem_Number() ) 
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

