using System;
using System.Windows.Forms;
using TibiaReader;

namespace TibiaHUD.Forms
{
	public partial class MainWindow : Form
	{
		HUDForm hudForm;

		public MainWindow() {
			InitializeComponent();

			foreach (var client in TibiaClient.GetClients()) {
				clientCombo.Items.Add(client);
			}

			clientCombo.SelectedIndex = 0;
		}

		private void clientCombo_SelectedIndexChanged(object sender, EventArgs e) {
			if (clientCombo.SelectedIndex > 0) {
				hudForm = new HUDForm((TibiaClient)clientCombo.Items[clientCombo.SelectedIndex]);
				hudForm.Show();
			} else if (hudForm != null) {
				hudForm.Close();
				hudForm = null;
			}
		}
	}
}
