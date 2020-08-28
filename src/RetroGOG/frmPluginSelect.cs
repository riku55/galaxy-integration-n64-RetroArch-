using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroGOG
{
	public partial class frmPluginSelect : Form
	{
		public frmPluginSelect()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit the wizard?  Any unsaved progress will be lost.", "RetroGOG", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form frmDependencies = new frmDependencies();
			frmDependencies.Closed += (s, args) => this.Close();
			frmDependencies.Show();
		}

		private void frmPluginSelect_Load(object sender, EventArgs e)
		{
			tmrCheck.Enabled = true;
			string playlistpath = Globals.RAPath.Replace("retroarch.exe", "playlists\\");
			string[] strPlaylists = Directory.GetFiles(playlistpath);
			if (strPlaylists.Count() > 0)
			{
				foreach (string name in strPlaylists)
				{
					chbPlaylists.Items.Add(name.Replace(playlistpath, "").Replace(".lpl", ""), true);
				}
			}
			else
			{
				chbPlaylists.Visible = false;
				lblExplain.Visible = false;
				lblNoPlaylists.Visible = true;
				lblRALink.Visible = true;
				btnNext.Enabled = false;
			}
		}

		private void lblRALink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://docs.libretro.com/guides/import-content/");
		}

		private void tmrCheck_Tick(object sender, EventArgs e)
		{
			if (chbPlaylists.CheckedItems.Count == 0)
			{
				btnNext.Enabled = false;
			}
			else
			{
				btnNext.Enabled = true;
			}

			if (barProgress.Value == barProgress.Maximum)
			{
				tmrCheck.Enabled = false;
				this.Hide();
				Form frmComplete = new frmComplete();
				frmComplete.Closed += (s, args) => this.Close();
				frmComplete.Show();
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			Form frmAbout = new frmAbout();
			frmAbout.Show();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			chbPlaylists.Enabled = false;
			btnNext.Enabled = false;
			barProgress.Visible = true;
			barProgress.Value = 0;
			barProgress.Maximum = chbPlaylists.CheckedItems.Count;

			// Build dictionaries
			IDictionary<string, string> plugin_codes = new Dictionary<string, string>();
			plugin_codes.Add("The 3DO Company - 3DO", "3do_9d81c0ec-5646-4b1a-b809-e7e61e1d3577");
			plugin_codes.Add("Nintendo - Nintendo 3DS", "3ds_f6acd3ed-2c31-47d6-bae4-07b6714c1e55");
			plugin_codes.Add("Atari - 2600", "atari_830528d9-e621-48e9-8ed4-e03a4853843e");
			plugin_codes.Add("Sega - Dreamcast", "dc_5d181ffd-48dc-4330-aa58-6f646e76a5c8");
			plugin_codes.Add("Nintendo - Game Boy", "gb_4345afe1-a2c3-4c58-93d3-373c53a90a92");
			plugin_codes.Add("Atari - Jaguar", "jaguar_b9773549-9c20-4729-b23d-f683762ce73a");
			plugin_codes.Add("Nintendo - Nintendo 64", "n64_a3824d31-c2d3-4a1a-b321-7d0764da5513");
			plugin_codes.Add("Nintendo - GameCube", "ncube_602422b9-ced5-476e-911a-7fa0adf0f7f7");
			plugin_codes.Add("Nintendo - Nintendo DS", "nds_4704ed29-f516-4fd8-8477-ddbcdb7cedfc");
			plugin_codes.Add("Nintendo - Nintendo Entertainment System", "nes_e2c630e1-3cbe-4dbd-9235-5e6a2d2955ad");
			plugin_codes.Add("Nintendo - Wii", "nwii_2d0e97ac-0406-4e5f-a85b-ab5b1a042cba");
			plugin_codes.Add("NEC - PC Engine - TurboGrafx 16", "pce_c0ffd4b8-41c3-46b8-b0f7-5f4e4bafc68a");
			plugin_codes.Add("Sony - PlayStation", "ps1_ff02c67d-5962-4e79-a3a3-928814edb270");
			plugin_codes.Add("Sony - PlayStation 2", "ps2_50ad79eb-393c-4f95-98ce-59f095ae47ea");
			plugin_codes.Add("Sony - PlayStation Portable", "psp_05487532-ba29-411b-b799-784262d275bd");
			plugin_codes.Add("Sega - Saturn", "saturn_bd6ec091-8ee0-440a-9e26-71bbf21c05af");
			plugin_codes.Add("Sega - Mega-CD - Sega CD", "segacd_ec7197bf-a4e4-4b86-81b9-38ea7d56f3b2");
			plugin_codes.Add("Sega - Mega Drive - Genesis", "segag_e3ac94e7-945e-459d-bc1e-676cff8173f9");
			plugin_codes.Add("Sega - Master System - Mark III", "sms_c6689bfb-7ba4-4d24-98e3-bd2dc339926b");
			plugin_codes.Add("Nintendo - Super Nintendo Entertainment System", "snes_bc831044-f772-4391-8c22-529f42cb9799");

			IDictionary<string, string> core_codes = new Dictionary<string, string>();
			core_codes.Add("The 3DO Company - 3DO", "opera_libretro.dll");
			core_codes.Add("Nintendo - Nintendo 3DS", "citra_libretro.dll");
			core_codes.Add("Atari - 2600", "stella_libretro.dll");
			core_codes.Add("Sega - Dreamcast", "flycast_libretro.dll");
			core_codes.Add("Nintendo - Game Boy", "mgba_libretro.dll");
			core_codes.Add("Atari - Jaguar", "virtualjaguar_libretro.dll");
			core_codes.Add("Nintendo - Nintendo 64", "mupen64plus_next_libretro.dll");
			core_codes.Add("Nintendo - GameCube", "dolphin_libretro.dll");
			core_codes.Add("Nintendo - Nintendo DS", "desmume_libretro.dll");
			core_codes.Add("Nintendo - Nintendo Entertainment System", "mesen_libretro.dll");
			core_codes.Add("Nintendo - Wii", "dolphin_libretro.dll");
			core_codes.Add("NEC - PC Engine - TurboGrafx 16", "mednafen_pce_fast_libretro.dll");
			core_codes.Add("Sony - PlayStation", "pcsx_rearmed_libretro.dll");
			core_codes.Add("Sony - PlayStation 2", "play_libretro.dll");
			core_codes.Add("Sony - PlayStation Portable", "ppsspp_libretro.dll");
			core_codes.Add("Sega - Saturn", "mednafen_saturn_libretro.dll");
			core_codes.Add("Sega - Mega-CD - Sega CD", "genesis_plus_gx_libretro.dll");
			core_codes.Add("Sega - Mega Drive - Genesis", "genesis_plus_gx_libretro.dll");
			core_codes.Add("Sega - Master System - Mark III", "genesis_plus_gx_libretro.dll");
			core_codes.Add("Nintendo - Super Nintendo Entertainment System", "snes9x_libretro.dll");


			// Download latest galaxy API for plugins
			using (var client = new WebClient())
			{
				client.Headers.Add("user-agent", "RetroGOG");
				client.DownloadFile("https://raw.githubusercontent.com/jshackles/RetroGOG/master/galaxy_api.zip", Globals.GOGPluginPath + "\\galaxy_api.zip");
			}

			foreach (string item in chbPlaylists.CheckedItems)
			{
				// Create Plugin directory
				Directory.CreateDirectory(Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\");

				using (var client = new WebClient())
				{
					// Download Plugin from Github
					client.Headers.Add("user-agent", "RetroGOG");
					client.DownloadFile("https://raw.githubusercontent.com/jshackles/RetroGOG/master/plugins/" + plugin_codes[item] + "/manifest.json", Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\" + "manifest.json");
					client.DownloadFile("https://raw.githubusercontent.com/jshackles/RetroGOG/master/plugins/" + plugin_codes[item] + "/plugin.py", Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\" + "plugin.py");
					client.DownloadFile("https://raw.githubusercontent.com/jshackles/RetroGOG/master/plugins/" + plugin_codes[item] + "/version.py", Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\" + "version.py");

					// Download Galaxy API and decompress
					if (Directory.Exists(Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\galaxy\\"))
					{
						Directory.Delete(Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\galaxy\\", true);
					}
					System.IO.Compression.ZipFile.ExtractToDirectory(Globals.GOGPluginPath + "\\galaxy_api.zip", Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\galaxy\\");

					// Write user_config.py file
					string[] lines = new string[3];
					lines[0] = "# This file automatically generated by RetroGOG";
					lines[1] = "emu_path = \"" + Globals.RAPath.Replace("\\", "/").Replace("retroarch.exe", "") + "\"";
					if (File.Exists(Globals.RAPath.Replace("retroarch.exe", "cores\\") + core_codes[item]))
					{
						lines[2] = "core = \"" + core_codes[item] + "\"";
					}
					else
					{
						Form frmCoreSelect = new frmCoreSelect();
						frmCoreSelect.Text = item;
						frmCoreSelect.ShowDialog(this);
						lines[2] = "core = \"" + Globals.TempCore + "\"";
					}
					System.IO.File.WriteAllLines(Globals.GOGPluginPath + "\\" + plugin_codes[item] + "\\" + "user_config.py", lines);

					barProgress.Value = barProgress.Value + 1;
				}
			}
		}
	}
}
