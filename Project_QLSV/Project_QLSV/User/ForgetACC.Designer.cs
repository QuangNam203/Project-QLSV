namespace Project_QLSV.User
{
    partial class ForgetACC
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.chbrobot = new System.Windows.Forms.CheckBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.dgvACC = new System.Windows.Forms.DataGridView();
            this.lblsms = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(86, 50);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(171, 20);
            this.txtUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gmail";
            // 
            // txtgmail
            // 
            this.txtgmail.Location = new System.Drawing.Point(86, 99);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(171, 20);
            this.txtgmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SĐT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(86, 146);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(171, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã sms";
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(86, 212);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(90, 20);
            this.txtSMS.TabIndex = 1;
            // 
            // chbrobot
            // 
            this.chbrobot.AutoSize = true;
            this.chbrobot.Location = new System.Drawing.Point(86, 253);
            this.chbrobot.Name = "chbrobot";
            this.chbrobot.Size = new System.Drawing.Size(124, 17);
            this.chbrobot.TabIndex = 2;
            this.chbrobot.Text = "Tôi không phải robot";
            this.chbrobot.UseVisualStyleBackColor = true;
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(122, 290);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(75, 23);
            this.btnGui.TabIndex = 3;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // dgvACC
            // 
            this.dgvACC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvACC.Location = new System.Drawing.Point(333, 50);
            this.dgvACC.Name = "dgvACC";
            this.dgvACC.Size = new System.Drawing.Size(456, 150);
            this.dgvACC.TabIndex = 4;
            // 
            // lblsms
            // 
            this.lblsms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsms.Location = new System.Drawing.Point(86, 178);
            this.lblsms.Name = "lblsms";
            this.lblsms.Size = new System.Drawing.Size(100, 23);
            this.lblsms.TabIndex = 5;
            this.lblsms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(205, 178);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(24, 23);
            this.btnRest.TabIndex = 6;
            this.btnRest.Text = "o";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // ForgetACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(324, 334);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.lblsms);
            this.Controls.Add(this.dgvACC);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.chbrobot);
            this.Controls.Add(this.txtSMS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "ForgetACC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetACC";
            this.Load += new System.EventHandler(this.ForgetACC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvACC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.CheckBox chbrobot;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.DataGridView dgvACC;
        private System.Windows.Forms.Label lblsms;
        private System.Windows.Forms.Button btnRest;
    }
}