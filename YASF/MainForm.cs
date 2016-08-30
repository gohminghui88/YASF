/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 24/08/2016
 * Time: 10:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using YASF;
using System.IO;
using System.Linq;
using System.Text;

namespace YASF
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string curDir = System.IO.Directory.GetCurrentDirectory();
		private IniFile MyIni;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//Disable Folder Tab components
			this.folderListBox.Enabled = false;
			this.addButton.Enabled = false;
			this.unhideButton.Enabled = false;
			
			//Disable Create passwords Tab components
			this.addPassTextBox1.Enabled = false;
			this.addPassTextBox2.Enabled = false;
			this.APOKButton.Enabled = false;
			this.APCancelButton.Enabled = false;
			
			
			//init ini settings file
			MyIni = new IniFile(curDir + "//settings.ini");
			
			//if settings.ini not found, go to create user tab
			if(!File.Exists(curDir + "//settings.ini"))
			{
				TabPage t = tabControl1.TabPages[2];
				tabControl1.SelectedTab =  t; //go to tab
				
				
				//Enable Create passwords Tab components
				this.addPassTextBox1.Enabled = true;
				this.addPassTextBox2.Enabled = true;
				this.APOKButton.Enabled = true;
				this.APCancelButton.Enabled = true;
			}
			
			
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void LoginButtonClick(object sender, EventArgs e)
		{
			//Check password field not empty
			if(passTextBox.Text != "") {
				
				//Read settings.ini
				string pass = MyIni.Read("Passwords", "General");
				
				//Validate passwords
				if(this.CreateMD5(passTextBox.Text) == pass)
				{
					//if login success, display message
					loginLabel.Text = "Success";
					
					//Read from settings.ini the hidden folders list and add to list box
					for(int i = 0; i < 999; i++) {
						string dirKey = "dir" + i.ToString();
					
						if(MyIni.KeyExists(dirKey, "Directories"))
						{
							folderListBox.Items.Add(MyIni.Read(dirKey, "Directories"));
						}
					}
					
					//Go to Folder Tab
					TabPage t = tabControl1.TabPages[1];
					tabControl1.SelectedTab =  t; //go to tab
					
					//Enable Folder Tab components
					this.folderListBox.Enabled = true;
					this.addButton.Enabled = true;
					this.unhideButton.Enabled = true;
					
					//Enable Create passwords Tab components
					this.addPassTextBox1.Enabled = true;
					this.addPassTextBox2.Enabled = true;
					this.APOKButton.Enabled = true;
					this.APCancelButton.Enabled = true;
					
					//Clear login passwords
					this.passTextBox.Text = "";
				}
				
				else loginLabel.Text = "Failed";
			}
			
			else
				MessageBox.Show("Please enter passwords. ");
		}
		
		void UsrLabelClick(object sender, EventArgs e)
		{
			//Go to About Tab
			TabPage t = tabControl1.TabPages[3];
			tabControl1.SelectedTab =  t; //go to tab
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			//Get folder Path to Hide
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			
			DialogResult result = fbd.ShowDialog();
			
			if (result==DialogResult.OK)
			{
				//Add to Listbox
				folderListBox.Items.Add(fbd.SelectedPath.ToString());
				
				//Update settings.ini
				for(int i = 0; i < 999; i++)
				{
					string dirKey = "dir" + i.ToString();
					
					if(!MyIni.KeyExists(dirKey, "Directories"))
					{
						MyIni.Write(dirKey, fbd.SelectedPath.ToString(), "Directories");
						break;
					}
				}
				
				//Hide Folder
				FolderHider fh = new FolderHider();
				fh.hide(fbd.SelectedPath.ToString());
			}
		}
		
		void UnhideButtonClick(object sender, EventArgs e)
		{
			//Get Selected folder from list box
			if(folderListBox.SelectedIndex != -1)
			{
				string folderPath = folderListBox.SelectedItems[0].ToString();
				
				//Update settings.ini
				for(int i = 0; i < 999; i++) {
					string dirKey = "dir" + i.ToString();
					
					if(MyIni.KeyExists(dirKey, "Directories"))
					{
						if(folderPath == MyIni.Read(dirKey, "Directories"))
						{
							MyIni.DeleteKey(dirKey, "Directories");
							break;
						}
					}
				}
				
				//Unhide selected folder
				FolderHider fh = new FolderHider();
				fh.unhide(folderPath);
				
				//Remove from listbox
				folderListBox.Items.RemoveAt(folderListBox.SelectedIndex);
			}
			
			else
				MessageBox.Show("Please select a folder to unhide first. ");
		}
		
		void APCancelButtonClick(object sender, EventArgs e)
		{
			//Go to Login Tab
			TabPage t = tabControl1.TabPages[0];
			tabControl1.SelectedTab =  t; //go to tab
			
			//Disable Create passwords Tab components
			this.addPassTextBox1.Enabled = false;
			this.addPassTextBox2.Enabled = false;
			this.APOKButton.Enabled = false;
			this.APCancelButton.Enabled = false;
		}
		
		void APOKButtonClick(object sender, EventArgs e)
		{
			if(addPassTextBox1.Text != "" && addPassTextBox2.Text != "")
			{
				if(addPassTextBox1.Text == addPassTextBox2.Text)
				{
					//Write passwords to settings.ini with md5 hashing
					MyIni.Write("Passwords", this.CreateMD5(addPassTextBox1.Text), "General");
					
					MessageBox.Show("Passwords Created/Replaced. ");
					
					//Go to Login Tab
					TabPage t = tabControl1.TabPages[0];
					tabControl1.SelectedTab =  t; //go to tab
					
					//Disable Create passwords Tab components
					this.addPassTextBox1.Enabled = false;
					this.addPassTextBox2.Enabled = false;
					this.APOKButton.Enabled = false;
					this.APCancelButton.Enabled = false;
					
					//Clear entered passwords
					this.addPassTextBox1.Text = "";
					this.addPassTextBox2.Text = "";
				}
				
				else
					MessageBox.Show("Both passwords must be the same. ");
			}
			
			else
				MessageBox.Show("Passwords Empty. ");
		}
		
		void AbtCancelButtonClick(object sender, EventArgs e)
		{
			//Go to Login Tab
			TabPage t = tabControl1.TabPages[0];
			tabControl1.SelectedTab =  t; //go to tab
		}
		
		
		//Reference: http://stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string
		string CreateMD5(string input)
    	{
        	// Use input string to calculate MD5 hash
        	using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        	{
            	byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            	byte[] hashBytes = md5.ComputeHash(inputBytes);

            	// Convert the byte array to hexadecimal string
            	StringBuilder sb = new StringBuilder();
            	for (int i = 0; i < hashBytes.Length; i++)
            	{
                	sb.Append(hashBytes[i].ToString("X2"));
            	}
            	return sb.ToString();
        	}
    	}
	}
}
