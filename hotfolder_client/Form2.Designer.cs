namespace _hotfolder_client {
	partial class Form2 {
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
			this.source_text_box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.destination_text_box = new System.Windows.Forms.TextBox();
			this.ftp_panel = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.password_text_box = new System.Windows.Forms.TextBox();
			this.username_text_box = new System.Windows.Forms.TextBox();
			this.hostname_text_box = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ftp_checkbox = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.resize_panel = new System.Windows.Forms.Panel();
			this.thumb_checkbox = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.height_text_box = new System.Windows.Forms.TextBox();
			this.width_text_box = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.resize_checkbox = new System.Windows.Forms.CheckBox();
			this.ftp_panel.SuspendLayout();
			this.resize_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// source_text_box
			// 
			this.source_text_box.Location = new System.Drawing.Point(124, 12);
			this.source_text_box.Name = "source_text_box";
			this.source_text_box.Size = new System.Drawing.Size(121, 20);
			this.source_text_box.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Source directory:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Destination directory:";
			// 
			// destination_text_box
			// 
			this.destination_text_box.Location = new System.Drawing.Point(124, 38);
			this.destination_text_box.Name = "destination_text_box";
			this.destination_text_box.Size = new System.Drawing.Size(121, 20);
			this.destination_text_box.TabIndex = 3;
			// 
			// ftp_panel
			// 
			this.ftp_panel.Controls.Add(this.label6);
			this.ftp_panel.Controls.Add(this.label5);
			this.ftp_panel.Controls.Add(this.password_text_box);
			this.ftp_panel.Controls.Add(this.username_text_box);
			this.ftp_panel.Controls.Add(this.hostname_text_box);
			this.ftp_panel.Controls.Add(this.label4);
			this.ftp_panel.Enabled = false;
			this.ftp_panel.Location = new System.Drawing.Point(15, 196);
			this.ftp_panel.Name = "ftp_panel";
			this.ftp_panel.Size = new System.Drawing.Size(236, 82);
			this.ftp_panel.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "FTP password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "FTP username:";
			// 
			// password_text_box
			// 
			this.password_text_box.Location = new System.Drawing.Point(109, 57);
			this.password_text_box.Name = "password_text_box";
			this.password_text_box.Size = new System.Drawing.Size(121, 20);
			this.password_text_box.TabIndex = 9;
			this.password_text_box.UseSystemPasswordChar = true;
			// 
			// username_text_box
			// 
			this.username_text_box.Location = new System.Drawing.Point(109, 31);
			this.username_text_box.Name = "username_text_box";
			this.username_text_box.Size = new System.Drawing.Size(121, 20);
			this.username_text_box.TabIndex = 2;
			// 
			// hostname_text_box
			// 
			this.hostname_text_box.Location = new System.Drawing.Point(109, 4);
			this.hostname_text_box.Name = "hostname_text_box";
			this.hostname_text_box.Size = new System.Drawing.Size(121, 20);
			this.hostname_text_box.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "FTP hostname:";
			// 
			// ftp_checkbox
			// 
			this.ftp_checkbox.AutoSize = true;
			this.ftp_checkbox.Location = new System.Drawing.Point(12, 173);
			this.ftp_checkbox.Name = "ftp_checkbox";
			this.ftp_checkbox.Size = new System.Drawing.Size(68, 17);
			this.ftp_checkbox.TabIndex = 7;
			this.ftp_checkbox.Text = "Use FTP";
			this.ftp_checkbox.UseVisualStyleBackColor = true;
			this.ftp_checkbox.CheckStateChanged += new System.EventHandler(this.ftp_checkbox_check_state_changed);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 281);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ok_button_click);
			// 
			// resize_panel
			// 
			this.resize_panel.Controls.Add(this.thumb_checkbox);
			this.resize_panel.Controls.Add(this.label8);
			this.resize_panel.Controls.Add(this.height_text_box);
			this.resize_panel.Controls.Add(this.width_text_box);
			this.resize_panel.Controls.Add(this.label9);
			this.resize_panel.Enabled = false;
			this.resize_panel.Location = new System.Drawing.Point(15, 89);
			this.resize_panel.Name = "resize_panel";
			this.resize_panel.Size = new System.Drawing.Size(236, 78);
			this.resize_panel.TabIndex = 10;
			// 
			// thumb_checkbox
			// 
			this.thumb_checkbox.AutoSize = true;
			this.thumb_checkbox.Location = new System.Drawing.Point(6, 58);
			this.thumb_checkbox.Name = "thumb_checkbox";
			this.thumb_checkbox.Size = new System.Drawing.Size(168, 17);
			this.thumb_checkbox.TabIndex = 12;
			this.thumb_checkbox.Text = "Append \"_thumb\" to filename.";
			this.thumb_checkbox.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Height";
			// 
			// height_text_box
			// 
			this.height_text_box.Location = new System.Drawing.Point(109, 31);
			this.height_text_box.Name = "height_text_box";
			this.height_text_box.Size = new System.Drawing.Size(121, 20);
			this.height_text_box.TabIndex = 2;
			// 
			// width_text_box
			// 
			this.width_text_box.Location = new System.Drawing.Point(109, 4);
			this.width_text_box.Name = "width_text_box";
			this.width_text_box.Size = new System.Drawing.Size(121, 20);
			this.width_text_box.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Width:";
			// 
			// resize_checkbox
			// 
			this.resize_checkbox.AutoSize = true;
			this.resize_checkbox.Location = new System.Drawing.Point(12, 66);
			this.resize_checkbox.Name = "resize_checkbox";
			this.resize_checkbox.Size = new System.Drawing.Size(58, 17);
			this.resize_checkbox.TabIndex = 11;
			this.resize_checkbox.Text = "Resize";
			this.resize_checkbox.UseVisualStyleBackColor = true;
			this.resize_checkbox.CheckedChanged += new System.EventHandler(this.resize_checkbox_checked_state_changed);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 309);
			this.Controls.Add(this.resize_checkbox);
			this.Controls.Add(this.resize_panel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ftp_checkbox);
			this.Controls.Add(this.ftp_panel);
			this.Controls.Add(this.destination_text_box);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.source_text_box);
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Text = "Add new transfer";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ftp_panel.ResumeLayout(false);
			this.ftp_panel.PerformLayout();
			this.resize_panel.ResumeLayout(false);
			this.resize_panel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox source_text_box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox destination_text_box;
		private System.Windows.Forms.Panel ftp_panel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox password_text_box;
		private System.Windows.Forms.TextBox username_text_box;
		private System.Windows.Forms.TextBox hostname_text_box;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox ftp_checkbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel resize_panel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox height_text_box;
		private System.Windows.Forms.TextBox width_text_box;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox resize_checkbox;
		private System.Windows.Forms.CheckBox thumb_checkbox;
	}
}