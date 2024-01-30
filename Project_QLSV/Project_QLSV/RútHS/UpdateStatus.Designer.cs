namespace Project_QLSV.RútHS
{
    partial class UpdateStatus
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
            this.lblma = new System.Windows.Forms.Label();
            this.lbllop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtRut = new System.Windows.Forms.RadioButton();
            this.rbtBao = new System.Windows.Forms.RadioButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblma
            // 
            this.lblma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblma.Location = new System.Drawing.Point(63, 21);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(85, 23);
            this.lblma.TabIndex = 1;
            this.lblma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllop
            // 
            this.lbllop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbllop.Location = new System.Drawing.Point(206, 21);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(85, 23);
            this.lbllop.TabIndex = 2;
            this.lbllop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp";
            // 
            // lblten
            // 
            this.lblten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblten.Location = new System.Drawing.Point(63, 76);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(165, 23);
            this.lblten.TabIndex = 4;
            this.lblten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ho Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã SV";
            // 
            // rbtRut
            // 
            this.rbtRut.AutoSize = true;
            this.rbtRut.Location = new System.Drawing.Point(66, 136);
            this.rbtRut.Name = "rbtRut";
            this.rbtRut.Size = new System.Drawing.Size(70, 17);
            this.rbtRut.TabIndex = 7;
            this.rbtRut.TabStop = true;
            this.rbtRut.Text = "Withdraw";
            this.rbtRut.UseVisualStyleBackColor = true;
            // 
            // rbtBao
            // 
            this.rbtBao.AutoSize = true;
            this.rbtBao.Location = new System.Drawing.Point(197, 136);
            this.rbtBao.Name = "rbtBao";
            this.rbtBao.Size = new System.Drawing.Size(65, 17);
            this.rbtBao.TabIndex = 8;
            this.rbtBao.TabStop = true;
            this.rbtBao.Text = "Reserve";
            this.rbtBao.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::Project_QLSV.Properties.Resources.update;
            this.btnLuu.Location = new System.Drawing.Point(66, 186);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 32);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::Project_QLSV.Properties.Resources.delet;
            this.btnXoa.Location = new System.Drawing.Point(197, 186);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UpdateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 249);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.rbtBao);
            this.Controls.Add(this.rbtRut);
            this.Controls.Add(this.lblma);
            this.Controls.Add(this.lbllop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UpdateStatus";
            this.Text = "Cập Nhật Trạng Thái Hồ Sơ";
            this.Load += new System.EventHandler(this.UpdateStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtRut;
        private System.Windows.Forms.RadioButton rbtBao;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}