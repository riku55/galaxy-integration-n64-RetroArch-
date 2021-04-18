using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace RetroGOG
{
	public partial class frmDependencies : Form
	{
		public bool GOGFound = false;
		public bool RAFound = false;

		public frmDependencies()
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
			Form frmMain = new frmMain();
			frmMain.Closed += (s, args) => this.Close();
			frmMain.Show();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit the wizard?  Any unsaved progress will be lost.", "RetroGOG", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void frmDependencies_Load(object sender, EventArgs e)
		{
			// Check for various dependencies and files / directories
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\GOG Galaxy\\GalaxyClient.exe"))
			{
				imgGOGStatus.Image = Properties.Resources.yes;
				lblGOGStatus.Text = "GOG Galaxy 2.0 is installed in the default location.";
				GOGFound = true;
			}
			else
			{
				imgGOGStatus.Image = Properties.Resources.no;
				lblGOGStatus.Text = "GOG Galaxy 2.0 was not found on this system.";
				btnDownloadGOG.Visible = true;
			}

			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\GOG.com\\Galaxy\\plugins\\installed"))
			{
				Globals.GOGPluginPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\GOG.com\\Galaxy\\plugins\\installed";
			}
			else
			{
				imgGOGStatus.Image = Properties.Resources.no;
				lblGOGStatus.Text = "GOG Galaxy 2.0 was not found on this system.";
				GOGFound = false;
			}

			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RetroArch\\retroarch.exe"))
			{
				imgRetroStatus.Image = Properties.Resources.yes;
				lblRetroStatus.Text = "Retroarch found in the default location.";
				Globals.RAPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RetroArch\\retroarch.exe";
				RAFound = true;
			}
			else
			{
				imgRetroStatus.Image = Properties.Resources.warn;
				lblRetroStatus.Text = "Retroarch not found in the default location.";
				lblRetroBrowse.Visible = true;
				txtRetroPath.Visible = true;
				btnRetroBrowse.Visible = true;
			}
		}

		private void tmrCheck_Tick(object sender, EventArgs e)
		{
			if (GOGFound == true && RAFound == true)
			{
				btnNext.Enabled = true;
			}
		}

		private void btnRetroBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog browser = new OpenFileDialog();
			browser.Title = "Please select your retroarch.exe file";
			browser.InitialDirectory = @"c:\";
			browser.Filter = "Retroarch Application|retroarch.exe";
			browser.FilterIndex = 2;
			browser.RestoreDirectory = true;
			if (browser.ShowDialog() == DialogResult.OK)
			{
				txtRetroPath.Text = browser.FileName;
				imgRetroStatus.Image = Properties.Resources.yes;
				lblRetroStatus.Text = "Retroarch location has been entered by user.";
				Globals.RAPath = txtRetroPath.Text;
				RAFound = true;
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form frmPluginSelect = new frmPluginSelect();
			frmPluginSelect.Closed += (s, args) => this.Close();
			frmPluginSelect.Show();
		}

		private void btnDownloadGOG_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.gog.com/galaxy");
		}
	}
}
