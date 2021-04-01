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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeftGroup = new System.Windows.Forms.GroupBox();
            this.LeftFullPath = new System.Windows.Forms.TextBox();
            this.RightGroup = new System.Windows.Forms.GroupBox();
            this.RightFullPath = new System.Windows.Forms.TextBox();
            this.RightListView = new System.Windows.Forms.ListView();
            this.RightListNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightListExtensionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightListSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightListDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FocusPath = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpInGroup = new System.Windows.Forms.GroupBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.FindBookButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.LeftGroup.SuspendLayout();
            this.RightGroup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SignUpInGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveButton
            // 
            this.MoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MoveButton.BackColor = System.Drawing.SystemColors.Control;
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveButton.Location = new System.Drawing.Point(438, 11);
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
            this.CompressButton.Location = new System.Drawing.Point(0, 11);
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
            this.RenameButton.Location = new System.Drawing.Point(146, 11);
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
            this.CopyButton.Location = new System.Drawing.Point(292, 11);
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
            this.CreateNewFolderButton.Location = new System.Drawing.Point(584, 11);
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
            this.DeleteButton.Location = new System.Drawing.Point(730, 11);
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
            this.ExitButton.Location = new System.Drawing.Point(1022, 11);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindBookButton);
            this.groupBox1.Controls.Add(this.CompressButton);
            this.groupBox1.Controls.Add(this.RenameButton);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.CopyButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.MoveButton);
            this.groupBox1.Controls.Add(this.CreateNewFolderButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 655);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 38);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LeftGroup
            // 
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
            // LeftFullPath
            // 
            this.LeftFullPath.Location = new System.Drawing.Point(6, 23);
            this.LeftFullPath.Name = "LeftFullPath";
            this.LeftFullPath.Size = new System.Drawing.Size(532, 22);
            this.LeftFullPath.TabIndex = 12;
            // 
            // RightGroup
            // 
            this.RightGroup.Controls.Add(this.RightFullPath);
            this.RightGroup.Controls.Add(this.RightListView);
            this.RightGroup.Location = new System.Drawing.Point(594, 23);
            this.RightGroup.Name = "RightGroup";
            this.RightGroup.Size = new System.Drawing.Size(531, 594);
            this.RightGroup.TabIndex = 13;
            this.RightGroup.TabStop = false;
            this.RightGroup.Enter += new System.EventHandler(this.RightGroup_Enter);
            this.RightGroup.Leave += new System.EventHandler(this.RightGroup_Leave);
            // 
            // RightFullPath
            // 
            this.RightFullPath.Location = new System.Drawing.Point(0, 23);
            this.RightFullPath.Name = "RightFullPath";
            this.RightFullPath.Size = new System.Drawing.Size(531, 22);
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
            this.RightListView.Size = new System.Drawing.Size(531, 537);
            this.RightListView.TabIndex = 11;
            this.RightListView.UseCompatibleStateImageBehavior = false;
            this.RightListView.View = System.Windows.Forms.View.Details;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 22);
            this.textBox1.TabIndex = 14;
            // 
            // FocusPath
            // 
            this.FocusPath.AutoSize = true;
            this.FocusPath.Location = new System.Drawing.Point(538, 8);
            this.FocusPath.Name = "FocusPath";
            this.FocusPath.Size = new System.Drawing.Size(0, 17);
            this.FocusPath.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.FocusPath);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 627);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1188, 28);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
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
            // FindBookButton
            // 
            this.FindBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindBookButton.BackColor = System.Drawing.SystemColors.Control;
            this.FindBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindBookButton.Location = new System.Drawing.Point(876, 11);
            this.FindBookButton.Margin = new System.Windows.Forms.Padding(0);
            this.FindBookButton.Name = "FindBookButton";
            this.FindBookButton.Size = new System.Drawing.Size(146, 27);
            this.FindBookButton.TabIndex = 10;
            this.FindBookButton.Text = "F9 Find book";
            this.FindBookButton.UseVisualStyleBackColor = false;
            this.FindBookButton.Click += new System.EventHandler(this.FindBookButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 693);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SignUpInGroup);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.RightGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LeftGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.LeftGroup.ResumeLayout(false);
            this.LeftGroup.PerformLayout();
            this.RightGroup.ResumeLayout(false);
            this.RightGroup.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox LeftGroup;
        private System.Windows.Forms.GroupBox RightGroup;
        private System.Windows.Forms.ListView RightListView;
        private System.Windows.Forms.ColumnHeader RightListNameColumn;
        private System.Windows.Forms.ColumnHeader RightListExtensionColumn;
        private System.Windows.Forms.ColumnHeader RightListSizeColumn;
        private System.Windows.Forms.ColumnHeader RightListDateColumn;
        private System.Windows.Forms.TextBox LeftFullPath;
        private System.Windows.Forms.TextBox RightFullPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label FocusPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.GroupBox SignUpInGroup;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button FindBookButton;
    }
}

