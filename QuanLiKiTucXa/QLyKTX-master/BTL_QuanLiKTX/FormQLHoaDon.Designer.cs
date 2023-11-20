namespace BTL_QuanLiKTX
{
	partial class FormQLHoaDon
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tìmKiếmHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvThuePhong = new Guna.UI2.WinForms.Guna2DataGridView();
			this.dBQuanLiKTX = new BTL_QuanLiKTX.DBQuanLiKTX();
			this.dBQuanLiKTXBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBQuanLiKTXDataSet = new BTL_QuanLiKTX.DBQuanLiKTXDataSet();
			this.dBQuanLiKTXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dbQLSVDataSet = new BTL_QuanLiKTX.dbQLSVDataSet();
			this.thuephongBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.thuephongTableAdapter = new BTL_QuanLiKTX.dbQLSVDataSetTableAdapters.ThuephongTableAdapter();
			this.masothueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayBdauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTXBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTXDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTXDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbQLSVDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.thuephongBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1288, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmHóaĐơnToolStripMenuItem});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// tìmKiếmHóaĐơnToolStripMenuItem
			// 
			this.tìmKiếmHóaĐơnToolStripMenuItem.Name = "tìmKiếmHóaĐơnToolStripMenuItem";
			this.tìmKiếmHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.tìmKiếmHóaĐơnToolStripMenuItem.Text = "Tìm kiếm hóa đơn";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1288, 85);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(501, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(302, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lí hóa đơn";
			// 
			// dgvThuePhong
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvThuePhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvThuePhong.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvThuePhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvThuePhong.ColumnHeadersHeight = 18;
			this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masothueDataGridViewTextBoxColumn,
            this.masvDataGridViewTextBoxColumn,
            this.maphongDataGridViewTextBoxColumn,
            this.ngayBdauDataGridViewTextBoxColumn,
            this.ngayktDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
			this.dgvThuePhong.DataSource = this.thuephongBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvThuePhong.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvThuePhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvThuePhong.Location = new System.Drawing.Point(12, 143);
			this.dgvThuePhong.Name = "dgvThuePhong";
			this.dgvThuePhong.RowHeadersVisible = false;
			this.dgvThuePhong.RowHeadersWidth = 51;
			this.dgvThuePhong.RowTemplate.Height = 24;
			this.dgvThuePhong.Size = new System.Drawing.Size(1264, 595);
			this.dgvThuePhong.TabIndex = 5;
			this.dgvThuePhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvThuePhong.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvThuePhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvThuePhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvThuePhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvThuePhong.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvThuePhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvThuePhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvThuePhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvThuePhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvThuePhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvThuePhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvThuePhong.ThemeStyle.HeaderStyle.Height = 18;
			this.dgvThuePhong.ThemeStyle.ReadOnly = false;
			this.dgvThuePhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvThuePhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvThuePhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvThuePhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvThuePhong.ThemeStyle.RowsStyle.Height = 24;
			this.dgvThuePhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvThuePhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// dBQuanLiKTX
			// 
			this.dBQuanLiKTX.DataSetName = "DBQuanLiKTX";
			this.dBQuanLiKTX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dBQuanLiKTXBindingSource
			// 
			this.dBQuanLiKTXBindingSource.DataSource = this.dBQuanLiKTX;
			this.dBQuanLiKTXBindingSource.Position = 0;
			// 
			// dBQuanLiKTXDataSet
			// 
			this.dBQuanLiKTXDataSet.DataSetName = "DBQuanLiKTXDataSet";
			this.dBQuanLiKTXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dBQuanLiKTXDataSetBindingSource
			// 
			this.dBQuanLiKTXDataSetBindingSource.DataSource = this.dBQuanLiKTXDataSet;
			this.dBQuanLiKTXDataSetBindingSource.Position = 0;
			// 
			// dbQLSVDataSet
			// 
			this.dbQLSVDataSet.DataSetName = "dbQLSVDataSet";
			this.dbQLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// thuephongBindingSource
			// 
			this.thuephongBindingSource.DataMember = "Thuephong";
			this.thuephongBindingSource.DataSource = this.dbQLSVDataSet;
			// 
			// thuephongTableAdapter
			// 
			this.thuephongTableAdapter.ClearBeforeFill = true;
			// 
			// masothueDataGridViewTextBoxColumn
			// 
			this.masothueDataGridViewTextBoxColumn.DataPropertyName = "Masothue";
			this.masothueDataGridViewTextBoxColumn.HeaderText = "Masothue";
			this.masothueDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.masothueDataGridViewTextBoxColumn.Name = "masothueDataGridViewTextBoxColumn";
			// 
			// masvDataGridViewTextBoxColumn
			// 
			this.masvDataGridViewTextBoxColumn.DataPropertyName = "Masv";
			this.masvDataGridViewTextBoxColumn.HeaderText = "Masv";
			this.masvDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
			// 
			// maphongDataGridViewTextBoxColumn
			// 
			this.maphongDataGridViewTextBoxColumn.DataPropertyName = "Maphong";
			this.maphongDataGridViewTextBoxColumn.HeaderText = "Maphong";
			this.maphongDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maphongDataGridViewTextBoxColumn.Name = "maphongDataGridViewTextBoxColumn";
			// 
			// ngayBdauDataGridViewTextBoxColumn
			// 
			this.ngayBdauDataGridViewTextBoxColumn.DataPropertyName = "NgayBdau";
			this.ngayBdauDataGridViewTextBoxColumn.HeaderText = "NgayBdau";
			this.ngayBdauDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngayBdauDataGridViewTextBoxColumn.Name = "ngayBdauDataGridViewTextBoxColumn";
			// 
			// ngayktDataGridViewTextBoxColumn
			// 
			this.ngayktDataGridViewTextBoxColumn.DataPropertyName = "Ngaykt";
			this.ngayktDataGridViewTextBoxColumn.HeaderText = "Ngaykt";
			this.ngayktDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngayktDataGridViewTextBoxColumn.Name = "ngayktDataGridViewTextBoxColumn";
			// 
			// ghichuDataGridViewTextBoxColumn
			// 
			this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
			this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghichu";
			this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
			// 
			// FormQLHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1288, 750);
			this.Controls.Add(this.dgvThuePhong);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormQLHoaDon";
			this.Text = "FormQLHoaDon";
			this.Load += new System.EventHandler(this.FormQLHoaDon_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTXBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTXDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBQuanLiKTXDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbQLSVDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.thuephongBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tìmKiếmHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView dgvThuePhong;
		private System.Windows.Forms.BindingSource dBQuanLiKTXDataSetBindingSource;
		private DBQuanLiKTXDataSet dBQuanLiKTXDataSet;
		private DBQuanLiKTX dBQuanLiKTX;
		private System.Windows.Forms.BindingSource dBQuanLiKTXBindingSource;
		private dbQLSVDataSet dbQLSVDataSet;
		private System.Windows.Forms.BindingSource thuephongBindingSource;
		private dbQLSVDataSetTableAdapters.ThuephongTableAdapter thuephongTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn masothueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngayBdauDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngayktDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
	}
}