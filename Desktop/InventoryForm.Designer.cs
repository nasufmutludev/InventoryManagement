namespace Desktop
{
    partial class InventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.dtRelease = new System.Windows.Forms.DateTimePicker();
            this.dtEntry = new System.Windows.Forms.DateTimePicker();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtQantity = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnInvantoryAdd = new System.Windows.Forms.Button();
            this.txtInventoryName = new System.Windows.Forms.TextBox();
            this.lblEnvanterAdi = new System.Windows.Forms.Label();
            this.dgwInventoryList = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.dgwCompanyList = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventoryList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanyList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbCompany);
            this.tabPage1.Controls.Add(this.dtRelease);
            this.tabPage1.Controls.Add(this.dtEntry);
            this.tabPage1.Controls.Add(this.lblRelease);
            this.tabPage1.Controls.Add(this.lblEntry);
            this.tabPage1.Controls.Add(this.lblCompany);
            this.tabPage1.Controls.Add(this.txtQantity);
            this.tabPage1.Controls.Add(this.lblAdet);
            this.tabPage1.Controls.Add(this.btnInvantoryAdd);
            this.tabPage1.Controls.Add(this.txtInventoryName);
            this.tabPage1.Controls.Add(this.lblEnvanterAdi);
            this.tabPage1.Controls.Add(this.dgwInventoryList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Envanter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(92, 35);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(100, 23);
            this.cbCompany.TabIndex = 13;
            // 
            // dtRelease
            // 
            this.dtRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRelease.Location = new System.Drawing.Point(92, 122);
            this.dtRelease.Name = "dtRelease";
            this.dtRelease.Size = new System.Drawing.Size(100, 23);
            this.dtRelease.TabIndex = 12;
            this.dtRelease.Value = new System.DateTime(2022, 10, 29, 14, 20, 30, 0);
            // 
            // dtEntry
            // 
            this.dtEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntry.Location = new System.Drawing.Point(92, 93);
            this.dtEntry.Name = "dtEntry";
            this.dtEntry.Size = new System.Drawing.Size(100, 23);
            this.dtEntry.TabIndex = 11;
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(6, 128);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(69, 15);
            this.lblRelease.TabIndex = 10;
            this.lblRelease.Text = "Çıkış Tarihi :";
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(6, 99);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(67, 15);
            this.lblEntry.TabIndex = 8;
            this.lblEntry.Text = "Giriş Tarihi :";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(6, 38);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(43, 15);
            this.lblCompany.TabIndex = 6;
            this.lblCompany.Text = "Firma :";
            // 
            // txtQantity
            // 
            this.txtQantity.Location = new System.Drawing.Point(92, 64);
            this.txtQantity.Name = "txtQantity";
            this.txtQantity.Size = new System.Drawing.Size(100, 23);
            this.txtQantity.TabIndex = 5;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(6, 67);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(38, 15);
            this.lblAdet.TabIndex = 4;
            this.lblAdet.Text = "Adet :";
            // 
            // btnInvantoryAdd
            // 
            this.btnInvantoryAdd.Location = new System.Drawing.Point(117, 151);
            this.btnInvantoryAdd.Name = "btnInvantoryAdd";
            this.btnInvantoryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnInvantoryAdd.TabIndex = 3;
            this.btnInvantoryAdd.Text = "Kaydet";
            this.btnInvantoryAdd.UseVisualStyleBackColor = true;
            this.btnInvantoryAdd.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtInventoryName
            // 
            this.txtInventoryName.Location = new System.Drawing.Point(92, 6);
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.Size = new System.Drawing.Size(100, 23);
            this.txtInventoryName.TabIndex = 2;
            // 
            // lblEnvanterAdi
            // 
            this.lblEnvanterAdi.AutoSize = true;
            this.lblEnvanterAdi.Location = new System.Drawing.Point(6, 9);
            this.lblEnvanterAdi.Name = "lblEnvanterAdi";
            this.lblEnvanterAdi.Size = new System.Drawing.Size(80, 15);
            this.lblEnvanterAdi.TabIndex = 1;
            this.lblEnvanterAdi.Text = "Envanter Adı :";
            // 
            // dgwInventoryList
            // 
            this.dgwInventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInventoryList.Location = new System.Drawing.Point(214, 6);
            this.dgwInventoryList.Name = "dgwInventoryList";
            this.dgwInventoryList.RowTemplate.Height = 25;
            this.dgwInventoryList.Size = new System.Drawing.Size(570, 408);
            this.dgwInventoryList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCompanyAdd);
            this.tabPage2.Controls.Add(this.txtCompanyName);
            this.tabPage2.Controls.Add(this.lblFirmaAdi);
            this.tabPage2.Controls.Add(this.dgwCompanyList);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Firma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Location = new System.Drawing.Point(118, 36);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCompanyAdd.TabIndex = 9;
            this.btnCompanyAdd.Text = "Kaydet";
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(93, 7);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 23);
            this.txtCompanyName.TabIndex = 8;
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(7, 10);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(64, 15);
            this.lblFirmaAdi.TabIndex = 7;
            this.lblFirmaAdi.Text = "Firma Adı :";
            // 
            // dgwCompanyList
            // 
            this.dgwCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompanyList.Location = new System.Drawing.Point(215, 7);
            this.dgwCompanyList.Name = "dgwCompanyList";
            this.dgwCompanyList.RowTemplate.Height = 25;
            this.dgwCompanyList.Size = new System.Drawing.Size(570, 408);
            this.dgwCompanyList.TabIndex = 6;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "InventoryForm";
            this.Text = "EnvanterForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventoryList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnInvantoryAdd;
        private TextBox txtInventoryName;
        private Label lblEnvanterAdi;
        private DataGridView dgwInventoryList;
        private TabPage tabPage2;
        private TextBox txtQantity;
        private Label lblAdet;
        private Button btnCompanyAdd;
        private TextBox txtCompanyName;
        private Label lblFirmaAdi;
        private DataGridView dgwCompanyList;
        private DateTimePicker dtRelease;
        private DateTimePicker dtEntry;
        private Label lblRelease;
        private Label lblEntry;
        private Label lblCompany;
        private ComboBox cbCompany;
    }
}