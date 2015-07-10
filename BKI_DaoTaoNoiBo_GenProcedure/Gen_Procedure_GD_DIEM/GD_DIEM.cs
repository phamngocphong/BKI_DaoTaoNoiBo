///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'GD_DIEM'
// Generated by LLBLGen v1.21.2003.712 Final on: 09 Tháng Bảy 2015, 3:01:55 CH
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAO_TAO_NOI_BOLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the table 'GD_DIEM'.
	/// </summary>
	public class GD_DIEM : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		_nGAY_SUA, _nGAY_LAP;
			private SqlDecimal		_iD, _iD_LOP_HOC, _iD_LOP_HOCOld, _iD_NHAN_VIEN, _iD_NHAN_VIENOld;
			private SqlString		_nGUOI_SUA, _dA_XOA, _qUA_MON, _nGUOI_LAP;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GD_DIEM()
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
		///		 <LI>ID_NHAN_VIEN</LI>
		///		 <LI>ID_LOP_HOC</LI>
		///		 <LI>QUA_MON</LI>
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
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_VIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_VIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOP_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOP_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@QUA_MON", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _qUA_MON));
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
				throw new Exception("GD_DIEM::Insert::Error occured.", ex);
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
		///		 <LI>ID_NHAN_VIEN</LI>
		///		 <LI>ID_LOP_HOC</LI>
		///		 <LI>QUA_MON</LI>
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
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_VIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_VIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOP_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOP_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@QUA_MON", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _qUA_MON));
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
				throw new Exception("GD_DIEM::Update::Error occured.", ex);
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
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'ID_NHAN_VIEN.
		/// This method will Update one or more existing rows in the database. It will reset the field 'ID_NHAN_VIEN' in
		/// all rows which have as value for this field the value as set in property 'ID_NHAN_VIENOld' to 
		/// the value as set in property 'ID_NHAN_VIEN'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_NHAN_VIEN</LI>
		///		 <LI>ID_NHAN_VIENOld</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWID_NHAN_VIENLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_UpdateAllWID_NHAN_VIENLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_VIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_VIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_VIENOld", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_VIENOld));

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
				throw new Exception("GD_DIEM::UpdateAllWID_NHAN_VIENLogic::Error occured.", ex);
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
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'ID_LOP_HOC.
		/// This method will Update one or more existing rows in the database. It will reset the field 'ID_LOP_HOC' in
		/// all rows which have as value for this field the value as set in property 'ID_LOP_HOCOld' to 
		/// the value as set in property 'ID_LOP_HOC'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_LOP_HOC</LI>
		///		 <LI>ID_LOP_HOCOld</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWID_LOP_HOCLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_UpdateAllWID_LOP_HOCLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOP_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOP_HOC));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOP_HOCOld", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOP_HOCOld));

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
				throw new Exception("GD_DIEM::UpdateAllWID_LOP_HOCLogic::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_Delete]";
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
				throw new Exception("GD_DIEM::Delete::Error occured.", ex);
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
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'ID_NHAN_VIEN'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_NHAN_VIEN</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWID_NHAN_VIENLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_DeleteAllWID_NHAN_VIENLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_VIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_VIEN));

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
				throw new Exception("GD_DIEM::DeleteAllWID_NHAN_VIENLogic::Error occured.", ex);
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
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'ID_LOP_HOC'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_LOP_HOC</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWID_LOP_HOCLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_DeleteAllWID_LOP_HOCLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOP_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOP_HOC));

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
				throw new Exception("GD_DIEM::DeleteAllWID_LOP_HOCLogic::Error occured.", ex);
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
		///		 <LI>ID_NHAN_VIEN</LI>
		///		 <LI>ID_LOP_HOC</LI>
		///		 <LI>QUA_MON</LI>
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
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_SelectOne]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_DIEM");
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
					_iD_NHAN_VIEN = (Decimal)toReturn.Rows[0]["ID_NHAN_VIEN"];
					_iD_LOP_HOC = (Decimal)toReturn.Rows[0]["ID_LOP_HOC"];
					_qUA_MON = (string)toReturn.Rows[0]["QUA_MON"];
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
				throw new Exception("GD_DIEM::SelectOne::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_SelectAll]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_DIEM");
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
				throw new Exception("GD_DIEM::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'ID_NHAN_VIEN'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_NHAN_VIEN</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWID_NHAN_VIENLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_SelectAllWID_NHAN_VIENLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_DIEM");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_VIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_VIEN));

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
				throw new Exception("GD_DIEM::SelectAllWID_NHAN_VIENLogic::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'ID_LOP_HOC'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_LOP_HOC</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWID_LOP_HOCLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_DIEM_SelectAllWID_LOP_HOCLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_DIEM");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOP_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOP_HOC));

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
				throw new Exception("GD_DIEM::SelectAllWID_LOP_HOCLogic::Error occured.", ex);
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


		public SqlDecimal ID_NHAN_VIEN
		{
			get
			{
				return _iD_NHAN_VIEN;
			}
			set
			{
				SqlDecimal iD_NHAN_VIENTmp = (SqlDecimal)value;
				if(iD_NHAN_VIENTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_NHAN_VIEN", "ID_NHAN_VIEN can't be NULL");
				}
				_iD_NHAN_VIEN = value;
			}
		}
		public SqlDecimal ID_NHAN_VIENOld
		{
			get
			{
				return _iD_NHAN_VIENOld;
			}
			set
			{
				SqlDecimal iD_NHAN_VIENOldTmp = (SqlDecimal)value;
				if(iD_NHAN_VIENOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_NHAN_VIENOld", "ID_NHAN_VIENOld can't be NULL");
				}
				_iD_NHAN_VIENOld = value;
			}
		}


		public SqlDecimal ID_LOP_HOC
		{
			get
			{
				return _iD_LOP_HOC;
			}
			set
			{
				SqlDecimal iD_LOP_HOCTmp = (SqlDecimal)value;
				if(iD_LOP_HOCTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_LOP_HOC", "ID_LOP_HOC can't be NULL");
				}
				_iD_LOP_HOC = value;
			}
		}
		public SqlDecimal ID_LOP_HOCOld
		{
			get
			{
				return _iD_LOP_HOCOld;
			}
			set
			{
				SqlDecimal iD_LOP_HOCOldTmp = (SqlDecimal)value;
				if(iD_LOP_HOCOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_LOP_HOCOld", "ID_LOP_HOCOld can't be NULL");
				}
				_iD_LOP_HOCOld = value;
			}
		}


		public SqlString QUA_MON
		{
			get
			{
				return _qUA_MON;
			}
			set
			{
				SqlString qUA_MONTmp = (SqlString)value;
				if(qUA_MONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("QUA_MON", "QUA_MON can't be NULL");
				}
				_qUA_MON = value;
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