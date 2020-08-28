namespace RetroGOG
{
	partial class frmPluginSelect
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPluginSelect));
			this.btnBack = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.chbPlaylists = new System.Windows.Forms.CheckedListBox();
			this.lblNoPlaylists = new System.Windows.Forms.Label();
			this.lblRALink = new System.Windows.Forms.LinkLabel();
			this.lblExplain = new System.Windows.Forms.Label();
			this.tmrCheck = new System.Windows.Forms.Timer(this.components);
			this.barProgress = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnBack.Location = new System.Drawing.Point(93, 343);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 13;
			this.btnBack.Text = "< < &Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(12, 343);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 23);
			this.btnAbout.TabIndex = 12;
			this.btnAbout.Text = "&About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(543, 343);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnNext
			// 
			this.btnNext.Enabled = false;
			this.btnNext.Location = new System.Drawing.Point(462, 343);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 10;
			this.btnNext.Text = "&Next > >";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// chbPlaylists
			// 
			this.chbPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbPlaylists.FormattingEnabled = true;
			this.chbPlaylists.Location = new System.Drawing.Point(12, 37);
			this.chbPlaylists.Name = "chbPlaylists";
			this.chbPlaylists.Size = new System.Drawing.Size(606, 270);
			this.chbPlaylists.TabIndex = 16;
			// 
			// lblNoPlaylists
			// 
			this.lblNoPlaylists.AutoSize = true;
			this.lblNoPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoPlaylists.Location = new System.Drawing.Point(12, 9);
			this.lblNoPlaylists.Name = "lblNoPlaylists";
			this.lblNoPlaylists.Size = new System.Drawing.Size(446, 18);
			this.lblNoPlaylists.TabIndex = 17;
			this.lblNoPlaylists.Text = "No Playlists found in Retroarch directory!  Please read instructions ";
			this.lblNoPlaylists.Visible = false;
			// 
			// lblRALink
			// 
			this.lblRALink.AutoSize = true;
			this.lblRALink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRALink.Location = new System.Drawing.Point(455, 9);
			this.lblRALink.Name = "lblRALink";
			this.lblRALink.Size = new System.Drawing.Size(50, 18);
			this.lblRALink.TabIndex = 18;
			this.lblRALink.TabStop = true;
			this.lblRALink.Text = "HERE";
			this.lblRALink.Visible = false;
			this.lblRALink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRALink_LinkClicked);
			// 
			// lblExplain
			// 
			this.lblExplain.AutoSize = true;
			this.lblExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplain.Location = new System.Drawing.Point(12, 9);
			this.lblExplain.Name = "lblExplain";
			this.lblExplain.Size = new System.Drawing.Size(454, 18);
			this.lblExplain.TabIndex = 19;
			this.lblExplain.Text = "Please select which systems you would like RetroGOG to configure";
			// 
			// tmrCheck
			// 
			this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
			// 
			// barProgress
			// 
			this.barProgress.Location = new System.Drawing.Point(12, 314);
			this.barProgress.Name = "barProgress";
			this.barProgress.Size = new System.Drawing.Size(606, 23);
			this.barProgress.TabIndex = 20;
			this.barProgress.Visible = false;
			// 
			// frmPluginSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 378);
			this.Controls.Add(this.barProgress);
			this.Controls.Add(this.lblExplain);
			this.Controls.Add(this.lblRALink);
			this.Controls.Add(this.lblNoPlaylists);
			this.Controls.Add(this.chbPlaylists);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnNext);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPluginSelect";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RetroGOG";
			this.Load += new System.EventHandler(this.frmPluginSelect_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.CheckedListBox chbPlaylists;
		private System.Windows.Forms.Label lblNoPlaylists;
		private System.Windows.Forms.LinkLabel lblRALink;
		private System.Windows.Forms.Label lblExplain;
		private System.Windows.Forms.Timer tmrCheck;
		private System.Windows.Forms.ProgressBar barProgress;
	}
}