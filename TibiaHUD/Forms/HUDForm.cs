using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TibiaReader;
using TibiaHUD.Controls;

namespace TibiaHUD.Forms
{
	public partial class HUDForm : Form
	{
		private const int WS_EX_Transparent = 0x20;
		private const int WS_EX_Layered = 0x80000;
		private const int WS_EX_Composited = 0x02000000;

		private TibiaClient tibia;
		private CurveBar hpManaBar;
		
		[StructLayout(LayoutKind.Sequential)]
		private struct RECT
		{
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;
		}
		
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		public HUDForm(TibiaClient tibia) {
			this.tibia = tibia;
			InitializeComponent();
			
			BackColor = Constants.TransparencyKey;
			TransparencyKey = Constants.TransparencyKey;

			hpManaBar = new CurveBar(tibia) {
				Top = 280
			};

			Controls.Add(hpManaBar);

			updateTimer.Start();
		}

		protected override CreateParams CreateParams {
			get {
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= WS_EX_Composited | WS_EX_Transparent | WS_EX_Layered;
				return cp;
			}
		}

		private void updateTimer_Tick(object sender, EventArgs e) {
			// Find Tibia window and move form to the same position and resize it to fit the window
			IntPtr hWnd = tibia.Process.MainWindowHandle;
			RECT rect;
			GetWindowRect(hWnd, out rect);
			if (rect.Left == -32000 || GetForegroundWindow() != hWnd) {
				this.WindowState = FormWindowState.Minimized;
			} else {
				this.WindowState = FormWindowState.Normal;
				this.Location = new Point(rect.Left + 10, rect.Top);
				this.Width = rect.Right - rect.Left - 20;
				this.Height = rect.Bottom - rect.Top - 10;
			}

			hpManaBar.Left = ((this.Width - 175) / 2) - (hpManaBar.Width / 2) - 15;
		}
	}
}
