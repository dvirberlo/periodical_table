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
        private bool isManager;
        public FormMenu(OleDbConnection dataConnection, bool isManager)
        {
            this.dataConnection = dataConnection;
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
