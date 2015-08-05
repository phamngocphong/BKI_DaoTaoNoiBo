///************************************************
/// Generated by: tund
/// Date: 03/08/2015 10:40:31
/// Goal: Create User Service Class for GD_CHUNG_CHI
///************************************************
/// <summary>
/// Create User Service Class for GD_CHUNG_CHI
/// </summary>

using System;
using BKI_DTNB.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DTNB.US{

public class US_GD_CHUNG_CHI : US_Object
{
	private const string c_TableName = "GD_CHUNG_CHI";
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

	public DateTime datNGAY_CAP
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_CAP", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_CAP"] = value;
		}
	}

	public bool IsNGAY_CAPNull()
	{
		return pm_objDR.IsNull("NGAY_CAP");
	}

	public void SetNGAY_CAPNull()
	{
		pm_objDR["NGAY_CAP"] = System.Convert.DBNull;
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
	public US_GD_CHUNG_CHI() 
	{
		pm_objDS = new DS_GD_CHUNG_CHI();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_CHUNG_CHI(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_CHUNG_CHI(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_CHUNG_CHI();
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