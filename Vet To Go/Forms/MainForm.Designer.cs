namespace Vet_To_Go
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.grpCustSearch = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.btnQueries = new System.Windows.Forms.Button();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.btnDatabaseStats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCustSearch.SuspendLayout();
            this.grpTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(295, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vet To Go";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(133, 40);
            this.txtFirstName.MaxLength = 40;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(133, 80);
            this.txtLastName.MaxLength = 40;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(6, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(6, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNum.Location = new System.Drawing.Point(6, 120);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(118, 20);
            this.lblPhoneNum.TabIndex = 6;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(133, 120);
            this.txtPhoneNum.Mask = "(999) 000-0000";
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(197, 26);
            this.txtPhoneNum.TabIndex = 7;
            this.txtPhoneNum.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // grpCustSearch
            // 
            this.grpCustSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCustSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpCustSearch.Controls.Add(this.clearBtn);
            this.grpCustSearch.Controls.Add(this.btnSearch);
            this.grpCustSearch.Controls.Add(this.lblFirstName);
            this.grpCustSearch.Controls.Add(this.txtPhoneNum);
            this.grpCustSearch.Controls.Add(this.txtFirstName);
            this.grpCustSearch.Controls.Add(this.lblPhoneNum);
            this.grpCustSearch.Controls.Add(this.txtLastName);
            this.grpCustSearch.Controls.Add(this.lblLastName);
            this.grpCustSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.grpCustSearch.Location = new System.Drawing.Point(12, 83);
            this.grpCustSearch.Name = "grpCustSearch";
            this.grpCustSearch.Size = new System.Drawing.Size(336, 193);
            this.grpCustSearch.TabIndex = 8;
            this.grpCustSearch.TabStop = false;
            this.grpCustSearch.Text = "Customer Search";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.clearBtn.Location = new System.Drawing.Point(133, 158);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSearch.Location = new System.Drawing.Point(236, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewCust
            // 
            this.btnNewCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewCust.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnNewCust.Location = new System.Drawing.Point(6, 40);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(320, 23);
            this.btnNewCust.TabIndex = 9;
            this.btnNewCust.Text = "New Customer";
            this.btnNewCust.UseVisualStyleBackColor = true;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // btnQueries
            // 
            this.btnQueries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQueries.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnQueries.Location = new System.Drawing.Point(6, 80);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(320, 23);
            this.btnQueries.TabIndex = 10;
            this.btnQueries.Text = "Queries and Reports";
            this.btnQueries.UseVisualStyleBackColor = true;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // grpTools
            // 
            this.grpTools.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTools.BackColor = System.Drawing.Color.Transparent;
            this.grpTools.Controls.Add(this.btnDatabaseStats);
            this.grpTools.Controls.Add(this.btnExit);
            this.grpTools.Controls.Add(this.btnQueries);
            this.grpTools.Controls.Add(this.btnNewCust);
            this.grpTools.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTools.ForeColor = System.Drawing.SystemColors.Control;
            this.grpTools.Location = new System.Drawing.Point(354, 83);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(332, 193);
            this.grpTools.TabIndex = 12;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Tools";
            // 
            // btnDatabaseStats
            // 
            this.btnDatabaseStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatabaseStats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabaseStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDatabaseStats.Location = new System.Drawing.Point(6, 120);
            this.btnDatabaseStats.Name = "btnDatabaseStats";
            this.btnDatabaseStats.Size = new System.Drawing.Size(320, 23);
            this.btnDatabaseStats.TabIndex = 13;
            this.btnDatabaseStats.Text = "Database Statistics";
            this.btnDatabaseStats.UseVisualStyleBackColor = true;
            this.btnDatabaseStats.Click += new System.EventHandler(this.btnDatabaseStats_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.Location = new System.Drawing.Point(6, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(320, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(698, 321);
            this.Controls.Add(this.grpTools);
            this.Controls.Add(this.grpCustSearch);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(714, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vet To Go";
            this.grpCustSearch.ResumeLayout(false);
            this.grpCustSearch.PerformLayout();
            this.grpTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.MaskedTextBox txtPhoneNum;
        private System.Windows.Forms.GroupBox grpCustSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDatabaseStats;
    }
}

