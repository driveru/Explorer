namespace Exprorer_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveButton = new System.Windows.Forms.Button();
            this.CompressButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CreateNewFolderButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LeftListView = new System.Windows.Forms.ListView();
            this.LeftListNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftListExtensionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftListSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftListDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FooterGroup = new System.Windows.Forms.GroupBox();
            this.FindBookButton = new System.Windows.Forms.Button();
            this.LeftGroup = new System.Windows.Forms.GroupBox();
            this.LeftCancelSearchButton = new System.Windows.Forms.Button();
            this.LeftFullPath = new System.Windows.Forms.TextBox();
            this.RightGroup = new System.Windows.Forms.GroupBox();
            this.RightCancelSearchButton = new System.Windows.Forms.Button();
            this.RightFullPath = new System.Windows.Forms.TextBox();
            this.RightListView = new System.Windows.Forms.ListView();
            this.RightListNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightListExtensionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightListSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightListDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchKeyTexBox = new System.Windows.Forms.TextBox();
            this.FocusPath = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelDownloadButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackToExplorerButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpInGroup = new System.Windows.Forms.GroupBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FooterGroup.SuspendLayout();
            this.LeftGroup.SuspendLayout();
            this.RightGroup.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SignUpInGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveButton
            // 
            this.MoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MoveButton.BackColor = System.Drawing.SystemColors.Control;
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveButton.Location = new System.Drawing.Point(441, 11);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(146, 27);
            this.MoveButton.TabIndex = 3;
            this.MoveButton.Text = "F6 Move";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // CompressButton
            // 
            this.CompressButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CompressButton.BackColor = System.Drawing.SystemColors.Control;
            this.CompressButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompressButton.Location = new System.Drawing.Point(3, 11);
            this.CompressButton.Margin = new System.Windows.Forms.Padding(0);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(146, 27);
            this.CompressButton.TabIndex = 4;
            this.CompressButton.Text = "F3 Compress";
            this.CompressButton.UseVisualStyleBackColor = false;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RenameButton.BackColor = System.Drawing.SystemColors.Control;
            this.RenameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RenameButton.Location = new System.Drawing.Point(149, 11);
            this.RenameButton.Margin = new System.Windows.Forms.Padding(0);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(146, 27);
            this.RenameButton.TabIndex = 5;
            this.RenameButton.Text = "F4 Rename";
            this.RenameButton.UseVisualStyleBackColor = false;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CopyButton.BackColor = System.Drawing.SystemColors.Control;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyButton.Location = new System.Drawing.Point(295, 11);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(0);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(146, 27);
            this.CopyButton.TabIndex = 6;
            this.CopyButton.Text = "F5 Copy";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CreateNewFolderButton
            // 
            this.CreateNewFolderButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateNewFolderButton.BackColor = System.Drawing.SystemColors.Control;
            this.CreateNewFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateNewFolderButton.Location = new System.Drawing.Point(587, 11);
            this.CreateNewFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.CreateNewFolderButton.Name = "CreateNewFolderButton";
            this.CreateNewFolderButton.Size = new System.Drawing.Size(146, 27);
            this.CreateNewFolderButton.TabIndex = 7;
            this.CreateNewFolderButton.Text = "F7 NewFolder";
            this.CreateNewFolderButton.UseVisualStyleBackColor = false;
            this.CreateNewFolderButton.Click += new System.EventHandler(this.CreateNewFolderButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Location = new System.Drawing.Point(733, 11);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(146, 27);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "F8 Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(1025, 11);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(146, 27);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Alt+F4 Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LeftListView
            // 
            this.LeftListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LeftListNameColumn,
            this.LeftListExtensionColumn,
            this.LeftListSizeColumn,
            this.LeftListDateColumn});
            this.LeftListView.HideSelection = false;
            this.LeftListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LeftListView.Location = new System.Drawing.Point(6, 51);
            this.LeftListView.Name = "LeftListView";
            this.LeftListView.Size = new System.Drawing.Size(532, 537);
            this.LeftListView.TabIndex = 10;
            this.LeftListView.UseCompatibleStateImageBehavior = false;
            this.LeftListView.View = System.Windows.Forms.View.Details;
            this.LeftListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LeftListView_ColumnClick);
            this.LeftListView.SelectedIndexChanged += new System.EventHandler(this.LeftListView_SelectedIndexChanged);
            this.LeftListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LeftListView_MouseDoubleClick);
            // 
            // LeftListNameColumn
            // 
            this.LeftListNameColumn.Text = "Name";
            this.LeftListNameColumn.Width = 235;
            // 
            // LeftListExtensionColumn
            // 
            this.LeftListExtensionColumn.Text = "Ext";
            // 
            // LeftListSizeColumn
            // 
            this.LeftListSizeColumn.Text = "Size";
            // 
            // LeftListDateColumn
            // 
            this.LeftListDateColumn.Text = "Date";
            this.LeftListDateColumn.Width = 51;
            // 
            // FooterGroup
            // 
            this.FooterGroup.Controls.Add(this.FindBookButton);
            this.FooterGroup.Controls.Add(this.CompressButton);
            this.FooterGroup.Controls.Add(this.RenameButton);
            this.FooterGroup.Controls.Add(this.ExitButton);
            this.FooterGroup.Controls.Add(this.CopyButton);
            this.FooterGroup.Controls.Add(this.DeleteButton);
            this.FooterGroup.Controls.Add(this.MoveButton);
            this.FooterGroup.Controls.Add(this.CreateNewFolderButton);
            this.FooterGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterGroup.Location = new System.Drawing.Point(0, 655);
            this.FooterGroup.Name = "FooterGroup";
            this.FooterGroup.Size = new System.Drawing.Size(1195, 38);
            this.FooterGroup.TabIndex = 11;
            this.FooterGroup.TabStop = false;
            // 
            // FindBookButton
            // 
            this.FindBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindBookButton.BackColor = System.Drawing.SystemColors.Control;
            this.FindBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindBookButton.Location = new System.Drawing.Point(879, 11);
            this.FindBookButton.Margin = new System.Windows.Forms.Padding(0);
            this.FindBookButton.Name = "FindBookButton";
            this.FindBookButton.Size = new System.Drawing.Size(146, 27);
            this.FindBookButton.TabIndex = 10;
            this.FindBookButton.Text = "F9 Find book";
            this.FindBookButton.UseVisualStyleBackColor = false;
            this.FindBookButton.Click += new System.EventHandler(this.FindBookButton_Click);
            // 
            // LeftGroup
            // 
            this.LeftGroup.Controls.Add(this.LeftCancelSearchButton);
            this.LeftGroup.Controls.Add(this.LeftFullPath);
            this.LeftGroup.Controls.Add(this.LeftListView);
            this.LeftGroup.Location = new System.Drawing.Point(0, 23);
            this.LeftGroup.Name = "LeftGroup";
            this.LeftGroup.Size = new System.Drawing.Size(538, 594);
            this.LeftGroup.TabIndex = 12;
            this.LeftGroup.TabStop = false;
            this.LeftGroup.Enter += new System.EventHandler(this.LeftGroup_Enter);
            this.LeftGroup.Leave += new System.EventHandler(this.LeftGroup_Leave);
            // 
            // LeftCancelSearchButton
            // 
            this.LeftCancelSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftCancelSearchButton.BackgroundImage")));
            this.LeftCancelSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftCancelSearchButton.Location = new System.Drawing.Point(508, 51);
            this.LeftCancelSearchButton.Name = "LeftCancelSearchButton";
            this.LeftCancelSearchButton.Size = new System.Drawing.Size(30, 28);
            this.LeftCancelSearchButton.TabIndex = 20;
            this.LeftCancelSearchButton.UseVisualStyleBackColor = true;
            this.LeftCancelSearchButton.Visible = false;
            this.LeftCancelSearchButton.Click += new System.EventHandler(this.LeftCancelSearchButton_Click);
            // 
            // LeftFullPath
            // 
            this.LeftFullPath.Location = new System.Drawing.Point(6, 23);
            this.LeftFullPath.Name = "LeftFullPath";
            this.LeftFullPath.Size = new System.Drawing.Size(532, 22);
            this.LeftFullPath.TabIndex = 12;
            // 
            // RightGroup
            // 
            this.RightGroup.Controls.Add(this.RightCancelSearchButton);
            this.RightGroup.Controls.Add(this.RightFullPath);
            this.RightGroup.Controls.Add(this.RightListView);
            this.RightGroup.Location = new System.Drawing.Point(594, 23);
            this.RightGroup.Name = "RightGroup";
            this.RightGroup.Size = new System.Drawing.Size(574, 594);
            this.RightGroup.TabIndex = 13;
            this.RightGroup.TabStop = false;
            this.RightGroup.Enter += new System.EventHandler(this.RightGroup_Enter);
            this.RightGroup.Leave += new System.EventHandler(this.RightGroup_Leave);
            // 
            // RightCancelSearchButton
            // 
            this.RightCancelSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightCancelSearchButton.BackgroundImage")));
            this.RightCancelSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightCancelSearchButton.Location = new System.Drawing.Point(544, 51);
            this.RightCancelSearchButton.Name = "RightCancelSearchButton";
            this.RightCancelSearchButton.Size = new System.Drawing.Size(30, 28);
            this.RightCancelSearchButton.TabIndex = 19;
            this.RightCancelSearchButton.UseVisualStyleBackColor = true;
            this.RightCancelSearchButton.Visible = false;
            this.RightCancelSearchButton.Click += new System.EventHandler(this.RightCancelSearchButton_Click);
            // 
            // RightFullPath
            // 
            this.RightFullPath.Location = new System.Drawing.Point(0, 23);
            this.RightFullPath.Name = "RightFullPath";
            this.RightFullPath.Size = new System.Drawing.Size(574, 22);
            this.RightFullPath.TabIndex = 13;
            // 
            // RightListView
            // 
            this.RightListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RightListNameColumn,
            this.RightListExtensionColumn,
            this.RightListSizeColumn,
            this.RightListDateColumn});
            this.RightListView.HideSelection = false;
            this.RightListView.Location = new System.Drawing.Point(0, 51);
            this.RightListView.Name = "RightListView";
            this.RightListView.Size = new System.Drawing.Size(574, 537);
            this.RightListView.TabIndex = 11;
            this.RightListView.UseCompatibleStateImageBehavior = false;
            this.RightListView.View = System.Windows.Forms.View.Details;
            this.RightListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.RightListView_ColumnClick);
            this.RightListView.SelectedIndexChanged += new System.EventHandler(this.RightListView_SelectedIndexChanged);
            this.RightListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RightListView_MouseDoubleClick);
            // 
            // RightListNameColumn
            // 
            this.RightListNameColumn.Text = "Name";
            this.RightListNameColumn.Width = 229;
            // 
            // RightListExtensionColumn
            // 
            this.RightListExtensionColumn.Text = "Ext";
            // 
            // RightListSizeColumn
            // 
            this.RightListSizeColumn.Text = "Size";
            // 
            // RightListDateColumn
            // 
            this.RightListDateColumn.Text = "Date";
            // 
            // SearchKeyTexBox
            // 
            this.SearchKeyTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchKeyTexBox.Location = new System.Drawing.Point(572, 9);
            this.SearchKeyTexBox.Name = "SearchKeyTexBox";
            this.SearchKeyTexBox.Size = new System.Drawing.Size(553, 26);
            this.SearchKeyTexBox.TabIndex = 14;
            // 
            // FocusPath
            // 
            this.FocusPath.AutoSize = true;
            this.FocusPath.Location = new System.Drawing.Point(538, 8);
            this.FocusPath.Name = "FocusPath";
            this.FocusPath.Size = new System.Drawing.Size(0, 17);
            this.FocusPath.TabIndex = 15;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.CancelDownloadButton);
            this.SearchGroupBox.Controls.Add(this.DownloadButton);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Controls.Add(this.BackToExplorerButton);
            this.SearchGroupBox.Controls.Add(this.SearchKeyTexBox);
            this.SearchGroupBox.Controls.Add(this.FocusPath);
            this.SearchGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchGroupBox.Location = new System.Drawing.Point(0, 617);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(1195, 38);
            this.SearchGroupBox.TabIndex = 15;
            this.SearchGroupBox.TabStop = false;
            // 
            // CancelDownloadButton
            // 
            this.CancelDownloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelDownloadButton.BackgroundImage")));
            this.CancelDownloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelDownloadButton.Location = new System.Drawing.Point(140, 9);
            this.CancelDownloadButton.Name = "CancelDownloadButton";
            this.CancelDownloadButton.Size = new System.Drawing.Size(30, 28);
            this.CancelDownloadButton.TabIndex = 20;
            this.CancelDownloadButton.UseVisualStyleBackColor = true;
            this.CancelDownloadButton.Visible = false;
            this.CancelDownloadButton.Click += new System.EventHandler(this.CancelDownloadButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownloadButton.BackgroundImage")));
            this.DownloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownloadButton.Location = new System.Drawing.Point(1161, 8);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(29, 30);
            this.DownloadButton.TabIndex = 18;
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Location = new System.Drawing.Point(1127, 8);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(29, 30);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BackToExplorerButton
            // 
            this.BackToExplorerButton.Location = new System.Drawing.Point(6, 7);
            this.BackToExplorerButton.Name = "BackToExplorerButton";
            this.BackToExplorerButton.Size = new System.Drawing.Size(128, 32);
            this.BackToExplorerButton.TabIndex = 16;
            this.BackToExplorerButton.Text = "Back to explorer";
            this.BackToExplorerButton.UseVisualStyleBackColor = true;
            this.BackToExplorerButton.Visible = false;
            this.BackToExplorerButton.Click += new System.EventHandler(this.BackToExplorerButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(0, 0);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(84, 28);
            this.SignInButton.TabIndex = 16;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignUpInGroup
            // 
            this.SignUpInGroup.Controls.Add(this.SignUpButton);
            this.SignUpInGroup.Controls.Add(this.SignInButton);
            this.SignUpInGroup.Location = new System.Drawing.Point(0, 0);
            this.SignUpInGroup.Name = "SignUpInGroup";
            this.SignUpInGroup.Size = new System.Drawing.Size(166, 29);
            this.SignUpInGroup.TabIndex = 17;
            this.SignUpInGroup.TabStop = false;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(81, 0);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(84, 28);
            this.SignUpButton.TabIndex = 17;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(1042, 0);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(83, 28);
            this.LogOutButton.TabIndex = 18;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Visible = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(12, 6);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(46, 17);
            this.UserNameLabel.TabIndex = 18;
            this.UserNameLabel.Text = "label3";
            this.UserNameLabel.Visible = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(962, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(83, 28);
            this.SettingsButton.TabIndex = 19;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Visible = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "email pattern"});
            this.comboBox1.Location = new System.Drawing.Point(411, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 693);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SignUpInGroup);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.RightGroup);
            this.Controls.Add(this.FooterGroup);
            this.Controls.Add(this.LeftGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.FooterGroup.ResumeLayout(false);
            this.LeftGroup.ResumeLayout(false);
            this.LeftGroup.PerformLayout();
            this.RightGroup.ResumeLayout(false);
            this.RightGroup.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.SignUpInGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button CompressButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button CreateNewFolderButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView LeftListView;
        private System.Windows.Forms.ColumnHeader LeftListNameColumn;
        private System.Windows.Forms.ColumnHeader LeftListExtensionColumn;
        private System.Windows.Forms.ColumnHeader LeftListSizeColumn;
        private System.Windows.Forms.ColumnHeader LeftListDateColumn;
        private System.Windows.Forms.GroupBox FooterGroup;
        private System.Windows.Forms.GroupBox LeftGroup;
        private System.Windows.Forms.GroupBox RightGroup;
        private System.Windows.Forms.ListView RightListView;
        private System.Windows.Forms.ColumnHeader RightListNameColumn;
        private System.Windows.Forms.ColumnHeader RightListExtensionColumn;
        private System.Windows.Forms.ColumnHeader RightListSizeColumn;
        private System.Windows.Forms.ColumnHeader RightListDateColumn;
        private System.Windows.Forms.TextBox LeftFullPath;
        private System.Windows.Forms.TextBox RightFullPath;
        private System.Windows.Forms.TextBox SearchKeyTexBox;
        private System.Windows.Forms.Label FocusPath;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.GroupBox SignUpInGroup;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button FindBookButton;
        private System.Windows.Forms.Button BackToExplorerButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button LeftCancelSearchButton;
        private System.Windows.Forms.Button RightCancelSearchButton;
        private System.Windows.Forms.Button CancelDownloadButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

