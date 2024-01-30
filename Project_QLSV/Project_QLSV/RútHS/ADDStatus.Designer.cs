namespace Project_QLSV.RútHS
{
    partial class ADDStatus
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbllop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRut = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.lblma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp";
            // 
            // lbllop
            // 
            this.lbllop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbllop.Location = new System.Drawing.Point(207, 19);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(85, 23);
            this.lbllop.TabIndex = 0;
            this.lbllop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ho Tên";
            // 
            // lblten
            // 
            this.lblten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblten.Location = new System.Drawing.Point(70, 74);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(165, 23);
            this.lblten.TabIndex = 0;
            this.lblten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(91, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thiết Lập Trạng Thái ??";
            // 
            // btnRut
            // 
            this.btnRut.Image = global::Project_QLSV.Properties.Resources.add2;
            this.btnRut.Location = new System.Drawing.Point(53, 170);
            this.btnRut.Name = "btnRut";
            this.btnRut.Size = new System.Drawing.Size(90, 32);
            this.btnRut.TabIndex = 2;
            this.btnRut.Text = "Rút Hồ Sơ";
            this.btnRut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRut.UseVisualStyleBackColor = true;
            this.btnRut.Click += new System.EventHandler(this.btnRut_Click);
            // 
            // btnBao
            // 
            this.btnBao.Image = global::Project_QLSV.Properties.Resources.add2;
            this.btnBao.Location = new System.Drawing.Point(190, 170);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(90, 32);
            this.btnBao.TabIndex = 2;
            this.btnBao.Text = "Bảo Lưu";
            this.btnBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // lblma
            // 
            this.lblma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblma.Location = new System.Drawing.Point(64, 19);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(85, 23);
            this.lblma.TabIndex = 0;
            this.lblma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ADDStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(316, 225);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnRut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblma);
            this.Controls.Add(this.lbllop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "ADDStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Trạng Thái Hồ Sơ";
            this.Load += new System.EventHandler(this.UpStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRut;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Label lblma;
    }
}