using System;
using System.Collections.Generic;
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
            catch (Exception e)
            {
                return null;
            }
            return data;
        }

        public Object[] GetUserOverview(String id)
        {
            return GetOneRow("tblUsers", "userID, userPassword, userIsManager, userFirstName, userLastName, userPicture", "WHERE userID=" + id);
        }
    }
}
