using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicalTable
{
    public partial class FormPeriodicalTable : Form
    {
        private OleDbConnection dataConnection;
        private Dictionary<int, object[]> elements;
        private Dictionary<string, Color> groups;

        private int groupCount = 0;
        private int elemCount = 0;
        private int rows = 0;
        private int cols = 0;

        private Button[] btnTable;
        private Button[] groupTable;
        private Label[] lblArr;

        public FormPeriodicalTable(OleDbConnection dataConnection)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            LoadPeriodicalTable();
            this.Shown += CreateButtonsTable;
            this.ResizeEnd += Refresh;
            this.Resize += ResizeChecker;
        }
        private void LoadPeriodicalTable()
        {
            try
            {
                // read groups colors
                groups = new Dictionary<string, Color>();
                OleDbCommand groupCommand = new OleDbCommand();
                groupCommand.Connection = dataConnection;
                String groupSelects = "groupName,groupColor";
                groupCommand.CommandText = "SELECT " + groupSelects + " FROM tblGroups";
                OleDbDataReader groupReader = groupCommand.ExecuteReader();
                int groupCounter = 0;
                while (groupReader.Read())
                {
                    object[] groupObj = new object[groupSelects.Split(',').Length];
                    int len = groupReader.GetValues(groupObj);
                    String name = groupReader.GetString(0);
                    String colorS = groupReader.GetString(1);
                    Color color = System.Drawing.ColorTranslator.FromHtml(colorS);
                    groups.Add(name, color);
                    groupCounter++;
                }
                groupReader.Close();
                this.groupCount = groupCounter;

                // read element tbl
                elements = new Dictionary<int, object[]>();
                OleDbCommand elemCommand = new OleDbCommand();
                elemCommand.Connection = dataConnection;
                String elemSelects = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
                elemCommand.CommandText = "SELECT " + elemSelects + " FROM tblElements";
                OleDbDataReader elemReader = elemCommand.ExecuteReader();
                int elemCounter = 0;
                int maxRow = -1, maxCol = -1;
                while (elemReader.Read())
                {
                    object[] elemObj = new object[elemSelects.Split(',').Length];
                    int len = elemReader.GetValues(elemObj);
                    int id = Convert.ToInt32(elemObj[0]);
                    elements.Add(id, elemObj);

                    int row = Convert.ToInt32(elemObj[1]);
                    int col = Convert.ToInt32(elemObj[2]);
                    maxCol = Math.Max(col, maxCol);
                    maxRow = Math.Max(row, maxRow);
                    elemCounter++;
                }
                elemReader.Close();
                this.elemCount = elemCounter;
                this.rows = maxRow;
                this.cols = maxCol;
            }
            catch (Exception err)
            {
                MessageBox.Show("@OleDb load error: \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CreateButtonsTable(Object sender, EventArgs e)
        {
            int cols = 18, rows = 10;
            btnTable = new Button[elemCount];
            lblArr = new Label[cols + rows];
            groupTable = new Button[groupCount];

            int startX, startY;
            if (this.Width / cols >= this.Height / rows)
            {
                startX = ((this.Width / cols - this.Height / rows) * cols) / 2;
                startY = 15;
            }
            else
            {
                startX = 15;
                startY = ((this.Height / rows - this.Width / cols) * rows) / 2;
            }
            int width = this.Width - 2 * startX, height = this.Height - 2 * startY;
            int marginX = (width / cols) / 5, marginY = (height / rows) / 5;
            int btnSizeX = marginX * 4, btnSizeY = marginY * 4;

            // rows and cols
            int lblIndex = 0;
            for (int row = 1; row <= rows; row++, lblIndex++)
            {
                int x = startX + ((0) * (btnSizeX + marginX)) - 15;
                int y = startY + ((row - 1) * (btnSizeY + marginY));
                String rowS = row.ToString();
                if (row >= 9) rowS = (row - 3).ToString();
                lblArr[lblIndex] = CreateLabel(x, y, btnSizeX, btnSizeY, rowS, ContentAlignment.MiddleLeft);
            }
            for (int col = 1; col <= cols; col++, lblIndex++)
            {
                int x = startX + ((col - 1) * (btnSizeX + marginX));
                int y = startY + ((0) * (btnSizeY + marginY)) - 15;
                lblArr[lblIndex] = CreateLabel(x, y, btnSizeX, btnSizeY, col.ToString(), ContentAlignment.TopCenter);
            }
            // elements
            foreach (KeyValuePair<int, object[]> elem in elements)
            {
                object[] elemObj = elem.Value;
                int id = Convert.ToInt32(elemObj[0]);
                int row = Convert.ToInt32(elemObj[1]);
                int col = Convert.ToInt32(elemObj[2]);
                String symbol = elemObj[3].ToString();
                String group = elemObj[4].ToString();
                String fullName = elemObj[5].ToString();
                String enName = elemObj[6].ToString();
                String heName = elemObj[7].ToString();
                int atomicWeight = Convert.ToInt32(elemObj[8]);
                String energyLevels = elemObj[9].ToString();

                Color color = groups[group];
                int x = startX + ((col - 1) * (btnSizeX + marginX));
                int y = startY + ((row - 1) * (btnSizeY + marginY));
                String name = "btn_" + row.ToString() + "_" + col.ToString();
                btnTable[id - 1] = CreateElemButton(x, y, btnSizeX, btnSizeY, name, symbol, color, id, fullName, enName, heName, group, atomicWeight, energyLevels, symbol);
            }
            // group-color dict
            int groupRows = 2;
            int groupColS = 4;
            int groupCounter = 0;
            int groupCols = cols - groupColS -1 - (groups.Count / groupRows);
            foreach (KeyValuePair<String, Color> group in groups)
            {
                String name = group.Key;
                Color color = group.Value;
                int col = groupColS + (groupCounter % groupCols);
                int row = 1 + (groupCounter /  groupCols);
                int x = startX + ((col - 1) * (btnSizeX + marginX));
                int y = startY + ((row - 1) * (btnSizeY + marginY));
                int stretchX = 1;
                if(group.Value == groups.Values.Last()){
                    stretchX = groupCols - (groupCounter % groupCols);
                }
                groupTable[groupCounter] = CreateButton(x, y, (btnSizeX + marginX) * stretchX + 5, btnSizeY + marginY + 5, name, name, color);
                groupCounter++;
            }

        }

        private Button CreateButton(int x, int y, int width, int height, String name, String text, Color color)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.BackColor = color;
            btn.FlatAppearance.BorderColor = Color.FromName("Black");
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatStyle = FlatStyle.Flat;

            btn.Name = name;
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Size = new Size(width, height);
            btn.BringToFront();
            return btn;
        }
        private Button CreateElemButton(int x, int y, int width, int height, String name, String text, Color color, int elemID, String fullName, String enName, String heName, String group, int atomicWeight, String energyLevels, String symbol)
        {
            Button btn = CreateButton(x, y, width, height, name, text, color);
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 10;
            tt.OwnerDraw = true;
            tt.Draw += toolTip_Draw;
            String ttText = "סמל: " + symbol + "\nמספר זהות: " + elemID.ToString() + "\nשם מלא: " + fullName + "\nשם אנגלי: " + enName + "\nשם עברי: " + heName + "\nקבוצה: " + group + "\nמשקל אטומי: " + atomicWeight.ToString() + "\nרמות אנרגייה: " + energyLevels;
            tt.SetToolTip(btn, ttText);
            return btn;
        }
        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.FillRectangle(SystemBrushes.Info, e.Bounds);
            e.DrawBorder();
            e.DrawText(TextFormatFlags.RightToLeft | TextFormatFlags.Right);
        }
        private Label CreateLabel(int x, int y, int width, int height, String text, ContentAlignment ca)
        {
            Label lbl = new Label();
            this.Controls.Add(lbl);
            lbl.AutoSize = false;
            lbl.TextAlign = ca;
            lbl.Text = text;
            lbl.Size = new Size(width, height);
            lbl.Location = new Point(x, y);
            lbl.SendToBack();
            return lbl;
        }

        private void DeleteButtonsTable(object sender, EventArgs e)
        {
            for (int i = 0; i < btnTable.Length; i++)
            {
                btnTable[i].Dispose();
            }
            for (int i = 0; i < groupTable.Length; i++)
            {
                groupTable[i].Dispose();
            }
            for (int i = 0; i < lblArr.Length; i++)
            {
                lblArr[i].Dispose();
            }
        }
        private void Refresh(object sender, EventArgs e)
        {
            DeleteButtonsTable(sender, e);
            CreateButtonsTable(sender, e);
        }
        private void ResizeChecker(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Minimized)
            {
                Refresh(sender, e);
            }
        }
    }
}
