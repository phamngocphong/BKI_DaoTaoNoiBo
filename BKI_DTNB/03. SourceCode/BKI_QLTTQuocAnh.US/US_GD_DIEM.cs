///************************************************
/// Generated by: THAIPH
/// Date: 13/07/2015 10:16:35
/// Goal: Create User Service Class for GD_DIEM
///************************************************
/// <summary>
/// Create User Service Class for GD_DIEM
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_GD_DIEM : US_Object
{
	private const string c_TableName = "GD_DIEM";
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

	public decimal dcID_LOP_HOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOP_HOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOP_HOC"] = value;
		}
	}

	public bool IsID_LOP_HOCNull()	{
		return pm_objDR.IsNull("ID_LOP_HOC");
	}

	public void SetID_LOP_HOCNull() {
		pm_objDR["ID_LOP_HOC"] = System.Convert.DBNull;
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

	public string strHOC_XONG_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HOC_XONG_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HOC_XONG_YN"] = value;
		}
	}

	public bool IsHOC_XONG_YNNull() 
	{
		return pm_objDR.IsNull("HOC_XONG_YN");
	}

	public void SetHOC_XONG_YNNull() {
		pm_objDR["HOC_XONG_YN"] = System.Convert.DBNull;
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
	public US_GD_DIEM() 
	{
		pm_objDS = new DS_GD_DIEM();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_DIEM(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_DIEM(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_DIEM();
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
