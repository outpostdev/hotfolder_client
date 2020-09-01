using System;
using System.Windows.Forms;
using System.IO;

namespace _hotfolder_client {
	public partial class Form2: Form {
		public Form2() {
			InitializeComponent();
		}

		private void ok_button_click(object sender, EventArgs e) {
			StreamWriter nsw = new StreamWriter(Program.ns);
			string msg = null;

			// TODO: Handle filenames with spaces.

			// Build message.
			msg += $"-source {source_text_box.Text}";
			if(ftp_checkbox.Checked) {
				msg += $" -destination ftp:{destination_text_box.Text}";
			} else {
				msg += $" -destination {destination_text_box.Text}";
			}
			if(resize_checkbox.Checked) {
				if(thumb_checkbox.Checked) msg += " -mode thumb";
				else msg += " -mode resize";
				msg += $" -width {width_text_box.Text} -height {height_text_box.Text}";
			}
			if(ftp_checkbox.Checked) msg += $" -ftpserver {hostname_text_box.Text} -ftpuser {username_text_box.Text} -ftppass {password_text_box.Text}";

			// Send message.
			nsw.Write($"a\u0004{msg}\u0004");
			nsw.Flush();
			
			// Refresh view list and close form.
			Program.main_form.refresh_active_transfers();
			Close();
		}

		private void resize_checkbox_checked_state_changed(object sender, EventArgs e) {
			resize_panel.Enabled = !resize_panel.Enabled;
		}

		private void ftp_checkbox_check_state_changed(object sender, EventArgs e) {
			ftp_panel.Enabled = !ftp_panel.Enabled;
		}

		private void Form2_Load(object sender, EventArgs e) {

		}
	}
}
