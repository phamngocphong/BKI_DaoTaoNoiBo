///************************************************
/// Generated by: PhongPN
/// Date: 09/07/2015 03:34:49
/// Goal: Create User Service Class for DM_MON_HOC
///************************************************
/// <summary>
/// Create User Service Class for DM_MON_HOC
/// </summary>

namespace BKI_QLTTQuocAnh.US
{
    using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_DM_MON_HOC : US_Object
{
	private const string c_TableName = "DM_MON_HOC";
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

	public string strDON_VI_GIANG_DAY 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DON_VI_GIANG_DAY", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DON_VI_GIANG_DAY"] = value;
		}
	}

	public bool IsDON_VI_GIANG_DAYNull() 
	{
		return pm_objDR.IsNull("DON_VI_GIANG_DAY");
	}

	public void SetDON_VI_GIANG_DAYNull() {
		pm_objDR["DON_VI_GIANG_DAY"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_MON_HOC() 
	{
		pm_objDS = new DS_DM_MON_HOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_MON_HOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_MON_HOC(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_MON_HOC();
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
