namespace Project_QLSV.User
{
    partial class ShowACC
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.Location = new System.Drawing.Point(109, 20);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(35, 13);
            this.lblUse.TabIndex = 1;
            this.lblUse.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pass :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(109, 62);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(35, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "label4";
            // 
            // ShowACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(194, 113);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUse);
            this.Controls.Add(this.label1);
            this.Name = "ShowACC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowACC";
            this.Load += new System.EventHandler(this.ShowACC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPass;
    }
}