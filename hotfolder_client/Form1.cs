using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace _hotfolder_client {
	public partial class Form1: System.Windows.Forms.Form {
		public Form1() {
			InitializeComponent();
			transmissions_list_view.Columns.Add("Source", -2);
			transmissions_list_view.Columns.Add("Destination", -2);
			transmissions_list_view.Columns.Add("FTP Server", -2);
			transmissions_list_view.Columns.Add("FTP Username", -2);
			transmissions_list_view.FullRowSelect = true;
			this.Refresh();
		}

		private void add_button_click(object sender, EventArgs e) {
			Form2 f = new Form2();
			f.Show();
		}

		private void remove_button_click(object sender, EventArgs e) {
			StreamWriter nsw = new StreamWriter(Program.ns);
			
			foreach(int i in transmissions_list_view.SelectedIndices) {
				try {
					nsw.Write($"r\u0004{i}\u0004");
					nsw.Flush();
				} catch {}
			}

			refresh_active_transfers();
		}

		private void refresh_button_click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;
			refresh_active_transfers();
			Cursor.Current = Cursors.Default;
		}

		private void connect_button_click(object sender, EventArgs e) {
			string msg, ex_msg;
			StreamWriter nsw;

			Cursor.Current = Cursors.WaitCursor;
			connect_label.Text = "Connecting...";
			connect_label.ForeColor = Color.FromName("MenuHighlight");
			this.Refresh();

			if(Program.connect(host_text_box.Text, int.Parse(port_text_box.Text), out ex_msg)) {
				Program.read_message(out msg); // TODO: Handle exceptions here.

				if(string.Compare(msg, "w") == 0) {
					connect_label.Text = $"Connection denied: server is still starting up.";
					connect_label.ForeColor = Color.FromName("Purple");
					this.Refresh();
				} else if(string.Compare(msg, "p") == 0) {
					// Send password.
					nsw = new StreamWriter(Program.ns);
					nsw.Write($"{password_text_box.Text}\u0004");
					nsw.Flush();

					// Recieve password validation message.
					Program.read_message(out msg);

					if(string.Compare(msg, "o") == 0) {
						connect_label.Text = $"Connected to {host_text_box.Text}:{port_text_box.Text}.";
						connect_label.ForeColor = Color.FromName("Green");
						add_button.Enabled = true;
						refresh_button.Enabled = true;
						this.Refresh();
						refresh_active_transfers();
					} else {
						connect_label.Text = "Connection denied: invalid password!";
						connect_label.ForeColor = Color.FromName("Red");
						this.Refresh();
					}
				} else {
					connect_label.Text = $"Connected to {host_text_box.Text}:{port_text_box.Text}.";
					connect_label.ForeColor = Color.FromName("Green");
					add_button.Enabled = true;
					refresh_button.Enabled = true;
					this.Refresh();
					refresh_active_transfers();
				}
			} else {
				connect_label.Text = ex_msg;
				connect_label.ForeColor = Color.FromName("Red");
				this.Refresh();
			}
			Cursor.Current = Cursors.Default;
		}

		public void refresh_active_transfers() {
			string msg = null;
			string[] msg_lines, args;
			ListViewItem item;
			StreamReader nsr = new StreamReader(Program.ns);
			StreamWriter nsw = new StreamWriter(Program.ns);

			transmissions_list_view.Items.Clear();

			nsw.Write("l\u0004");
			nsw.Flush();
			
			if(Program.read_message(out msg) == false) {
				connect_label.Text = "Connection broken unexpectedly.";
				connect_label.ForeColor = Color.FromName("Red");
				this.Refresh();
			}

			transmissions_list_view.BeginUpdate();
			msg_lines = msg.Split('\n');
			for(UInt32 i = 0; i < msg_lines.Length - 1; i++) {
				args = msg_lines[i].Split(' ');
				item = new ListViewItem(args[0], 0);
				item.SubItems.Add(args[1]);
				item.SubItems.Add(args[2]);
				item.SubItems.Add(args[3]);
				transmissions_list_view.Items.Add(item);
			}
			transmissions_list_view.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			transmissions_list_view.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			this.Refresh();
			transmissions_list_view.EndUpdate();
		}

		private void list_view_item_selection_changed(object sender, ListViewItemSelectionChangedEventArgs e) {
			if(transmissions_list_view.SelectedIndices.Count == 0) remove_button.Enabled = false;
			else remove_button.Enabled = true;
		}

		private void Form1_Load(object sender, EventArgs e) {

		}
	}
}
