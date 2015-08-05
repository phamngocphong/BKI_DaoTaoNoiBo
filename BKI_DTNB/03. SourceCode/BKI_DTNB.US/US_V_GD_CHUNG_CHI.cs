///************************************************
/// Generated by: PhongPN
/// Date: 05/08/2015 10:55:48
/// Goal: Create User Service Class for V_GD_CHUNG_CHI
///************************************************
/// <summary>
/// Create User Service Class for V_GD_CHUNG_CHI
/// </summary>

using System;
using BKI_DTNB.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DTNB.US{

public class US_V_GD_CHUNG_CHI : US_Object
{
	private const string c_TableName = "V_GD_CHUNG_CHI";
#region "Public Properties"
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

	public DateTime datNGAY_BAT_DAU
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BAT_DAU"] = value;
		}
	}

	public bool IsNGAY_BAT_DAUNull()
	{
		return pm_objDR.IsNull("NGAY_BAT_DAU");
	}

	public void SetNGAY_BAT_DAUNull()
	{
		pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KET_THUC
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KET_THUC"] = value;
		}
	}

	public bool IsNGAY_KET_THUCNull()
	{
		return pm_objDR.IsNull("NGAY_KET_THUC");
	}

	public void SetNGAY_KET_THUCNull()
	{
		pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
	}

	public string strSO_CHUNG_CHI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "SO_CHUNG_CHI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["SO_CHUNG_CHI"] = value;
		}
	}

	public bool IsSO_CHUNG_CHINull() 
	{
		return pm_objDR.IsNull("SO_CHUNG_CHI");
	}

	public void SetSO_CHUNG_CHINull() {
		pm_objDR["SO_CHUNG_CHI"] = System.Convert.DBNull;
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

	public string strTRANG_THAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI"] = value;
		}
	}

	public bool IsTRANG_THAINull() 
	{
		return pm_objDR.IsNull("TRANG_THAI");
	}

	public void SetTRANG_THAINull() {
		pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
	}

	public decimal dcID_GD_DIEM 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_GD_DIEM", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_GD_DIEM"] = value;
		}
	}

	public bool IsID_GD_DIEMNull()	{
		return pm_objDR.IsNull("ID_GD_DIEM");
	}

	public void SetID_GD_DIEMNull() {
		pm_objDR["ID_GD_DIEM"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_LAP
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_LAP"] = value;
		}
	}

	public bool IsNGAY_LAPNull()
	{
		return pm_objDR.IsNull("NGAY_LAP");
	}

	public void SetNGAY_LAPNull()
	{
		pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_CHUNG_CHI() 
	{
		pm_objDS = new DS_V_GD_CHUNG_CHI();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_CHUNG_CHI(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_CHUNG_CHI(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_CHUNG_CHI();
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
