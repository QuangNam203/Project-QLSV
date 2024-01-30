namespace Project_QLSV.Khen_Thưởng
{
    partial class UpdateKhen
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbKhen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbllop = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmsv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớp :";
            // 
            // cbKhen
            // 
            this.cbKhen.FormattingEnabled = true;
            this.cbKhen.Location = new System.Drawing.Point(125, 156);
            this.cbKhen.Name = "cbKhen";
            this.cbKhen.Size = new System.Drawing.Size(92, 21);
            this.cbKhen.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khen Thưởng";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::Project_QLSV.Properties.Resources.update;
            this.btnLuu.Location = new System.Drawing.Point(69, 202);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 32);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::Project_QLSV.Properties.Resources.delet;
            this.btnXoa.Location = new System.Drawing.Point(173, 202);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 32);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbllop
            // 
            this.lbllop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbllop.Location = new System.Drawing.Point(97, 109);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(94, 26);
            this.lbllop.TabIndex = 67;
            this.lbllop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblhoten
            // 
            this.lblhoten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblhoten.Location = new System.Drawing.Point(97, 34);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(152, 26);
            this.lblhoten.TabIndex = 68;
            this.lblhoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmsv
            // 
            this.lblmsv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblmsv.Location = new System.Drawing.Point(97, 71);
            this.lblmsv.Name = "lblmsv";
            this.lblmsv.Size = new System.Drawing.Size(94, 26);
            this.lblmsv.TabIndex = 69;
            this.lblmsv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateKhen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(296, 269);
            this.Controls.Add(this.lbllop);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lblmsv);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbKhen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UpdateKhen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Khen Thưởng Sinh Viên";
            this.Load += new System.EventHandler(this.UpdateKhen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKhen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmsv;
    }
}