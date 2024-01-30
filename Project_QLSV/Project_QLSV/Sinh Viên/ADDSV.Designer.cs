namespace Project_QLSV
{
    partial class ADDSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDSV));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbnganh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcha = new System.Windows.Forms.TextBox();
            this.txtMe = new System.Windows.Forms.TextBox();
            this.txtDantoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(176, 49);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(254, 26);
            this.txtHo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đệm";
            // 
            // txtTendem
            // 
            this.txtTendem.Location = new System.Drawing.Point(176, 106);
            this.txtTendem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTendem.Name = "txtTendem";
            this.txtTendem.Size = new System.Drawing.Size(254, 26);
            this.txtTendem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(176, 162);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(254, 26);
            this.txtTen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // mtbNgaysinh
            // 
            this.mtbNgaysinh.Location = new System.Drawing.Point(176, 220);
            this.mtbNgaysinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbNgaysinh.Mask = "00/00/0000";
            this.mtbNgaysinh.Name = "mtbNgaysinh";
            this.mtbNgaysinh.Size = new System.Drawing.Size(110, 26);
            this.mtbNgaysinh.TabIndex = 2;
            this.mtbNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Checked = true;
            this.rbtNam.Location = new System.Drawing.Point(294, 225);
            this.rbtNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(67, 24);
            this.rbtNam.TabIndex = 3;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Location = new System.Drawing.Point(374, 225);
            this.rbtNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(54, 24);
            this.rbtNu.TabIndex = 3;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "SĐT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(594, 154);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(286, 26);
            this.txtSDT.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Addres";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(344, 405);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 49);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(512, 405);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 49);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbnganh
            // 
            this.cbnganh.FormattingEnabled = true;
            this.cbnganh.Location = new System.Drawing.Point(660, 48);
            this.cbnganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbnganh.Name = "cbnganh";
            this.cbnganh.Size = new System.Drawing.Size(220, 28);
            this.cbnganh.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "CMND :";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(594, 100);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(286, 26);
            this.txtCMND.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên Mẹ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 337);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tên Cha";
            // 
            // txtcha
            // 
            this.txtcha.Location = new System.Drawing.Point(176, 275);
            this.txtcha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcha.Name = "txtcha";
            this.txtcha.Size = new System.Drawing.Size(254, 26);
            this.txtcha.TabIndex = 1;
            // 
            // txtMe
            // 
            this.txtMe.Location = new System.Drawing.Point(176, 329);
            this.txtMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMe.Name = "txtMe";
            this.txtMe.Size = new System.Drawing.Size(254, 26);
            this.txtMe.TabIndex = 1;
            // 
            // txtDantoc
            // 
            this.txtDantoc.Location = new System.Drawing.Point(594, 326);
            this.txtDantoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDantoc.Name = "txtDantoc";
            this.txtDantoc.Size = new System.Drawing.Size(286, 26);
            this.txtDantoc.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 337);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Dân Tộc";
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(489, 48);
            this.cbkhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(150, 28);
            this.cbkhoa.TabIndex = 53;
            this.cbkhoa.Text = "---- Chọn Khóa ----";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(594, 217);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(594, 272);
            this.txtAddres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(286, 26);
            this.txtAddres.TabIndex = 1;
            // 
            // ADDSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(966, 483);
            this.Controls.Add(this.cbkhoa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbnganh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.rbtNu);
            this.Controls.Add(this.rbtNam);
            this.Controls.Add(this.mtbNgaysinh);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDantoc);
            this.Controls.Add(this.txtMe);
            this.Controls.Add(this.txtcha);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTendem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ADDSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTendem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbNgaysinh;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbnganh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcha;
        private System.Windows.Forms.TextBox txtMe;
        private System.Windows.Forms.TextBox txtDantoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddres;
    }
}