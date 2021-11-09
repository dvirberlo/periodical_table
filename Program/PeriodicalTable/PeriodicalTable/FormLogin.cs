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
        private bool isManager;
        public FormLogin(OleDbConnection dataConnection)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            this.contBtn.Visible = false;
            this.welcomeLbl.Text = "";
            this.pictureBox1.ImageLocation = "";
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            String line, password;
            int id;
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT userID, userPassword, userIsManager, userFirstName, userLastName, userPicture FROM tblUsers WHERE userID=" + this.idNumber.Text;
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                password = dataReader.GetString(1);
                this.isManager = dataReader.GetBoolean(2);
                String msg = "ברוך הבא " + dataReader.GetString(3) + " " + dataReader.GetString(4);
                String pic = dataReader.GetValue(5).ToString();

                if (password == this.password.Text)
                {
                    pictureBox1.ImageLocation = pic;
                    this.welcomeLbl.Text = msg;
                    this.contBtn.Visible = true;
                }
                else
                {
                    line = "Invalid Password: " + this.password.Text;
                    MessageBox.Show(line, "Error");
                }
                dataReader.Close();
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

        private void continueClick(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu frMenu = new FormMenu(dataConnection, isManager);
            frMenu.Show();
            frMenu.Disposed += new EventHandler(frMenu_Disposed);
        }

    }
}
