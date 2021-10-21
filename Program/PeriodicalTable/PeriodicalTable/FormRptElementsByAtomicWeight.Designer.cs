namespace PeriodicalTable
{
    partial class FormRptElementsByAtomicWeight
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
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.colorBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromAtomic
            // 
            this.fromAtomic.FormattingEnabled = true;
            this.fromAtomic.Location = new System.Drawing.Point(854, 88);
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
            this.toAtomic.Location = new System.Drawing.Point(715, 88);
            this.toAtomic.Name = "toAtomic";
            this.toAtomic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toAtomic.Size = new System.Drawing.Size(109, 24);
            this.toAtomic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(989, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "טווח משקל אטומי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(830, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(12, 143);
            this.listView.Name = "listView";
            this.listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView.RightToLeftLayout = true;
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(1158, 489);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Location = new System.Drawing.Point(632, 78);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(65, 42);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "הוסף";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.SearchBtnClick);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 91);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(76, 44);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "נקה";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(114, 91);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(75, 44);
            this.colorBtn.TabIndex = 7;
            this.colorBtn.Text = "שינוי צבע";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "דוח יסודות לפי משקל אטומי";
            // 
            // FormRptElementsByAtomicWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toAtomic);
            this.Controls.Add(this.fromAtomic);
            this.Name = "FormRptElementsByAtomicWeight";
            this.Text = "FormRptElementsByAtomicWeight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromAtomic;
        private System.Windows.Forms.ComboBox toAtomic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Label label3;
    }
}