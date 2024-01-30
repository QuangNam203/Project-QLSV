namespace Project_QLSV.Class_Sinh_Viên
{
    partial class SVinClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVinClass));
            this.lblnganh = new System.Windows.Forms.Label();
            this.lbltenlop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSVlop = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnchuyen = new System.Windows.Forms.Button();
            this.txtchuyen = new System.Windows.Forms.TextBox();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnganh
            // 
            this.lblnganh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnganh.Location = new System.Drawing.Point(693, 45);
            this.lblnganh.Name = "lblnganh";
            this.lblnganh.Size = new System.Drawing.Size(169, 27);
            this.lblnganh.TabIndex = 41;
            this.lblnganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltenlop
            // 
            this.lbltenlop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltenlop.Location = new System.Drawing.Point(535, 44);
            this.lbltenlop.Name = "lbltenlop";
            this.lbltenlop.Size = new System.Drawing.Size(76, 27);
            this.lbltenlop.TabIndex = 40;
            this.lbltenlop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngành :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lớp :";
            // 
            // dgvSVlop
            // 
            this.dgvSVlop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSVlop.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSVlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSVlop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSVlop.Location = new System.Drawing.Point(0, 130);
            this.dgvSVlop.Name = "dgvSVlop";
            this.dgvSVlop.Size = new System.Drawing.Size(1284, 491);
            this.dgvSVlop.TabIndex = 45;
            this.dgvSVlop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSVlop_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(942, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 20);
            this.txtSearch.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1159, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(889, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Search :";
            // 
            // btnchuyen
            // 
            this.btnchuyen.Location = new System.Drawing.Point(1159, 90);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(75, 23);
            this.btnchuyen.TabIndex = 49;
            this.btnchuyen.Text = "Chuyển Lớp";
            this.btnchuyen.UseVisualStyleBackColor = true;
            this.btnchuyen.Click += new System.EventHandler(this.btnchuyen_Click);
            // 
            // txtchuyen
            // 
            this.txtchuyen.Location = new System.Drawing.Point(1043, 93);
            this.txtchuyen.Name = "txtchuyen";
            this.txtchuyen.Size = new System.Drawing.Size(96, 20);
            this.txtchuyen.TabIndex = 50;
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(942, 93);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(95, 21);
            this.cblop.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SVinClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1284, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.txtchuyen);
            this.Controls.Add(this.btnchuyen);
            this.Controls.Add(this.dgvSVlop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblnganh);
            this.Controls.Add(this.lbltenlop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "SVinClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sinh Viên Của Lớp";
            this.Load += new System.EventHandler(this.SVinClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblnganh;
        private System.Windows.Forms.Label lbltenlop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSVlop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnchuyen;
        private System.Windows.Forms.TextBox txtchuyen;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}