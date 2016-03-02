using System;
using System.Drawing;
using System.Windows.Forms;
using TibiaReader;

namespace TibiaHUD.Controls
{
	public class CurveBar : Control
	{
		private TibiaClient tibia;
		private Timer updateTimer;

		private float health;
		private float mana;

		public CurveBar(TibiaClient tibia) {
			this.tibia = tibia;

			health = 1f;
			mana = 1f;

			Height = 300;
			Width = 300;

			updateTimer = new Timer();
			updateTimer.Interval = 100;
			updateTimer.Tick += updateTimer_Tick;
			updateTimer.Start();
		}

		private void updateTimer_Tick(object sender, EventArgs e) {
			health = (float)tibia.Health / tibia.MaxHealth;
			mana = (float)tibia.Mana / tibia.MaxMana;
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			
			Rectangle rect = this.DisplayRectangle;
			rect.Width -= 20;
			rect.X += 10;
			
			Pen pen = new Pen(Color.Black);
			pen.Width = 16;
			e.Graphics.DrawArc(pen, rect, 135, 90);
			e.Graphics.DrawArc(pen, rect, 45, -90);

			pen.Width = 14;

			int red = (int)(255 - (health * 255));
			int green = (int)(health * 255);
			pen.Color = Color.FromArgb(red, green, 0);
			e.Graphics.DrawArc(pen, rect, 135, 90 * health);

			pen.Color = Color.Blue;
			e.Graphics.DrawArc(pen, rect, 45, -90 * mana);
		}
	}
}
