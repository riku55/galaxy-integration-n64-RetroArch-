using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroGOG
{
	public partial class frmComplete : Form
	{
		public frmComplete()
		{
			InitializeComponent();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			Form frmAbout = new frmAbout();
			frmAbout.Show();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form frmPluginSelect = new frmPluginSelect();
			frmPluginSelect.Closed += (s, args) => this.Close();
			frmPluginSelect.Show();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
