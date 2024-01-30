namespace Project_QLSV.Class_Sinh_Viên
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.cbnganh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtlimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.dgvlop = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbnganh
            // 
            this.cbnganh.FormattingEnabled = true;
            this.cbnganh.Location = new System.Drawing.Point(930, 35);
            this.cbnganh.Name = "cbnganh";
            this.cbnganh.Size = new System.Drawing.Size(174, 21);
            this.cbnganh.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(887, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ngành";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::Project_QLSV.Properties.Resources.add2;
            this.btnLuu.Location = new System.Drawing.Point(1146, 38);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 32);
            this.btnLuu.TabIndex = 47;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtlimit
            // 
            this.txtlimit.Location = new System.Drawing.Point(1076, 74);
            this.txtlimit.Name = "txtlimit";
            this.txtlimit.Size = new System.Drawing.Size(28, 20);
            this.txtlimit.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1036, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Limit :";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(642, 38);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 13);
            this.lblkhoa.TabIndex = 39;
            this.lblkhoa.Text = "Khóa :";
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(697, 77);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(121, 20);
            this.txtmalop.TabIndex = 1;
            this.txtmalop.TextChanged += new System.EventHandler(this.txtmalop_TextChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(642, 80);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(49, 13);
            this.l.TabIndex = 40;
            this.l.Text = "Mã Lớp :";
            // 
            // dgvlop
            // 
            this.dgvlop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlop.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL});
            this.dgvlop.Location = new System.Drawing.Point(0, 158);
            this.dgvlop.Name = "dgvlop";
            this.dgvlop.Size = new System.Drawing.Size(1284, 469);
            this.dgvlop.TabIndex = 51;
            this.dgvlop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellDoubleClick);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(697, 33);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(121, 21);
            this.cbkhoa.TabIndex = 52;
            this.cbkhoa.Text = "---- Chọn Khóa ----";
            this.cbkhoa.SelectedIndexChanged += new System.EventHandler(this.cbkhoa_SelectedIndexChanged);
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(930, 73);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(100, 20);
            this.txtlop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Lớp";
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(983, 121);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 21);
            this.cblop.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.Image = global::Project_QLSV.Properties.Resources.delet;
            this.button1.Location = new System.Drawing.Point(1146, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 56;
            this.button1.Text = "Xóa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1284, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.cbkhoa);
            this.Controls.Add(this.cbnganh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtlimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblkhoa);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.l);
            this.Controls.Add(this.dgvlop);
            this.Name = "Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbnganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtlimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dgvlop;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}