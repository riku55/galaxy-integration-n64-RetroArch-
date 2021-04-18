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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit the wizard?  Any unsaved progress will be lost.", "RetroGOG", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			Form frmAbout = new frmAbout();
			frmAbout.Show();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form frmDependencies = new frmDependencies();			
			frmDependencies.Closed += (s, args) => this.Close();
			frmDependencies.Show();
		}
	}
}
