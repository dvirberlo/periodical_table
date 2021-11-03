namespace PeriodicalTable
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesInElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addElementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPropertiesInElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateElementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.udateGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicalTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByAtomicNumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elemntsByAtomicNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByPropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByAtomicWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByAtomicNumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByGroupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByPropertyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsByCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.periodicalTableToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.chartsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citiesToolStripMenuItem,
            this.elementsToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.propertiesInElementToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.tableToolStripMenuItem.Text = "&Tables";
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.citiesToolStripMenuItem.Text = "Cities";
            this.citiesToolStripMenuItem.Click += new System.EventHandler(this.CitiesClick);
            // 
            // elementsToolStripMenuItem
            // 
            this.elementsToolStripMenuItem.Name = "elementsToolStripMenuItem";
            this.elementsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.elementsToolStripMenuItem.Text = "Elements";
            this.elementsToolStripMenuItem.Click += new System.EventHandler(this.ElementsClick);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.GroupsClick);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesClick);
            // 
            // propertiesInElementToolStripMenuItem
            // 
            this.propertiesInElementToolStripMenuItem.Name = "propertiesInElementToolStripMenuItem";
            this.propertiesInElementToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.propertiesInElementToolStripMenuItem.Text = "PropertiesInElement";
            this.propertiesInElementToolStripMenuItem.Click += new System.EventHandler(this.PropertiesInElementClick);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UsersClick);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.categoriesToolStripMenuItem.Text = "C&ategories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.TblCategoriesClick);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addCitiesToolStripMenuItem,
            this.addElementsToolStripMenuItem,
            this.addGroupToolStripMenuItem,
            this.addPropertiesToolStripMenuItem,
            this.addPropertiesInElementToolStripMenuItem,
            this.addCategoriesToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.addToolStripMenuItem.Text = "&Add ";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addUserToolStripMenuItem.Text = "Add &User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.AddUsersClick);
            // 
            // addCitiesToolStripMenuItem
            // 
            this.addCitiesToolStripMenuItem.Name = "addCitiesToolStripMenuItem";
            this.addCitiesToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addCitiesToolStripMenuItem.Text = "Add &Cities";
            this.addCitiesToolStripMenuItem.Click += new System.EventHandler(this.AddCitiesClick);
            // 
            // addElementsToolStripMenuItem
            // 
            this.addElementsToolStripMenuItem.Name = "addElementsToolStripMenuItem";
            this.addElementsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addElementsToolStripMenuItem.Text = "Add &Elements";
            this.addElementsToolStripMenuItem.Click += new System.EventHandler(this.AddElementsClick);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addGroupToolStripMenuItem.Text = "Add &Groups";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.AddGroupsClick);
            // 
            // addPropertiesToolStripMenuItem
            // 
            this.addPropertiesToolStripMenuItem.Name = "addPropertiesToolStripMenuItem";
            this.addPropertiesToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addPropertiesToolStripMenuItem.Text = "Add &Properties";
            this.addPropertiesToolStripMenuItem.Click += new System.EventHandler(this.AddPropertiesClick);
            // 
            // addPropertiesInElementToolStripMenuItem
            // 
            this.addPropertiesInElementToolStripMenuItem.Name = "addPropertiesInElementToolStripMenuItem";
            this.addPropertiesInElementToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addPropertiesInElementToolStripMenuItem.Text = "Add Properties In Element";
            this.addPropertiesInElementToolStripMenuItem.Click += new System.EventHandler(this.AddPropertiesInElementClick);
            // 
            // addCategoriesToolStripMenuItem
            // 
            this.addCategoriesToolStripMenuItem.Name = "addCategoriesToolStripMenuItem";
            this.addCategoriesToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addCategoriesToolStripMenuItem.Text = "Add C&ategories";
            this.addCategoriesToolStripMenuItem.Click += new System.EventHandler(this.AddCategoriesClick);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUsersToolStripMenuItem,
            this.updateElementsToolStripMenuItem,
            this.udateGroupsToolStripMenuItem,
            this.updatePropertiesToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.updateToolStripMenuItem.Text = "&Update";
            // 
            // updateUsersToolStripMenuItem
            // 
            this.updateUsersToolStripMenuItem.Name = "updateUsersToolStripMenuItem";
            this.updateUsersToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.updateUsersToolStripMenuItem.Text = "Update &Users";
            this.updateUsersToolStripMenuItem.Click += new System.EventHandler(this.UpdateUsersClick);
            // 
            // updateElementsToolStripMenuItem
            // 
            this.updateElementsToolStripMenuItem.Name = "updateElementsToolStripMenuItem";
            this.updateElementsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.updateElementsToolStripMenuItem.Text = "Update &Elements";
            this.updateElementsToolStripMenuItem.Click += new System.EventHandler(this.UpdateElementsClick);
            // 
            // udateGroupsToolStripMenuItem
            // 
            this.udateGroupsToolStripMenuItem.Name = "udateGroupsToolStripMenuItem";
            this.udateGroupsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.udateGroupsToolStripMenuItem.Text = "Udate &Groups";
            this.udateGroupsToolStripMenuItem.Click += new System.EventHandler(this.UpdateGroupsClick);
            // 
            // updatePropertiesToolStripMenuItem
            // 
            this.updatePropertiesToolStripMenuItem.Name = "updatePropertiesToolStripMenuItem";
            this.updatePropertiesToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.updatePropertiesToolStripMenuItem.Text = "Update &Properties";
            this.updatePropertiesToolStripMenuItem.Click += new System.EventHandler(this.UpdatePropertiesClick);
            // 
            // periodicalTableToolStripMenuItem
            // 
            this.periodicalTableToolStripMenuItem.Name = "periodicalTableToolStripMenuItem";
            this.periodicalTableToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.periodicalTableToolStripMenuItem.Text = "&Periodical Table";
            this.periodicalTableToolStripMenuItem.Click += new System.EventHandler(this.PeriodicalTableClick);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementsByAtomicNumToolStripMenuItem,
            this.elemntsByAtomicNumberToolStripMenuItem,
            this.elementsByGroupToolStripMenuItem,
            this.elementsByPropertyToolStripMenuItem,
            this.elementsByCategoryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // elementsByAtomicNumToolStripMenuItem
            // 
            this.elementsByAtomicNumToolStripMenuItem.Name = "elementsByAtomicNumToolStripMenuItem";
            this.elementsByAtomicNumToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.elementsByAtomicNumToolStripMenuItem.Text = "Elements By Atomic &Weight";
            this.elementsByAtomicNumToolStripMenuItem.Click += new System.EventHandler(this.RptElementsByAtomicWeight);
            // 
            // elemntsByAtomicNumberToolStripMenuItem
            // 
            this.elemntsByAtomicNumberToolStripMenuItem.Name = "elemntsByAtomicNumberToolStripMenuItem";
            this.elemntsByAtomicNumberToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.elemntsByAtomicNumberToolStripMenuItem.Text = "Elemnts By Atomic &Number";
            this.elemntsByAtomicNumberToolStripMenuItem.Click += new System.EventHandler(this.RptElementsByAtomicNum);
            // 
            // elementsByGroupToolStripMenuItem
            // 
            this.elementsByGroupToolStripMenuItem.Name = "elementsByGroupToolStripMenuItem";
            this.elementsByGroupToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.elementsByGroupToolStripMenuItem.Text = "Elements By &Group";
            this.elementsByGroupToolStripMenuItem.Click += new System.EventHandler(this.RptElementsByGroup);
            // 
            // elementsByPropertyToolStripMenuItem
            // 
            this.elementsByPropertyToolStripMenuItem.Name = "elementsByPropertyToolStripMenuItem";
            this.elementsByPropertyToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.elementsByPropertyToolStripMenuItem.Text = "Elements By &Property";
            this.elementsByPropertyToolStripMenuItem.Click += new System.EventHandler(this.RptElementsByProperty);
            // 
            // elementsByCategoryToolStripMenuItem
            // 
            this.elementsByCategoryToolStripMenuItem.Name = "elementsByCategoryToolStripMenuItem";
            this.elementsByCategoryToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.elementsByCategoryToolStripMenuItem.Text = "Elements By &Category";
            this.elementsByCategoryToolStripMenuItem.Click += new System.EventHandler(this.RptElementsByCategory);
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementsByAtomicWeightToolStripMenuItem,
            this.elementsByAtomicNumToolStripMenuItem1,
            this.elementsByGroupToolStripMenuItem1,
            this.elementsByPropertyToolStripMenuItem1,
            this.elementsByCategoryToolStripMenuItem1});
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            this.chartsToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.chartsToolStripMenuItem.Text = "&Charts";
            // 
            // elementsByAtomicWeightToolStripMenuItem
            // 
            this.elementsByAtomicWeightToolStripMenuItem.Name = "elementsByAtomicWeightToolStripMenuItem";
            this.elementsByAtomicWeightToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.elementsByAtomicWeightToolStripMenuItem.Text = "Elements By Atomic &Weight";
            this.elementsByAtomicWeightToolStripMenuItem.Click += new System.EventHandler(this.ChartElementsByAtomicWeight);
            // 
            // elementsByAtomicNumToolStripMenuItem1
            // 
            this.elementsByAtomicNumToolStripMenuItem1.Name = "elementsByAtomicNumToolStripMenuItem1";
            this.elementsByAtomicNumToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.elementsByAtomicNumToolStripMenuItem1.Text = "Elements By Atomic &Num";
            this.elementsByAtomicNumToolStripMenuItem1.Click += new System.EventHandler(this.ChartElementsByAtomicNum);
            // 
            // elementsByGroupToolStripMenuItem1
            // 
            this.elementsByGroupToolStripMenuItem1.Name = "elementsByGroupToolStripMenuItem1";
            this.elementsByGroupToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.elementsByGroupToolStripMenuItem1.Text = "Elements By &Group";
            this.elementsByGroupToolStripMenuItem1.Click += new System.EventHandler(this.ChartElementsByGroup);
            // 
            // elementsByPropertyToolStripMenuItem1
            // 
            this.elementsByPropertyToolStripMenuItem1.Name = "elementsByPropertyToolStripMenuItem1";
            this.elementsByPropertyToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.elementsByPropertyToolStripMenuItem1.Text = "Elements By &Property";
            this.elementsByPropertyToolStripMenuItem1.Click += new System.EventHandler(this.ChartElementsByProperty);
            // 
            // elementsByCategoryToolStripMenuItem1
            // 
            this.elementsByCategoryToolStripMenuItem1.Name = "elementsByCategoryToolStripMenuItem1";
            this.elementsByCategoryToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.elementsByCategoryToolStripMenuItem1.Text = "Elements By &Category";
            this.elementsByCategoryToolStripMenuItem1.Click += new System.EventHandler(this.ChartElementsByCategory);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesInElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addElementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPropertiesInElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateElementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem udateGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicalTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsByAtomicNumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elemntsByAtomicNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsByGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsByPropertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsByCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsByAtomicWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsByAtomicNumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementsByGroupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementsByPropertyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementsByCategoryToolStripMenuItem1;
    }
}