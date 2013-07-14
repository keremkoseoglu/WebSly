using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WebSly
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt1Decoded;
		private System.Windows.Forms.TextBox txt1Encoded;

		private Util myUtil;
		private bool pageLoaded;

		private System.Windows.Forms.RadioButton rb1Url;
		private System.Windows.Forms.RadioButton rb1Html;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt2Url;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt2Var;
		private System.Windows.Forms.TextBox txt2Val;
		private System.Windows.Forms.ListBox lst2;
		private System.Windows.Forms.Button btn2Add;
		private System.Windows.Forms.Button btn2Remove;
		private System.Windows.Forms.Button btn1Decode;
		private System.Windows.Forms.Button btn1Encode;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btn2Get;
		private System.Windows.Forms.Button btn2Post;
		private AxSHDocVw.AxWebBrowser webMain;
		private System.Windows.Forms.Button btn2Modify;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel lnkMain;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.SaveFileDialog saveMain;
		private System.Windows.Forms.OpenFileDialog loadMain;
		private System.Windows.Forms.TextBox txt2Address;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ListBox lst2Form;
		private System.Windows.Forms.Button btn2Transfer;
		private System.Windows.Forms.ImageList ilMain;
		private System.Windows.Forms.PictureBox picStat;
		private System.ComponentModel.IContainer components;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			myUtil = new Util();
			picStat.Image = ilMain.Images[0];
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.rb1Html = new System.Windows.Forms.RadioButton();
			this.rb1Url = new System.Windows.Forms.RadioButton();
			this.btn1Decode = new System.Windows.Forms.Button();
			this.btn1Encode = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txt1Encoded = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt1Decoded = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btn2Transfer = new System.Windows.Forms.Button();
			this.lst2Form = new System.Windows.Forms.ListBox();
			this.btn2Post = new System.Windows.Forms.Button();
			this.btn2Get = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txt2Address = new System.Windows.Forms.TextBox();
			this.webMain = new AxSHDocVw.AxWebBrowser();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn2Modify = new System.Windows.Forms.Button();
			this.btn2Remove = new System.Windows.Forms.Button();
			this.btn2Add = new System.Windows.Forms.Button();
			this.lst2 = new System.Windows.Forms.ListBox();
			this.txt2Val = new System.Windows.Forms.TextBox();
			this.txt2Var = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt2Url = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.label4 = new System.Windows.Forms.Label();
			this.lnkMain = new System.Windows.Forms.LinkLabel();
			this.saveMain = new System.Windows.Forms.SaveFileDialog();
			this.loadMain = new System.Windows.Forms.OpenFileDialog();
			this.ilMain = new System.Windows.Forms.ImageList(this.components);
			this.picStat = new System.Windows.Forms.PictureBox();
			this.tabMain.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webMain)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.tabPage1);
			this.tabMain.Controls.Add(this.tabPage2);
			this.tabMain.Location = new System.Drawing.Point(8, 8);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(624, 304);
			this.tabMain.TabIndex = 0;
			this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.rb1Html);
			this.tabPage1.Controls.Add(this.rb1Url);
			this.tabPage1.Controls.Add(this.btn1Decode);
			this.tabPage1.Controls.Add(this.btn1Encode);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(616, 278);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Encode Data";
			// 
			// rb1Html
			// 
			this.rb1Html.Location = new System.Drawing.Point(112, 128);
			this.rb1Html.Name = "rb1Html";
			this.rb1Html.TabIndex = 5;
			this.rb1Html.Text = "HTML Encode";
			// 
			// rb1Url
			// 
			this.rb1Url.Checked = true;
			this.rb1Url.Location = new System.Drawing.Point(16, 128);
			this.rb1Url.Name = "rb1Url";
			this.rb1Url.Size = new System.Drawing.Size(88, 24);
			this.rb1Url.TabIndex = 4;
			this.rb1Url.TabStop = true;
			this.rb1Url.Text = "URL Encode";
			// 
			// btn1Decode
			// 
			this.btn1Decode.Location = new System.Drawing.Point(528, 128);
			this.btn1Decode.Name = "btn1Decode";
			this.btn1Decode.Size = new System.Drawing.Size(80, 32);
			this.btn1Decode.TabIndex = 3;
			this.btn1Decode.Text = "Decode";
			this.btn1Decode.Click += new System.EventHandler(this.txt1Decode_Click);
			// 
			// btn1Encode
			// 
			this.btn1Encode.Location = new System.Drawing.Point(440, 128);
			this.btn1Encode.Name = "btn1Encode";
			this.btn1Encode.Size = new System.Drawing.Size(80, 32);
			this.btn1Encode.TabIndex = 2;
			this.btn1Encode.Text = "Encode";
			this.btn1Encode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txt1Encoded);
			this.groupBox2.Location = new System.Drawing.Point(8, 168);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(600, 112);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Encoded Text";
			// 
			// txt1Encoded
			// 
			this.txt1Encoded.Location = new System.Drawing.Point(8, 24);
			this.txt1Encoded.Multiline = true;
			this.txt1Encoded.Name = "txt1Encoded";
			this.txt1Encoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt1Encoded.Size = new System.Drawing.Size(584, 80);
			this.txt1Encoded.TabIndex = 1;
			this.txt1Encoded.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt1Decoded);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Decoded Text";
			// 
			// txt1Decoded
			// 
			this.txt1Decoded.Location = new System.Drawing.Point(8, 24);
			this.txt1Decoded.Multiline = true;
			this.txt1Decoded.Name = "txt1Decoded";
			this.txt1Decoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt1Decoded.Size = new System.Drawing.Size(584, 80);
			this.txt1Decoded.TabIndex = 0;
			this.txt1Decoded.Text = "";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox5);
			this.tabPage2.Controls.Add(this.btn2Post);
			this.tabPage2.Controls.Add(this.btn2Get);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.txt2Url);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(616, 278);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Post Data";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btn2Transfer);
			this.groupBox5.Controls.Add(this.lst2Form);
			this.groupBox5.Location = new System.Drawing.Point(328, 48);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(280, 136);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Form Analysis";
			// 
			// btn2Transfer
			// 
			this.btn2Transfer.Location = new System.Drawing.Point(8, 88);
			this.btn2Transfer.Name = "btn2Transfer";
			this.btn2Transfer.Size = new System.Drawing.Size(264, 32);
			this.btn2Transfer.TabIndex = 1;
			this.btn2Transfer.Text = "Transfer";
			this.btn2Transfer.Click += new System.EventHandler(this.btn2Transfer_Click);
			// 
			// lst2Form
			// 
			this.lst2Form.Location = new System.Drawing.Point(8, 24);
			this.lst2Form.Name = "lst2Form";
			this.lst2Form.Size = new System.Drawing.Size(264, 56);
			this.lst2Form.TabIndex = 0;
			// 
			// btn2Post
			// 
			this.btn2Post.Location = new System.Drawing.Point(560, 16);
			this.btn2Post.Name = "btn2Post";
			this.btn2Post.Size = new System.Drawing.Size(48, 23);
			this.btn2Post.TabIndex = 5;
			this.btn2Post.Text = "Post";
			this.btn2Post.Click += new System.EventHandler(this.btn2Post_Click);
			// 
			// btn2Get
			// 
			this.btn2Get.Location = new System.Drawing.Point(504, 16);
			this.btn2Get.Name = "btn2Get";
			this.btn2Get.Size = new System.Drawing.Size(48, 23);
			this.btn2Get.TabIndex = 4;
			this.btn2Get.Text = "Get";
			this.btn2Get.Click += new System.EventHandler(this.btn2Get_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txt2Address);
			this.groupBox4.Controls.Add(this.webMain);
			this.groupBox4.Location = new System.Drawing.Point(8, 192);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(600, 80);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Result";
			// 
			// txt2Address
			// 
			this.txt2Address.Location = new System.Drawing.Point(16, 24);
			this.txt2Address.Name = "txt2Address";
			this.txt2Address.ReadOnly = true;
			this.txt2Address.Size = new System.Drawing.Size(576, 20);
			this.txt2Address.TabIndex = 2;
			this.txt2Address.Text = "";
			// 
			// webMain
			// 
			this.webMain.ContainingControl = this;
			this.webMain.Enabled = true;
			this.webMain.Location = new System.Drawing.Point(16, 48);
			this.webMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("webMain.OcxState")));
			this.webMain.Size = new System.Drawing.Size(576, 48);
			this.webMain.TabIndex = 1;
			this.webMain.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.webMain_DocumentComplete);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn2Modify);
			this.groupBox3.Controls.Add(this.btn2Remove);
			this.groupBox3.Controls.Add(this.btn2Add);
			this.groupBox3.Controls.Add(this.lst2);
			this.groupBox3.Controls.Add(this.txt2Val);
			this.groupBox3.Controls.Add(this.txt2Var);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(8, 48);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(312, 136);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Variables";
			// 
			// btn2Modify
			// 
			this.btn2Modify.Location = new System.Drawing.Point(72, 88);
			this.btn2Modify.Name = "btn2Modify";
			this.btn2Modify.Size = new System.Drawing.Size(56, 32);
			this.btn2Modify.TabIndex = 7;
			this.btn2Modify.Text = "Modify";
			this.btn2Modify.Click += new System.EventHandler(this.btn2Modify_Click);
			// 
			// btn2Remove
			// 
			this.btn2Remove.Location = new System.Drawing.Point(128, 88);
			this.btn2Remove.Name = "btn2Remove";
			this.btn2Remove.Size = new System.Drawing.Size(56, 32);
			this.btn2Remove.TabIndex = 6;
			this.btn2Remove.Text = "Remove";
			this.btn2Remove.Click += new System.EventHandler(this.btn2Remove_Click);
			// 
			// btn2Add
			// 
			this.btn2Add.Location = new System.Drawing.Point(16, 88);
			this.btn2Add.Name = "btn2Add";
			this.btn2Add.Size = new System.Drawing.Size(56, 32);
			this.btn2Add.TabIndex = 5;
			this.btn2Add.Text = "Add";
			this.btn2Add.Click += new System.EventHandler(this.btn2Add_Click);
			// 
			// lst2
			// 
			this.lst2.Location = new System.Drawing.Point(192, 24);
			this.lst2.Name = "lst2";
			this.lst2.Size = new System.Drawing.Size(112, 95);
			this.lst2.TabIndex = 4;
			this.lst2.SelectedIndexChanged += new System.EventHandler(this.lst2_SelectedIndexChanged);
			// 
			// txt2Val
			// 
			this.txt2Val.Location = new System.Drawing.Point(80, 56);
			this.txt2Val.Name = "txt2Val";
			this.txt2Val.TabIndex = 3;
			this.txt2Val.Text = "";
			this.txt2Val.Enter += new System.EventHandler(this.txt2Val_Enter);
			// 
			// txt2Var
			// 
			this.txt2Var.Location = new System.Drawing.Point(80, 24);
			this.txt2Var.Name = "txt2Var";
			this.txt2Var.TabIndex = 2;
			this.txt2Var.Text = "";
			this.txt2Var.Enter += new System.EventHandler(this.txt2Var_Enter);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Value";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Variable";
			// 
			// txt2Url
			// 
			this.txt2Url.Location = new System.Drawing.Point(56, 16);
			this.txt2Url.Name = "txt2Url";
			this.txt2Url.Size = new System.Drawing.Size(440, 20);
			this.txt2Url.TabIndex = 1;
			this.txt2Url.Text = "";
			this.txt2Url.TextChanged += new System.EventHandler(this.txt2Url_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem2});
			this.menuItem1.Text = "&File";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "&Save Post Data...";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "&Load Post Data...";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "-";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 3;
			this.menuItem2.Text = "E&xit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(464, 320);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Visit";
			// 
			// lnkMain
			// 
			this.lnkMain.Location = new System.Drawing.Point(496, 320);
			this.lnkMain.Name = "lnkMain";
			this.lnkMain.Size = new System.Drawing.Size(136, 23);
			this.lnkMain.TabIndex = 2;
			this.lnkMain.TabStop = true;
			this.lnkMain.Text = "http://www.whitesaint.org";
			this.lnkMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMain_LinkClicked);
			// 
			// saveMain
			// 
			this.saveMain.DefaultExt = "xml";
			// 
			// ilMain
			// 
			this.ilMain.ImageSize = new System.Drawing.Size(32, 15);
			this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
			this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// picStat
			// 
			this.picStat.Location = new System.Drawing.Point(8, 320);
			this.picStat.Name = "picStat";
			this.picStat.Size = new System.Drawing.Size(32, 15);
			this.picStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picStat.TabIndex = 3;
			this.picStat.TabStop = false;
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(642, 343);
			this.Controls.Add(this.picStat);
			this.Controls.Add(this.lnkMain);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tabMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "frmMain";
			this.Text = "WebSly 0.81 - written by Kerem Koseoglu";
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.tabMain.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webMain)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private Util.encodingMethod getEncodingMethod()
		{
			Util.encodingMethod emReturn;

			if (rb1Url.Checked) emReturn = Util.encodingMethod.URL; else emReturn = Util.encodingMethod.HTML;

			return emReturn;
		}

		private void resizeItems()
		{
			int space = 10;

			try
			{
				// lnkMain
				lnkMain.Top		= frmMain.ActiveForm.Height - 30 - lnkMain.Height - space;
				lnkMain.Left	= frmMain.ActiveForm.Width - lnkMain.Width - space;
				label4.Top		= lnkMain.Top;
				label4.Left		= lnkMain.Left - label4.Width;
				picStat.Top		= lnkMain.Top;

				// tabMain
				tabMain.Width	= frmMain.ActiveForm.Width - tabMain.Left - space;
				tabMain.Height	= frmMain.ActiveForm.Height - lnkMain.Height - space - tabMain.Top - space - 30;
				
				// tabPage1
				groupBox1.Width		= tabPage1.Width - groupBox1.Left - space;
				groupBox1.Height	= (tabPage1.Height / 2) - btn1Encode.Height;
				rb1Url.Top			= groupBox1.Top + groupBox1.Height + space;
				rb1Html.Top			= rb1Url.Top;
				btn1Encode.Top		= rb1Url.Top;
				btn1Decode.Top		= rb1Url.Top;
				groupBox2.Top		= rb1Url.Top + rb1Url.Height + space;
				groupBox2.Width		= groupBox1.Width;
				groupBox2.Height	= groupBox1.Height;
			
				txt1Decoded.Top		= space * 2;
				txt1Decoded.Left	= space * 2;
				txt1Decoded.Width	= groupBox1.Width - txt1Decoded.Left - space;
				txt1Decoded.Height	= groupBox1.Height - txt1Decoded.Top - space;

				txt1Encoded.Top		= space * 2;
				txt1Encoded.Left	= space * 2;
				txt1Encoded.Width	= txt1Decoded.Width;
				txt1Encoded.Height	= txt1Decoded.Height;

				btn1Decode.Left		= groupBox2.Right - btn1Decode.Width;
				btn1Encode.Left		= btn1Decode.Left - btn1Encode.Width - space;

				// tabPage2			
				groupBox3.Width		= (tabPage2.Width - groupBox3.Left - space) / 2;
				txt2Url.Width		= (groupBox3.Width * 2) - txt2Url.Left - btn2Get.Width - btn2Post.Width - space;
				btn2Get.Left		= txt2Url.Left + txt2Url.Width + space;
				btn2Post.Left		= btn2Get.Left + btn2Get.Width + space;
				lst2.Width			= groupBox3.Width - lst2.Left - space;

				groupBox5.Width		= groupBox3.Width;
				groupBox5.Left		= groupBox3.Left + + groupBox3.Width + space;
				lst2Form.Width		= groupBox5.Width - lst2Form.Left - space;
				lst2Form.Height		= groupBox5.Height - lst2Form.Top - btn2Transfer.Height - space;
				btn2Transfer.Top	= lst2Form.Top + lst2Form.Height + 1;
				btn2Transfer.Width	= lst2Form.Width;

				groupBox4.Width		= groupBox3.Width + groupBox5.Width + space;
				groupBox4.Height	= tabPage2.Height - groupBox4.Top - space;
				webMain.Width		= groupBox4.Width - webMain.Left - space;
				webMain.Height		= groupBox4.Height - webMain.Top - space;
				txt2Address.Width	= webMain.Width;
			}
			catch{}
		}

		private void refreshVarList()
		{
			lst2.Items.Clear();

			for (int n = 0; n < myUtil.alVar.Count; n++)
			{
				lst2.Items.Add(myUtil.alVar[n].ToString() + " = " + myUtil.alVal[n].ToString());
			}
		}

		private void waitUntilDocumentLoaded()
		{
			while (!pageLoaded)
			{
				System.Threading.Thread.Sleep(500);
				Application.DoEvents();
			}
		}

		private void btnEncode_Click(object sender, System.EventArgs e)
		{
			txt1Encoded.Text = myUtil.encodeText(txt1Decoded.Text, getEncodingMethod());
		}

		private void txt1Decode_Click(object sender, System.EventArgs e)
		{
			txt1Decoded.Text = myUtil.decodeText(txt1Encoded.Text, getEncodingMethod());
		}

		private void frmMain_Resize(object sender, System.EventArgs e)
		{
			resizeItems();
		}

		private void tabMain_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			resizeItems();
		}

		private void btn2Add_Click(object sender, System.EventArgs e)
		{
			myUtil.addVariable(txt2Var.Text, txt2Val.Text);
			txt2Var.Clear();
			txt2Val.Clear();
			refreshVarList();
		}

		private void btn2Remove_Click(object sender, System.EventArgs e)
		{
			if (lst2.SelectedIndex < 0) return;

			myUtil.removeVariable(lst2.SelectedIndex);
			txt2Var.Clear();
			txt2Val.Clear();
			refreshVarList();
		}

		private void btn2Get_Click(object sender, System.EventArgs e)
		{
			string url; 
			object u;
			object o = null;

			picStat.Image = ilMain.Images[1];
			
			url = txt2Url.Text;
			myUtil.getGetData(ref url);
			u = url;

			txt2Address.Clear();
			pageLoaded = false;
			webMain.Navigate2(ref u, ref o, ref o, ref o, ref o);
			//waitUntilDocumentLoaded();
		}

		private void btn2Post_Click(object sender, System.EventArgs e)
		{
			string url	= "";
			string post	= "";
			object u;
			object o	= null;
			object p;
			object h;

			picStat.Image = ilMain.Images[1];

			url = txt2Url.Text;
			myUtil.getPostData(ref url, ref post);

			u = url;
			p = System.Text.ASCIIEncoding.ASCII.GetBytes(post);
			h = "Content-Type: application/x-www-form-urlencoded";

			txt2Address.Clear();
			pageLoaded = false;
			webMain.Navigate2(ref u, ref o, ref o, ref p, ref h); 
			//waitUntilDocumentLoaded();
		}

		private void lst2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lst2.SelectedIndex < 0) return;

			txt2Var.Text = myUtil.alVar[lst2.SelectedIndex].ToString();
			txt2Val.Text = myUtil.alVal[lst2.SelectedIndex].ToString();
		}

		private void btn2Modify_Click(object sender, System.EventArgs e)
		{
			if (lst2.SelectedIndex < 0) return;

			myUtil.alVar[lst2.SelectedIndex] = txt2Var.Text;
			myUtil.alVal[lst2.SelectedIndex] = txt2Val.Text;
			txt2Var.Clear();
			txt2Val.Clear();
			refreshVarList();
		}

		private void txt2Var_Enter(object sender, System.EventArgs e)
		{
			txt2Var.SelectAll();
		}

		private void txt2Val_Enter(object sender, System.EventArgs e)
		{
			txt2Val.SelectAll();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void lnkMain_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(lnkMain.Text);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			string url = "";

			if (loadMain.ShowDialog() == DialogResult.OK && loadMain.FileName != null)
			{
				try
				{
					myUtil.loadPostData(ref url, loadMain.FileName);
				}
				catch{}
			}	
			txt2Url.Text = url;
			refreshVarList();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if (saveMain.ShowDialog() == DialogResult.OK && saveMain.FileName != null)
			{
				try
				{
					myUtil.savePostData(txt2Url.Text, saveMain.FileName);
				}
				catch{}
			}
		}

		private void webMain_DocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
		{
			// Adresi yazalým
			pageLoaded = true;
			txt2Address.Text = webMain.LocationURL;

			// Formlarýn listesini alalým
			myUtil.getHtmlForms((mshtml.HTMLDocument) webMain.Document);
			lst2Form.Items.Clear();
			foreach(DataRow dr in myUtil.dtForm.Rows)
			{
				lst2Form.Items.Add(dr["form"].ToString());
			}

			// Ekran serbest
			picStat.Image = ilMain.Images[0];
		}

		private void btn2Transfer_Click(object sender, System.EventArgs e)
		{
			if (lst2Form.SelectedIndex < 0) return;

			// URL
			txt2Url.Text = myUtil.dtForm.Rows[lst2Form.SelectedIndex]["action"].ToString();

			// Buttons
			if (myUtil.dtForm.Rows[lst2Form.SelectedIndex]["method"].ToString().ToLower() == "get")
			{
				btn2Get.Enabled		= true;
				btn2Post.Enabled	= false;
			}
			else
			{
				btn2Get.Enabled		= false;
				btn2Post.Enabled	= true;
			}

			// Variables
			myUtil.clearVariables();
			foreach(DataRow dr in myUtil.dtFormItem.Rows)
			{
				if (dr["form"].ToString() == myUtil.dtForm.Rows[lst2Form.SelectedIndex]["form"].ToString() && dr["formaction"].ToString() == myUtil.dtForm.Rows[lst2Form.SelectedIndex]["action"].ToString())
				{
					if (!myUtil.variableExists(dr["name"].ToString()))
					{
						myUtil.addVariable(dr["name"].ToString(), dr["value"].ToString());
					}
				}
			}
			refreshVarList();
		}

		private void txt2Url_TextChanged(object sender, System.EventArgs e)
		{
			btn2Get.Enabled		= true;
			btn2Post.Enabled	= true;
		}


	}
}
