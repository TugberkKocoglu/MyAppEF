namespace MyApp.UI.Forms
{
    partial class FrmUpdate
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
            this.cmbApps = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateR = new System.Windows.Forms.Button();
            this.btnDelR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbApps
            // 
            this.cmbApps.FormattingEnabled = true;
            this.cmbApps.Location = new System.Drawing.Point(141, 40);
            this.cmbApps.Name = "cmbApps";
            this.cmbApps.Size = new System.Drawing.Size(225, 24);
            this.cmbApps.TabIndex = 0;
            this.cmbApps.Text = "Uygulama Seç";
            this.cmbApps.SelectedIndexChanged += new System.EventHandler(this.cmbApps_SelectedIndexChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(141, 128);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // btnUpdateR
            // 
            this.btnUpdateR.Location = new System.Drawing.Point(195, 338);
            this.btnUpdateR.Name = "btnUpdateR";
            this.btnUpdateR.Size = new System.Drawing.Size(171, 54);
            this.btnUpdateR.TabIndex = 3;
            this.btnUpdateR.Text = "GÜNCELLE";
            this.btnUpdateR.UseVisualStyleBackColor = true;
            this.btnUpdateR.Click += new System.EventHandler(this.btnUpdateR_Click);
            // 
            // btnDelR
            // 
            this.btnDelR.Location = new System.Drawing.Point(476, 338);
            this.btnDelR.Name = "btnDelR";
            this.btnDelR.Size = new System.Drawing.Size(172, 54);
            this.btnDelR.TabIndex = 4;
            this.btnDelR.Text = "SİL";
            this.btnDelR.UseVisualStyleBackColor = true;
            this.btnDelR.Click += new System.EventHandler(this.btnDelR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelR);
            this.Controls.Add(this.btnUpdateR);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmbApps);
            this.Name = "FrmUpdate";
            this.Text = "GÜNCELLEME FORMU";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbApps;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdateR;
        private System.Windows.Forms.Button btnDelR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}