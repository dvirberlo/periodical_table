using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using PeriodicalTable.backend;
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

            DBManager db = new DBManager("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2022\\Project_DvirBerlowitz\\Access\\dbPeriodicalTable.accdb");
            Application.Run(new FormLogin(db));
        }
    }
}
