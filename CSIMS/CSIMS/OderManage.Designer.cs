namespace CSIMS
{
    partial class OderManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OderManage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvOder = new System.Windows.Forms.DataGridView();
            this.btnOdrinsert = new System.Windows.Forms.Button();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txbTtl = new System.Windows.Forms.TextBox();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvCstm = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvVioder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PDOder = new System.Drawing.Printing.PrintDocument();
            this.PPDOder = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCstm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVioder)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 766);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.dgvOder);
            this.tabPage2.Controls.Add(this.btnOdrinsert);
            this.tabPage2.Controls.Add(this.dtOd);
            this.tabPage2.Controls.Add(this.txtCName);
            this.tabPage2.Controls.Add(this.txbTtl);
            this.tabPage2.Controls.Add(this.txtOid);
            this.tabPage2.Controls.Add(this.txtCId);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnInsert);
            this.tabPage2.Controls.Add(this.txtqty);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dgvCstm);
            this.tabPage2.Controls.Add(this.dgvItem);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1202, 733);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oder Manage";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvOder
            // 
            this.dgvOder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOder.Location = new System.Drawing.Point(2, 363);
            this.dgvOder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOder.Name = "dgvOder";
            this.dgvOder.RowHeadersWidth = 62;
            this.dgvOder.Size = new System.Drawing.Size(792, 329);
            this.dgvOder.TabIndex = 40;
            this.dgvOder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOder_CellContentClick);
            // 
            // btnOdrinsert
            // 
            this.btnOdrinsert.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOdrinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdrinsert.ForeColor = System.Drawing.Color.OldLace;
            this.btnOdrinsert.Location = new System.Drawing.Point(900, 645);
            this.btnOdrinsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOdrinsert.Name = "btnOdrinsert";
            this.btnOdrinsert.Size = new System.Drawing.Size(196, 48);
            this.btnOdrinsert.TabIndex = 39;
            this.btnOdrinsert.Text = "INSERT";
            this.btnOdrinsert.UseVisualStyleBackColor = false;
            this.btnOdrinsert.Click += new System.EventHandler(this.btnOdrinsert_Click_1);
            // 
            // dtOd
            // 
            this.dtOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOd.Location = new System.Drawing.Point(986, 528);
            this.dtOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(172, 26);
            this.dtOd.TabIndex = 38;
            this.dtOd.Value = new System.DateTime(2021, 10, 13, 0, 0, 0, 0);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(986, 469);
            this.txtCName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(172, 26);
            this.txtCName.TabIndex = 34;
            // 
            // txbTtl
            // 
            this.txbTtl.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTtl.ForeColor = System.Drawing.Color.Blue;
            this.txbTtl.Location = new System.Drawing.Point(900, 586);
            this.txbTtl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTtl.Name = "txbTtl";
            this.txbTtl.Size = new System.Drawing.Size(194, 34);
            this.txbTtl.TabIndex = 35;
            this.txbTtl.Text = "Total Amount";
            // 
            // txtOid
            // 
            this.txtOid.Location = new System.Drawing.Point(986, 357);
            this.txtOid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOid.Name = "txtOid";
            this.txtOid.Size = new System.Drawing.Size(172, 26);
            this.txtOid.TabIndex = 36;
            this.txtOid.TextChanged += new System.EventHandler(this.txtOid_TextChanged);
            // 
            // txtCId
            // 
            this.txtCId.Location = new System.Drawing.Point(986, 414);
            this.txtCId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(172, 26);
            this.txtCId.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(812, 528);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 25);
            this.label17.TabIndex = 31;
            this.label17.Text = "Date of oder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(812, 469);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Customer Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(812, 414);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(812, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Oder ID";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.OldLace;
            this.btnInsert.Location = new System.Drawing.Point(612, 285);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 48);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(520, 294);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(80, 26);
            this.txtqty.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(452, 294);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Qty";
            // 
            // dgvCstm
            // 
            this.dgvCstm.BackgroundColor = System.Drawing.Color.White;
            this.dgvCstm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCstm.Location = new System.Drawing.Point(752, 5);
            this.dgvCstm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCstm.Name = "dgvCstm";
            this.dgvCstm.RowHeadersWidth = 62;
            this.dgvCstm.Size = new System.Drawing.Size(447, 271);
            this.dgvCstm.TabIndex = 14;
            this.dgvCstm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCstm_CellContentClick_1);
            // 
            // dgvItem
            // 
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(0, 5);
            this.dgvItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersWidth = 62;
            this.dgvItem.Size = new System.Drawing.Size(738, 271);
            this.dgvItem.TabIndex = 13;
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvVioder);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1202, 733);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "View Oder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvVioder
            // 
            this.dgvVioder.BackgroundColor = System.Drawing.Color.White;
            this.dgvVioder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVioder.Location = new System.Drawing.Point(105, 65);
            this.dgvVioder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVioder.Name = "dgvVioder";
            this.dgvVioder.RowHeadersWidth = 62;
            this.dgvVioder.Size = new System.Drawing.Size(939, 648);
            this.dgvVioder.TabIndex = 41;
            this.dgvVioder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVioder_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(-8, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 69);
            this.panel2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1134, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.Location = new System.Drawing.Point(1176, 5);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(39, 37);
            this.lblExit.TabIndex = 11;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(216, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(745, 42);
            this.label10.TabIndex = 10;
            this.label10.Text = "PCG INVENTORY MANAGEMENT SYSTEM";
            // 
            // PDOder
            // 
            this.PDOder.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PDOder_PrintPage);
            // 
            // PPDOder
            // 
            this.PPDOder.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPDOder.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPDOder.ClientSize = new System.Drawing.Size(400, 300);
            this.PPDOder.Document = this.PDOder;
            this.PPDOder.Enabled = true;
            this.PPDOder.Icon = ((System.Drawing.Icon)(resources.GetObject("PPDOder.Icon")));
            this.PPDOder.Name = "PPDOder";
            this.PPDOder.Visible = false;
            // 
            // OderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 842);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OderManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OderManage";
            this.Load += new System.EventHandler(this.OderManage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCstm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVioder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridView dgvOder;
        private System.Windows.Forms.Button btnOdrinsert;
        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txbTtl;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvCstm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvVioder;
        private System.Drawing.Printing.PrintDocument PDOder;
        private System.Windows.Forms.PrintPreviewDialog PPDOder;
    }
}