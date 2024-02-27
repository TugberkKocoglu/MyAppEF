namespace MyApp.UI
{
    partial class FrmIndex
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
            this.btnNewRec = new System.Windows.Forms.Button();
            this.btnRecs = new System.Windows.Forms.Button();
            this.btnRecUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewRec
            // 
            this.btnNewRec.Location = new System.Drawing.Point(58, 161);
            this.btnNewRec.Name = "btnNewRec";
            this.btnNewRec.Size = new System.Drawing.Size(159, 129);
            this.btnNewRec.TabIndex = 0;
            this.btnNewRec.Text = "Yeni Kayıt ";
            this.btnNewRec.UseVisualStyleBackColor = true;
            this.btnNewRec.Click += new System.EventHandler(this.btnNewRec_Click);
            // 
            // btnRecs
            // 
            this.btnRecs.Location = new System.Drawing.Point(307, 161);
            this.btnRecs.Name = "btnRecs";
            this.btnRecs.Size = new System.Drawing.Size(166, 129);
            this.btnRecs.TabIndex = 1;
            this.btnRecs.Text = "Kayıtlar";
            this.btnRecs.UseVisualStyleBackColor = true;
            this.btnRecs.Click += new System.EventHandler(this.btnRecs_Click);
            // 
            // btnRecUpdate
            // 
            this.btnRecUpdate.Location = new System.Drawing.Point(545, 161);
            this.btnRecUpdate.Name = "btnRecUpdate";
            this.btnRecUpdate.Size = new System.Drawing.Size(176, 129);
            this.btnRecUpdate.TabIndex = 2;
            this.btnRecUpdate.Text = "Kayıt Güncelle";
            this.btnRecUpdate.UseVisualStyleBackColor = true;
            this.btnRecUpdate.Click += new System.EventHandler(this.btnRecUpdate_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecUpdate);
            this.Controls.Add(this.btnRecs);
            this.Controls.Add(this.btnNewRec);
            this.Name = "FrmIndex";
            this.Text = "MYAPPS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewRec;
        private System.Windows.Forms.Button btnRecs;
        private System.Windows.Forms.Button btnRecUpdate;
    }
}