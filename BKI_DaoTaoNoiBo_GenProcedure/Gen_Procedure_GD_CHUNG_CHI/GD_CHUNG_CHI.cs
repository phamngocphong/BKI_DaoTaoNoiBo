///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'GD_CHUNG_CHI'
// Generated by LLBLGen v1.21.2003.712 Final on: 09 Tháng Bảy 2015, 3:01:41 CH
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAO_TAO_NOI_BOLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the table 'GD_CHUNG_CHI'.
	/// </summary>
	public class GD_CHUNG_CHI : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		_nGAY_LAP, _nGAY_BAT_DAU, _nGAY_KET_THUC, _nGAY_SUA;
			private SqlDecimal		_iD, _iD_GD_DIEM, _iD_GD_DIEMOld, _iD_NHAN_SU, _iD_NHAN_SUOld;
			private SqlString		_nGUOI_SUA, _dA_XOA, _sO_CHUNG_CHI, _nGUOI_LAP;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GD_CHUNG_CHI()
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
		///		 <LI>ID</LI>
		///		 <LI>ID_NHAN_SU. May be SqlDecimal.Null</LI>
		///		 <LI>ID_GD_DIEM</LI>
		///		 <LI>SO_CHUNG_CHI</LI>
		///		 <LI>NGAY_BAT_DAU</LI>
		///		 <LI>NGAY_KET_THUC</LI>
		///		 <LI>NGAY_LAP</LI>
		///		 <LI>NGAY_SUA</LI>
		///		 <LI>NGUOI_LAP</LI>
		///		 <LI>NGUOI_SUA</LI>
		///		 <LI>DA_XOA</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_SU", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_SU));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_GD_DIEM", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_GD_DIEM));
				cmdToExecute.Parameters.Add(new SqlParameter("@SO_CHUNG_CHI", SqlDbType.NVarChar, 35, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _sO_CHUNG_CHI));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_BAT_DAU", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_BAT_DAU));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_KET_THUC", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_KET_THUC));
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
				throw new Exception("GD_CHUNG_CHI::Insert::Error occured.", ex);
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
		///		 <LI>ID_NHAN_SU. May be SqlDecimal.Null</LI>
		///		 <LI>ID_GD_DIEM</LI>
		///		 <LI>SO_CHUNG_CHI</LI>
		///		 <LI>NGAY_BAT_DAU</LI>
		///		 <LI>NGAY_KET_THUC</LI>
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
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_SU", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_SU));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_GD_DIEM", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_GD_DIEM));
				cmdToExecute.Parameters.Add(new SqlParameter("@SO_CHUNG_CHI", SqlDbType.NVarChar, 35, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _sO_CHUNG_CHI));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_BAT_DAU", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_BAT_DAU));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_KET_THUC", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_KET_THUC));
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
				throw new Exception("GD_CHUNG_CHI::Update::Error occured.", ex);
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
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'ID_NHAN_SU.
		/// This method will Update one or more existing rows in the database. It will reset the field 'ID_NHAN_SU' in
		/// all rows which have as value for this field the value as set in property 'ID_NHAN_SUOld' to 
		/// the value as set in property 'ID_NHAN_SU'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_NHAN_SU. May be SqlDecimal.Null</LI>
		///		 <LI>ID_NHAN_SUOld. May be SqlDecimal.Null</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWID_NHAN_SULogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_UpdateAllWID_NHAN_SULogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_SU", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_SU));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_SUOld", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_SUOld));

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
				throw new Exception("GD_CHUNG_CHI::UpdateAllWID_NHAN_SULogic::Error occured.", ex);
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
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'ID_GD_DIEM.
		/// This method will Update one or more existing rows in the database. It will reset the field 'ID_GD_DIEM' in
		/// all rows which have as value for this field the value as set in property 'ID_GD_DIEMOld' to 
		/// the value as set in property 'ID_GD_DIEM'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_GD_DIEM</LI>
		///		 <LI>ID_GD_DIEMOld</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWID_GD_DIEMLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_UpdateAllWID_GD_DIEMLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_GD_DIEM", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_GD_DIEM));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_GD_DIEMOld", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_GD_DIEMOld));

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
				throw new Exception("GD_CHUNG_CHI::UpdateAllWID_GD_DIEMLogic::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_Delete]";
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
				throw new Exception("GD_CHUNG_CHI::Delete::Error occured.", ex);
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
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'ID_NHAN_SU'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_NHAN_SU. May be SqlDecimal.Null</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWID_NHAN_SULogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_DeleteAllWID_NHAN_SULogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_SU", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_SU));

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
				throw new Exception("GD_CHUNG_CHI::DeleteAllWID_NHAN_SULogic::Error occured.", ex);
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
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'ID_GD_DIEM'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_GD_DIEM</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWID_GD_DIEMLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_DeleteAllWID_GD_DIEMLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_GD_DIEM", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_GD_DIEM));

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
				throw new Exception("GD_CHUNG_CHI::DeleteAllWID_GD_DIEMLogic::Error occured.", ex);
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
		///		 <LI>ID_NHAN_SU</LI>
		///		 <LI>ID_GD_DIEM</LI>
		///		 <LI>SO_CHUNG_CHI</LI>
		///		 <LI>NGAY_BAT_DAU</LI>
		///		 <LI>NGAY_KET_THUC</LI>
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
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_SelectOne]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_CHUNG_CHI");
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
					_iD_NHAN_SU = toReturn.Rows[0]["ID_NHAN_SU"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)toReturn.Rows[0]["ID_NHAN_SU"];
					_iD_GD_DIEM = (Decimal)toReturn.Rows[0]["ID_GD_DIEM"];
					_sO_CHUNG_CHI = (string)toReturn.Rows[0]["SO_CHUNG_CHI"];
					_nGAY_BAT_DAU = (DateTime)toReturn.Rows[0]["NGAY_BAT_DAU"];
					_nGAY_KET_THUC = (DateTime)toReturn.Rows[0]["NGAY_KET_THUC"];
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
				throw new Exception("GD_CHUNG_CHI::SelectOne::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_SelectAll]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_CHUNG_CHI");
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
				throw new Exception("GD_CHUNG_CHI::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'ID_NHAN_SU'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_NHAN_SU. May be SqlDecimal.Null</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWID_NHAN_SULogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_SelectAllWID_NHAN_SULogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_CHUNG_CHI");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NHAN_SU", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NHAN_SU));

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
				throw new Exception("GD_CHUNG_CHI::SelectAllWID_NHAN_SULogic::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'ID_GD_DIEM'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_GD_DIEM</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWID_GD_DIEMLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_GD_CHUNG_CHI_SelectAllWID_GD_DIEMLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("GD_CHUNG_CHI");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_GD_DIEM", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_GD_DIEM));

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
				throw new Exception("GD_CHUNG_CHI::SelectAllWID_GD_DIEMLogic::Error occured.", ex);
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


		public SqlDecimal ID_NHAN_SU
		{
			get
			{
				return _iD_NHAN_SU;
			}
			set
			{
				SqlDecimal iD_NHAN_SUTmp = (SqlDecimal)value;
				if(iD_NHAN_SUTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_NHAN_SU", "ID_NHAN_SU can't be NULL");
				}
				_iD_NHAN_SU = value;
			}
		}
		public SqlDecimal ID_NHAN_SUOld
		{
			get
			{
				return _iD_NHAN_SUOld;
			}
			set
			{
				SqlDecimal iD_NHAN_SUOldTmp = (SqlDecimal)value;
				if(iD_NHAN_SUOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_NHAN_SUOld", "ID_NHAN_SUOld can't be NULL");
				}
				_iD_NHAN_SUOld = value;
			}
		}


		public SqlDecimal ID_GD_DIEM
		{
			get
			{
				return _iD_GD_DIEM;
			}
			set
			{
				SqlDecimal iD_GD_DIEMTmp = (SqlDecimal)value;
				if(iD_GD_DIEMTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_GD_DIEM", "ID_GD_DIEM can't be NULL");
				}
				_iD_GD_DIEM = value;
			}
		}
		public SqlDecimal ID_GD_DIEMOld
		{
			get
			{
				return _iD_GD_DIEMOld;
			}
			set
			{
				SqlDecimal iD_GD_DIEMOldTmp = (SqlDecimal)value;
				if(iD_GD_DIEMOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_GD_DIEMOld", "ID_GD_DIEMOld can't be NULL");
				}
				_iD_GD_DIEMOld = value;
			}
		}


		public SqlString SO_CHUNG_CHI
		{
			get
			{
				return _sO_CHUNG_CHI;
			}
			set
			{
				SqlString sO_CHUNG_CHITmp = (SqlString)value;
				if(sO_CHUNG_CHITmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("SO_CHUNG_CHI", "SO_CHUNG_CHI can't be NULL");
				}
				_sO_CHUNG_CHI = value;
			}
		}


		public SqlDateTime NGAY_BAT_DAU
		{
			get
			{
				return _nGAY_BAT_DAU;
			}
			set
			{
				SqlDateTime nGAY_BAT_DAUTmp = (SqlDateTime)value;
				if(nGAY_BAT_DAUTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGAY_BAT_DAU", "NGAY_BAT_DAU can't be NULL");
				}
				_nGAY_BAT_DAU = value;
			}
		}


		public SqlDateTime NGAY_KET_THUC
		{
			get
			{
				return _nGAY_KET_THUC;
			}
			set
			{
				SqlDateTime nGAY_KET_THUCTmp = (SqlDateTime)value;
				if(nGAY_KET_THUCTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGAY_KET_THUC", "NGAY_KET_THUC can't be NULL");
				}
				_nGAY_KET_THUC = value;
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
