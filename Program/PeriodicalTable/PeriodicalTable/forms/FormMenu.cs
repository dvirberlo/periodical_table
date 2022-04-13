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
using PeriodicalTable.backend;

namespace PeriodicalTable
{
    public partial class FormMenu : Form
    {
        private DBManager db;
        public OleDbConnection dataConnection;
        private bool isManager;
        public FormMenu(DBManager db, bool isManager)
        {
            this.db = db;
            this.dataConnection = db.dataConnection;
            this.isManager = isManager;
            InitializeComponent();

            if (!isManager)
            {
                mainMenu.Items[0].Enabled = false;
                mainMenu.Items[1].Enabled = false;
                mainMenu.Items[2].Enabled = false;
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
            ShowFormAndHide(new FormAddUser(db));
        }

        private void AddCitiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddCities(db));
        }

        private void AddElementsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddElements(db));
        }

        private void AddGroupsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddGroups(db));
        }

        private void AddPropertiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddProperties(db));
        }

        private void AddPropertiesInElementClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddPropertiesInElement(db));
        }
        private void AddCategoriesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormAddCategories(db));
        }

        //update

        private void UpdateUsersClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateUsers(db));
        }

        private void UpdateElementsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateElements(db));
        }

        private void UpdateGroupsClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateGroups(db));
        }

        private void UpdatePropertiesClick(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormUpdateProperties(db));
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

        // reports
        private void RptElementsByAtomicWeight(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormRptElementsByAtomicWeight(dataConnection));
        }

        private void RptElementsByAtomicNum(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormRptElementsByAtomicNum(dataConnection));
        }

        private void RptElementsByGroup(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormRptElementsByGroup(dataConnection));
        }

        private void RptElementsByProperty(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormRptElementsByProperty(dataConnection));
        }

        private void RptElementsByCategory(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormRptElementsByCategory(dataConnection));
        }

        // charts
        private void ChartElementsByAtomicWeight(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormChartElementsByAtomicWeight(dataConnection));
        }

        private void ChartElementsByAtomicNum(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormChartElementsByAtomicNum(dataConnection));
        }

        private void ChartElementsByGroup(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormChartElementsByGroup(dataConnection));
        }

        private void ChartElementsByProperty(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormChartElementsByProperty(dataConnection));
        }

        private void ChartElementsByCategory(object sender, EventArgs e)
        {
            ShowFormAndHide(new FormChartElementsByCategory(dataConnection));
        }


    }
}
