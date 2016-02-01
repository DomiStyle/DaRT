namespace DaRT
{
    partial class GUImain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUImain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dart = new System.Windows.Forms.PictureBox();
            this.nextRefresh = new System.Windows.Forms.ProgressBar();
            this.execute = new System.Windows.Forms.Button();
            this.hosts = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lastRefresh = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.host = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.playersTab = new System.Windows.Forms.TabPage();
            this.playerList = new System.Windows.Forms.ListView();
            this.bansTab = new System.Windows.Forms.TabPage();
            this.bansList = new System.Windows.Forms.ListView();
            this.playerdatabaseTab = new System.Windows.Forms.TabPage();
            this.playerDBList = new System.Windows.Forms.ListView();
            this.playerCounter = new System.Windows.Forms.Label();
            this.news = new System.Windows.Forms.Label();
            this.banCounter = new System.Windows.Forms.Label();
            this.adminCounter = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.allowMessages = new System.Windows.Forms.CheckBox();
            this.logTabs = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.all = new DaRT.ExtendedRichTextBox();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.console = new DaRT.ExtendedRichTextBox();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.chat = new DaRT.ExtendedRichTextBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.logs = new DaRT.ExtendedRichTextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.autoRefresh = new System.Windows.Forms.CheckBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.banner = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.playersTab.SuspendLayout();
            this.bansTab.SuspendLayout();
            this.playerdatabaseTab.SuspendLayout();
            this.logTabs.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dart);
            this.splitContainer1.Panel1.Controls.Add(this.nextRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.execute);
            this.splitContainer1.Panel1.Controls.Add(this.hosts);
            this.splitContainer1.Panel1.Controls.Add(this.settings);
            this.splitContainer1.Panel1.Controls.Add(this.logo);
            this.splitContainer1.Panel1.Controls.Add(this.lastRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.refresh);
            this.splitContainer1.Panel1.Controls.Add(this.disconnect);
            this.splitContainer1.Panel1.Controls.Add(this.connect);
            this.splitContainer1.Panel1.Controls.Add(this.password);
            this.splitContainer1.Panel1.Controls.Add(this.passwordLabel);
            this.splitContainer1.Panel1.Controls.Add(this.portLabel);
            this.splitContainer1.Panel1.Controls.Add(this.hostLabel);
            this.splitContainer1.Panel1.Controls.Add(this.port);
            this.splitContainer1.Panel1.Controls.Add(this.host);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 571);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 0;
            // 
            // dart
            // 
            this.dart.Image = global::DaRT.Properties.Resources.konami;
            this.dart.Location = new System.Drawing.Point(0, 0);
            this.dart.Name = "dart";
            this.dart.Size = new System.Drawing.Size(10, 10);
            this.dart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dart.TabIndex = 1;
            this.dart.TabStop = false;
            this.dart.Visible = false;
            this.dart.Click += new System.EventHandler(this.dart_Click);
            // 
            // nextRefresh
            // 
            this.nextRefresh.Location = new System.Drawing.Point(9, 339);
            this.nextRefresh.Maximum = 10;
            this.nextRefresh.Name = "nextRefresh";
            this.nextRefresh.Size = new System.Drawing.Size(120, 10);
            this.nextRefresh.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.nextRefresh.TabIndex = 21;
            // 
            // execute
            // 
            this.execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.execute.Enabled = false;
            this.execute.Location = new System.Drawing.Point(9, 507);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(120, 23);
            this.execute.TabIndex = 20;
            this.execute.Text = "Execute...";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // hosts
            // 
            this.hosts.Location = new System.Drawing.Point(9, 362);
            this.hosts.Name = "hosts";
            this.hosts.Size = new System.Drawing.Size(120, 23);
            this.hosts.TabIndex = 18;
            this.hosts.Text = "Load host";
            this.hosts.UseVisualStyleBackColor = true;
            this.hosts.Click += new System.EventHandler(this.hosts_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings.Location = new System.Drawing.Point(9, 536);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(120, 23);
            this.settings.TabIndex = 17;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(6, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(130, 62);
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // lastRefresh
            // 
            this.lastRefresh.AutoSize = true;
            this.lastRefresh.Location = new System.Drawing.Point(17, 321);
            this.lastRefresh.Name = "lastRefresh";
            this.lastRefresh.Size = new System.Drawing.Size(100, 13);
            this.lastRefresh.TabIndex = 12;
            this.lastRefresh.Text = "Last refresh: 0s ago";
            // 
            // refresh
            // 
            this.refresh.Enabled = false;
            this.refresh.Location = new System.Drawing.Point(9, 295);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(120, 23);
            this.refresh.TabIndex = 9;
            this.refresh.Text = "Refresh (F5)";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Location = new System.Drawing.Point(9, 266);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(120, 23);
            this.disconnect.TabIndex = 8;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(9, 237);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(120, 23);
            this.connect.TabIndex = 6;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(9, 211);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(120, 20);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(44, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(55, 156);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(55, 117);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(29, 13);
            this.hostLabel.TabIndex = 2;
            this.hostLabel.Text = "Host";
            this.hostLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(9, 172);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(120, 20);
            this.port.TabIndex = 1;
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(9, 133);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(120, 20);
            this.host.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl);
            this.splitContainer2.Panel1.Controls.Add(this.playerCounter);
            this.splitContainer2.Panel1.Controls.Add(this.news);
            this.splitContainer2.Panel1.Controls.Add(this.banCounter);
            this.splitContainer2.Panel1.Controls.Add(this.adminCounter);
            this.splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.counter);
            this.splitContainer2.Panel2.Controls.Add(this.allowMessages);
            this.splitContainer2.Panel2.Controls.Add(this.logTabs);
            this.splitContainer2.Panel2.Controls.Add(this.search);
            this.splitContainer2.Panel2.Controls.Add(this.searchButton);
            this.splitContainer2.Panel2.Controls.Add(this.autoRefresh);
            this.splitContainer2.Panel2.Controls.Add(this.filter);
            this.splitContainer2.Panel2.Controls.Add(this.searchLabel);
            this.splitContainer2.Panel2.Controls.Add(this.input);
            this.splitContainer2.Panel2.Controls.Add(this.banner);
            this.splitContainer2.Panel2.Controls.Add(this.options);
            this.splitContainer2.Panel2MinSize = 50;
            this.splitContainer2.Size = new System.Drawing.Size(1041, 571);
            this.splitContainer2.SplitterDistance = 329;
            this.splitContainer2.TabIndex = 21;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.playersTab);
            this.tabControl.Controls.Add(this.bansTab);
            this.tabControl.Controls.Add(this.playerdatabaseTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1041, 329);
            this.tabControl.TabIndex = 11;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // playersTab
            // 
            this.playersTab.Controls.Add(this.playerList);
            this.playersTab.Location = new System.Drawing.Point(4, 22);
            this.playersTab.Name = "playersTab";
            this.playersTab.Size = new System.Drawing.Size(1033, 303);
            this.playersTab.TabIndex = 0;
            this.playersTab.Text = "Players";
            this.playersTab.UseVisualStyleBackColor = true;
            // 
            // playerList
            // 
            this.playerList.AllowColumnReorder = true;
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerList.FullRowSelect = true;
            this.playerList.GridLines = true;
            this.playerList.Location = new System.Drawing.Point(0, 0);
            this.playerList.MultiSelect = false;
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(1033, 303);
            this.playerList.TabIndex = 0;
            this.playerList.UseCompatibleStateImageBehavior = false;
            this.playerList.View = System.Windows.Forms.View.Details;
            this.playerList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerList_ColumnClick);
            this.playerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerList_MouseDown);
            // 
            // bansTab
            // 
            this.bansTab.Controls.Add(this.bansList);
            this.bansTab.Location = new System.Drawing.Point(4, 22);
            this.bansTab.Name = "bansTab";
            this.bansTab.Size = new System.Drawing.Size(1033, 303);
            this.bansTab.TabIndex = 1;
            this.bansTab.Text = "Bans";
            this.bansTab.UseVisualStyleBackColor = true;
            // 
            // bansList
            // 
            this.bansList.AllowColumnReorder = true;
            this.bansList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bansList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bansList.FullRowSelect = true;
            this.bansList.GridLines = true;
            this.bansList.Location = new System.Drawing.Point(0, 0);
            this.bansList.MultiSelect = false;
            this.bansList.Name = "bansList";
            this.bansList.Size = new System.Drawing.Size(1033, 303);
            this.bansList.TabIndex = 10;
            this.bansList.UseCompatibleStateImageBehavior = false;
            this.bansList.View = System.Windows.Forms.View.Details;
            this.bansList.VirtualMode = true;
            this.bansList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.bansList_ColumnClick);
            this.bansList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.bansList_RetrieveVirtualItem);
            this.bansList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bansList_MouseDown);
            // 
            // playerdatabaseTab
            // 
            this.playerdatabaseTab.Controls.Add(this.playerDBList);
            this.playerdatabaseTab.Location = new System.Drawing.Point(4, 22);
            this.playerdatabaseTab.Name = "playerdatabaseTab";
            this.playerdatabaseTab.Size = new System.Drawing.Size(1033, 303);
            this.playerdatabaseTab.TabIndex = 2;
            this.playerdatabaseTab.Text = "Player Database";
            this.playerdatabaseTab.UseVisualStyleBackColor = true;
            // 
            // playerDBList
            // 
            this.playerDBList.AllowColumnReorder = true;
            this.playerDBList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerDBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerDBList.FullRowSelect = true;
            this.playerDBList.GridLines = true;
            this.playerDBList.Location = new System.Drawing.Point(0, 0);
            this.playerDBList.MultiSelect = false;
            this.playerDBList.Name = "playerDBList";
            this.playerDBList.Size = new System.Drawing.Size(1033, 303);
            this.playerDBList.TabIndex = 11;
            this.playerDBList.UseCompatibleStateImageBehavior = false;
            this.playerDBList.View = System.Windows.Forms.View.Details;
            this.playerDBList.VirtualMode = true;
            this.playerDBList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerDBList_ColumnClick);
            this.playerDBList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.playerDBList_RetrieveVirtualItem);
            this.playerDBList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerDBList_MouseDown);
            // 
            // playerCounter
            // 
            this.playerCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerCounter.AutoSize = true;
            this.playerCounter.Location = new System.Drawing.Point(823, 4);
            this.playerCounter.Name = "playerCounter";
            this.playerCounter.Size = new System.Drawing.Size(53, 13);
            this.playerCounter.TabIndex = 16;
            this.playerCounter.Text = "Players: 0";
            // 
            // news
            // 
            this.news.AutoSize = true;
            this.news.Location = new System.Drawing.Point(252, 4);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(82, 13);
            this.news.TabIndex = 19;
            this.news.Text = "Loading news...";
            this.news.Click += new System.EventHandler(this.news_Click);
            // 
            // banCounter
            // 
            this.banCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.banCounter.AutoSize = true;
            this.banCounter.Location = new System.Drawing.Point(965, 4);
            this.banCounter.Name = "banCounter";
            this.banCounter.Size = new System.Drawing.Size(43, 13);
            this.banCounter.TabIndex = 17;
            this.banCounter.Text = "Bans: 0";
            // 
            // adminCounter
            // 
            this.adminCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminCounter.AutoSize = true;
            this.adminCounter.Location = new System.Drawing.Point(896, 4);
            this.adminCounter.Name = "adminCounter";
            this.adminCounter.Size = new System.Drawing.Size(53, 13);
            this.adminCounter.TabIndex = 18;
            this.adminCounter.Text = "Admins: 0";
            // 
            // counter
            // 
            this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.counter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(92, 215);
            this.counter.Margin = new System.Windows.Forms.Padding(0);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(50, 20);
            this.counter.TabIndex = 1;
            this.counter.Text = "0/400";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // allowMessages
            // 
            this.allowMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allowMessages.AutoSize = true;
            this.allowMessages.Checked = true;
            this.allowMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowMessages.Location = new System.Drawing.Point(825, 3);
            this.allowMessages.Name = "allowMessages";
            this.allowMessages.Size = new System.Drawing.Size(124, 17);
            this.allowMessages.TabIndex = 22;
            this.allowMessages.Text = "Allow new messages";
            this.allowMessages.UseVisualStyleBackColor = true;
            this.allowMessages.CheckedChanged += new System.EventHandler(this.autoScroll_CheckedChanged);
            // 
            // logTabs
            // 
            this.logTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.logTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTabs.Controls.Add(this.tabAll);
            this.logTabs.Controls.Add(this.tabConsole);
            this.logTabs.Controls.Add(this.tabChat);
            this.logTabs.Controls.Add(this.tabLog);
            this.logTabs.Location = new System.Drawing.Point(0, 23);
            this.logTabs.Margin = new System.Windows.Forms.Padding(0);
            this.logTabs.Multiline = true;
            this.logTabs.Name = "logTabs";
            this.logTabs.Padding = new System.Drawing.Point(0, 0);
            this.logTabs.SelectedIndex = 0;
            this.logTabs.Size = new System.Drawing.Size(1047, 188);
            this.logTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.logTabs.TabIndex = 21;
            // 
            // tabAll
            // 
            this.tabAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAll.Controls.Add(this.all);
            this.tabAll.Location = new System.Drawing.Point(23, 4);
            this.tabAll.Margin = new System.Windows.Forms.Padding(0);
            this.tabAll.Name = "tabAll";
            this.tabAll.Size = new System.Drawing.Size(1020, 180);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "All";
            // 
            // all
            // 
            this.all.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.all.Location = new System.Drawing.Point(0, 0);
            this.all.Margin = new System.Windows.Forms.Padding(0);
            this.all.Name = "all";
            this.all.ReadOnly = true;
            this.all.Size = new System.Drawing.Size(1018, 178);
            this.all.TabIndex = 1;
            this.all.Text = "";
            this.all.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
            // 
            // tabConsole
            // 
            this.tabConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabConsole.Controls.Add(this.console);
            this.tabConsole.Location = new System.Drawing.Point(23, 4);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Size = new System.Drawing.Size(1020, 180);
            this.tabConsole.TabIndex = 1;
            this.tabConsole.Text = "Console";
            // 
            // console
            // 
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Margin = new System.Windows.Forms.Padding(0);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(1018, 178);
            this.console.TabIndex = 2;
            this.console.Text = "";
            this.console.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
            // 
            // tabChat
            // 
            this.tabChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabChat.Controls.Add(this.chat);
            this.tabChat.Location = new System.Drawing.Point(23, 4);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(1020, 180);
            this.tabChat.TabIndex = 2;
            this.tabChat.Text = "Chat";
            // 
            // chat
            // 
            this.chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chat.Location = new System.Drawing.Point(0, 0);
            this.chat.Margin = new System.Windows.Forms.Padding(0);
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.Size = new System.Drawing.Size(1018, 178);
            this.chat.TabIndex = 3;
            this.chat.Text = "";
            this.chat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
            // 
            // tabLog
            // 
            this.tabLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLog.Controls.Add(this.logs);
            this.tabLog.Location = new System.Drawing.Point(23, 4);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(1020, 180);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = "Log";
            // 
            // logs
            // 
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.logs.Location = new System.Drawing.Point(0, 0);
            this.logs.Margin = new System.Windows.Forms.Padding(0);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(1018, 178);
            this.logs.TabIndex = 3;
            this.logs.Text = "";
            this.logs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(196, 1);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(534, 20);
            this.search.TabIndex = 13;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(736, -1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 23);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // autoRefresh
            // 
            this.autoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoRefresh.AutoSize = true;
            this.autoRefresh.Location = new System.Drawing.Point(954, 3);
            this.autoRefresh.Name = "autoRefresh";
            this.autoRefresh.Size = new System.Drawing.Size(88, 17);
            this.autoRefresh.TabIndex = 15;
            this.autoRefresh.Text = "Auto Refresh";
            this.autoRefresh.UseVisualStyleBackColor = true;
            // 
            // filter
            // 
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(54, 0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(136, 21);
            this.filter.TabIndex = 14;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(4, 4);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search:";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.AutoCompleteCustomSource.AddRange(new string[] {
            "ban",
            "addBan",
            "removeBan",
            "writeBans",
            "loadScripts",
            "missions",
            "kick",
            "RConPassword",
            "MaxPing",
            "say",
            "update"});
            this.input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.input.Enabled = false;
            this.input.Location = new System.Drawing.Point(145, 215);
            this.input.MaxLength = 400;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(537, 20);
            this.input.TabIndex = 2;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.ImageLocation = "";
            this.banner.Location = new System.Drawing.Point(688, 215);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(350, 20);
            this.banner.TabIndex = 10;
            this.banner.TabStop = false;
            this.banner.Click += new System.EventHandler(this.banner_Click);
            // 
            // options
            // 
            this.options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.options.FormattingEnabled = true;
            this.options.Items.AddRange(new object[] {
            "Say Global",
            "Console"});
            this.options.Location = new System.Drawing.Point(3, 214);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(86, 21);
            this.options.TabIndex = 3;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GUImain
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1184, 571);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1000, 610);
            this.Name = "GUImain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaRT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.playersTab.ResumeLayout(false);
            this.bansTab.ResumeLayout(false);
            this.playerdatabaseTab.ResumeLayout(false);
            this.logTabs.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabChat.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ListView bansList;
        private System.Windows.Forms.ListView playerDBList;
        private System.Windows.Forms.Label lastRefresh;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox autoRefresh;
        private ExtendedRichTextBox all;
        public System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button hosts;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.TabPage playersTab;
        private System.Windows.Forms.TabPage bansTab;
        private System.Windows.Forms.TabPage playerdatabaseTab;
        private System.Windows.Forms.Label banCounter;
        private System.Windows.Forms.Label playerCounter;
        private System.Windows.Forms.Label adminCounter;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox port;
        public System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label news;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl logTabs;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.CheckBox allowMessages;
        private ExtendedRichTextBox console;
        private ExtendedRichTextBox chat;
        private ExtendedRichTextBox logs;
        public System.Windows.Forms.TextBox search;
        public System.Windows.Forms.ProgressBar nextRefresh;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.PictureBox dart;
    }
}

