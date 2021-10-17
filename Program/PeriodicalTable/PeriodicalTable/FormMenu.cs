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
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        public FormMenu()
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

        // tables
        private void CitiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormTblCities());
        }

        private void ElementsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormTblElements());
        }

        private void GroupsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormTblGroups());
        }

        private void PropertiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormTblProperties());
        }

        private void PropertiesInElementClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormTblPropertiesInElement());
        }

        private void UsersClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormTblUsers());
        }
        private void TblCategoriesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormTblCategories());
        }

        // add
        private void AddUsersClick(object sender, EventArgs e)
        {
            // FormAddUsers form = new FormAddUsers();
            ShowFormAndHide(new FormAddUser(dataConnection));
        }

        private void AddCitiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddCities(dataConnection));
        }

        private void AddElementsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddElements(dataConnection));
        }

        private void AddGroupsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddGroups(dataConnection));
        }

        private void AddPropertiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddProperties(dataConnection));
        }

        private void AddPropertiesInElementClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddPropertiesInElement(dataConnection));
        }
        private void AddCategoriesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddCategories(dataConnection));
        }

        //update

        private void UpdateUsersClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateUsers(dataConnection));
        }

        private void UpdateElementsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateElements(dataConnection));
        }

        private void UpdateGroupsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateGroups(dataConnection));
        }

        private void UpdatePropertiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateProperties(dataConnection));
        }

        public void ShowFormAndHide(Form form)
        {
            this.Hide();
            form.Show();
            form.Disposed += new EventHandler(formCloseCallback);
        }
        void formCloseCallback(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void PeriodicalTableClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormPeriodicalTable(dataConnection));
        }



    }
}
