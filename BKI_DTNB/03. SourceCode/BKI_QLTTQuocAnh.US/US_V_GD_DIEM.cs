///************************************************
/// Generated by: PhongPN
/// Date: 21/07/2015 10:49:38
/// Goal: Create User Service Class for V_GD_DIEM
///************************************************
/// <summary>
/// Create User Service Class for V_GD_DIEM
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_V_GD_DIEM : US_Object
{
	private const string c_TableName = "V_GD_DIEM";
#region "Public Properties"
	public decimal dcID_NHAN_VIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_VIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHAN_VIEN"] = value;
		}
	}

	public bool IsID_NHAN_VIENNull()	{
		return pm_objDR.IsNull("ID_NHAN_VIEN");
	}

	public void SetID_NHAN_VIENNull() {
		pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
	}

	public string strHO_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN"] = value;
		}
	}

	public bool IsHO_TENNull() 
	{
		return pm_objDR.IsNull("HO_TEN");
	}

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

	public string strMA_TRUNG_TAM 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_TRUNG_TAM", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_TRUNG_TAM"] = value;
		}
	}

	public bool IsMA_TRUNG_TAMNull() 
	{
		return pm_objDR.IsNull("MA_TRUNG_TAM");
	}

	public void SetMA_TRUNG_TAMNull() {
		pm_objDR["MA_TRUNG_TAM"] = System.Convert.DBNull;
	}

	public decimal dcID_MON_HOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_MON_HOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_MON_HOC"] = value;
		}
	}

	public bool IsID_MON_HOCNull()	{
		return pm_objDR.IsNull("ID_MON_HOC");
	}

	public void SetID_MON_HOCNull() {
		pm_objDR["ID_MON_HOC"] = System.Convert.DBNull;
	}

	public string strMA_MON_HOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_MON_HOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_MON_HOC"] = value;
		}
	}

	public bool IsMA_MON_HOCNull() 
	{
		return pm_objDR.IsNull("MA_MON_HOC");
	}

	public void SetMA_MON_HOCNull() {
		pm_objDR["MA_MON_HOC"] = System.Convert.DBNull;
	}

	public string strMA_LOP_HOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LOP_HOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LOP_HOC"] = value;
		}
	}

	public bool IsMA_LOP_HOCNull() 
	{
		return pm_objDR.IsNull("MA_LOP_HOC");
	}

	public void SetMA_LOP_HOCNull() {
		pm_objDR["MA_LOP_HOC"] = System.Convert.DBNull;
	}

	public decimal dcID_LOP_MON 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOP_MON", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOP_MON"] = value;
		}
	}

	public bool IsID_LOP_MONNull()	{
		return pm_objDR.IsNull("ID_LOP_MON");
	}

	public void SetID_LOP_MONNull() {
		pm_objDR["ID_LOP_MON"] = System.Convert.DBNull;
	}

	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public decimal dcDIEM_CHUYEN_CAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DIEM_CHUYEN_CAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DIEM_CHUYEN_CAN"] = value;
		}
	}

	public bool IsDIEM_CHUYEN_CANNull()	{
		return pm_objDR.IsNull("DIEM_CHUYEN_CAN");
	}

	public void SetDIEM_CHUYEN_CANNull() {
		pm_objDR["DIEM_CHUYEN_CAN"] = System.Convert.DBNull;
	}

	public decimal dcDIEM_KIEM_TRA 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DIEM_KIEM_TRA", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DIEM_KIEM_TRA"] = value;
		}
	}

	public bool IsDIEM_KIEM_TRANull()	{
		return pm_objDR.IsNull("DIEM_KIEM_TRA");
	}

	public void SetDIEM_KIEM_TRANull() {
		pm_objDR["DIEM_KIEM_TRA"] = System.Convert.DBNull;
	}

	public decimal dcDIEM_THI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DIEM_THI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DIEM_THI"] = value;
		}
	}

	public bool IsDIEM_THINull()	{
		return pm_objDR.IsNull("DIEM_THI");
	}

	public void SetDIEM_THINull() {
		pm_objDR["DIEM_THI"] = System.Convert.DBNull;
	}

	public string strHOC_XONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HOC_XONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HOC_XONG"] = value;
		}
	}

	public bool IsHOC_XONGNull() 
	{
		return pm_objDR.IsNull("HOC_XONG");
	}

	public void SetHOC_XONGNull() {
		pm_objDR["HOC_XONG"] = System.Convert.DBNull;
	}

	public string strQUA_MON 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "QUA_MON", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["QUA_MON"] = value;
		}
	}

	public bool IsQUA_MONNull() 
	{
		return pm_objDR.IsNull("QUA_MON");
	}

	public void SetQUA_MONNull() {
		pm_objDR["QUA_MON"] = System.Convert.DBNull;
	}

	public string strMA_NV 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_NV", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_NV"] = value;
		}
	}

	public bool IsMA_NVNull() 
	{
		return pm_objDR.IsNull("MA_NV");
	}

	public void SetMA_NVNull() {
		pm_objDR["MA_NV"] = System.Convert.DBNull;
	}

	public string strDA_XOA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DA_XOA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DA_XOA"] = value;
		}
	}

	public bool IsDA_XOANull() 
	{
		return pm_objDR.IsNull("DA_XOA");
	}

	public void SetDA_XOANull() {
		pm_objDR["DA_XOA"] = System.Convert.DBNull;
	}

	public string strTEN_MON_HOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_MON_HOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_MON_HOC"] = value;
		}
	}

	public bool IsTEN_MON_HOCNull() 
	{
		return pm_objDR.IsNull("TEN_MON_HOC");
	}

	public void SetTEN_MON_HOCNull() {
		pm_objDR["TEN_MON_HOC"] = System.Convert.DBNull;
	}

	public string strMA_VERSION 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_VERSION", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_VERSION"] = value;
		}
	}

	public bool IsMA_VERSIONNull() 
	{
		return pm_objDR.IsNull("MA_VERSION");
	}

	public void SetMA_VERSIONNull() {
		pm_objDR["MA_VERSION"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_DIEM() 
	{
		pm_objDS = new DS_V_GD_DIEM();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_DIEM(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_DIEM(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_DIEM();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
