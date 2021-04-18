using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroGOG
{
	public partial class frmCoreSelect : Form
	{
		public frmCoreSelect()
		{
			InitializeComponent();
		}

		private void frmCoreSelect_Load(object sender, EventArgs e)
		{
			lblConsoleName.Text = this.Text;
			this.Text = "Select Retorarch Plugin";
			var files = Directory.EnumerateFiles(Globals.RAPath.Replace("retroarch.exe", "cores\\")).Select(Path.GetFileName);
			foreach (var file in files)
			{
				cboCore.Items.Add(file);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Globals.TempCore = cboCore.Text;
			this.Close();
		}
	}
}
