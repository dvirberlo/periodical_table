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
    public partial class FormUpdateElements : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateElements(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillGroupCombo();
            RefreshDataGridView();
        }

        private void FormUpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);
        }


        private void FillGroupCombo()                   // fill cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   * " +
                                          "FROM     tblGroups ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboGroup.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill groups combobox failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)          //Update students table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblElements  \n" +
                                          "SET     elemID           =   " + id.Text              + "  ," +
                                                  "elemFullName     =  '" + fullName.Text        + "' ," +
                                                  "elemEnName       =  '" + enName.Text          + "' ," +
                                                  "elemHeName       =  '" + heName.Text          + "' ," +
                                                  "elemRow          =   " + row.Text             + "  ," +
                                                  "elemColumn       =   " + col.Text             + "  ," +
                                                  "elemGroup        =  '" + comboGroup.Text      + "' ," +
                                                  "elemAtomicWeight =   " + atomicWeight.Text    + "  ," +
                                                  "elemEnergyLevels =  '" + energyLevels.Text    + "' ," +
                                                  "elemPicture      =  '" + pictureLocation.Text + "'  " +
                                          "\n WHERE  elemSymbol     =  '" + symbol.Text + "';";
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblElements ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblElements failed \n" + err.Message, "Error",
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
                                     "FROM     tblElements ";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblElements table failed \n" + err.Message, "Error",
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
                symbol.Text          = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                id.Text              = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                fullName.Text        = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                enName.Text          = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                heName.Text          = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                row.Text             = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                col.Text             = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                comboGroup.Text      = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                atomicWeight.Text    = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                energyLevels.Text    = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                pictureLocation.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                pictureBox1.ImageLocation = pictureLocation.Text;
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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            pictureLocation.Text = pictureFileName;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.symbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.elemSymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemEnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemHeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemColumnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemAtomicWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemEnergyLevelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblElementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetElements = new PeriodicalTable.DataSetElements();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.heName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.col = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.atomicWeight = new System.Windows.Forms.TextBox();
            this.energyLevels = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tblElementsTableAdapter = new PeriodicalTable.DataSetElementsTableAdapters.tblElementsTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(974, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "סימן";
            // 
            // symbol
            // 
            this.symbol.Enabled = false;
            this.symbol.Location = new System.Drawing.Point(868, 96);
            this.symbol.Name = "symbol";
            this.symbol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.symbol.Size = new System.Drawing.Size(100, 22);
            this.symbol.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "מספר סידורי";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(646, 98);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "שם מלא";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(428, 98);
            this.fullName.Name = "fullName";
            this.fullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fullName.Size = new System.Drawing.Size(100, 22);
            this.fullName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "משקל אטומי";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(974, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "שם אנגלי";
            // 
            // enName
            // 
            this.enName.Location = new System.Drawing.Point(823, 148);
            this.enName.Name = "enName";
            this.enName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enName.Size = new System.Drawing.Size(145, 22);
            this.enName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "קבוצה";
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(625, 146);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboGroup.Size = new System.Drawing.Size(121, 24);
            this.comboGroup.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(572, 317);
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
            this.label7.Location = new System.Drawing.Point(630, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "עדכון פרטי יסוד";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elemSymbolDataGridViewTextBoxColumn,
            this.elemIDDataGridViewTextBoxColumn,
            this.elemFullNameDataGridViewTextBoxColumn,
            this.elemEnNameDataGridViewTextBoxColumn,
            this.elemHeNameDataGridViewTextBoxColumn,
            this.elemRowDataGridViewTextBoxColumn,
            this.elemColumnDataGridViewTextBoxColumn,
            this.elemGroupDataGridViewTextBoxColumn,
            this.elemAtomicWeightDataGridViewTextBoxColumn,
            this.elemEnergyLevelsDataGridViewTextBoxColumn,
            this.elemPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblElementsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 359);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // elemSymbolDataGridViewTextBoxColumn
            // 
            this.elemSymbolDataGridViewTextBoxColumn.DataPropertyName = "elemSymbol";
            this.elemSymbolDataGridViewTextBoxColumn.HeaderText = "סמל";
            this.elemSymbolDataGridViewTextBoxColumn.Name = "elemSymbolDataGridViewTextBoxColumn";
            // 
            // elemIDDataGridViewTextBoxColumn
            // 
            this.elemIDDataGridViewTextBoxColumn.DataPropertyName = "elemID";
            this.elemIDDataGridViewTextBoxColumn.HeaderText = "מספר זהות";
            this.elemIDDataGridViewTextBoxColumn.Name = "elemIDDataGridViewTextBoxColumn";
            // 
            // elemFullNameDataGridViewTextBoxColumn
            // 
            this.elemFullNameDataGridViewTextBoxColumn.DataPropertyName = "elemFullName";
            this.elemFullNameDataGridViewTextBoxColumn.HeaderText = "שם מלא";
            this.elemFullNameDataGridViewTextBoxColumn.Name = "elemFullNameDataGridViewTextBoxColumn";
            // 
            // elemEnNameDataGridViewTextBoxColumn
            // 
            this.elemEnNameDataGridViewTextBoxColumn.DataPropertyName = "elemEnName";
            this.elemEnNameDataGridViewTextBoxColumn.HeaderText = "שם אנגלי";
            this.elemEnNameDataGridViewTextBoxColumn.Name = "elemEnNameDataGridViewTextBoxColumn";
            // 
            // elemHeNameDataGridViewTextBoxColumn
            // 
            this.elemHeNameDataGridViewTextBoxColumn.DataPropertyName = "elemHeName";
            this.elemHeNameDataGridViewTextBoxColumn.HeaderText = "שם עברי";
            this.elemHeNameDataGridViewTextBoxColumn.Name = "elemHeNameDataGridViewTextBoxColumn";
            // 
            // elemRowDataGridViewTextBoxColumn
            // 
            this.elemRowDataGridViewTextBoxColumn.DataPropertyName = "elemRow";
            this.elemRowDataGridViewTextBoxColumn.HeaderText = "שורה";
            this.elemRowDataGridViewTextBoxColumn.Name = "elemRowDataGridViewTextBoxColumn";
            // 
            // elemColumnDataGridViewTextBoxColumn
            // 
            this.elemColumnDataGridViewTextBoxColumn.DataPropertyName = "elemColumn";
            this.elemColumnDataGridViewTextBoxColumn.HeaderText = "טור";
            this.elemColumnDataGridViewTextBoxColumn.Name = "elemColumnDataGridViewTextBoxColumn";
            // 
            // elemGroupDataGridViewTextBoxColumn
            // 
            this.elemGroupDataGridViewTextBoxColumn.DataPropertyName = "elemGroup";
            this.elemGroupDataGridViewTextBoxColumn.HeaderText = "קבוצה";
            this.elemGroupDataGridViewTextBoxColumn.Name = "elemGroupDataGridViewTextBoxColumn";
            // 
            // elemAtomicWeightDataGridViewTextBoxColumn
            // 
            this.elemAtomicWeightDataGridViewTextBoxColumn.DataPropertyName = "elemAtomicWeight";
            this.elemAtomicWeightDataGridViewTextBoxColumn.HeaderText = "משקל אטומי";
            this.elemAtomicWeightDataGridViewTextBoxColumn.Name = "elemAtomicWeightDataGridViewTextBoxColumn";
            // 
            // elemEnergyLevelsDataGridViewTextBoxColumn
            // 
            this.elemEnergyLevelsDataGridViewTextBoxColumn.DataPropertyName = "elemEnergyLevels";
            this.elemEnergyLevelsDataGridViewTextBoxColumn.HeaderText = "רמות אנרגייה";
            this.elemEnergyLevelsDataGridViewTextBoxColumn.Name = "elemEnergyLevelsDataGridViewTextBoxColumn";
            // 
            // elemPictureDataGridViewTextBoxColumn
            // 
            this.elemPictureDataGridViewTextBoxColumn.DataPropertyName = "elemPicture";
            this.elemPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.elemPictureDataGridViewTextBoxColumn.Name = "elemPictureDataGridViewTextBoxColumn";
            // 
            // tblElementsBindingSource
            // 
            this.tblElementsBindingSource.DataMember = "tblElements";
            this.tblElementsBindingSource.DataSource = this.dataSetElements;
            // 
            // dataSetElements
            // 
            this.dataSetElements.DataSetName = "DataSetElements";
            this.dataSetElements.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(408, 249);
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
            this.buttonNext.Location = new System.Drawing.Point(636, 249);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(83, 41);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(515, 249);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(81, 41);
            this.buttonLast.TabIndex = 18;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(733, 249);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 41);
            this.buttonFirst.TabIndex = 19;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "שם עברי";
            // 
            // heName
            // 
            this.heName.Location = new System.Drawing.Point(428, 148);
            this.heName.Name = "heName";
            this.heName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.heName.Size = new System.Drawing.Size(100, 22);
            this.heName.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "שורה";
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(254, 148);
            this.row.Name = "row";
            this.row.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row.Size = new System.Drawing.Size(100, 22);
            this.row.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1044, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(974, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "תמונה";
            // 
            // pictureLocation
            // 
            this.pictureLocation.Location = new System.Drawing.Point(610, 199);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(349, 22);
            this.pictureLocation.TabIndex = 27;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(520, 198);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 28;
            this.buttonBrowse.Text = " . . . עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(375, 195);
            this.col.Name = "col";
            this.col.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.col.Size = new System.Drawing.Size(101, 22);
            this.col.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "טור";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "רמות אנרגיה";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // atomicWeight
            // 
            this.atomicWeight.Location = new System.Drawing.Point(177, 90);
            this.atomicWeight.Name = "atomicWeight";
            this.atomicWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.atomicWeight.Size = new System.Drawing.Size(123, 22);
            this.atomicWeight.TabIndex = 33;
            // 
            // energyLevels
            // 
            this.energyLevels.Location = new System.Drawing.Point(124, 199);
            this.energyLevels.Name = "energyLevels";
            this.energyLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.energyLevels.Size = new System.Drawing.Size(117, 22);
            this.energyLevels.TabIndex = 34;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tblElementsTableAdapter
            // 
            this.tblElementsTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(764, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "יסודות";
            // 
            // FormUpdateElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.energyLevels);
            this.Controls.Add(this.atomicWeight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.col);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.row);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.heName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateElements";
            this.Text = "FormUpdateElements";
            this.Load += new System.EventHandler(this.FormUpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


    }
}
