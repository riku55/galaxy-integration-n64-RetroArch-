namespace RetroGOG
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnNext = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.lblWelcom = new System.Windows.Forms.Label();
			this.lblExplain = new System.Windows.Forms.Label();
			this.lblExplain2 = new System.Windows.Forms.Label();
			this.lblExplain3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(462, 343);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "&Next > >";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::RetroGOG.Properties.Resources.retroarch;
			this.pictureBox1.InitialImage = global::RetroGOG.Properties.Resources.retroarch;
			this.pictureBox1.Location = new System.Drawing.Point(12, 131);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(193, 192);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::RetroGOG.Properties.Resources.galaxy_logo;
			this.pictureBox2.Location = new System.Drawing.Point(425, 131);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(193, 192);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = global::RetroGOG.Properties.Resources.arrow;
			this.pictureBox3.Location = new System.Drawing.Point(211, 131);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(208, 134);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(543, 343);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(12, 343);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 23);
			this.btnAbout.TabIndex = 5;
			this.btnAbout.Text = "&About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// lblWelcom
			// 
			this.lblWelcom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWelcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcom.Location = new System.Drawing.Point(-2, 9);
			this.lblWelcom.Name = "lblWelcom";
			this.lblWelcom.Size = new System.Drawing.Size(630, 24);
			this.lblWelcom.TabIndex = 6;
			this.lblWelcom.Text = "Welcome to the RetroGOG Installation Wizard";
			this.lblWelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblExplain
			// 
			this.lblExplain.AutoSize = true;
			this.lblExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplain.Location = new System.Drawing.Point(12, 45);
			this.lblExplain.Name = "lblExplain";
			this.lblExplain.Size = new System.Drawing.Size(616, 18);
			this.lblExplain.TabIndex = 7;
			this.lblExplain.Text = "This wizard will guide you through the download, installation, and configuration " +
    "of RetroGOG.";
			// 
			// lblExplain2
			// 
			this.lblExplain2.AutoSize = true;
			this.lblExplain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplain2.Location = new System.Drawing.Point(12, 63);
			this.lblExplain2.Name = "lblExplain2";
			this.lblExplain2.Size = new System.Drawing.Size(536, 18);
			this.lblExplain2.TabIndex = 8;
			this.lblExplain2.Text = "RetroGOG allows you to play your Retroarch games directly in GOG Galaxy 2.0.";
			// 
			// lblExplain3
			// 
			this.lblExplain3.AutoSize = true;
			this.lblExplain3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplain3.Location = new System.Drawing.Point(12, 91);
			this.lblExplain3.Name = "lblExplain3";
			this.lblExplain3.Size = new System.Drawing.Size(158, 18);
			this.lblExplain3.TabIndex = 9;
			this.lblExplain3.Text = "To begin, press \"Next\".";
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnNext;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(630, 378);
			this.Controls.Add(this.lblExplain3);
			this.Controls.Add(this.lblExplain2);
			this.Controls.Add(this.lblExplain);
			this.Controls.Add(this.lblWelcom);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnNext);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RetroGOG";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Label lblWelcom;
		private System.Windows.Forms.Label lblExplain;
		private System.Windows.Forms.Label lblExplain2;
		private System.Windows.Forms.Label lblExplain3;
	}
}