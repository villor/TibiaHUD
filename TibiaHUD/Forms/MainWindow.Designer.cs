namespace TibiaHUD.Forms
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.clientCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// clientCombo
			// 
			this.clientCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.clientCombo.FormattingEnabled = true;
			this.clientCombo.Items.AddRange(new object[] {
			"Disabled"});
			this.clientCombo.Location = new System.Drawing.Point(12, 12);
			this.clientCombo.Name = "clientCombo";
			this.clientCombo.Size = new System.Drawing.Size(230, 21);
			this.clientCombo.TabIndex = 0;
			this.clientCombo.SelectedIndexChanged += new System.EventHandler(this.clientCombo_SelectedIndexChanged);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 47);
			this.Controls.Add(this.clientCombo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "TibiaHUD";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox clientCombo;
	}
}

