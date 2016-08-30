/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 24/08/2016
 * Time: 10:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace YASF
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Label usrLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox passTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button abtCancelButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button unhideButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox folderListBox;
		private System.Windows.Forms.Button APCancelButton;
		private System.Windows.Forms.Button APOKButton;
		private System.Windows.Forms.TextBox addPassTextBox2;
		private System.Windows.Forms.TextBox addPassTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.loginLabel = new System.Windows.Forms.Label();
			this.usrLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.passTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.addButton = new System.Windows.Forms.Button();
			this.unhideButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.folderListBox = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.APCancelButton = new System.Windows.Forms.Button();
			this.APOKButton = new System.Windows.Forms.Button();
			this.addPassTextBox2 = new System.Windows.Forms.TextBox();
			this.addPassTextBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.abtCancelButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(699, 430);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.loginLabel);
			this.tabPage1.Controls.Add(this.usrLabel);
			this.tabPage1.Controls.Add(this.cancelButton);
			this.tabPage1.Controls.Add(this.loginButton);
			this.tabPage1.Controls.Add(this.passTextBox);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(691, 401);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// loginLabel
			// 
			this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.loginLabel.Location = new System.Drawing.Point(265, 68);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(100, 23);
			this.loginLabel.TabIndex = 5;
			// 
			// usrLabel
			// 
			this.usrLabel.ForeColor = System.Drawing.Color.Maroon;
			this.usrLabel.Location = new System.Drawing.Point(643, 3);
			this.usrLabel.Name = "usrLabel";
			this.usrLabel.Size = new System.Drawing.Size(40, 23);
			this.usrLabel.TabIndex = 4;
			this.usrLabel.Text = "About";
			this.usrLabel.Click += new System.EventHandler(this.UsrLabelClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(499, 156);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(418, 156);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButtonClick);
			// 
			// passTextBox
			// 
			this.passTextBox.Location = new System.Drawing.Point(114, 119);
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.Size = new System.Drawing.Size(460, 20);
			this.passTextBox.TabIndex = 1;
			this.passTextBox.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(39, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Passwords: ";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.addButton);
			this.tabPage2.Controls.Add(this.unhideButton);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.folderListBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(691, 401);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(610, 43);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Add Folder";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// unhideButton
			// 
			this.unhideButton.Location = new System.Drawing.Point(610, 72);
			this.unhideButton.Name = "unhideButton";
			this.unhideButton.Size = new System.Drawing.Size(75, 23);
			this.unhideButton.TabIndex = 2;
			this.unhideButton.Text = "Unhide";
			this.unhideButton.UseVisualStyleBackColor = true;
			this.unhideButton.Click += new System.EventHandler(this.UnhideButtonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Hidden Folders: ";
			// 
			// folderListBox
			// 
			this.folderListBox.FormattingEnabled = true;
			this.folderListBox.Location = new System.Drawing.Point(8, 43);
			this.folderListBox.Name = "folderListBox";
			this.folderListBox.Size = new System.Drawing.Size(594, 342);
			this.folderListBox.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.APCancelButton);
			this.tabPage3.Controls.Add(this.APOKButton);
			this.tabPage3.Controls.Add(this.addPassTextBox2);
			this.tabPage3.Controls.Add(this.addPassTextBox1);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(691, 401);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Settings";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// APCancelButton
			// 
			this.APCancelButton.Location = new System.Drawing.Point(463, 189);
			this.APCancelButton.Name = "APCancelButton";
			this.APCancelButton.Size = new System.Drawing.Size(75, 23);
			this.APCancelButton.TabIndex = 5;
			this.APCancelButton.Text = "Cancel";
			this.APCancelButton.UseVisualStyleBackColor = true;
			this.APCancelButton.Click += new System.EventHandler(this.APCancelButtonClick);
			// 
			// APOKButton
			// 
			this.APOKButton.Location = new System.Drawing.Point(544, 189);
			this.APOKButton.Name = "APOKButton";
			this.APOKButton.Size = new System.Drawing.Size(75, 23);
			this.APOKButton.TabIndex = 4;
			this.APOKButton.Text = "OK";
			this.APOKButton.UseVisualStyleBackColor = true;
			this.APOKButton.Click += new System.EventHandler(this.APOKButtonClick);
			// 
			// addPassTextBox2
			// 
			this.addPassTextBox2.Location = new System.Drawing.Point(160, 135);
			this.addPassTextBox2.Name = "addPassTextBox2";
			this.addPassTextBox2.Size = new System.Drawing.Size(460, 20);
			this.addPassTextBox2.TabIndex = 3;
			this.addPassTextBox2.UseSystemPasswordChar = true;
			// 
			// addPassTextBox1
			// 
			this.addPassTextBox1.Location = new System.Drawing.Point(160, 92);
			this.addPassTextBox1.Name = "addPassTextBox1";
			this.addPassTextBox1.Size = new System.Drawing.Size(460, 20);
			this.addPassTextBox1.TabIndex = 2;
			this.addPassTextBox1.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(54, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Confirm Passwords: ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(54, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Enter Passwords: ";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.abtCancelButton);
			this.tabPage4.Controls.Add(this.label2);
			this.tabPage4.Controls.Add(this.richTextBox1);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(691, 401);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "About";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// abtCancelButton
			// 
			this.abtCancelButton.Location = new System.Drawing.Point(598, 38);
			this.abtCancelButton.Name = "abtCancelButton";
			this.abtCancelButton.Size = new System.Drawing.Size(75, 23);
			this.abtCancelButton.TabIndex = 2;
			this.abtCancelButton.Text = "Cancel";
			this.abtCancelButton.UseVisualStyleBackColor = true;
			this.abtCancelButton.Click += new System.EventHandler(this.AbtCancelButtonClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "About";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 40);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(574, 353);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 430);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YASF - Yet Another Secure Folder v1.0 beta";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
