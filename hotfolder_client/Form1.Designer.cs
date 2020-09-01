namespace _hotfolder_client {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
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
			this.add_button = new System.Windows.Forms.Button();
			this.remove_button = new System.Windows.Forms.Button();
			this.transmissions_list_view = new System.Windows.Forms.ListView();
			this.connect_button = new System.Windows.Forms.Button();
			this.connect_label = new System.Windows.Forms.Label();
			this.host_text_box = new System.Windows.Forms.TextBox();
			this.port_text_box = new System.Windows.Forms.TextBox();
			this.host_label = new System.Windows.Forms.Label();
			this.port_label = new System.Windows.Forms.Label();
			this.password_label = new System.Windows.Forms.Label();
			this.password_text_box = new System.Windows.Forms.TextBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.refresh_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// add_button
			// 
			this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.add_button.Enabled = false;
			this.add_button.Location = new System.Drawing.Point(697, 526);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(75, 23);
			this.add_button.TabIndex = 0;
			this.add_button.Text = "Add...";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.add_button_click);
			// 
			// remove_button
			// 
			this.remove_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.remove_button.Enabled = false;
			this.remove_button.Location = new System.Drawing.Point(616, 526);
			this.remove_button.Name = "remove_button";
			this.remove_button.Size = new System.Drawing.Size(75, 23);
			this.remove_button.TabIndex = 1;
			this.remove_button.Text = "Remove";
			this.remove_button.UseVisualStyleBackColor = true;
			this.remove_button.Click += new System.EventHandler(this.remove_button_click);
			// 
			// transmissions_list_view
			// 
			this.transmissions_list_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.transmissions_list_view.ForeColor = System.Drawing.SystemColors.Desktop;
			this.transmissions_list_view.HideSelection = false;
			this.transmissions_list_view.Location = new System.Drawing.Point(12, 41);
			this.transmissions_list_view.Name = "transmissions_list_view";
			this.transmissions_list_view.Size = new System.Drawing.Size(760, 479);
			this.transmissions_list_view.TabIndex = 2;
			this.transmissions_list_view.UseCompatibleStateImageBehavior = false;
			this.transmissions_list_view.View = System.Windows.Forms.View.Details;
			this.transmissions_list_view.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_view_item_selection_changed);
			// 
			// connect_button
			// 
			this.connect_button.Location = new System.Drawing.Point(465, 11);
			this.connect_button.Name = "connect_button";
			this.connect_button.Size = new System.Drawing.Size(75, 23);
			this.connect_button.TabIndex = 3;
			this.connect_button.Text = "Connect...";
			this.connect_button.UseVisualStyleBackColor = true;
			this.connect_button.Click += new System.EventHandler(this.connect_button_click);
			// 
			// connect_label
			// 
			this.connect_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.connect_label.ForeColor = System.Drawing.SystemColors.GrayText;
			this.connect_label.Location = new System.Drawing.Point(546, 16);
			this.connect_label.Name = "connect_label";
			this.connect_label.Size = new System.Drawing.Size(226, 13);
			this.connect_label.TabIndex = 4;
			this.connect_label.Text = "Not connected";
			// 
			// host_text_box
			// 
			this.host_text_box.Location = new System.Drawing.Point(50, 13);
			this.host_text_box.Name = "host_text_box";
			this.host_text_box.Size = new System.Drawing.Size(100, 20);
			this.host_text_box.TabIndex = 5;
			// 
			// port_text_box
			// 
			this.port_text_box.Location = new System.Drawing.Point(191, 13);
			this.port_text_box.Name = "port_text_box";
			this.port_text_box.Size = new System.Drawing.Size(100, 20);
			this.port_text_box.TabIndex = 6;
			this.port_text_box.Text = "1234";
			// 
			// host_label
			// 
			this.host_label.AutoSize = true;
			this.host_label.Location = new System.Drawing.Point(12, 16);
			this.host_label.Name = "host_label";
			this.host_label.Size = new System.Drawing.Size(32, 13);
			this.host_label.TabIndex = 7;
			this.host_label.Text = "Host:";
			// 
			// port_label
			// 
			this.port_label.AutoSize = true;
			this.port_label.Location = new System.Drawing.Point(156, 16);
			this.port_label.Name = "port_label";
			this.port_label.Size = new System.Drawing.Size(29, 13);
			this.port_label.TabIndex = 8;
			this.port_label.Text = "Port:";
			// 
			// password_label
			// 
			this.password_label.AutoSize = true;
			this.password_label.Location = new System.Drawing.Point(297, 16);
			this.password_label.Name = "password_label";
			this.password_label.Size = new System.Drawing.Size(56, 13);
			this.password_label.TabIndex = 9;
			this.password_label.Text = "Password:";
			// 
			// password_text_box
			// 
			this.password_text_box.Location = new System.Drawing.Point(359, 13);
			this.password_text_box.Name = "password_text_box";
			this.password_text_box.Size = new System.Drawing.Size(100, 20);
			this.password_text_box.TabIndex = 10;
			this.password_text_box.UseSystemPasswordChar = true;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// refresh_button
			// 
			this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.refresh_button.Enabled = false;
			this.refresh_button.Location = new System.Drawing.Point(535, 526);
			this.refresh_button.Name = "refresh_button";
			this.refresh_button.Size = new System.Drawing.Size(75, 23);
			this.refresh_button.TabIndex = 11;
			this.refresh_button.Text = "Refresh";
			this.refresh_button.UseVisualStyleBackColor = true;
			this.refresh_button.Click += new System.EventHandler(this.refresh_button_click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.refresh_button);
			this.Controls.Add(this.password_text_box);
			this.Controls.Add(this.password_label);
			this.Controls.Add(this.port_label);
			this.Controls.Add(this.host_label);
			this.Controls.Add(this.port_text_box);
			this.Controls.Add(this.host_text_box);
			this.Controls.Add(this.connect_label);
			this.Controls.Add(this.connect_button);
			this.Controls.Add(this.transmissions_list_view);
			this.Controls.Add(this.remove_button);
			this.Controls.Add(this.add_button);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Name = "Form1";
			this.Text = "Hotfolder Client";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Button remove_button;
		private System.Windows.Forms.ListView transmissions_list_view;
		private System.Windows.Forms.Button connect_button;
		private System.Windows.Forms.Label connect_label;
		private System.Windows.Forms.TextBox host_text_box;
		private System.Windows.Forms.TextBox port_text_box;
		private System.Windows.Forms.Label host_label;
		private System.Windows.Forms.Label port_label;
		private System.Windows.Forms.Label password_label;
		private System.Windows.Forms.TextBox password_text_box;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button refresh_button;
	}
}

