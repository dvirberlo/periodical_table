using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PeriodicalTable
{
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        public FormLogin()
        {
            InitializeComponent();
            OpenDb();
        }

        private void OpenDb()
        {
            dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2022\\Project_DvirBerlowitz\\Access\\dbPeriodicalTable.accdb";
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database: " + e.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            String line, password;
            int id;
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT userID, userPassword FROM tblUsers WHERE userID="+this.idNumber.Text;
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                password = dataReader.GetString(1);

                if (password == this.password.Text)
                {
                    this.Hide();
                    // FormMenu frMenu = new FormMenu(dataConnection);
                    FormMenu frMenu = new FormMenu();
                    frMenu.Show();
                    frMenu.Disposed += new EventHandler(frMenu_Disposed);
                }
                else
                {
                    line = "Invalid Password: " + this.password.Text;
                    MessageBox.Show(line, "Error");
                }
            }
            catch (Exception err)
            {
                line = "Invalid Id: " + this.idNumber.Text + err.Message;
                MessageBox.Show(line, "Error");
            }
        }
        void frMenu_Disposed(object sender, EventArgs e)
        {
            this.idNumber.Text = "";
            this.password.Text = "";
            this.Show();
            this.Activate();
        }
    }
}
