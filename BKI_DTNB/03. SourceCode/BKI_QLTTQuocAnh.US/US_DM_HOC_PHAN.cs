///************************************************
/// Generated by: PhongPN
/// Date: 09/07/2015 03:34:24
/// Goal: Create User Service Class for DM_HOC_PHAN
///************************************************
/// <summary>
/// Create User Service Class for DM_HOC_PHAN
/// </summary>

namespace BKI_QLTTQuocAnh.US
{
    using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_DM_HOC_PHAN : US_Object
{
	private const string c_TableName = "DM_HOC_PHAN";
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

	public string strMA_HOC_PHAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HOC_PHAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HOC_PHAN"] = value;
		}
	}

	public bool IsMA_HOC_PHANNull() 
	{
		return pm_objDR.IsNull("MA_HOC_PHAN");
	}

	public void SetMA_HOC_PHANNull() {
		pm_objDR["MA_HOC_PHAN"] = System.Convert.DBNull;
	}

	public string strTEN_HOC_PHAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_HOC_PHAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_HOC_PHAN"] = value;
		}
	}

	public bool IsTEN_HOC_PHANNull() 
	{
		return pm_objDR.IsNull("TEN_HOC_PHAN");
	}

	public void SetTEN_HOC_PHANNull() {
		pm_objDR["TEN_HOC_PHAN"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG_YEU_CAU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_YEU_CAU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG_YEU_CAU"] = value;
		}
	}

	public bool IsSO_LUONG_YEU_CAUNull()	{
		return pm_objDR.IsNull("SO_LUONG_YEU_CAU");
	}

	public void SetSO_LUONG_YEU_CAUNull() {
		pm_objDR["SO_LUONG_YEU_CAU"] = System.Convert.DBNull;
	}

	public string strBAT_BUOC_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "BAT_BUOC_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["BAT_BUOC_YN"] = value;
		}
	}

	public bool IsBAT_BUOC_YNNull() 
	{
		return pm_objDR.IsNull("BAT_BUOC_YN");
	}

	public void SetBAT_BUOC_YNNull() {
		pm_objDR["BAT_BUOC_YN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_HOC_PHAN() 
	{
		pm_objDS = new DS_DM_HOC_PHAN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_HOC_PHAN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_HOC_PHAN(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_HOC_PHAN();
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
