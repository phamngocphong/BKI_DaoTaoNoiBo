SET NOCOUNT ON
GO
USE [TRMPro]
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_AUCTION_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_AUCTION_Insert]
GO

CREATE PROCEDURE [dbo].[pr_AUCTION_Insert]
	@AUCTION_CODE nvarchar(35),
	@AUCTION_NAME nvarchar(250),
	@ID_KIND_OF_STOCK numeric(18, 0),
	@TOTAL_OF_STOCK numeric(21, 3),
	@FACE_VALUE numeric(21, 3),
	@STARTING_PRICE numeric(21, 3),
	@BID_LEVEL numeric(4, 0),
	@PRICE_STEP numeric(21, 3),
	@REG_TIME_FROM datetime,
	@REG_TIME_TO datetime,
	@AUCTION_TIME datetime,
	@AUCTION_LOCATION nvarchar(250),
	@CLOSE_TIME_FROM datetime,
	@CLOSE_TIME_TO datetime,
	@IS_OPEN_YN nvarchar(1),
	@PAY_LOCATION nvarchar(250),
	@CONTACT_ADDRESS nvarchar(250),
	@REGISTER_COUNT numeric(21, 3),
	@ID_CREATE_BY numeric(18, 0),
	@CREATE_DATE datetime,
	@ID_MODIFY_BY numeric(18, 0),
	@MODIFY_DATE datetime,
	@ID_DELETE_BY numeric(18, 0),
	@DELETE_DATE datetime,
	@AMOUNT_STEP numeric(18, 0),
	@AUCTION_ACCOUNT nvarchar(50),
	@LA_DAI_LY_YN nvarchar(1),
	@TY_LE_PHI numeric(21, 3),
	@PHAT_TIEN_DAT_COC_YN nvarchar(1),
	@REPAID_TIME_FROM datetime,
	@REPAID_TIME_TO datetime,
	@TINH_THANH_TO_CHUC nvarchar(50),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[AUCTION]
(
	[AUCTION_CODE],
	[AUCTION_NAME],
	[ID_KIND_OF_STOCK],
	[TOTAL_OF_STOCK],
	[FACE_VALUE],
	[STARTING_PRICE],
	[BID_LEVEL],
	[PRICE_STEP],
	[REG_TIME_FROM],
	[REG_TIME_TO],
	[AUCTION_TIME],
	[AUCTION_LOCATION],
	[CLOSE_TIME_FROM],
	[CLOSE_TIME_TO],
	[IS_OPEN_YN],
	[PAY_LOCATION],
	[CONTACT_ADDRESS],
	[REGISTER_COUNT],
	[ID_CREATE_BY],
	[CREATE_DATE],
	[ID_MODIFY_BY],
	[MODIFY_DATE],
	[ID_DELETE_BY],
	[DELETE_DATE],
	[AMOUNT_STEP],
	[AUCTION_ACCOUNT],
	[LA_DAI_LY_YN],
	[TY_LE_PHI],
	[PHAT_TIEN_DAT_COC_YN],
	[REPAID_TIME_FROM],
	[REPAID_TIME_TO],
	[TINH_THANH_TO_CHUC]
)
VALUES
(
	@AUCTION_CODE,
	@AUCTION_NAME,
	@ID_KIND_OF_STOCK,
	@TOTAL_OF_STOCK,
	@FACE_VALUE,
	@STARTING_PRICE,
	@BID_LEVEL,
	@PRICE_STEP,
	@REG_TIME_FROM,
	@REG_TIME_TO,
	@AUCTION_TIME,
	@AUCTION_LOCATION,
	@CLOSE_TIME_FROM,
	@CLOSE_TIME_TO,
	@IS_OPEN_YN,
	@PAY_LOCATION,
	@CONTACT_ADDRESS,
	@REGISTER_COUNT,
	@ID_CREATE_BY,
	@CREATE_DATE,
	@ID_MODIFY_BY,
	@MODIFY_DATE,
	@ID_DELETE_BY,
	@DELETE_DATE,
	@AMOUNT_STEP,
	@AUCTION_ACCOUNT,
	@LA_DAI_LY_YN,
	@TY_LE_PHI,
	@PHAT_TIEN_DAT_COC_YN,
	@REPAID_TIME_FROM,
	@REPAID_TIME_TO,
	@TINH_THANH_TO_CHUC
)
SELECT @ID=SCOPE_IDENTITY()
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_AUCTION_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_AUCTION_Update]
GO

CREATE PROCEDURE [dbo].[pr_AUCTION_Update]
	@ID numeric(18, 0),
	@AUCTION_CODE nvarchar(35),
	@AUCTION_NAME nvarchar(250),
	@ID_KIND_OF_STOCK numeric(18, 0),
	@TOTAL_OF_STOCK numeric(21, 3),
	@FACE_VALUE numeric(21, 3),
	@STARTING_PRICE numeric(21, 3),
	@BID_LEVEL numeric(4, 0),
	@PRICE_STEP numeric(21, 3),
	@REG_TIME_FROM datetime,
	@REG_TIME_TO datetime,
	@AUCTION_TIME datetime,
	@AUCTION_LOCATION nvarchar(250),
	@CLOSE_TIME_FROM datetime,
	@CLOSE_TIME_TO datetime,
	@IS_OPEN_YN nvarchar(1),
	@PAY_LOCATION nvarchar(250),
	@CONTACT_ADDRESS nvarchar(250),
	@REGISTER_COUNT numeric(21, 3),
	@ID_CREATE_BY numeric(18, 0),
	@CREATE_DATE datetime,
	@ID_MODIFY_BY numeric(18, 0),
	@MODIFY_DATE datetime,
	@ID_DELETE_BY numeric(18, 0),
	@DELETE_DATE datetime,
	@AMOUNT_STEP numeric(18, 0),
	@AUCTION_ACCOUNT nvarchar(50),
	@LA_DAI_LY_YN nvarchar(1),
	@TY_LE_PHI numeric(21, 3),
	@PHAT_TIEN_DAT_COC_YN nvarchar(1),
	@REPAID_TIME_FROM datetime,
	@REPAID_TIME_TO datetime,
	@TINH_THANH_TO_CHUC nvarchar(50)
AS
UPDATE [dbo].[AUCTION]
SET 
	[AUCTION_CODE] = @AUCTION_CODE,
	[AUCTION_NAME] = @AUCTION_NAME,
	[ID_KIND_OF_STOCK] = @ID_KIND_OF_STOCK,
	[TOTAL_OF_STOCK] = @TOTAL_OF_STOCK,
	[FACE_VALUE] = @FACE_VALUE,
	[STARTING_PRICE] = @STARTING_PRICE,
	[BID_LEVEL] = @BID_LEVEL,
	[PRICE_STEP] = @PRICE_STEP,
	[REG_TIME_FROM] = @REG_TIME_FROM,
	[REG_TIME_TO] = @REG_TIME_TO,
	[AUCTION_TIME] = @AUCTION_TIME,
	[AUCTION_LOCATION] = @AUCTION_LOCATION,
	[CLOSE_TIME_FROM] = @CLOSE_TIME_FROM,
	[CLOSE_TIME_TO] = @CLOSE_TIME_TO,
	[IS_OPEN_YN] = @IS_OPEN_YN,
	[PAY_LOCATION] = @PAY_LOCATION,
	[CONTACT_ADDRESS] = @CONTACT_ADDRESS,
	[REGISTER_COUNT] = @REGISTER_COUNT,
	[ID_CREATE_BY] = @ID_CREATE_BY,
	[CREATE_DATE] = @CREATE_DATE,
	[ID_MODIFY_BY] = @ID_MODIFY_BY,
	[MODIFY_DATE] = @MODIFY_DATE,
	[ID_DELETE_BY] = @ID_DELETE_BY,
	[DELETE_DATE] = @DELETE_DATE,
	[AMOUNT_STEP] = @AMOUNT_STEP,
	[AUCTION_ACCOUNT] = @AUCTION_ACCOUNT,
	[LA_DAI_LY_YN] = @LA_DAI_LY_YN,
	[TY_LE_PHI] = @TY_LE_PHI,
	[PHAT_TIEN_DAT_COC_YN] = @PHAT_TIEN_DAT_COC_YN,
	[REPAID_TIME_FROM] = @REPAID_TIME_FROM,
	[REPAID_TIME_TO] = @REPAID_TIME_TO,
	[TINH_THANH_TO_CHUC] = @TINH_THANH_TO_CHUC
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_AUCTION_UpdateAllWID_KIND_OF_STOCKLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_AUCTION_UpdateAllWID_KIND_OF_STOCKLogic]
GO

CREATE PROCEDURE [dbo].[pr_AUCTION_UpdateAllWID_KIND_OF_STOCKLogic]
	@ID_KIND_OF_STOCK numeric(18, 0),
	@ID_KIND_OF_STOCKOld numeric(18, 0)
AS
UPDATE [dbo].[AUCTION]
SET
	[ID_KIND_OF_STOCK] = @ID_KIND_OF_STOCK
WHERE
	[ID_KIND_OF_STOCK] = @ID_KIND_OF_STOCKOld
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_AUCTION_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_AUCTION_Delete]
GO

CREATE PROCEDURE [dbo].[pr_AUCTION_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[AUCTION]
WHERE
	[ID] = @ID
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_AUCTION_DeleteAllWID_KIND_OF_STOCKLogic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_AUCTION_DeleteAllWID_KIND_OF_STOCKLogic]
GO

CREATE PROCEDURE [dbo].[pr_AUCTION_DeleteAllWID_KIND_OF_STOCKLogic]
	@ID_KIND_OF_STOCK numeric(18, 0)
AS
DELETE
FROM [dbo].[AUCTION]
WHERE
	[ID_KIND_OF_STOCK] = @ID_KIND_OF_STOCK
GO

-- //// Try-to-lock-and-compare Stored procedure.
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pr_AUCTION_IsUpdatable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[pr_AUCTION_IsUpdatable]
GO

CREATE PROCEDURE [dbo].[pr_AUCTION_IsUpdatable]
	@AUCTION_CODE nvarchar(35),
	@AUCTION_NAME nvarchar(250),
	@ID_KIND_OF_STOCK numeric(18, 0),
	@TOTAL_OF_STOCK numeric(21, 3),
	@FACE_VALUE numeric(21, 3),
	@STARTING_PRICE numeric(21, 3),
	@BID_LEVEL numeric(4, 0),
	@PRICE_STEP numeric(21, 3),
	@REG_TIME_FROM datetime,
	@REG_TIME_TO datetime,
	@AUCTION_TIME datetime,
	@AUCTION_LOCATION nvarchar(250),
	@CLOSE_TIME_FROM datetime,
	@CLOSE_TIME_TO datetime,
	@IS_OPEN_YN nvarchar(1),
	@PAY_LOCATION nvarchar(250),
	@CONTACT_ADDRESS nvarchar(250),
	@REGISTER_COUNT numeric(21, 3),
	@ID_CREATE_BY numeric(18, 0),
	@CREATE_DATE datetime,
	@ID_MODIFY_BY numeric(18, 0),
	@MODIFY_DATE datetime,
	@ID_DELETE_BY numeric(18, 0),
	@DELETE_DATE datetime,
	@AMOUNT_STEP numeric(18, 0),
	@AUCTION_ACCOUNT nvarchar(50),
	@LA_DAI_LY_YN nvarchar(1),
	@TY_LE_PHI numeric(21, 3),
	@PHAT_TIEN_DAT_COC_YN nvarchar(1),
	@REPAID_TIME_FROM datetime,
	@REPAID_TIME_TO datetime,
	@TINH_THANH_TO_CHUC nvarchar(50),
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
	declare @v_AUCTION_CODE nvarchar(35)
	declare @v_AUCTION_NAME nvarchar(250)
	declare @v_ID_KIND_OF_STOCK numeric(18, 0)
	declare @v_TOTAL_OF_STOCK numeric(21, 3)
	declare @v_FACE_VALUE numeric(21, 3)
	declare @v_STARTING_PRICE numeric(21, 3)
	declare @v_BID_LEVEL numeric(4, 0)
	declare @v_PRICE_STEP numeric(21, 3)
	declare @v_REG_TIME_FROM datetime
	declare @v_REG_TIME_TO datetime
	declare @v_AUCTION_TIME datetime
	declare @v_AUCTION_LOCATION nvarchar(250)
	declare @v_CLOSE_TIME_FROM datetime
	declare @v_CLOSE_TIME_TO datetime
	declare @v_IS_OPEN_YN nvarchar(1)
	declare @v_PAY_LOCATION nvarchar(250)
	declare @v_CONTACT_ADDRESS nvarchar(250)
	declare @v_REGISTER_COUNT numeric(21, 3)
	declare @v_ID_CREATE_BY numeric(18, 0)
	declare @v_CREATE_DATE datetime
	declare @v_ID_MODIFY_BY numeric(18, 0)
	declare @v_MODIFY_DATE datetime
	declare @v_ID_DELETE_BY numeric(18, 0)
	declare @v_DELETE_DATE datetime
	declare @v_AMOUNT_STEP numeric(18, 0)
	declare @v_AUCTION_ACCOUNT nvarchar(50)
	declare @v_LA_DAI_LY_YN nvarchar(1)
	declare @v_TY_LE_PHI numeric(21, 3)
	declare @v_PHAT_TIEN_DAT_COC_YN nvarchar(1)
	declare @v_REPAID_TIME_FROM datetime
	declare @v_REPAID_TIME_TO datetime
	declare @v_TINH_THANH_TO_CHUC nvarchar(50)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_AUCTION_CODE = AUCTION_CODE ,
	@v_AUCTION_NAME = AUCTION_NAME ,
	@v_ID_KIND_OF_STOCK = ID_KIND_OF_STOCK ,
	@v_TOTAL_OF_STOCK = TOTAL_OF_STOCK ,
	@v_FACE_VALUE = FACE_VALUE ,
	@v_STARTING_PRICE = STARTING_PRICE ,
	@v_BID_LEVEL = BID_LEVEL ,
	@v_PRICE_STEP = PRICE_STEP ,
	@v_REG_TIME_FROM = REG_TIME_FROM ,
	@v_REG_TIME_TO = REG_TIME_TO ,
	@v_AUCTION_TIME = AUCTION_TIME ,
	@v_AUCTION_LOCATION = AUCTION_LOCATION ,
	@v_CLOSE_TIME_FROM = CLOSE_TIME_FROM ,
	@v_CLOSE_TIME_TO = CLOSE_TIME_TO ,
	@v_IS_OPEN_YN = IS_OPEN_YN ,
	@v_PAY_LOCATION = PAY_LOCATION ,
	@v_CONTACT_ADDRESS = CONTACT_ADDRESS ,
	@v_REGISTER_COUNT = REGISTER_COUNT ,
	@v_ID_CREATE_BY = ID_CREATE_BY ,
	@v_CREATE_DATE = CREATE_DATE ,
	@v_ID_MODIFY_BY = ID_MODIFY_BY ,
	@v_MODIFY_DATE = MODIFY_DATE ,
	@v_ID_DELETE_BY = ID_DELETE_BY ,
	@v_DELETE_DATE = DELETE_DATE ,
	@v_AMOUNT_STEP = AMOUNT_STEP ,
	@v_AUCTION_ACCOUNT = AUCTION_ACCOUNT ,
	@v_LA_DAI_LY_YN = LA_DAI_LY_YN ,
	@v_TY_LE_PHI = TY_LE_PHI ,
	@v_PHAT_TIEN_DAT_COC_YN = PHAT_TIEN_DAT_COC_YN ,
	@v_REPAID_TIME_FROM = REPAID_TIME_FROM ,
	@v_REPAID_TIME_TO = REPAID_TIME_TO ,
	@v_TINH_THANH_TO_CHUC = TINH_THANH_TO_CHUC 
	 from AUCTION with (updlock, rowlock, nowait)
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
	isnull( @v_AUCTION_CODE,dbo.C_Extrem_Str() ) <> isnull( @AUCTION_CODE ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_AUCTION_NAME,dbo.C_Extrem_Str() ) <> isnull( @AUCTION_NAME ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_KIND_OF_STOCK,dbo.C_Extrem_Number() ) <> isnull( @ID_KIND_OF_STOCK ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TOTAL_OF_STOCK,dbo.C_Extrem_Number() ) <> isnull( @TOTAL_OF_STOCK ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_FACE_VALUE,dbo.C_Extrem_Number() ) <> isnull( @FACE_VALUE ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_STARTING_PRICE,dbo.C_Extrem_Number() ) <> isnull( @STARTING_PRICE ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_BID_LEVEL,dbo.C_Extrem_Number() ) <> isnull( @BID_LEVEL ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_PRICE_STEP,dbo.C_Extrem_Number() ) <> isnull( @PRICE_STEP ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_REG_TIME_FROM,dbo.C_Extrem_Date() ) <> isnull( @REG_TIME_FROM ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_REG_TIME_TO,dbo.C_Extrem_Date() ) <> isnull( @REG_TIME_TO ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_AUCTION_TIME,dbo.C_Extrem_Date() ) <> isnull( @AUCTION_TIME ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_AUCTION_LOCATION,dbo.C_Extrem_Str() ) <> isnull( @AUCTION_LOCATION ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_CLOSE_TIME_FROM,dbo.C_Extrem_Date() ) <> isnull( @CLOSE_TIME_FROM ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_CLOSE_TIME_TO,dbo.C_Extrem_Date() ) <> isnull( @CLOSE_TIME_TO ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_IS_OPEN_YN,dbo.C_Extrem_Str() ) <> isnull( @IS_OPEN_YN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_PAY_LOCATION,dbo.C_Extrem_Str() ) <> isnull( @PAY_LOCATION ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_CONTACT_ADDRESS,dbo.C_Extrem_Str() ) <> isnull( @CONTACT_ADDRESS ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_REGISTER_COUNT,dbo.C_Extrem_Number() ) <> isnull( @REGISTER_COUNT ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_ID_CREATE_BY,dbo.C_Extrem_Number() ) <> isnull( @ID_CREATE_BY ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_CREATE_DATE,dbo.C_Extrem_Date() ) <> isnull( @CREATE_DATE ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_ID_MODIFY_BY,dbo.C_Extrem_Number() ) <> isnull( @ID_MODIFY_BY ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_MODIFY_DATE,dbo.C_Extrem_Date() ) <> isnull( @MODIFY_DATE ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_ID_DELETE_BY,dbo.C_Extrem_Number() ) <> isnull( @ID_DELETE_BY ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_DELETE_DATE,dbo.C_Extrem_Date() ) <> isnull( @DELETE_DATE ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_AMOUNT_STEP,dbo.C_Extrem_Number() ) <> isnull( @AMOUNT_STEP ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_AUCTION_ACCOUNT,dbo.C_Extrem_Str() ) <> isnull( @AUCTION_ACCOUNT ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_LA_DAI_LY_YN,dbo.C_Extrem_Str() ) <> isnull( @LA_DAI_LY_YN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TY_LE_PHI,dbo.C_Extrem_Number() ) <> isnull( @TY_LE_PHI ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_PHAT_TIEN_DAT_COC_YN,dbo.C_Extrem_Str() ) <> isnull( @PHAT_TIEN_DAT_COC_YN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_REPAID_TIME_FROM,dbo.C_Extrem_Date() ) <> isnull( @REPAID_TIME_FROM ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_REPAID_TIME_TO,dbo.C_Extrem_Date() ) <> isnull( @REPAID_TIME_TO ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_TINH_THANH_TO_CHUC,dbo.C_Extrem_Str() ) <> isnull( @TINH_THANH_TO_CHUC ,dbo.C_Extrem_Str() ) 
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

