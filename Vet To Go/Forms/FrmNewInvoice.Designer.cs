namespace Vet_To_Go.Forms
{
    partial class FrmNewInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewInvoice));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbPaidNo = new System.Windows.Forms.RadioButton();
            this.rdbPaidYes = new System.Windows.Forms.RadioButton();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cldInvoice = new System.Windows.Forms.MonthCalendar();
            this.cldVisit = new System.Windows.Forms.MonthCalendar();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblVisitDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.Location = new System.Drawing.Point(18, 518);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit without saving";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSaveInvoice.Location = new System.Drawing.Point(355, 518);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(165, 23);
            this.btnSaveInvoice.TabIndex = 8;
            this.btnSaveInvoice.Text = "Save new invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(18, 386);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(502, 126);
            this.rtbNotes.TabIndex = 6;
            this.rtbNotes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(15, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Visit notes:";
            // 
            // rdbPaidNo
            // 
            this.rdbPaidNo.AutoSize = true;
            this.rdbPaidNo.Checked = true;
            this.rdbPaidNo.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.rdbPaidNo.Location = new System.Drawing.Point(55, 0);
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
            this.rdbPaidYes.Location = new System.Drawing.Point(3, 0);
            this.rdbPaidYes.Name = "rdbPaidYes";
            this.rdbPaidYes.Size = new System.Drawing.Size(46, 21);
            this.rdbPaidYes.TabIndex = 4;
            this.rdbPaidYes.Text = "Yes";
            this.rdbPaidYes.UseVisualStyleBackColor = true;
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.txtInvoiceAmount.Location = new System.Drawing.Point(18, 312);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(227, 22);
            this.txtInvoiceAmount.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(290, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date of visit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(290, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fully paid?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(15, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Invoice amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of invoice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "New Invoice";
            // 
            // cldInvoice
            // 
            this.cldInvoice.Location = new System.Drawing.Point(18, 107);
            this.cldInvoice.Name = "cldInvoice";
            this.cldInvoice.TabIndex = 1;
            this.cldInvoice.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldInvoice_DateChanged);
            // 
            // cldVisit
            // 
            this.cldVisit.Location = new System.Drawing.Point(293, 107);
            this.cldVisit.Name = "cldVisit";
            this.cldVisit.TabIndex = 2;
            this.cldVisit.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldVisit_DateChanged);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblInvoiceDate.Location = new System.Drawing.Point(133, 81);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(62, 17);
            this.lblInvoiceDate.TabIndex = 19;
            this.lblInvoiceDate.Text = "1/1/2000";
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.AutoSize = true;
            this.lblVisitDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblVisitDate.Location = new System.Drawing.Point(385, 81);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(62, 17);
            this.lblVisitDate.TabIndex = 20;
            this.lblVisitDate.Text = "1/1/2000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbPaidYes);
            this.panel1.Controls.Add(this.rdbPaidNo);
            this.panel1.Location = new System.Drawing.Point(293, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 21);
            this.panel1.TabIndex = 21;
            // 
            // FrmNewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(538, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVisitDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.cldVisit);
            this.Controls.Add(this.cldInvoice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.txtInvoiceAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Invoice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbPaidNo;
        private System.Windows.Forms.RadioButton rdbPaidYes;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar cldInvoice;
        private System.Windows.Forms.MonthCalendar cldVisit;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.Panel panel1;
    }
}