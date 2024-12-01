using SoftwareTrainingApplication.Models.UserControls;

namespace FocusApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlBack = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.customPanel3 = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.btnShowNewAddress = new System.Windows.Forms.Label();
            this.clistboxWebAddress = new SoftwareTrainingApplication.Models.UserControls.CheckListBox();
            this.customPanel2 = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.pnlFocus = new System.Windows.Forms.Panel();
            this.pnlSettigs = new System.Windows.Forms.Panel();
            this.cmboxTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtnTimeLimit = new kysToolDemo.KysTools.KYSToggleButton();
            this.btnStartFocus = new kysToolDemo.KysTools.KYSButton();
            this.btnFinishFocus = new kysToolDemo.KysTools.KYSButton();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlNewAddress = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebAddress = new kysToolDemo.KysTools.KYSTextBox();
            this.btnAddAddress = new kysToolDemo.KysTools.KYSButton();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new kysToolDemo.KysTools.KYSButton();
            this.btnClose = new kysToolDemo.KysTools.KYSButton();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pnlBack.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.pnlFocus.SuspendLayout();
            this.pnlSettigs.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.pnlNewAddress.SuspendLayout();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.pnlBack.BottomLeftRadius = 10;
            this.pnlBack.BottomRightRadius = 10;
            this.pnlBack.Controls.Add(this.pnlBody);
            this.pnlBack.Controls.Add(this.pnlBar);
            this.pnlBack.Location = new System.Drawing.Point(2, 2);
            this.pnlBack.MinimumSize = new System.Drawing.Size(20, 20);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(721, 471);
            this.pnlBack.TabIndex = 0;
            this.pnlBack.TopLeftRadius = 10;
            this.pnlBack.TopRightRadius = 10;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.customPanel3);
            this.pnlBody.Controls.Add(this.clistboxWebAddress);
            this.pnlBody.Controls.Add(this.customPanel2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 29);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(721, 442);
            this.pnlBody.TabIndex = 16;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.customPanel3.BottomLeftRadius = 0;
            this.customPanel3.BottomRightRadius = 0;
            this.customPanel3.Controls.Add(this.btnShowNewAddress);
            this.customPanel3.Location = new System.Drawing.Point(264, 13);
            this.customPanel3.MinimumSize = new System.Drawing.Size(20, 10);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(208, 34);
            this.customPanel3.TabIndex = 22;
            this.customPanel3.TopLeftRadius = 10;
            this.customPanel3.TopRightRadius = 10;
            // 
            // btnShowNewAddress
            // 
            this.btnShowNewAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btnShowNewAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowNewAddress.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnShowNewAddress.ForeColor = System.Drawing.Color.White;
            this.btnShowNewAddress.Location = new System.Drawing.Point(0, 0);
            this.btnShowNewAddress.Name = "btnShowNewAddress";
            this.btnShowNewAddress.Size = new System.Drawing.Size(208, 34);
            this.btnShowNewAddress.TabIndex = 22;
            this.btnShowNewAddress.Text = "Yeni Adres";
            this.btnShowNewAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowNewAddress.Click += new System.EventHandler(this.btnShowNewAddress_Click);
            // 
            // clistboxWebAddress
            // 
            this.clistboxWebAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clistboxWebAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.clistboxWebAddress.CheckedColor = System.Drawing.Color.Empty;
            this.clistboxWebAddress.ForeColor = System.Drawing.Color.White;
            this.clistboxWebAddress.ItemsBackColor = System.Drawing.Color.Empty;
            this.clistboxWebAddress.Location = new System.Drawing.Point(15, 6);
            this.clistboxWebAddress.Name = "clistboxWebAddress";
            this.clistboxWebAddress.Size = new System.Drawing.Size(232, 431);
            this.clistboxWebAddress.TabIndex = 17;
            this.clistboxWebAddress.Title = "Web Adresleri";
            this.clistboxWebAddress.ListChanged += new SoftwareTrainingApplication.Models.UserControls.ListChangedEventHandler(this.clistboxWebAddress_ListChanged);
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(125)))));
            this.customPanel2.BottomLeftRadius = 10;
            this.customPanel2.BottomRightRadius = 10;
            this.customPanel2.Controls.Add(this.pnlFocus);
            this.customPanel2.Controls.Add(this.pnlTimer);
            this.customPanel2.Controls.Add(this.pnlNewAddress);
            this.customPanel2.Location = new System.Drawing.Point(264, 53);
            this.customPanel2.MinimumSize = new System.Drawing.Size(20, 20);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(448, 386);
            this.customPanel2.TabIndex = 21;
            this.customPanel2.TopLeftRadius = 10;
            this.customPanel2.TopRightRadius = 10;
            // 
            // pnlFocus
            // 
            this.pnlFocus.Controls.Add(this.pnlSettigs);
            this.pnlFocus.Controls.Add(this.btnStartFocus);
            this.pnlFocus.Controls.Add(this.btnFinishFocus);
            this.pnlFocus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFocus.Location = new System.Drawing.Point(0, 210);
            this.pnlFocus.Name = "pnlFocus";
            this.pnlFocus.Size = new System.Drawing.Size(448, 176);
            this.pnlFocus.TabIndex = 22;
            // 
            // pnlSettigs
            // 
            this.pnlSettigs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettigs.Controls.Add(this.cmboxTime);
            this.pnlSettigs.Controls.Add(this.label2);
            this.pnlSettigs.Controls.Add(this.tbtnTimeLimit);
            this.pnlSettigs.Location = new System.Drawing.Point(7, 8);
            this.pnlSettigs.Name = "pnlSettigs";
            this.pnlSettigs.Size = new System.Drawing.Size(435, 63);
            this.pnlSettigs.TabIndex = 29;
            // 
            // cmboxTime
            // 
            this.cmboxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(125)))));
            this.cmboxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTime.Font = new System.Drawing.Font("Verdana", 17F);
            this.cmboxTime.ForeColor = System.Drawing.Color.White;
            this.cmboxTime.Items.AddRange(new object[] {
            "10",
            "15",
            "30",
            "45",
            "60",
            "90",
            "120",
            "150",
            "180",
            "210",
            "240",
            "270",
            "300",
            "360",
            "420",
            "480",
            "1"});
            this.cmboxTime.Location = new System.Drawing.Point(235, 13);
            this.cmboxTime.Name = "cmboxTime";
            this.cmboxTime.Size = new System.Drawing.Size(188, 36);
            this.cmboxTime.TabIndex = 26;
            this.cmboxTime.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Süre Sınırı:";
            // 
            // tbtnTimeLimit
            // 
            this.tbtnTimeLimit.Location = new System.Drawing.Point(148, 15);
            this.tbtnTimeLimit.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbtnTimeLimit.Name = "tbtnTimeLimit";
            this.tbtnTimeLimit.OffBackColor = System.Drawing.Color.Gray;
            this.tbtnTimeLimit.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtnTimeLimit.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtnTimeLimit.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtnTimeLimit.Size = new System.Drawing.Size(67, 33);
            this.tbtnTimeLimit.TabIndex = 25;
            this.tbtnTimeLimit.UseVisualStyleBackColor = true;
            this.tbtnTimeLimit.CheckedChanged += new System.EventHandler(this.tbtnTimeLimit_CheckedChanged);
            // 
            // btnStartFocus
            // 
            this.btnStartFocus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartFocus.Angles = 90F;
            this.btnStartFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(135)))));
            this.btnStartFocus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(135)))));
            this.btnStartFocus.BorderColor = System.Drawing.Color.White;
            this.btnStartFocus.BorderRadius = 25;
            this.btnStartFocus.BorderSize = 2;
            this.btnStartFocus.ColorBottom = System.Drawing.Color.White;
            this.btnStartFocus.ColorTop = System.Drawing.Color.White;
            this.btnStartFocus.FlatAppearance.BorderSize = 0;
            this.btnStartFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartFocus.ForeColor = System.Drawing.Color.White;
            this.btnStartFocus.Location = new System.Drawing.Point(110, 88);
            this.btnStartFocus.Name = "btnStartFocus";
            this.btnStartFocus.Size = new System.Drawing.Size(242, 68);
            this.btnStartFocus.TabIndex = 27;
            this.btnStartFocus.Text = "Başlat";
            this.btnStartFocus.TextColor = System.Drawing.Color.White;
            this.btnStartFocus.UseVisualStyleBackColor = false;
            this.btnStartFocus.Click += new System.EventHandler(this.btnStartFocus_Click);
            // 
            // btnFinishFocus
            // 
            this.btnFinishFocus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishFocus.Angles = 90F;
            this.btnFinishFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(135)))));
            this.btnFinishFocus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(135)))));
            this.btnFinishFocus.BorderColor = System.Drawing.Color.White;
            this.btnFinishFocus.BorderRadius = 25;
            this.btnFinishFocus.BorderSize = 2;
            this.btnFinishFocus.ColorBottom = System.Drawing.Color.White;
            this.btnFinishFocus.ColorTop = System.Drawing.Color.White;
            this.btnFinishFocus.FlatAppearance.BorderSize = 0;
            this.btnFinishFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishFocus.ForeColor = System.Drawing.Color.White;
            this.btnFinishFocus.Location = new System.Drawing.Point(110, 88);
            this.btnFinishFocus.Name = "btnFinishFocus";
            this.btnFinishFocus.Size = new System.Drawing.Size(242, 68);
            this.btnFinishFocus.TabIndex = 28;
            this.btnFinishFocus.Text = "Bitir";
            this.btnFinishFocus.TextColor = System.Drawing.Color.White;
            this.btnFinishFocus.UseVisualStyleBackColor = false;
            this.btnFinishFocus.Visible = false;
            this.btnFinishFocus.Click += new System.EventHandler(this.btnFinishFocus_Click);
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimer.Location = new System.Drawing.Point(0, 105);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(448, 105);
            this.pnlTimer.TabIndex = 21;
            this.pnlTimer.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(5, 3);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(437, 93);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNewAddress
            // 
            this.pnlNewAddress.Controls.Add(this.label1);
            this.pnlNewAddress.Controls.Add(this.txtWebAddress);
            this.pnlNewAddress.Controls.Add(this.btnAddAddress);
            this.pnlNewAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewAddress.Location = new System.Drawing.Point(0, 0);
            this.pnlNewAddress.Name = "pnlNewAddress";
            this.pnlNewAddress.Size = new System.Drawing.Size(448, 105);
            this.pnlNewAddress.TabIndex = 20;
            this.pnlNewAddress.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Web Adresi";
            // 
            // txtWebAddress
            // 
            this.txtWebAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtWebAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtWebAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtWebAddress.BorderRadius = 0;
            this.txtWebAddress.BorderSize = 4;
            this.txtWebAddress.Font = new System.Drawing.Font("Yu Gothic UI", 15F);
            this.txtWebAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtWebAddress.Location = new System.Drawing.Point(20, 46);
            this.txtWebAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebAddress.MultiLine = false;
            this.txtWebAddress.Name = "txtWebAddress";
            this.txtWebAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWebAddress.PasswordChar = false;
            this.txtWebAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtWebAddress.PlaceholderText = "";
            this.txtWebAddress.Size = new System.Drawing.Size(315, 43);
            this.txtWebAddress.TabIndex = 20;
            this.txtWebAddress.Texts = "";
            this.txtWebAddress.UnderlinedStyle = true;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAddress.Angles = 90F;
            this.btnAddAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btnAddAddress.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btnAddAddress.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnAddAddress.BorderRadius = 8;
            this.btnAddAddress.BorderSize = 2;
            this.btnAddAddress.ColorBottom = System.Drawing.Color.White;
            this.btnAddAddress.ColorTop = System.Drawing.Color.White;
            this.btnAddAddress.FlatAppearance.BorderSize = 0;
            this.btnAddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddress.ForeColor = System.Drawing.Color.White;
            this.btnAddAddress.Location = new System.Drawing.Point(342, 46);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(86, 43);
            this.btnAddAddress.TabIndex = 19;
            this.btnAddAddress.Text = "Ekle";
            this.btnAddAddress.TextColor = System.Drawing.Color.White;
            this.btnAddAddress.UseVisualStyleBackColor = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.pnlBar.Controls.Add(this.pictureBox1);
            this.pnlBar.Controls.Add(this.btnMinimize);
            this.pnlBar.Controls.Add(this.btnClose);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(721, 29);
            this.pnlBar.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::FocusApp.Properties.Resources.Purposeful_man;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Angles = 90F;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnMinimize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnMinimize.BackgroundImage = global::FocusApp.Properties.Resources.Minimize_Window;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BorderRadius = 13;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.ColorBottom = System.Drawing.Color.White;
            this.btnMinimize.ColorTop = System.Drawing.Color.White;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(663, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(3);
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Angles = 90F;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnClose.BackgroundImage = global::FocusApp.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 13;
            this.btnClose.BorderSize = 0;
            this.btnClose.ColorBottom = System.Drawing.Color.White;
            this.btnClose.ColorTop = System.Drawing.Color.White;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(692, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(725, 475);
            this.Controls.Add(this.pnlBack);
            this.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(600, 475);
            this.Name = "frmMain";
            this.Text = "Focus Application";
            this.pnlBack.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.pnlFocus.ResumeLayout(false);
            this.pnlSettigs.ResumeLayout(false);
            this.pnlSettigs.PerformLayout();
            this.pnlTimer.ResumeLayout(false);
            this.pnlNewAddress.ResumeLayout(false);
            this.pnlNewAddress.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SoftwareTrainingApplication.Models.Tools.CustomPanel pnlBack;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlNewAddress;
        private kysToolDemo.KysTools.KYSButton btnAddAddress;
        private CheckListBox clistboxWebAddress;
        private System.Windows.Forms.Label label1;
        private kysToolDemo.KysTools.KYSTextBox txtWebAddress;
        private SoftwareTrainingApplication.Models.Tools.CustomPanel customPanel2;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Panel pnlFocus;
        private System.Windows.Forms.ComboBox cmboxTime;
        private kysToolDemo.KysTools.KYSToggleButton tbtnTimeLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private kysToolDemo.KysTools.KYSButton btnStartFocus;
        private kysToolDemo.KysTools.KYSButton btnClose;
        private kysToolDemo.KysTools.KYSButton btnMinimize;
        private SoftwareTrainingApplication.Models.Tools.CustomPanel customPanel3;
        private System.Windows.Forms.Label btnShowNewAddress;
        private kysToolDemo.KysTools.KYSButton btnFinishFocus;
        private System.Windows.Forms.Panel pnlSettigs;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

