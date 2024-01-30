namespace Project_QLSV
{
    partial class FrmKyLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKyLuat));
            this.rbtlan2 = new System.Windows.Forms.RadioButton();
            this.rbtlan1 = new System.Windows.Forms.RadioButton();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKyluat = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnloc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyluat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtlan2
            // 
            this.rbtlan2.AutoSize = true;
            this.rbtlan2.Location = new System.Drawing.Point(1071, 71);
            this.rbtlan2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtlan2.Name = "rbtlan2";
            this.rbtlan2.Size = new System.Drawing.Size(74, 24);
            this.rbtlan2.TabIndex = 18;
            this.rbtlan2.TabStop = true;
            this.rbtlan2.Text = "Lần 2";
            this.rbtlan2.UseVisualStyleBackColor = true;
            // 
            // rbtlan1
            // 
            this.rbtlan1.AutoSize = true;
            this.rbtlan1.Location = new System.Drawing.Point(956, 71);
            this.rbtlan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtlan1.Name = "rbtlan1";
            this.rbtlan1.Size = new System.Drawing.Size(74, 24);
            this.rbtlan1.TabIndex = 17;
            this.rbtlan1.TabStop = true;
            this.rbtlan1.Text = "Lần 1";
            this.rbtlan1.UseVisualStyleBackColor = true;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(766, 69);
            this.cbLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(144, 28);
            this.cbLop.TabIndex = 16;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1402, 65);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 26);
            this.txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1684, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 32);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1304, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search :";
            // 
            // dgvKyluat
            // 
            this.dgvKyluat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyluat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKyluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyluat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKyluat.Location = new System.Drawing.Point(0, 177);
            this.dgvKyluat.Name = "dgvKyluat";
            this.dgvKyluat.RowHeadersWidth = 51;
            this.dgvKyluat.RowTemplate.Height = 24;
            this.dgvKyluat.Size = new System.Drawing.Size(1926, 778);
            this.dgvKyluat.TabIndex = 12;
            this.dgvKyluat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyluat_CellContentClick);
            this.dgvKyluat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyluat_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1826, 63);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 35);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lớp :";
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(1158, 66);
            this.btnloc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(80, 35);
            this.btnloc.TabIndex = 21;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1926, 955);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbtlan2);
            this.Controls.Add(this.rbtlan1);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKyluat);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKyLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKyLuat";
            this.Load += new System.EventHandler(this.FrmKyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyluat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtlan2;
        private System.Windows.Forms.RadioButton rbtlan1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKyluat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}