namespace RetroGOG
{
	partial class frmComplete
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComplete));
			this.btnBack = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblExplain2 = new System.Windows.Forms.Label();
			this.lblExplain = new System.Windows.Forms.Label();
			this.lblWelcom = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
			this.btnCancel.Text = "&Finish";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblExplain2
			// 
			this.lblExplain2.AutoSize = true;
			this.lblExplain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplain2.Location = new System.Drawing.Point(13, 63);
			this.lblExplain2.Name = "lblExplain2";
			this.lblExplain2.Size = new System.Drawing.Size(430, 18);
			this.lblExplain2.TabIndex = 16;
			this.lblExplain2.Text = "Your configured plugins should now be available in GOG Galaxy.";
			// 
			// lblExplain
			// 
			this.lblExplain.AutoSize = true;
			this.lblExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExplain.Location = new System.Drawing.Point(13, 45);
			this.lblExplain.Name = "lblExplain";
			this.lblExplain.Size = new System.Drawing.Size(199, 18);
			this.lblExplain.TabIndex = 15;
			this.lblExplain.Text = "This wizard is now complete.";
			// 
			// lblWelcom
			// 
			this.lblWelcom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWelcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcom.Location = new System.Drawing.Point(-1, 9);
			this.lblWelcom.Name = "lblWelcom";
			this.lblWelcom.Size = new System.Drawing.Size(630, 24);
			this.lblWelcom.TabIndex = 14;
			this.lblWelcom.Text = "Thank you for using the RetroGOG Installation Wizard";
			this.lblWelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::RetroGOG.Properties.Resources.step_1;
			this.pictureBox1.InitialImage = global::RetroGOG.Properties.Resources.step_1;
			this.pictureBox1.Location = new System.Drawing.Point(12, 122);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(304, 215);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::RetroGOG.Properties.Resources.step_2;
			this.pictureBox2.Location = new System.Drawing.Point(64, 122);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(554, 215);
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 18);
			this.label1.TabIndex = 19;
			this.label1.Text = "If GOG Galaxy 2.0 is already running, please re-start it.";
			// 
			// frmComplete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 378);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblExplain2);
			this.Controls.Add(this.lblExplain);
			this.Controls.Add(this.lblWelcom);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmComplete";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RetroGOG";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblExplain2;
		private System.Windows.Forms.Label lblExplain;
		private System.Windows.Forms.Label lblWelcom;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
	}
}