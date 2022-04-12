using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeriodicalTable.backend;

namespace PeriodicalTable
{
    public partial class FormLogin : Form
    {
        private DBManager db;
        private bool isManager;
        public FormLogin(DBManager db)
        {
            this.db = db;
            InitializeComponent();
            this.contBtn.Visible = false;
            this.welcomeLbl.Text = "";
            this.pictureBox1.ImageLocation = "";
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            Object[] data = db.GetUserOverview(this.idNumber.Text);
            if (data == null)
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(data[0].ToString());
            String password = data[1].ToString();
            this.isManager = data[2].ToString() == "True";
            String msg = "ברוך הבא " + data[3].ToString() + " " + data[4].ToString();
            String pic = data[5].ToString();
            
            if (password != this.password.Text)
            {
                MessageBox.Show("Incorrect password:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox1.ImageLocation = pic;
            this.welcomeLbl.Text = msg;
            this.contBtn.Visible = true;
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
            FormMenu frMenu = new FormMenu(db, isManager);
            frMenu.Show();
            frMenu.Disposed += new EventHandler(frMenu_Disposed);
        }

    }
}
