///************************************************
/// Generated by: tund
/// Date: 02/08/2015 12:07:33
/// Goal: Create User Service Class for DM_NHAN_SU_NGHIEP_VU
///************************************************
/// <summary>
/// Create User Service Class for DM_NHAN_SU_NGHIEP_VU
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_DM_NHAN_SU_NGHIEP_VU : US_Object
{
	private const string c_TableName = "DM_NHAN_SU_NGHIEP_VU";
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

	public decimal dcID_NHAN_SU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_SU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHAN_SU"] = value;
		}
	}

	public bool IsID_NHAN_SUNull()	{
		return pm_objDR.IsNull("ID_NHAN_SU");
	}

	public void SetID_NHAN_SUNull() {
		pm_objDR["ID_NHAN_SU"] = System.Convert.DBNull;
	}

	public decimal dcID_NGHIEP_VU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGHIEP_VU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGHIEP_VU"] = value;
		}
	}

	public bool IsID_NGHIEP_VUNull()	{
		return pm_objDR.IsNull("ID_NGHIEP_VU");
	}

	public void SetID_NGHIEP_VUNull() {
		pm_objDR["ID_NGHIEP_VU"] = System.Convert.DBNull;
	}

	public string strNGHIEP_VU_CHINH_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHIEP_VU_CHINH_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHIEP_VU_CHINH_YN"] = value;
		}
	}

	public bool IsNGHIEP_VU_CHINH_YNNull() 
	{
		return pm_objDR.IsNull("NGHIEP_VU_CHINH_YN");
	}

	public void SetNGHIEP_VU_CHINH_YNNull() {
		pm_objDR["NGHIEP_VU_CHINH_YN"] = System.Convert.DBNull;
	}

	public string strNGHIEP_VU_HOC_THEM_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHIEP_VU_HOC_THEM_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHIEP_VU_HOC_THEM_YN"] = value;
		}
	}

	public bool IsNGHIEP_VU_HOC_THEM_YNNull() 
	{
		return pm_objDR.IsNull("NGHIEP_VU_HOC_THEM_YN");
	}

	public void SetNGHIEP_VU_HOC_THEM_YNNull() {
		pm_objDR["NGHIEP_VU_HOC_THEM_YN"] = System.Convert.DBNull;
	}

	public string strDA_XOA_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DA_XOA_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DA_XOA_YN"] = value;
		}
	}

	public bool IsDA_XOA_YNNull() 
	{
		return pm_objDR.IsNull("DA_XOA_YN");
	}

	public void SetDA_XOA_YNNull() {
		pm_objDR["DA_XOA_YN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_NHAN_SU_NGHIEP_VU() 
	{
		pm_objDS = new DS_DM_NHAN_SU_NGHIEP_VU();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_NHAN_SU_NGHIEP_VU(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_NHAN_SU_NGHIEP_VU(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_NHAN_SU_NGHIEP_VU();
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
