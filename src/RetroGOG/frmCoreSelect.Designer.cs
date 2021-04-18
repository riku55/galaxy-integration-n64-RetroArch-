namespace RetroGOG
{
	partial class frmCoreSelect
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
			this.cboCore = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblConsoleName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cboCore
			// 
			this.cboCore.FormattingEnabled = true;
			this.cboCore.Location = new System.Drawing.Point(12, 47);
			this.cboCore.Name = "cboCore";
			this.cboCore.Size = new System.Drawing.Size(369, 21);
			this.cboCore.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(306, 74);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblConsoleName
			// 
			this.lblConsoleName.AutoSize = true;
			this.lblConsoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsoleName.Location = new System.Drawing.Point(9, 26);
			this.lblConsoleName.Name = "lblConsoleName";
			this.lblConsoleName.Size = new System.Drawing.Size(46, 18);
			this.lblConsoleName.TabIndex = 2;
			this.lblConsoleName.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Choose a core for";
			// 
			// frmCoreSelect
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 108);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblConsoleName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cboCore);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frmCoreSelect";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select Retroarch Plugin";
			this.Load += new System.EventHandler(this.frmCoreSelect_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboCore;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblConsoleName;
		private System.Windows.Forms.Label label1;
	}
}