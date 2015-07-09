///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'GD_LOP_HOC'
// Generated by LLBLGen v1.21.2003.712 Final on: 09 Tháng Bảy 2015, 3:02:07 CH
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAO_TAO_NOI_BOLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the table 'GD_LOP_HOC'.
	/// </summary>
	public class GD_LOP_HOC : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		_tHOI_GIAN, _nGAY_LAP, _nGAY_SUA;
			private SqlInt32		_sO_LUONG;
			private SqlDecimal		_iD_MON_HOC, _iD_MON_HOCOld, _iD;
			private SqlString		_nGUOI_SUA, _dA_XOA, _nGUOI_LAP, _mA_LOP_HOC, _dIA_DIEM;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GD_LOP_HOC()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>MA_LOP_HOC</LI>
		///		 <LI>THOI_GIAN</LI>
		///		 <LI>DIA_DIEM. May be SqlString.Null</LI>
		///		 <LI>SO_LUONG</LI>
		///		 <LI>ID_MON_HOC</LI>
		///		 <LI>NGAY_LAP</LI>
		///		 <LI>NGAY_SUA</LI>
		///		 <LI>NGUOI_LAP</LI>
		///		 <LI>NGUOI_SUA</LI>
		///		 <LI>DA_XOA</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@MA_LOP_HOC", SqlDbType.NVarChar, 35, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mA_LOP_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@THOI_GIAN", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tHOI_GIAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@DIA_DIEM", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dIA_DIEM));
				cmdToExecute.Parameters.Add(new SqlParameter("@SO_LUONG", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _sO_LUONG));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_MON_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_MON_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_LAP", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_LAP));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_SUA", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_SUA));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGUOI_LAP", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGUOI_LAP));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGUOI_SUA", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGUOI_SUA));
				cmdToExecute.Parameters.Add(new SqlParameter("@DA_XOA", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dA_XOA));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Output, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_iD = (Decimal)cmdToExecute.Parameters["@ID"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::Insert::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		///		 <LI>MA_LOP_HOC</LI>
		///		 <LI>THOI_GIAN</LI>
		///		 <LI>DIA_DIEM. May be SqlString.Null</LI>
		///		 <LI>SO_LUONG</LI>
		///		 <LI>ID_MON_HOC</LI>
		///		 <LI>NGAY_LAP</LI>
		///		 <LI>NGAY_SUA</LI>
		///		 <LI>NGUOI_LAP</LI>
		///		 <LI>NGUOI_SUA</LI>
		///		 <LI>DA_XOA</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@MA_LOP_HOC", SqlDbType.NVarChar, 35, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mA_LOP_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@THOI_GIAN", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tHOI_GIAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@DIA_DIEM", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dIA_DIEM));
				cmdToExecute.Parameters.Add(new SqlParameter("@SO_LUONG", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _sO_LUONG));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_MON_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_MON_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_LAP", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_LAP));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_SUA", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_SUA));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGUOI_LAP", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGUOI_LAP));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGUOI_SUA", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGUOI_SUA));
				cmdToExecute.Parameters.Add(new SqlParameter("@DA_XOA", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dA_XOA));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::Update::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'ID_MON_HOC.
		/// This method will Update one or more existing rows in the database. It will reset the field 'ID_MON_HOC' in
		/// all rows which have as value for this field the value as set in property 'ID_MON_HOCOld' to 
		/// the value as set in property 'ID_MON_HOC'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_MON_HOC</LI>
		///		 <LI>ID_MON_HOCOld</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWID_MON_HOCLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_UpdateAllWID_MON_HOCLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_MON_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_MON_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_MON_HOCOld", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_MON_HOCOld));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::UpdateAllWID_MON_HOCLogic::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_Delete]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::Delete::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'ID_MON_HOC'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_MON_HOC</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWID_MON_HOCLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_DeleteAllWID_MON_HOCLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_MON_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_MON_HOC));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::DeleteAllWID_MON_HOCLogic::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		///		 <LI>ID</LI>
		///		 <LI>MA_LOP_HOC</LI>
		///		 <LI>THOI_GIAN</LI>
		///		 <LI>DIA_DIEM</LI>
		///		 <LI>SO_LUONG</LI>
		///		 <LI>ID_MON_HOC</LI>
		///		 <LI>NGAY_LAP</LI>
		///		 <LI>NGAY_SUA</LI>
		///		 <LI>NGUOI_LAP</LI>
		///		 <LI>NGUOI_SUA</LI>
		///		 <LI>DA_XOA</LI>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_SelectOne]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_LOP_HOC");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				adapter.Fill(toReturn);
				if(toReturn.Rows.Count > 0)
				{
					_iD = (Decimal)toReturn.Rows[0]["ID"];
					_mA_LOP_HOC = (string)toReturn.Rows[0]["MA_LOP_HOC"];
					_tHOI_GIAN = (DateTime)toReturn.Rows[0]["THOI_GIAN"];
					_dIA_DIEM = toReturn.Rows[0]["DIA_DIEM"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["DIA_DIEM"];
					_sO_LUONG = (Int32)toReturn.Rows[0]["SO_LUONG"];
					_iD_MON_HOC = (Decimal)toReturn.Rows[0]["ID_MON_HOC"];
					_nGAY_LAP = (DateTime)toReturn.Rows[0]["NGAY_LAP"];
					_nGAY_SUA = (DateTime)toReturn.Rows[0]["NGAY_SUA"];
					_nGUOI_LAP = (string)toReturn.Rows[0]["NGUOI_LAP"];
					_nGUOI_SUA = (string)toReturn.Rows[0]["NGUOI_SUA"];
					_dA_XOA = (string)toReturn.Rows[0]["DA_XOA"];
				}
				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::SelectOne::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: SelectAll method. This method will Select all rows from the table.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// </remarks>
		public override DataTable SelectAll()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_SelectAll]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_LOP_HOC");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				adapter.Fill(toReturn);
				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::SelectAll::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'ID_MON_HOC'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_MON_HOC</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWID_MON_HOCLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_LOP_HOC_SelectAllWID_MON_HOCLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_LOP_HOC");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_MON_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_MON_HOC));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				adapter.Fill(toReturn);
				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("GD_LOP_HOC::SelectAllWID_MON_HOCLogic::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlDecimal ID
		{
			get
			{
				return _iD;
			}
			set
			{
				SqlDecimal iDTmp = (SqlDecimal)value;
				if(iDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID", "ID can't be NULL");
				}
				_iD = value;
			}
		}


		public SqlString MA_LOP_HOC
		{
			get
			{
				return _mA_LOP_HOC;
			}
			set
			{
				SqlString mA_LOP_HOCTmp = (SqlString)value;
				if(mA_LOP_HOCTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("MA_LOP_HOC", "MA_LOP_HOC can't be NULL");
				}
				_mA_LOP_HOC = value;
			}
		}


		public SqlDateTime THOI_GIAN
		{
			get
			{
				return _tHOI_GIAN;
			}
			set
			{
				SqlDateTime tHOI_GIANTmp = (SqlDateTime)value;
				if(tHOI_GIANTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("THOI_GIAN", "THOI_GIAN can't be NULL");
				}
				_tHOI_GIAN = value;
			}
		}


		public SqlString DIA_DIEM
		{
			get
			{
				return _dIA_DIEM;
			}
			set
			{
				SqlString dIA_DIEMTmp = (SqlString)value;
				if(dIA_DIEMTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DIA_DIEM", "DIA_DIEM can't be NULL");
				}
				_dIA_DIEM = value;
			}
		}


		public SqlInt32 SO_LUONG
		{
			get
			{
				return _sO_LUONG;
			}
			set
			{
				SqlInt32 sO_LUONGTmp = (SqlInt32)value;
				if(sO_LUONGTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("SO_LUONG", "SO_LUONG can't be NULL");
				}
				_sO_LUONG = value;
			}
		}


		public SqlDecimal ID_MON_HOC
		{
			get
			{
				return _iD_MON_HOC;
			}
			set
			{
				SqlDecimal iD_MON_HOCTmp = (SqlDecimal)value;
				if(iD_MON_HOCTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_MON_HOC", "ID_MON_HOC can't be NULL");
				}
				_iD_MON_HOC = value;
			}
		}
		public SqlDecimal ID_MON_HOCOld
		{
			get
			{
				return _iD_MON_HOCOld;
			}
			set
			{
				SqlDecimal iD_MON_HOCOldTmp = (SqlDecimal)value;
				if(iD_MON_HOCOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_MON_HOCOld", "ID_MON_HOCOld can't be NULL");
				}
				_iD_MON_HOCOld = value;
			}
		}


		public SqlDateTime NGAY_LAP
		{
			get
			{
				return _nGAY_LAP;
			}
			set
			{
				SqlDateTime nGAY_LAPTmp = (SqlDateTime)value;
				if(nGAY_LAPTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGAY_LAP", "NGAY_LAP can't be NULL");
				}
				_nGAY_LAP = value;
			}
		}


		public SqlDateTime NGAY_SUA
		{
			get
			{
				return _nGAY_SUA;
			}
			set
			{
				SqlDateTime nGAY_SUATmp = (SqlDateTime)value;
				if(nGAY_SUATmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGAY_SUA", "NGAY_SUA can't be NULL");
				}
				_nGAY_SUA = value;
			}
		}


		public SqlString NGUOI_LAP
		{
			get
			{
				return _nGUOI_LAP;
			}
			set
			{
				SqlString nGUOI_LAPTmp = (SqlString)value;
				if(nGUOI_LAPTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGUOI_LAP", "NGUOI_LAP can't be NULL");
				}
				_nGUOI_LAP = value;
			}
		}


		public SqlString NGUOI_SUA
		{
			get
			{
				return _nGUOI_SUA;
			}
			set
			{
				SqlString nGUOI_SUATmp = (SqlString)value;
				if(nGUOI_SUATmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGUOI_SUA", "NGUOI_SUA can't be NULL");
				}
				_nGUOI_SUA = value;
			}
		}


		public SqlString DA_XOA
		{
			get
			{
				return _dA_XOA;
			}
			set
			{
				SqlString dA_XOATmp = (SqlString)value;
				if(dA_XOATmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DA_XOA", "DA_XOA can't be NULL");
				}
				_dA_XOA = value;
			}
		}
		#endregion
	}
}
