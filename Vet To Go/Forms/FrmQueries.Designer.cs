namespace Vet_To_Go.Forms
{
    partial class FrmQueries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueries));
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUnpaidInvoices = new System.Windows.Forms.Button();
            this.btnLicense = new System.Windows.Forms.Button();
            this.btnEmailList = new System.Windows.Forms.Button();
            this.btnSpeciesList = new System.Windows.Forms.Button();
            this.btnSterilize = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnVisitsByDate = new System.Windows.Forms.Button();
            this.btnAllCust = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(172, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(86, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Queries";
            // 
            // btnUnpaidInvoices
            // 
            this.btnUnpaidInvoices.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnpaidInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnUnpaidInvoices.Location = new System.Drawing.Point(12, 235);
            this.btnUnpaidInvoices.Name = "btnUnpaidInvoices";
            this.btnUnpaidInvoices.Size = new System.Drawing.Size(165, 23);
            this.btnUnpaidInvoices.TabIndex = 5;
            this.btnUnpaidInvoices.Text = "Unpaid Invoices";
            this.btnUnpaidInvoices.UseVisualStyleBackColor = true;
            this.btnUnpaidInvoices.Click += new System.EventHandler(this.btnUnpaidInvoices_Click);
            // 
            // btnLicense
            // 
            this.btnLicense.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLicense.Location = new System.Drawing.Point(12, 165);
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.Size = new System.Drawing.Size(165, 23);
            this.btnLicense.TabIndex = 3;
            this.btnLicense.Text = "Un-licensed Animals";
            this.btnLicense.UseVisualStyleBackColor = true;
            this.btnLicense.Click += new System.EventHandler(this.btnLicense_Click);
            // 
            // btnEmailList
            // 
            this.btnEmailList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEmailList.Location = new System.Drawing.Point(12, 95);
            this.btnEmailList.Name = "btnEmailList";
            this.btnEmailList.Size = new System.Drawing.Size(165, 23);
            this.btnEmailList.TabIndex = 1;
            this.btnEmailList.Text = "Email List";
            this.btnEmailList.UseVisualStyleBackColor = true;
            this.btnEmailList.Click += new System.EventHandler(this.btnEmailList_Click);
            // 
            // btnSpeciesList
            // 
            this.btnSpeciesList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeciesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSpeciesList.Location = new System.Drawing.Point(258, 95);
            this.btnSpeciesList.Name = "btnSpeciesList";
            this.btnSpeciesList.Size = new System.Drawing.Size(165, 23);
            this.btnSpeciesList.TabIndex = 2;
            this.btnSpeciesList.Text = "Species List";
            this.btnSpeciesList.UseVisualStyleBackColor = true;
            this.btnSpeciesList.Click += new System.EventHandler(this.btnSpeciesList_Click);
            // 
            // btnSterilize
            // 
            this.btnSterilize.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterilize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSterilize.Location = new System.Drawing.Point(258, 165);
            this.btnSterilize.Name = "btnSterilize";
            this.btnSterilize.Size = new System.Drawing.Size(165, 23);
            this.btnSterilize.TabIndex = 4;
            this.btnSterilize.Text = "Un-sterilized Animals";
            this.btnSterilize.UseVisualStyleBackColor = true;
            this.btnSterilize.Click += new System.EventHandler(this.btnSterilize_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnStats.Location = new System.Drawing.Point(12, 305);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(165, 23);
            this.btnStats.TabIndex = 7;
            this.btnStats.Text = "Database Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnVisitsByDate
            // 
            this.btnVisitsByDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitsByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnVisitsByDate.Location = new System.Drawing.Point(258, 235);
            this.btnVisitsByDate.Name = "btnVisitsByDate";
            this.btnVisitsByDate.Size = new System.Drawing.Size(165, 23);
            this.btnVisitsByDate.TabIndex = 6;
            this.btnVisitsByDate.Text = "Visits by Date";
            this.btnVisitsByDate.UseVisualStyleBackColor = true;
            this.btnVisitsByDate.Click += new System.EventHandler(this.btnVisitsByDate_Click);
            // 
            // btnAllCust
            // 
            this.btnAllCust.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAllCust.Location = new System.Drawing.Point(258, 305);
            this.btnAllCust.Name = "btnAllCust";
            this.btnAllCust.Size = new System.Drawing.Size(165, 23);
            this.btnAllCust.TabIndex = 8;
            this.btnAllCust.Text = "All Customers";
            this.btnAllCust.UseVisualStyleBackColor = true;
            this.btnAllCust.Click += new System.EventHandler(this.btnAllCust_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.Location = new System.Drawing.Point(134, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(435, 413);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAllCust);
            this.Controls.Add(this.btnVisitsByDate);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSterilize);
            this.Controls.Add(this.btnSpeciesList);
            this.Controls.Add(this.btnEmailList);
            this.Controls.Add(this.btnLicense);
            this.Controls.Add(this.btnUnpaidInvoices);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnUnpaidInvoices;
        private System.Windows.Forms.Button btnLicense;
        private System.Windows.Forms.Button btnEmailList;
        private System.Windows.Forms.Button btnSpeciesList;
        private System.Windows.Forms.Button btnSterilize;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnVisitsByDate;
        private System.Windows.Forms.Button btnAllCust;
        private System.Windows.Forms.Button btnExit;
    }
}