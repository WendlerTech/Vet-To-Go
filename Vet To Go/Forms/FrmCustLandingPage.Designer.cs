namespace Vet_To_Go.Forms
{
    partial class FrmCustLandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustLandingPage));
            this.lblNameHeader = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.grpPhoneNum = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCell = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnViewAnimals = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnEditCustInfo = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnSearchAgain = new System.Windows.Forms.Button();
            this.grpAddress.SuspendLayout();
            this.grpPhoneNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameHeader
            // 
            this.lblNameHeader.AutoSize = true;
            this.lblNameHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameHeader.Location = new System.Drawing.Point(33, 38);
            this.lblNameHeader.Name = "lblNameHeader";
            this.lblNameHeader.Size = new System.Drawing.Size(181, 24);
            this.lblNameHeader.TabIndex = 0;
            this.lblNameHeader.Text = "Customer Name";
            // 
            // grpAddress
            // 
            this.grpAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAddress.Controls.Add(this.lblZipCode);
            this.grpAddress.Controls.Add(this.lblState);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.lblAddress2);
            this.grpAddress.Controls.Add(this.lblAddress1);
            this.grpAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpAddress.Location = new System.Drawing.Point(33, 251);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(405, 140);
            this.grpAddress.TabIndex = 1;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // lblZipCode
            // 
            this.lblZipCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(18, 107);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(60, 17);
            this.lblZipCode.TabIndex = 4;
            this.lblZipCode.Text = "Zipcode";
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(18, 87);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(18, 67);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 17);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblAddress2
            // 
            this.lblAddress2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(18, 47);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(68, 17);
            this.lblAddress2.TabIndex = 1;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(18, 27);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(68, 17);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "Address 1";
            // 
            // grpPhoneNum
            // 
            this.grpPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPhoneNum.Controls.Add(this.lblEmail);
            this.grpPhoneNum.Controls.Add(this.lblCellPhone);
            this.grpPhoneNum.Controls.Add(this.lblHomePhone);
            this.grpPhoneNum.Controls.Add(this.labelEmail);
            this.grpPhoneNum.Controls.Add(this.labelCell);
            this.grpPhoneNum.Controls.Add(this.labelHome);
            this.grpPhoneNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhoneNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpPhoneNum.Location = new System.Drawing.Point(33, 104);
            this.grpPhoneNum.Name = "grpPhoneNum";
            this.grpPhoneNum.Size = new System.Drawing.Size(405, 116);
            this.grpPhoneNum.TabIndex = 2;
            this.grpPhoneNum.TabStop = false;
            this.grpPhoneNum.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(120, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Not provided";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.Location = new System.Drawing.Point(120, 55);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(95, 17);
            this.lblCellPhone.TabIndex = 4;
            this.lblCellPhone.Text = "Not provided";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePhone.Location = new System.Drawing.Point(120, 30);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(95, 17);
            this.lblHomePhone.TabIndex = 3;
            this.lblHomePhone.Text = "Not provided";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(18, 80);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 17);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCell.Location = new System.Drawing.Point(18, 55);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(82, 17);
            this.labelCell.TabIndex = 1;
            this.labelCell.Text = "Cell Phone:";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(18, 30);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(96, 17);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home Phone:";
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNewInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnNewInvoice.Location = new System.Drawing.Point(468, 357);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(176, 34);
            this.btnNewInvoice.TabIndex = 12;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // btnViewAnimals
            // 
            this.btnViewAnimals.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnViewAnimals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewAnimals.Location = new System.Drawing.Point(468, 186);
            this.btnViewAnimals.Name = "btnViewAnimals";
            this.btnViewAnimals.Size = new System.Drawing.Size(176, 34);
            this.btnViewAnimals.TabIndex = 10;
            this.btnViewAnimals.Text = "View Animals";
            this.btnViewAnimals.UseVisualStyleBackColor = true;
            this.btnViewAnimals.Click += new System.EventHandler(this.btnViewAnimals_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnNotes.Location = new System.Drawing.Point(468, 111);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(176, 34);
            this.btnNotes.TabIndex = 9;
            this.btnNotes.Text = "Customer Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnEditCustInfo
            // 
            this.btnEditCustInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditCustInfo.Location = new System.Drawing.Point(37, 65);
            this.btnEditCustInfo.Name = "btnEditCustInfo";
            this.btnEditCustInfo.Size = new System.Drawing.Size(176, 23);
            this.btnEditCustInfo.TabIndex = 8;
            this.btnEditCustInfo.Text = "Edit Customer Information";
            this.btnEditCustInfo.UseVisualStyleBackColor = true;
            this.btnEditCustInfo.Click += new System.EventHandler(this.btnEditCustInfo_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnInvoices.Location = new System.Drawing.Point(468, 282);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(176, 34);
            this.btnInvoices.TabIndex = 11;
            this.btnInvoices.Text = "Invoice Manager";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnSearchAgain
            // 
            this.btnSearchAgain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchAgain.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSearchAgain.Location = new System.Drawing.Point(12, 469);
            this.btnSearchAgain.Name = "btnSearchAgain";
            this.btnSearchAgain.Size = new System.Drawing.Size(176, 23);
            this.btnSearchAgain.TabIndex = 13;
            this.btnSearchAgain.Text = "Back to customer lookup";
            this.btnSearchAgain.UseVisualStyleBackColor = true;
            this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
            // 
            // FrmCustLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.btnSearchAgain;
            this.ClientSize = new System.Drawing.Size(668, 504);
            this.Controls.Add(this.btnSearchAgain);
            this.Controls.Add(this.btnEditCustInfo);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnViewAnimals);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.grpPhoneNum);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.lblNameHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustLandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Landing Page";
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpPhoneNum.ResumeLayout(false);
            this.grpPhoneNum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameHeader;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox grpPhoneNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnViewAnimals;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnEditCustInfo;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnSearchAgain;
    }
}