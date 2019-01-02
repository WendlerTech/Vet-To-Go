namespace Vet_To_Go.Forms
{
    partial class FrmCustomerNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerNotes));
            this.rtbNewNotes = new System.Windows.Forms.RichTextBox();
            this.rtbCustNotes = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteNotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbNewNotes
            // 
            this.rtbNewNotes.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rtbNewNotes.Location = new System.Drawing.Point(12, 25);
            this.rtbNewNotes.Name = "rtbNewNotes";
            this.rtbNewNotes.Size = new System.Drawing.Size(644, 208);
            this.rtbNewNotes.TabIndex = 0;
            this.rtbNewNotes.Text = "";
            // 
            // rtbCustNotes
            // 
            this.rtbCustNotes.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rtbCustNotes.Location = new System.Drawing.Point(12, 285);
            this.rtbCustNotes.Name = "rtbCustNotes";
            this.rtbCustNotes.ReadOnly = true;
            this.rtbCustNotes.Size = new System.Drawing.Size(644, 208);
            this.rtbCustNotes.TabIndex = 1;
            this.rtbCustNotes.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSave.Location = new System.Drawing.Point(480, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClear.Location = new System.Drawing.Point(12, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear new entry";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(13, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add New Notes:";
            // 
            // btnDeleteNotes
            // 
            this.btnDeleteNotes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNotes.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteNotes.Location = new System.Drawing.Point(12, 499);
            this.btnDeleteNotes.Name = "btnDeleteNotes";
            this.btnDeleteNotes.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteNotes.TabIndex = 6;
            this.btnDeleteNotes.TabStop = false;
            this.btnDeleteNotes.Text = "Delete All Notes";
            this.btnDeleteNotes.UseVisualStyleBackColor = true;
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.Location = new System.Drawing.Point(252, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmCustomerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(668, 529);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbCustNotes);
            this.Controls.Add(this.rtbNewNotes);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNewNotes;
        private System.Windows.Forms.RichTextBox rtbCustNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteNotes;
        private System.Windows.Forms.Button btnExit;
    }
}