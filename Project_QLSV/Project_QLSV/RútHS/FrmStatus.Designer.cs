namespace Project_QLSV.RútHS
{
    partial class FrmStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatus));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRut = new System.Windows.Forms.DataGridView();
            this.btnSearch_2 = new System.Windows.Forms.Button();
            this.txtSearch_2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRut)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.cbstatus);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvRut);
            this.panel2.Controls.Add(this.btnSearch_2);
            this.panel2.Controls.Add(this.txtSearch_2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(504, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 621);
            this.panel2.TabIndex = 1;
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Withdraw",
            "Reserve"});
            this.cbstatus.Location = new System.Drawing.Point(195, 67);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(121, 21);
            this.cbstatus.TabIndex = 4;
            this.cbstatus.Text = "--- Chọn Status ---";
            this.cbstatus.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // dgvRut
            // 
            this.dgvRut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRut.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRut.Location = new System.Drawing.Point(0, 143);
            this.dgvRut.Name = "dgvRut";
            this.dgvRut.Size = new System.Drawing.Size(780, 478);
            this.dgvRut.TabIndex = 0;
            this.dgvRut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRut_CellDoubleClick);
            // 
            // btnSearch_2
            // 
            this.btnSearch_2.Location = new System.Drawing.Point(667, 65);
            this.btnSearch_2.Name = "btnSearch_2";
            this.btnSearch_2.Size = new System.Drawing.Size(75, 23);
            this.btnSearch_2.TabIndex = 2;
            this.btnSearch_2.Text = "Search";
            this.btnSearch_2.UseVisualStyleBackColor = true;
            this.btnSearch_2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch_2
            // 
            this.txtSearch_2.Location = new System.Drawing.Point(506, 68);
            this.txtSearch_2.Name = "txtSearch_2";
            this.txtSearch_2.Size = new System.Drawing.Size(145, 20);
            this.txtSearch_2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 621);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(398, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(237, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvCheck
            // 
            this.dgvCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheck.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCheck.Location = new System.Drawing.Point(0, 143);
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.Size = new System.Drawing.Size(500, 478);
            this.dgvCheck.TabIndex = 0;
            this.dgvCheck.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheck_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1284, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hồ Sơ";
            this.Load += new System.EventHandler(this.FrmRut_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.DataGridView dgvRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch_2;
        private System.Windows.Forms.TextBox txtSearch_2;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}