using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PeriodicalTable.backend
{
    public class DBManager
    {
        // TODO: make private
        public OleDbConnection dataConnection;
        public DBManager(String connectionString)
        {
            dataConnection = new OleDbConnection();
            try
            {
                // dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2022\\Project_DvirBerlowitz\\Access\\dbPeriodicalTable.accdb";
                dataConnection.ConnectionString = connectionString;
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database:\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Object[] GetOneRow(String table, String cols, String cmd) {
            Object[] data = new Object[cols.Split(',').Length];
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT " +  cols + " FROM "+table+" " + cmd;
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                dataReader.GetValues(data);
                dataReader.Close();
            }
            catch
            {
                return null;
            }
            return data;
        }

        public Object[] GetUserOverview(String id)
        {
            return GetOneRow("tblUsers", "userID, userPassword, userIsManager, userFirstName, userLastName, userPicture", "WHERE userID=" + id);
        }
        public List<String> ListForCombo(String table, String col)
        {
            List<String> data = new List<String>();
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT " + col + " FROM " + table;
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read()) data.Add(dataReader.GetString(0));
                dataReader.Close();
            }
            catch
            {
                return null;
            }
            return data;
        }
        public bool Insert(String table, String cols, Object[] values)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = "INSERT INTO "+ table +" " + "(" + cols + ") " + " VALUES (";
                for(int i = 0; i < values.Length; i++)
                {
                    Object val = values[i];
                    if (val is String || val is DateTime) str += "'";
                    str += val.ToString();
                    if (val is String || val is DateTime) str += "'";
                    if (i != values.Length - 1) str += ",";
                }
                str += ")";
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                return true;
            }
            catch {}
            return false;
        }
        public DataTable GetDataTable(String table)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT * FROM " + table;
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                return data;
            }
            catch {}
            return null;
        }
        public bool Update(String table, String cols, Object[] values)
        {
            try
            {
                String[] colsArr = cols.Split(',');
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = "UPDATE " + table + " SET ";
                for (int i = 1; i < values.Length; i++)
                {
                    str += colsArr[i] + " = ";
                    Object val = values[i];
                    if (val is String || val is DateTime) str += "'";
                    str += val.ToString();
                    if (val is String || val is DateTime) str += "'";
                    if (i != values.Length - 1) str += ",";
                }
                str += " WHERE " + colsArr[0] + " = ";
                if (values[0] is String) str += "'";
                str += values[0];
                if (values[0] is String) str += "'";
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                ;
            }
            return false;
        }
    }
}
