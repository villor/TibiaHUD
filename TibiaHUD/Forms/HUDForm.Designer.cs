namespace TibiaHUD.Forms
{
	partial class HUDForm
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
			this.components = new System.ComponentModel.Container();
			this.updateTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// updateTimer
			// 
			this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
			// 
			// HUDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(10, 10);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "HUDForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "HUDForm";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.HUDForm_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer updateTimer;
	}
}