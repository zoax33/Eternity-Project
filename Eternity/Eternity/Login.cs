using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Eramake;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Eternity
{
	// Token: 0x02000007 RID: 7
	public class Login : MetroForm
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00003A7C File Offset: 0x00001C7C


		// Token: 0x06000021 RID: 33 RVA: 0x00003ABC File Offset: 0x00001CBC
		private void Form2_Shown(object sender, EventArgs e)
		{
			try
			{
				if (!this.MyIni.KeyExists("Style", null))
				{
					this.MyIni.Write("Style", "0", null);
				}
				int style = Convert.ToInt32(this.MyIni.Read("Style", null));
				this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
				WebClient webClient = new WebClient();
				if (!webClient.DownloadString("http://wowprohaxerkk.000webhostapp.com").Contains(Program.version))
				{
					MessageBox.Show("New version is out! Check Eternity Discord server.", "New version!");
					Environment.Exit(0);
				}
				webClient.Dispose();
				if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Eternity.ini"))
				{
					string text = this.MyIni.Read("username", null);
					string text2 = this.MyIni.Read("pass", null);
					string text3 = eCryptography.Decrypt(text2);
					if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
					{
						string a;
						try
						{
							StreamReader streamReader = new StreamReader(WebRequest.Create(string.Concat(new string[]
							{
								this.eurl,
								"auth.php?username=",
								text,
								"&password=",
								text3,
								"&cpuid=",
								Program.GetCpuID()
							})).GetResponse().GetResponseStream());
							a = streamReader.ReadToEnd();
							streamReader.Dispose();
						}
						catch
						{
							StreamReader streamReader2 = new StreamReader(WebRequest.Create(string.Concat(new string[]
							{
								"http://projecteternity.000webhostapp.com/auth.php?username=",
								text,
								"&password=",
								text3,
								"&cpuid=12345"
							})).GetResponse().GetResponseStream());
							a = streamReader2.ReadToEnd();
							streamReader2.Dispose();
						}
						if (a == "true")
						{
							base.Hide();
							//Main main = new Main(text, text3);
							//main.Closed += delegate (object s, EventArgs args)
							//{
							//	base.Close();
							//};
							//main.ShowDialog();
							//main.Dispose();
							//base.Close();
						}
					}
				}
				else
				{
					this.metroButton3.Enabled = false;
					this.Refresh();
					this.metroButton3.Enabled = true;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003D38 File Offset: 0x00001F38
		private void metroButton2_Click(object sender, EventArgs e)
		{

		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003F70 File Offset: 0x00002170
		private void Form2_Click(object sender, EventArgs e)
		{
			//this.label1.Focus();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003F8C File Offset: 0x0000218C
		private void metroTextBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.metroButton3.PerformClick();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003FB4 File Offset: 0x000021B4
		private void metroButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			Register register = new Register();
			register.ShowDialog();
			register.Dispose();
			base.Close();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003FE0 File Offset: 0x000021E0
		private void Login_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003FF0 File Offset: 0x000021F0
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(1);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004008 File Offset: 0x00002208
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004034 File Offset: 0x00002234
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(40, 106);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PromptText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(176, 25);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Magenta;
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TabStop = false;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 136);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(176, 25);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Magenta;
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TabStop = false;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(6, 245);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(47, 20);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton1.TabIndex = 13;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "Register";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(66, 179);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(112, 36);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton3.TabIndex = 14;
            this.metroButton3.TabStop = false;
            this.metroButton3.Text = "Login";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(264, 269);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Project iSoloii";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


	// Token: 0x04000013 RID: 19
	private readonly IniFile MyIni = new IniFile("Eternity.ini");

		// Token: 0x04000014 RID: 20
		public string username;

		// Token: 0x04000015 RID: 21
		public string eurl;

		// Token: 0x04000016 RID: 22
		private IContainer components;

		// Token: 0x04000017 RID: 23
		private MetroTextBox txtUsername;

		// Token: 0x04000018 RID: 24
		private Label label2;

		// Token: 0x0400001B RID: 27
		private MetroTextBox txtPassword;

		// Token: 0x0400001C RID: 28
		private MetroButton metroButton1;
		private MetroButton metroButton3;

		// Token: 0x0400001D RID: 29
		private MetroStyleManager metroStyleManager1;
		public Login()
		{
			this.InitializeComponent();
			this.eurl = "http://wowprohaxerkk.000webhostapp.com/";
		}

		private void metroButton2_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtUsername.Text) && !string.IsNullOrEmpty(this.txtPassword.Text))
			{
				string text = this.txtUsername.Text;
				string text2 = this.txtPassword.Text;
				string a = "";
				try
				{
					StreamReader streamReader = new StreamReader(WebRequest.Create(string.Concat(new string[]
					{
						this.eurl,
						"auth.php?username=",
						text,
						"&password=",
						text2,
						"&cpuid=",
						Program.GetCpuID()
					})).GetResponse().GetResponseStream());
					a = streamReader.ReadToEnd();
					streamReader.Dispose();
				}
				catch
				{
					try
					{
						StreamReader streamReader2 = new StreamReader(WebRequest.Create(string.Concat(new string[]
						{
							this.eurl,
							"auth.php?username=",
							text,
							"&password=",
							text2,
							"&cpuid=12345"
						})).GetResponse().GetResponseStream());
						a = streamReader2.ReadToEnd();
						streamReader2.Dispose();
					}
					catch
					{
						MessageBox.Show("Unable to connect to server.");
						return;
					}
				}
				if (a == "true")
				{
					base.Hide();
					this.MyIni.Write("username", text, null);
					this.MyIni.Write("pass", eCryptography.Encrypt(text2), null);
					Main zz = new Main(text, text2);
					zz.Show();
					Hide();
				}
				if (a == "time")
				{
					MessageBox.Show("Your license has expired.");
					return;
				}
				if (a == "invaliduser")
				{
					MessageBox.Show("Authorization failed.");
					return;
				}
				if (a == "nologininfo")
				{
					MessageBox.Show("Missing login info.");
				}
				return;
			}
			MessageBox.Show("Missing login info.");
		}

		private void metroButton1_Click_1(object sender, EventArgs e)
		{
			Register zz = new Register();
			zz.Show();
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			//Main zz = new Main("xandy", "z");
			//zz.Show();
			//Hide();
			if (!string.IsNullOrEmpty(this.txtUsername.Text) && !string.IsNullOrEmpty(this.txtPassword.Text))
			{
				string text = this.txtUsername.Text;
				string text2 = this.txtPassword.Text;
				string a = "";
				try
				{
					StreamReader streamReader = new StreamReader(WebRequest.Create(string.Concat(new string[]
					{
						this.eurl,
						"auth.php?username=",
						text,
						"&password=",
						text2,
						"&cpuid=",
						Program.GetCpuID()
					})).GetResponse().GetResponseStream());
					a = streamReader.ReadToEnd();
					streamReader.Dispose();
					Main zz = new Main(text, text2);
					zz.Show();
					Hide();
					MessageBox.Show("b");

				}
				catch
				{
					try
					{
						StreamReader streamReader2 = new StreamReader(WebRequest.Create(string.Concat(new string[]
						{
							this.eurl,
							"auth.php?username=",
							text,
							"&password=",
							text2,
							"&cpuid=12345"
						})).GetResponse().GetResponseStream());
						a = streamReader2.ReadToEnd();
						streamReader2.Dispose();
						MessageBox.Show("c");

					}
					catch
					{
						MessageBox.Show("Unable to connect to server.");
						return;
					}
				}
				if (a == "true")
				{
					base.Hide();
					this.MyIni.Write("username", text, null);
					this.MyIni.Write("pass", eCryptography.Encrypt(text2), null);
					//Main zz = new Main(text, text2);
					//zz.Show();
					//Hide();
				}
				if (a == "time")
				{
					MessageBox.Show("Your license has expired.");
					return;
				}
				if (a == "invaliduser")
				{
					MessageBox.Show("Authorization failed.");
					return;
				}
				if (a == "nologininfo")
				{
					MessageBox.Show("Missing login info.");
				}
				return;
			}
			MessageBox.Show("Missing login info.");
		}
	}
}
