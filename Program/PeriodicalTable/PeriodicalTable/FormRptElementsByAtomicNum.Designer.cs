namespace PeriodicalTable
{
    partial class FormRptElementsByAtomicNum
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
            this.fromAtomic = new System.Windows.Forms.ComboBox();
            this.toAtomic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromAtomic
            // 
            this.fromAtomic.FormattingEnabled = true;
            this.fromAtomic.Location = new System.Drawing.Point(573, 44);
            this.fromAtomic.Name = "fromAtomic";
            this.fromAtomic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromAtomic.Size = new System.Drawing.Size(115, 24);
            this.fromAtomic.TabIndex = 0;
            this.fromAtomic.TextChanged += new System.EventHandler(this.FromAtoomicChanged);
            // 
            // toAtomic
            // 
            this.toAtomic.Enabled = false;
            this.toAtomic.FormattingEnabled = true;
            this.toAtomic.Location = new System.Drawing.Point(397, 44);
            this.toAtomic.Name = "toAtomic";
            this.toAtomic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toAtomic.Size = new System.Drawing.Size(109, 24);
            this.toAtomic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "טווח משקל אטומי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(12, 92);
            this.listView.Name = "listView";
            this.listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(1158, 540);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(307, 31);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(65, 42);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "חיפוש";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtnClick);
            // 
            // FormRptElementsByAtomicNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toAtomic);
            this.Controls.Add(this.fromAtomic);
            this.Name = "FormRptElementsByAtomicNum";
            this.Text = "FormRptElementsByAtomicNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromAtomic;
        private System.Windows.Forms.ComboBox toAtomic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button searchBtn;
    }
}