namespace Vet_To_Go.Forms
{
    partial class FrmEditInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rdbPaidNo = new System.Windows.Forms.RadioButton();
            this.rdbPaidYes = new System.Windows.Forms.RadioButton();
            this.dtpVisit = new System.Windows.Forms.DateTimePicker();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnSaveNotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteNotes = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Details";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rdbPaidNo);
            this.grpBox.Controls.Add(this.rdbPaidYes);
            this.grpBox.Controls.Add(this.dtpVisit);
            this.grpBox.Controls.Add(this.txtInvoiceAmount);
            this.grpBox.Controls.Add(this.txtInvoiceID);
            this.grpBox.Controls.Add(this.dtpInvoice);
            this.grpBox.Controls.Add(this.label6);
            this.grpBox.Controls.Add(this.label5);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.ForeColor = System.Drawing.Color.White;
            this.grpBox.Location = new System.Drawing.Point(29, 57);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(439, 161);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Customer Name";
            // 
            // rdbPaidNo
            // 
            this.rdbPaidNo.AutoSize = true;
            this.rdbPaidNo.Checked = true;
            this.rdbPaidNo.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.rdbPaidNo.Location = new System.Drawing.Point(274, 134);
            this.rdbPaidNo.Name = "rdbPaidNo";
            this.rdbPaidNo.Size = new System.Drawing.Size(43, 21);
            this.rdbPaidNo.TabIndex = 5;
            this.rdbPaidNo.TabStop = true;
            this.rdbPaidNo.Text = "No";
            this.rdbPaidNo.UseVisualStyleBackColor = true;
            // 
            // rdbPaidYes
            // 
            this.rdbPaidYes.AutoSize = true;
            this.rdbPaidYes.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.rdbPaidYes.Location = new System.Drawing.Point(222, 134);
            this.rdbPaidYes.Name = "rdbPaidYes";
            this.rdbPaidYes.Size = new System.Drawing.Size(46, 21);
            this.rdbPaidYes.TabIndex = 4;
            this.rdbPaidYes.Text = "Yes";
            this.rdbPaidYes.UseVisualStyleBackColor = true;
            // 
            // dtpVisit
            // 
            this.dtpVisit.CustomFormat = "\"MM/DD/YYYY\"";
            this.dtpVisit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisit.Location = new System.Drawing.Point(222, 82);
            this.dtpVisit.Name = "dtpVisit";
            this.dtpVisit.Size = new System.Drawing.Size(163, 21);
            this.dtpVisit.TabIndex = 2;
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.txtInvoiceAmount.Location = new System.Drawing.Point(222, 108);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(163, 22);
            this.txtInvoiceAmount.TabIndex = 3;
            this.txtInvoiceAmount.Text = "Invoice Amount";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.AcceptsTab = true;
            this.txtInvoiceID.Enabled = false;
            this.txtInvoiceID.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.txtInvoiceID.Location = new System.Drawing.Point(222, 28);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(163, 22);
            this.txtInvoiceID.TabIndex = 1;
            this.txtInvoiceID.Text = "Invoice Number";
            // 
            // dtpInvoice
            // 
            this.dtpInvoice.CustomFormat = "\"MM/DD/YYYY\"";
            this.dtpInvoice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoice.Location = new System.Drawing.Point(222, 55);
            this.dtpInvoice.Name = "dtpInvoice";
            this.dtpInvoice.Size = new System.Drawing.Size(163, 21);
            this.dtpInvoice.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Invoice ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date of visit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fully paid?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of invoice:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Visit notes:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(29, 262);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(439, 126);
            this.rtbNotes.TabIndex = 7;
            this.rtbNotes.Text = "";
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.btnSaveNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSaveNotes.Location = new System.Drawing.Point(303, 394);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(165, 23);
            this.btnSaveNotes.TabIndex = 8;
            this.btnSaveNotes.Text = "Save note changes";
            this.btnSaveNotes.UseVisualStyleBackColor = true;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.Location = new System.Drawing.Point(176, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteNotes
            // 
            this.btnDeleteNotes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNotes.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteNotes.Location = new System.Drawing.Point(29, 394);
            this.btnDeleteNotes.Name = "btnDeleteNotes";
            this.btnDeleteNotes.Size = new System.Drawing.Size(165, 23);
            this.btnDeleteNotes.TabIndex = 9;
            this.btnDeleteNotes.TabStop = false;
            this.btnDeleteNotes.Text = "Delete all notes";
            this.btnDeleteNotes.UseVisualStyleBackColor = true;
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSaveInvoice.Location = new System.Drawing.Point(303, 224);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(165, 23);
            this.btnSaveInvoice.TabIndex = 6;
            this.btnSaveInvoice.Text = "Save invoice changes";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // FrmEditInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(501, 473);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.btnDeleteNotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View/Edit Invoice";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnSaveNotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteNotes;
        private System.Windows.Forms.RadioButton rdbPaidNo;
        private System.Windows.Forms.RadioButton rdbPaidYes;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.DateTimePicker dtpInvoice;
        private System.Windows.Forms.DateTimePicker dtpVisit;
    }
}