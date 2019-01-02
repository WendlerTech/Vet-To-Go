namespace Vet_To_Go.Forms
{
    partial class FrmAnimalNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimalNotes));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteNotes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbAnimalNotes = new System.Windows.Forms.RichTextBox();
            this.rtbNewNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.Location = new System.Drawing.Point(252, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteNotes
            // 
            this.btnDeleteNotes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNotes.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteNotes.Location = new System.Drawing.Point(12, 499);
            this.btnDeleteNotes.Name = "btnDeleteNotes";
            this.btnDeleteNotes.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteNotes.TabIndex = 14;
            this.btnDeleteNotes.TabStop = false;
            this.btnDeleteNotes.Text = "Delete All Notes";
            this.btnDeleteNotes.UseVisualStyleBackColor = true;
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add New Notes:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(13, 265);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(90, 17);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Animal Notes:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClear.Location = new System.Drawing.Point(12, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear new entry";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSave.Location = new System.Drawing.Point(480, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbAnimalNotes
            // 
            this.rtbAnimalNotes.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rtbAnimalNotes.Location = new System.Drawing.Point(12, 285);
            this.rtbAnimalNotes.Name = "rtbAnimalNotes";
            this.rtbAnimalNotes.ReadOnly = true;
            this.rtbAnimalNotes.Size = new System.Drawing.Size(644, 208);
            this.rtbAnimalNotes.TabIndex = 9;
            this.rtbAnimalNotes.Text = "";
            // 
            // rtbNewNotes
            // 
            this.rtbNewNotes.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rtbNewNotes.Location = new System.Drawing.Point(12, 25);
            this.rtbNewNotes.Name = "rtbNewNotes";
            this.rtbNewNotes.Size = new System.Drawing.Size(644, 208);
            this.rtbNewNotes.TabIndex = 8;
            this.rtbNewNotes.Text = "";
            // 
            // FrmAnimalNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(668, 529);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbAnimalNotes);
            this.Controls.Add(this.rtbNewNotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnimalNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbAnimalNotes;
        private System.Windows.Forms.RichTextBox rtbNewNotes;
    }
}