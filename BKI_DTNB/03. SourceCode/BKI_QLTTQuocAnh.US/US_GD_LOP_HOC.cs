///************************************************
/// Generated by: PhongPN
/// Date: 09/07/2015 03:35:52
/// Goal: Create User Service Class for GD_LOP_HOC
///************************************************
/// <summary>
/// Create User Service Class for GD_LOP_HOC
/// </summary>

namespace BKI_QLTTQuocAnh.US
{
    using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_GD_LOP_HOC : US_Object
{
	private const string c_TableName = "GD_LOP_HOC";
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

	public DateTime datTHOI_GIAN
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "THOI_GIAN", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["THOI_GIAN"] = value;
		}
	}

	public bool IsTHOI_GIANNull()
	{
		return pm_objDR.IsNull("THOI_GIAN");
	}

	public void SetTHOI_GIANNull()
	{
		pm_objDR["THOI_GIAN"] = System.Convert.DBNull;
	}

	public string strDIA_DIEM 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIA_DIEM", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIA_DIEM"] = value;
		}
	}

	public bool IsDIA_DIEMNull() 
	{
		return pm_objDR.IsNull("DIA_DIEM");
	}

	public void SetDIA_DIEMNull() {
		pm_objDR["DIA_DIEM"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG"] = value;
		}
	}

	public bool IsSO_LUONGNull()	{
		return pm_objDR.IsNull("SO_LUONG");
	}

	public void SetSO_LUONGNull() {
		pm_objDR["SO_LUONG"] = System.Convert.DBNull;
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

	public DateTime datNGAY_SUA
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SUA", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SUA"] = value;
		}
	}

	public bool IsNGAY_SUANull()
	{
		return pm_objDR.IsNull("NGAY_SUA");
	}

	public void SetNGAY_SUANull()
	{
		pm_objDR["NGAY_SUA"] = System.Convert.DBNull;
	}

	public string strNGUOI_LAP 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_LAP", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_LAP"] = value;
		}
	}

	public bool IsNGUOI_LAPNull() 
	{
		return pm_objDR.IsNull("NGUOI_LAP");
	}

	public void SetNGUOI_LAPNull() {
		pm_objDR["NGUOI_LAP"] = System.Convert.DBNull;
	}

	public string strNGUOI_SUA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_SUA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_SUA"] = value;
		}
	}

	public bool IsNGUOI_SUANull() 
	{
		return pm_objDR.IsNull("NGUOI_SUA");
	}

	public void SetNGUOI_SUANull() {
		pm_objDR["NGUOI_SUA"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_GD_LOP_HOC() 
	{
		pm_objDS = new DS_GD_LOP_HOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_LOP_HOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_LOP_HOC(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_LOP_HOC();
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
