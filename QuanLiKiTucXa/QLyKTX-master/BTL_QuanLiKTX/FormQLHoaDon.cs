using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKTX
{
	public partial class FormQLHoaDon : Form
	{
		public FormQLHoaDon()
		{
			InitializeComponent();
		}

		private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void FormQLHoaDon_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'dbQLSVDataSet.Thuephong' table. You can move, or remove it, as needed.
            this.thuephongTableAdapter.Fill(this.dbQLSVDataSet.Thuephong);

        }
    }
}
