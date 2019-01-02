namespace Vet_To_Go.Forms
{
    partial class FrmNewAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewAnimal));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShelter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbLicNo = new System.Windows.Forms.RadioButton();
            this.rdbLicYes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbSexMale = new System.Windows.Forms.RadioButton();
            this.rdbSexFemale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbSterYes = new System.Windows.Forms.RadioButton();
            this.rdbSterNo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(156, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(135, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "New Animal";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(24, 148);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(182, 20);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(247, 148);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(182, 20);
            this.txtBreed.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Animal Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(244, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Breed";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSpecies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSpecies.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Bird",
            "Reptile",
            "Horse",
            "Sheep",
            "Pig"});
            this.cmbSpecies.Location = new System.Drawing.Point(247, 90);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(182, 24);
            this.cmbSpecies.TabIndex = 2;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            this.cmbSpecies.Leave += new System.EventHandler(this.cmbSpecies_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(244, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Species";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(24, 204);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(182, 20);
            this.txtColor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(244, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Breeder/Shelter";
            // 
            // txtShelter
            // 
            this.txtShelter.Location = new System.Drawing.Point(247, 204);
            this.txtShelter.Name = "txtShelter";
            this.txtShelter.Size = new System.Drawing.Size(182, 20);
            this.txtShelter.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(21, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Licensed?";
            // 
            // rdbLicNo
            // 
            this.rdbLicNo.AutoSize = true;
            this.rdbLicNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbLicNo.Location = new System.Drawing.Point(56, 2);
            this.rdbLicNo.Name = "rdbLicNo";
            this.rdbLicNo.Size = new System.Drawing.Size(45, 21);
            this.rdbLicNo.TabIndex = 21;
            this.rdbLicNo.Text = "No";
            this.rdbLicNo.UseVisualStyleBackColor = true;
            // 
            // rdbLicYes
            // 
            this.rdbLicYes.AutoSize = true;
            this.rdbLicYes.Checked = true;
            this.rdbLicYes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbLicYes.Location = new System.Drawing.Point(4, 2);
            this.rdbLicYes.Name = "rdbLicYes";
            this.rdbLicYes.Size = new System.Drawing.Size(46, 21);
            this.rdbLicYes.TabIndex = 20;
            this.rdbLicYes.TabStop = true;
            this.rdbLicYes.Text = "Yes";
            this.rdbLicYes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbLicYes);
            this.panel1.Controls.Add(this.rdbLicNo);
            this.panel1.Location = new System.Drawing.Point(24, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 23);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbSexMale);
            this.panel2.Controls.Add(this.rdbSexFemale);
            this.panel2.Location = new System.Drawing.Point(24, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 23);
            this.panel2.TabIndex = 25;
            // 
            // rdbSexMale
            // 
            this.rdbSexMale.AutoSize = true;
            this.rdbSexMale.Checked = true;
            this.rdbSexMale.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbSexMale.Location = new System.Drawing.Point(4, 2);
            this.rdbSexMale.Name = "rdbSexMale";
            this.rdbSexMale.Size = new System.Drawing.Size(57, 21);
            this.rdbSexMale.TabIndex = 16;
            this.rdbSexMale.TabStop = true;
            this.rdbSexMale.Text = "Male";
            this.rdbSexMale.UseVisualStyleBackColor = true;
            // 
            // rdbSexFemale
            // 
            this.rdbSexFemale.AutoSize = true;
            this.rdbSexFemale.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbSexFemale.Location = new System.Drawing.Point(67, 2);
            this.rdbSexFemale.Name = "rdbSexFemale";
            this.rdbSexFemale.Size = new System.Drawing.Size(73, 21);
            this.rdbSexFemale.TabIndex = 17;
            this.rdbSexFemale.Text = "Female";
            this.rdbSexFemale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.Location = new System.Drawing.Point(21, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sex";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbSterYes);
            this.panel3.Controls.Add(this.rdbSterNo);
            this.panel3.Location = new System.Drawing.Point(24, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 23);
            this.panel3.TabIndex = 25;
            // 
            // rdbSterYes
            // 
            this.rdbSterYes.AutoSize = true;
            this.rdbSterYes.Checked = true;
            this.rdbSterYes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbSterYes.Location = new System.Drawing.Point(4, 2);
            this.rdbSterYes.Name = "rdbSterYes";
            this.rdbSterYes.Size = new System.Drawing.Size(46, 21);
            this.rdbSterYes.TabIndex = 18;
            this.rdbSterYes.TabStop = true;
            this.rdbSterYes.Text = "Yes";
            this.rdbSterYes.UseVisualStyleBackColor = true;
            // 
            // rdbSterNo
            // 
            this.rdbSterNo.AutoSize = true;
            this.rdbSterNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbSterNo.Location = new System.Drawing.Point(56, 2);
            this.rdbSterNo.Name = "rdbSterNo";
            this.rdbSterNo.Size = new System.Drawing.Size(45, 21);
            this.rdbSterNo.TabIndex = 19;
            this.rdbSterNo.Text = "No";
            this.rdbSterNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.Location = new System.Drawing.Point(21, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sterilized?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSubmit.Location = new System.Drawing.Point(247, 260);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(182, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClear.Location = new System.Drawing.Point(247, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.Location = new System.Drawing.Point(247, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit Without Saving";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmNewAnimal
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(455, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtShelter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Animal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtShelter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbLicNo;
        private System.Windows.Forms.RadioButton rdbLicYes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbSexMale;
        private System.Windows.Forms.RadioButton rdbSexFemale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbSterYes;
        private System.Windows.Forms.RadioButton rdbSterNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}