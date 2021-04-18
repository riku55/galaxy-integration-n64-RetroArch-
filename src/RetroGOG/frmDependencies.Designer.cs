namespace RetroGOG
{
	partial class frmDependencies
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDependencies));
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblExplain = new System.Windows.Forms.Label();
			this.imgRetroStatus = new System.Windows.Forms.PictureBox();
			this.imgGOGStatus = new System.Windows.Forms.PictureBox();
			this.lblRetroStatus = new System.Windows.Forms.Label();
			this.lblGOGStatus = new System.Windows.Forms.Label();
			this.lblRetroBrowse = new System.Windows.Forms.Label();
			this.txtRetroPath = new System.Windows.Forms.TextBox();
			this.btnRetroBrowse = new System.Windows.Forms.Button();
			this.tmrCheck = new System.Windows.Forms.Timer(this.components);
			this.btnDownloadGOG = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgRetroStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgGOGStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(12, 343);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 23);
			this.btnAbout.TabIndex = 8;
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
			this.btnCancel.TabIndex = 7;
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
			this.btnNext.TabIndex = 6;
			this.btnNext.Text = "&Next > >";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnBack.Location = new System.Drawing.Point(93, 343);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "< < &Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::RetroGOG.Properties.Resources.galaxy_logo;
			this.pictureBox2.Location = new System.Drawing.Point(39, 39);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 48);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::RetroGOG.Properties.Resources.retroarch;
			this.pictureBox1.InitialImage = global::RetroGOG.Properties.Resources.retroarch;
			this.pictureBox1.Location = new System.Drawing.Point(39, 93);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// lblExplain
			// 
			this.lblExplain.AutoSize = true;
			this.lblExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplain.Location = new System.Drawing.Point(9, 9);
			this.lblExplain.Name = "lblExplain";
			this.lblExplain.Size = new System.Drawing.Size(500, 18);
			this.lblExplain.TabIndex = 13;
			this.lblExplain.Text = "Please wait while we look for your Retroarch and GOG Galaxy applications";
			// 
			// imgRetroStatus
			// 
			this.imgRetroStatus.Location = new System.Drawing.Point(93, 100);
			this.imgRetroStatus.Name = "imgRetroStatus";
			this.imgRetroStatus.Size = new System.Drawing.Size(32, 32);
			this.imgRetroStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgRetroStatus.TabIndex = 14;
			this.imgRetroStatus.TabStop = false;
			// 
			// imgGOGStatus
			// 
			this.imgGOGStatus.Location = new System.Drawing.Point(93, 46);
			this.imgGOGStatus.Name = "imgGOGStatus";
			this.imgGOGStatus.Size = new System.Drawing.Size(32, 32);
			this.imgGOGStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgGOGStatus.TabIndex = 15;
			this.imgGOGStatus.TabStop = false;
			// 
			// lblRetroStatus
			// 
			this.lblRetroStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRetroStatus.Location = new System.Drawing.Point(131, 109);
			this.lblRetroStatus.Name = "lblRetroStatus";
			this.lblRetroStatus.Size = new System.Drawing.Size(487, 23);
			this.lblRetroStatus.TabIndex = 16;
			// 
			// lblGOGStatus
			// 
			this.lblGOGStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGOGStatus.Location = new System.Drawing.Point(131, 55);
			this.lblGOGStatus.Name = "lblGOGStatus";
			this.lblGOGStatus.Size = new System.Drawing.Size(487, 23);
			this.lblGOGStatus.TabIndex = 17;
			// 
			// lblRetroBrowse
			// 
			this.lblRetroBrowse.AutoSize = true;
			this.lblRetroBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRetroBrowse.Location = new System.Drawing.Point(90, 182);
			this.lblRetroBrowse.Name = "lblRetroBrowse";
			this.lblRetroBrowse.Size = new System.Drawing.Size(343, 18);
			this.lblRetroBrowse.TabIndex = 18;
			this.lblRetroBrowse.Text = "Please enter the path to your Retroarch installation:";
			this.lblRetroBrowse.Visible = false;
			// 
			// txtRetroPath
			// 
			this.txtRetroPath.Enabled = false;
			this.txtRetroPath.Location = new System.Drawing.Point(93, 203);
			this.txtRetroPath.Name = "txtRetroPath";
			this.txtRetroPath.Size = new System.Drawing.Size(444, 20);
			this.txtRetroPath.TabIndex = 19;
			this.txtRetroPath.Visible = false;
			// 
			// btnRetroBrowse
			// 
			this.btnRetroBrowse.Location = new System.Drawing.Point(543, 200);
			this.btnRetroBrowse.Name = "btnRetroBrowse";
			this.btnRetroBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnRetroBrowse.TabIndex = 20;
			this.btnRetroBrowse.Text = "B&rowse";
			this.btnRetroBrowse.UseVisualStyleBackColor = true;
			this.btnRetroBrowse.Visible = false;
			this.btnRetroBrowse.Click += new System.EventHandler(this.btnRetroBrowse_Click);
			// 
			// tmrCheck
			// 
			this.tmrCheck.Enabled = true;
			this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
			// 
			// btnDownloadGOG
			// 
			this.btnDownloadGOG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDownloadGOG.Image = global::RetroGOG.Properties.Resources.downloadgog;
			this.btnDownloadGOG.Location = new System.Drawing.Point(50, 272);
			this.btnDownloadGOG.Name = "btnDownloadGOG";
			this.btnDownloadGOG.Size = new System.Drawing.Size(534, 54);
			this.btnDownloadGOG.TabIndex = 21;
			this.btnDownloadGOG.UseVisualStyleBackColor = true;
			this.btnDownloadGOG.Visible = false;
			this.btnDownloadGOG.Click += new System.EventHandler(this.btnDownloadGOG_Click);
			// 
			// frmDependencies
			// 
			this.AcceptButton = this.btnNext;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnBack;
			this.ClientSize = new System.Drawing.Size(630, 378);
			this.Controls.Add(this.btnDownloadGOG);
			this.Controls.Add(this.btnRetroBrowse);
			this.Controls.Add(this.txtRetroPath);
			this.Controls.Add(this.lblRetroBrowse);
			this.Controls.Add(this.lblGOGStatus);
			this.Controls.Add(this.lblRetroStatus);
			this.Controls.Add(this.imgGOGStatus);
			this.Controls.Add(this.imgRetroStatus);
			this.Controls.Add(this.lblExplain);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnNext);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmDependencies";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RetroGOG";
			this.Load += new System.EventHandler(this.frmDependencies_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgRetroStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgGOGStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblExplain;
		private System.Windows.Forms.PictureBox imgRetroStatus;
		private System.Windows.Forms.PictureBox imgGOGStatus;
		private System.Windows.Forms.Label lblRetroStatus;
		private System.Windows.Forms.Label lblGOGStatus;
		private System.Windows.Forms.Label lblRetroBrowse;
		private System.Windows.Forms.TextBox txtRetroPath;
		private System.Windows.Forms.Button btnRetroBrowse;
		private System.Windows.Forms.Timer tmrCheck;
		private System.Windows.Forms.Button btnDownloadGOG;
	}
}