///************************************************
/// Generated by: PhongPN
/// Date: 09/07/2015 03:35:05
/// Goal: Create User Service Class for DM_NGACH_PHONG
///************************************************
/// <summary>
/// Create User Service Class for DM_NGACH_PHONG
/// </summary>

namespace AuctionUS
{
using AuctionDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_DM_NGACH_PHONG : US_Object
{
	private const string c_TableName = "DM_NGACH_PHONG";
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

	public decimal dcKHU_VUC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "KHU_VUC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["KHU_VUC"] = value;
		}
	}

	public bool IsKHU_VUCNull()	{
		return pm_objDR.IsNull("KHU_VUC");
	}

	public void SetKHU_VUCNull() {
		pm_objDR["KHU_VUC"] = System.Convert.DBNull;
	}

	public decimal dcID_NGACH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGACH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGACH"] = value;
		}
	}

	public bool IsID_NGACHNull()	{
		return pm_objDR.IsNull("ID_NGACH");
	}

	public void SetID_NGACHNull() {
		pm_objDR["ID_NGACH"] = System.Convert.DBNull;
	}

	public decimal dcID_PHONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_PHONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_PHONG"] = value;
		}
	}

	public bool IsID_PHONGNull()	{
		return pm_objDR.IsNull("ID_PHONG");
	}

	public void SetID_PHONGNull() {
		pm_objDR["ID_PHONG"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_NGACH_PHONG() 
	{
		pm_objDS = new DS_DM_NGACH_PHONG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_NGACH_PHONG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_NGACH_PHONG(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_NGACH_PHONG();
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
