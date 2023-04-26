namespace text_file_to_ui
{
    partial class frmUserDataDisplay
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblYearOfBirth = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFacuty = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblrsa = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtrsa = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtFacuty = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtYearOfBirth = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(27, 88);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblYearOfBirth
            // 
            this.lblYearOfBirth.AutoSize = true;
            this.lblYearOfBirth.Location = new System.Drawing.Point(27, 133);
            this.lblYearOfBirth.Name = "lblYearOfBirth";
            this.lblYearOfBirth.Size = new System.Drawing.Size(81, 16);
            this.lblYearOfBirth.TabIndex = 1;
            this.lblYearOfBirth.Text = "Year of birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(27, 175);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblFacuty
            // 
            this.lblFacuty.AutoSize = true;
            this.lblFacuty.Location = new System.Drawing.Point(27, 220);
            this.lblFacuty.Name = "lblFacuty";
            this.lblFacuty.Size = new System.Drawing.Size(50, 16);
            this.lblFacuty.TabIndex = 3;
            this.lblFacuty.Text = "Facuty:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(27, 264);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role:";
            // 
            // lblrsa
            // 
            this.lblrsa.AutoSize = true;
            this.lblrsa.Location = new System.Drawing.Point(27, 307);
            this.lblrsa.Name = "lblrsa";
            this.lblrsa.Size = new System.Drawing.Size(140, 16);
            this.lblrsa.TabIndex = 5;
            this.lblrsa.Text = "[role specific attribute]:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(30, 32);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 6;
            this.btnChooseFile.Text = "Choose file...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            // 
            // txtrsa
            // 
            this.txtrsa.Location = new System.Drawing.Point(174, 307);
            this.txtrsa.Name = "txtrsa";
            this.txtrsa.Size = new System.Drawing.Size(204, 22);
            this.txtrsa.TabIndex = 7;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(174, 264);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(204, 22);
            this.txtRole.TabIndex = 8;
            // 
            // txtFacuty
            // 
            this.txtFacuty.Location = new System.Drawing.Point(174, 220);
            this.txtFacuty.Name = "txtFacuty";
            this.txtFacuty.Size = new System.Drawing.Size(204, 22);
            this.txtFacuty.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(174, 175);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(204, 22);
            this.txtCity.TabIndex = 10;
            // 
            // txtYearOfBirth
            // 
            this.txtYearOfBirth.Location = new System.Drawing.Point(174, 133);
            this.txtYearOfBirth.Name = "txtYearOfBirth";
            this.txtYearOfBirth.Size = new System.Drawing.Size(204, 22);
            this.txtYearOfBirth.TabIndex = 11;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(174, 88);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(204, 22);
            this.txtFullName.TabIndex = 12;
            // 
            // frmUserDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 383);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtYearOfBirth);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtFacuty);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtrsa);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblrsa);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFacuty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblYearOfBirth);
            this.Controls.Add(this.lblFullName);
            this.Name = "frmUserDataDisplay";
            this.Text = "User data display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblYearOfBirth;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFacuty;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblrsa;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtrsa;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtFacuty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtYearOfBirth;
        private System.Windows.Forms.TextBox txtFullName;
    }
}

