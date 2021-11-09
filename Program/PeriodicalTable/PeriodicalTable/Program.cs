using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace PeriodicalTable
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OleDbConnection dataConnection = OpenDb();
            Application.Run(new FormLogin(dataConnection));
        }
        private static OleDbConnection OpenDb()
        {
            OleDbConnection dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2022\\Project_DvirBerlowitz\\Access\\dbPeriodicalTable.accdb";
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database: " + e.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataConnection;
        }
    }
}
