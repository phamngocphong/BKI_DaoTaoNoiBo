///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'DM_HOC_PHAN_MON_HOC'
// Generated by LLBLGen v1.21.2003.712 Final on: 09 Tháng Bảy 2015, 2:59:06 CH
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAO_TAO_NOI_BOLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the table 'DM_HOC_PHAN_MON_HOC'.
	/// </summary>
	public class DM_HOC_PHAN_MON_HOC : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDecimal		_iD_MON_HOC, _iD_MON_HOCOld, _iD_HOC_PHAN, _iD_HOC_PHANOld, _iD;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DM_HOC_PHAN_MON_HOC()
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
		///		 <LI>ID_HOC_PHAN</LI>
		///		 <LI>ID_MON_HOC</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_HOC_PHAN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_HOC_PHAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_MON_HOC", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_MON_HOC));
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
				throw new Exception("DM_HOC_PHAN_MON_HOC::Insert::Error occured.", ex);
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
		///		 <LI>ID_HOC_PHAN</LI>
		///		 <LI>ID_MON_HOC</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_HOC_PHAN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_HOC_PHAN));
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
				throw new Exception("DM_HOC_PHAN_MON_HOC::Update::Error occured.", ex);
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
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'ID_HOC_PHAN.
		/// This method will Update one or more existing rows in the database. It will reset the field 'ID_HOC_PHAN' in
		/// all rows which have as value for this field the value as set in property 'ID_HOC_PHANOld' to 
		/// the value as set in property 'ID_HOC_PHAN'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_HOC_PHAN</LI>
		///		 <LI>ID_HOC_PHANOld</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWID_HOC_PHANLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_HOC_PHANLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_HOC_PHAN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_HOC_PHAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_HOC_PHANOld", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_HOC_PHANOld));

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
				throw new Exception("DM_HOC_PHAN_MON_HOC::UpdateAllWID_HOC_PHANLogic::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_UpdateAllWID_MON_HOCLogic]";
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
				throw new Exception("DM_HOC_PHAN_MON_HOC::UpdateAllWID_MON_HOCLogic::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_Delete]";
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
				throw new Exception("DM_HOC_PHAN_MON_HOC::Delete::Error occured.", ex);
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
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'ID_HOC_PHAN'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_HOC_PHAN</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWID_HOC_PHANLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_HOC_PHANLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_HOC_PHAN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_HOC_PHAN));

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
				throw new Exception("DM_HOC_PHAN_MON_HOC::DeleteAllWID_HOC_PHANLogic::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_DeleteAllWID_MON_HOCLogic]";
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
				throw new Exception("DM_HOC_PHAN_MON_HOC::DeleteAllWID_MON_HOCLogic::Error occured.", ex);
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
		///		 <LI>ID_HOC_PHAN</LI>
		///		 <LI>ID_MON_HOC</LI>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_SelectOne]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("DM_HOC_PHAN_MON_HOC");
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
					_iD_HOC_PHAN = (Decimal)toReturn.Rows[0]["ID_HOC_PHAN"];
					_iD_MON_HOC = (Decimal)toReturn.Rows[0]["ID_MON_HOC"];
				}
				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("DM_HOC_PHAN_MON_HOC::SelectOne::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_SelectAll]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("DM_HOC_PHAN_MON_HOC");
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
				throw new Exception("DM_HOC_PHAN_MON_HOC::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'ID_HOC_PHAN'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_HOC_PHAN</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWID_HOC_PHANLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_HOC_PHANLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("DM_HOC_PHAN_MON_HOC");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_HOC_PHAN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_HOC_PHAN));

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
				throw new Exception("DM_HOC_PHAN_MON_HOC::SelectAllWID_HOC_PHANLogic::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_DM_HOC_PHAN_MON_HOC_SelectAllWID_MON_HOCLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("DM_HOC_PHAN_MON_HOC");
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
				throw new Exception("DM_HOC_PHAN_MON_HOC::SelectAllWID_MON_HOCLogic::Error occured.", ex);
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


		public SqlDecimal ID_HOC_PHAN
		{
			get
			{
				return _iD_HOC_PHAN;
			}
			set
			{
				SqlDecimal iD_HOC_PHANTmp = (SqlDecimal)value;
				if(iD_HOC_PHANTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_HOC_PHAN", "ID_HOC_PHAN can't be NULL");
				}
				_iD_HOC_PHAN = value;
			}
		}
		public SqlDecimal ID_HOC_PHANOld
		{
			get
			{
				return _iD_HOC_PHANOld;
			}
			set
			{
				SqlDecimal iD_HOC_PHANOldTmp = (SqlDecimal)value;
				if(iD_HOC_PHANOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_HOC_PHANOld", "ID_HOC_PHANOld can't be NULL");
				}
				_iD_HOC_PHANOld = value;
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
		#endregion
	}
}