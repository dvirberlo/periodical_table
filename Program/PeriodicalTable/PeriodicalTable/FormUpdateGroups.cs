using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PeriodicalTable
{
    public partial class FormUpdateGroups : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateGroups(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
        }

        private void FormUpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGroups.tblGroups' table. You can move, or remove it, as needed.
            this.tblGroupsTableAdapter.Fill(this.dataSetGroups.tblGroups);
            // TODO: This line of code loads data into the 'dataSetGroups.tblGroups' table. You can move, or remove it, as needed.
            this.tblGroupsTableAdapter.Fill(this.dataSetGroups.tblGroups);
        }


        

        private void buttonUpdate_Click(object sender, EventArgs e)          //Update students table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblGroups  \n" +
                                          "SET  groupColor    =  '" + groupColor.Text  + "' " +
                                          "\n WHERE  groupName = '" + userID.Text + "' ;";
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblGroups ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblGroups failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void RefreshDataGridView() 
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblGroups ";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblGroups table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void FillSelectedRow()
        {
            try
            {
                userID.Text          = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                groupColor.Text       = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();

        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupColor = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGroups = new PeriodicalTable.DataSetGroups();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.tblGroupsTableAdapter = new PeriodicalTable.DataSetGroupsTableAdapters.tblGroupsTableAdapter();
            this.pickColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(899, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם קבוצה";
            // 
            // userID
            // 
            this.userID.Enabled = false;
            this.userID.Location = new System.Drawing.Point(793, 99);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 22);
            this.userID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "צבע קבוצה";
            // 
            // groupColor
            // 
            this.groupColor.Location = new System.Drawing.Point(549, 101);
            this.groupColor.Name = "groupColor";
            this.groupColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupColor.Size = new System.Drawing.Size(122, 22);
            this.groupColor.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(686, 295);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(110, 52);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "ע ד כ ן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(612, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "עדכון פרטי קבוצה";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNameDataGridViewTextBoxColumn,
            this.groupColorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGroupsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 359);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "groupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "שם";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            // 
            // groupColorDataGridViewTextBoxColumn
            // 
            this.groupColorDataGridViewTextBoxColumn.DataPropertyName = "groupColor";
            this.groupColorDataGridViewTextBoxColumn.HeaderText = "צבע";
            this.groupColorDataGridViewTextBoxColumn.Name = "groupColorDataGridViewTextBoxColumn";
            // 
            // tblGroupsBindingSource
            // 
            this.tblGroupsBindingSource.DataMember = "tblGroups";
            this.tblGroupsBindingSource.DataSource = this.dataSetGroups;
            // 
            // dataSetGroups
            // 
            this.dataSetGroups.DataSetName = "DataSetGroups";
            this.dataSetGroups.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(522, 227);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(83, 41);
            this.buttonPrev.TabIndex = 16;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(750, 227);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(83, 41);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(629, 227);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(81, 41);
            this.buttonLast.TabIndex = 18;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(847, 227);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 41);
            this.buttonFirst.TabIndex = 19;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // tblGroupsTableAdapter
            // 
            this.tblGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // pickColor
            // 
            this.pickColor.Location = new System.Drawing.Point(449, 102);
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(75, 23);
            this.pickColor.TabIndex = 20;
            this.pickColor.Text = "בחר צבע";
            this.pickColor.UseVisualStyleBackColor = true;
            this.pickColor.Click += new System.EventHandler(this.PickColorClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "קבוצות";
            // 
            // FormUpdateGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickColor);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateGroups";
            this.Text = "FormUpdateGroups";
            this.Load += new System.EventHandler(this.FormUpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PickColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            groupColor.Text = "#"+(cd.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
        }


    }
}
