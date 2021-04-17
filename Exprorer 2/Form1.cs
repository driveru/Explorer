using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Compression;
using Microsoft.VisualBasic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Exprorer_2
{
    public partial class Form1 : Form
    {
        static private bool left_focused;
        static private ListViewItem selected_item;
        private User user;
        private CancellationTokenSource left_cancellation_src;
        private CancellationTokenSource right_cancellation_src;
        private CancellationTokenSource download_cancellation_src;

        public Form1()
        {
            InitializeComponent();
            PrintDrives(LeftListView, LeftFullPath);
            PrintDrives(RightListView, RightFullPath);
        }
        public Form1(User user)
        {           
            InitializeComponent();
            this.user = user;
            PrintDrives(LeftListView, LeftFullPath);
            PrintDrives(RightListView, RightFullPath);
            this.Text = user.explorer_label;
            SignUpInGroup.Visible = false;
            LogOutButton.Visible = true;
            SettingsButton.Visible = true;
            UserNameLabel.Visible = true;
            UserNameLabel.Text = $"Hey, {user.login} !";
        }

        private void ExpandDirectory(ListView CurrentListView, string path)
        {
            try
            {
                CurrentListView.Items.Clear();
                CurrentListView.ListViewItemSorter = null;
                DirectoryInfo di = new DirectoryInfo(path); 
                CurrentListView.Items.Add(new ListViewItem(new string[] { "return" }));
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    CurrentListView.Items.Add(new ListViewItem(new string[] { dir.Name, dir.Extension, "", dir.CreationTime.ToShortDateString()}));
                }
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    CurrentListView.Items.Add(new ListViewItem(new string[] { file.Name, file.Extension, file.Length.ToString() + "bytes", file.CreationTime.ToShortDateString()}));
                }
                selected_item = null;
            }
            catch (IOException)
            {
                TextBox textBox = (CurrentListView == LeftListView) ? LeftFullPath : RightFullPath;
                PrintDrives(CurrentListView, textBox);
            }
            catch (UnauthorizedAccessException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (ArgumentException)
            {
                TextBox textBox = (CurrentListView == LeftListView) ? LeftFullPath : RightFullPath;
                PrintDrives(CurrentListView, textBox);
            }
        }

        private void LeftListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MouseDoubleCLickEvent(LeftListView, LeftFullPath);        
        }
        private void RightListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MouseDoubleCLickEvent(RightListView, RightFullPath);
        }
        private void MouseDoubleCLickEvent(ListView listView, TextBox textBox)
        {
            if (listView.SelectedItems[0] == null) { return; }

            if (textBox.Text == "Books")
            {
                string book_label = listView.SelectedItems[0].SubItems[3].Text;
                Process.Start(book_label);
            }
            else if (textBox.Text == "Search results")
            {
                if (Path.GetExtension(listView.SelectedItems[0].Text) != "")
                {
                    Process.Start(listView.SelectedItems[0].SubItems[1].Text);
                }
                else
                {
                    textBox.Text = GetParentPath(listView.SelectedItems[0].SubItems[1].Text);
                    MouseDoubleCLickEvent(listView, textBox);
                }
            }
            else
            {
                if (Path.GetExtension(listView.SelectedItems[0].Text) != "")
                {
                    Process.Start(Path.Combine(textBox.Text, listView.SelectedItems[0].Text));
                }
                else
                {
                    listView.Columns.Clear();
                    listView.Columns.Add("Name");
                    listView.Columns.Add("Ext");
                    listView.Columns.Add("Size");
                    listView.Columns.Add("Date");

                    if (listView.SelectedItems[0].Text == "return")
                    {
                        try
                        {
                            textBox.Text = GetParentPath(textBox.Text);
                            ExpandDirectory(listView, textBox.Text);
                        }
                        catch (IndexOutOfRangeException) { PrintDrives(listView, textBox); }
                    }
                    else
                    {
                        textBox.Text = (textBox.Text == "") ? listView.SelectedItems[0].Text : Path.Combine(textBox.Text, listView.SelectedItems[0].Text);
                        ExpandDirectory(listView, textBox.Text);
                    }
                    FocusPath.Text = textBox.Text;
                }
            }
            
        }
        private void PrintDrives(ListView listView, TextBox textBox)
        {
            listView.Items.Clear();
            textBox.Text = "";
            listView.Columns.Clear();
            listView.Columns.Add("Name");
            listView.Columns.Add("Ext");
            listView.Columns.Add("Size");
            listView.Columns.Add("Date");

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    listView.Items.Add(new ListViewItem(new string[] { drive.Name }));
                }
            }
        }
        private string GetParentPath(string path)
        {
            path = path.Substring(0, path.Length - 1);
            char el = path[path.Length - 1];
            while (el != '\\') 
            {
                path = path.Substring(0, path.Length - 1);
                el = path[path.Length - 1];
            }
            return path;
        }

        private void LeftGroup_Enter(object sender, EventArgs e)
        {
            LeftListView.BackColor = Color.FromArgb(252, 252, 252);
            LeftFullPath.BackColor = Color.FromArgb(252, 252, 252);
            left_focused = true;
            FocusPath.Text = LeftFullPath.Text;
        }

        private void RightGroup_Enter(object sender, EventArgs e)
        {
            RightListView.BackColor = Color.FromArgb(252, 252, 252);
            RightFullPath.BackColor = Color.FromArgb(252, 252, 252);
            left_focused = false;
            FocusPath.Text = RightFullPath.Text;
        }

        private void LeftGroup_Leave(object sender, EventArgs e)
        {
            LeftListView.BackColor = Color.FromArgb(255, 255, 255);
            LeftFullPath.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void RightGroup_Leave(object sender, EventArgs e)
        {
            RightListView.BackColor = Color.FromArgb(255, 255, 255);
            RightFullPath.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void Copy()
        {
            string source = left_focused ? LeftFullPath.Text : RightFullPath.Text;
            string destination = left_focused ? RightFullPath.Text : LeftFullPath.Text;
            if (!String.IsNullOrEmpty(source) && !String.IsNullOrEmpty(destination) && (selected_item != null))
            {
                try
                {
                    string folder_or_file_name = selected_item.Text;
                    source = Path.Combine(source, folder_or_file_name);
                    destination = Path.Combine(destination, folder_or_file_name);
                    if (Path.GetExtension(source) == "")
                    {                                           
                        Directory.CreateDirectory(destination);
                        if (Directory.Exists(source))
                        {
                            string[] files = Directory.GetFiles(source);

                            // Copy the files and overwrite destination files if they already exist.
                            foreach (string s in files)
                            {
                                // Use static Path methods to extract only the file name from the path.
                                string fileName = Path.GetFileName(s);
                                string destFile = Path.Combine(destination, fileName);
                                File.Copy(s, destFile, true);
                            }
                            MessageBox.Show($"Directory {source} was successfully copied to {destination} !");
                            UpdateLists(); 
                        }
                        else
                        {
                            MessageBox.Show("Source path does not exist!");
                        }
                    }
                    else
                    {
                        File.Copy(source, destination, true);
                        MessageBox.Show($"File {source} was successfully copied to {destination} !");
                        UpdateLists();
                    }
                }
                catch (UnauthorizedAccessException ex) { MessageBox.Show(ex.Message); }
                catch (IOException ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Wrong source or destination path !");
            }
            
        }

        private void LeftListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_item = LeftListView.SelectedItems.Count != 0 ? LeftListView.SelectedItems[0] : null;
        }

        private void RightListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RightListView.SelectedItems.Count != 0)
                selected_item = RightListView.SelectedItems[0];
        }
        private void UpdateLists()
        {
            if (RightFullPath.Text != "Books")
                ExpandDirectory(RightListView, RightFullPath.Text);

            if (LeftFullPath.Text != "Books")
                ExpandDirectory(LeftListView, LeftFullPath.Text);
            
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            string source = left_focused ? LeftFullPath.Text : RightFullPath.Text;
            string destination = left_focused ? RightFullPath.Text : LeftFullPath.Text;
            if (!String.IsNullOrEmpty(source) && !String.IsNullOrEmpty(destination) && (selected_item != null))
            {
                string folder_or_file_name = selected_item.Text;
                source = Path.Combine(source, folder_or_file_name);
                destination = Path.Combine(destination, folder_or_file_name);
                try
                {
                    if (Path.GetExtension(source) == "")
                    {
                        Directory.Move(source, destination);
                        MessageBox.Show($"Directory {source} was successfully moved to {destination} !");                 
                    }
                    else
                    {
                        File.Move(source, destination);
                        MessageBox.Show($"File {source} was successfully moved to {destination} !");
                    }
                    UpdateLists();
                }
                catch (UnauthorizedAccessException ex) { MessageBox.Show(ex.Message); }
                catch (IOException ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = left_focused ? LeftFullPath.Text : RightFullPath.Text;
                string folder_or_file_name = selected_item.Text;
                path = Path.Combine(path, folder_or_file_name);
                File.Delete(path);
                MessageBox.Show($"File {path} was succesfully deleted !");
                UpdateLists();
            }
            catch (UnauthorizedAccessException ex) { MessageBox.Show(ex.Message); }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            string source = left_focused ? LeftFullPath.Text : RightFullPath.Text;
            string destination = left_focused ? RightFullPath.Text : LeftFullPath.Text;
            if (!String.IsNullOrEmpty(source) && !String.IsNullOrEmpty(destination) && (selected_item != null))
            {
                try
                {
                    string folder_or_file_name = selected_item.Text;
                    source = Path.Combine(source, folder_or_file_name);
                    destination = Path.Combine(destination, folder_or_file_name);
                    destination += ".zip";
                    ZipFile.CreateFromDirectory(source, destination);
                    MessageBox.Show($"{source} was succesfully compressed to {destination} !");
                    UpdateLists();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                ExitButton_Click(this, new EventArgs());
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.F3:
                        CompressButton_Click(this, new EventArgs());
                        break;
                    case Keys.F4:
                        RenameButton_Click(this, new EventArgs());
                        break;
                    case Keys.F5:
                        CopyButton_Click(this, new EventArgs());
                        break;
                    case Keys.F6:
                        MoveButton_Click(this, new EventArgs());
                        break;
                    case Keys.F7:
                        CreateNewFolderButton_Click(this, new EventArgs());
                        break;
                    case Keys.F8:
                        DeleteButton_Click(this, new EventArgs());
                        break;
                }                   
            }
        }

        private void CreateNewFolderButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string path = left_focused ? LeftFullPath.Text : RightFullPath.Text;
            path = (selected_item == null || Path.GetExtension(selected_item.Text) != "") ? path : Path.Combine(path, selected_item.Text);
            if (!String.IsNullOrEmpty(path))
            {
                InputNewName folder_name_form = new InputNewName($"Input name for new folder");
                if (folder_name_form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Directory.CreateDirectory(Path.Combine(path, folder_name_form.GetNewName()));
                        MessageBox.Show($"New folder {folder_name_form.GetNewName()} was successfully created at {path}!");
                        UpdateLists();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                folder_name_form.Dispose();
            }
            this.Enabled = true;
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string path = left_focused ? LeftFullPath.Text : RightFullPath.Text;

            if (!String.IsNullOrEmpty(path) && (selected_item != null))
            {
                string old_folder_or_file_name = selected_item.Text;
                string old_path = Path.Combine(path, old_folder_or_file_name);
                string folder_or_file;
                if (Path.GetExtension(old_path) == "")
                {
                    folder_or_file = "folder";
                }
                else
                {
                    folder_or_file = "file";
                }

                InputNewName folder_name_form = new InputNewName($"Input new {folder_or_file} name");
                if (folder_name_form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string new_folder_or_file_name = folder_name_form.GetNewName();       
                        string new_path = Path.Combine(path, new_folder_or_file_name) + Path.GetExtension(old_folder_or_file_name);
                        FileSystem.Rename(old_path, new_path);
                        MessageBox.Show($"{old_folder_or_file_name} sucessfully renamed to {new_folder_or_file_name} !");
                        UpdateLists();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                folder_name_form.Dispose();
            }
            this.Enabled = true;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
            User authorized_user = signInForm.GetUser();
            if (authorized_user != null)
            {
                this.Hide();
                (new Form1(authorized_user)).ShowDialog();
                this.Close();
            }
            else
            {
                this.Enabled = true;
            }            
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Enabled = true;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form1()).ShowDialog();
            this.Close();
        }

        private void FindBookButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            BackToExplorerButton.Visible = true;
            FindBookForm findBookForm = new FindBookForm();
            DialogResult dialogResult = findBookForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string query = findBookForm.GetQuery();
                query.Replace("#", "%23");
                int books_cnt = findBookForm.GetBooksCnt();
                CollectBooks(query, books_cnt);
            }          
            this.Enabled = true;
        }
        private void CollectBooks(string query, int books_cnt)
        {
            int search_page = 1;
            List<Book> books = new List<Book>();
            List<Book> new_books = new List<Book>();
            new_books.Add(new Book());
            while (new_books.Count > 0 && books_cnt > 0)
            {
                new_books = Parcer.GetBooksFromThePage($"https://www.packtpub.com/catalogsearch/result/?q={query}&released=Available&page={search_page}", books_cnt);
                books_cnt -= new_books.Count;
                books.AddRange(new_books);
                search_page++;
            }
            ShowBooks(books);
        }
        private void ShowBooks(List<Book> books)
        {
            ListView listView = left_focused ? LeftListView : RightListView;
            TextBox textBox = left_focused ? LeftFullPath : RightFullPath;

            textBox.Text = "Books";
            listView.Items.Clear();
            listView.Columns.Clear();
            listView.Columns.Add("Label");
            listView.Columns.Add("Date");
            listView.Columns.Add("Price");

            foreach (Book book in books)
            {
                listView.Items.Add(new ListViewItem(new string[] { book.label, $"{book.date.Month}.{book.date.Year}", $"${book.price}", book.href }));
            }
        } 

        private void BackToExplorerButton_Click(object sender, EventArgs e)
        {
            if (LeftFullPath.Text == "Books")
                LeftFullPath.Text = "";
            if (RightFullPath.Text == "Books")
                RightFullPath.Text = "";
            UpdateLists();   
            BackToExplorerButton.Visible = false;
        }

        private void RightListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort(RightListView, e.Column);
        }

        private void LeftListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort(LeftListView, e.Column);
        }
        private void ColumnSort(ListView listView, int column_index)
        {
            if (listView.Columns[column_index].Text == "Size" || listView.Columns[column_index].Text == "Price")
            {
                listView.ListViewItemSorter = new ListViewDoubleColumnComparer(column_index);
            }
            else if (listView.Columns[column_index].Text == "Date")
            {
                listView.ListViewItemSorter = new ListViewDateColumnComparer(column_index);
            }
            else
            {
                listView.ListViewItemSorter = new ListViewTextColumnComparer(column_index);
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UserSettingsForm settingsForm = new UserSettingsForm(user);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                this.Text = user.explorer_label;
                string users_data_path = Directory.GetCurrentDirectory();
                users_data_path = Path.Combine(users_data_path, "users.dat");
                Users users = new Users();
                if (File.Exists(users_data_path))
                    using (var fs = File.OpenRead(users_data_path))
                        users = (Users)new BinaryFormatter().Deserialize(fs);

                User data_user = users.FirstOrDefault(u => u.login == this.user.login);
                data_user.SetExplorerLabel(user.explorer_label);

                using (var fs = File.OpenWrite(users_data_path))
                    new BinaryFormatter().Serialize(fs, users);
            }              
        }
        private void Search(string source_dir, string srch_key, bool out_list)
        {
            if (out_list)
                left_cancellation_src = new CancellationTokenSource();
            else
                right_cancellation_src = new CancellationTokenSource();

            CancellationTokenSource token_source = out_list ? left_cancellation_src : right_cancellation_src;
            if (out_list)
                LeftCancelSearchButton.Visible = true;
            else
                RightCancelSearchButton.Visible = true;

            Task.Factory.StartNew(() =>
            {
                new SearchFiles(source_dir, srch_key, this, out_list, token_source).StartSearch();
            }, token_source.Token);
        }
        public void PrintSearchResults(string file_path, bool out_list)
        {
            ListView listView = out_list ? LeftListView : RightListView;
            this.Invoke((Action)delegate
                {
                    lock (RightGroup)
                    {
                        listView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file_path), file_path}));
                    }
                });
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ListView listView = left_focused ? LeftListView : RightListView;
            TextBox textBox = left_focused ? LeftFullPath : RightFullPath;
            
            listView.Columns.Clear();
            listView.Columns.Add("Name");
            listView.Columns.Add("Full path");
            textBox.Text = "Search results";
            listView.Items.Clear();
            
            Search(FocusPath.Text, SearchKeyTexBox.Text, left_focused);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (FocusPath.Text == "" || SearchKeyTexBox.Text == "")
                return;

            CancelDownloadButton.Visible = true;
            download_cancellation_src = new CancellationTokenSource();

            Task.Factory.StartNew(() =>
            {
                new DownloadFile(SearchKeyTexBox.Text, FocusPath.Text, this, download_cancellation_src).StartDownload();
            }, download_cancellation_src.Token);
        }

        private void RightCancelSearchButton_Click(object sender, EventArgs e)
        {
            right_cancellation_src.Cancel();
        }
        private void CancelDownloadButton_Click(object sender, EventArgs e)
        {
            download_cancellation_src.Cancel();
        }

        public void HideLeftCancelSearchButton()
        {
            this.Invoke((Action)delegate
            {
                lock (LeftCancelSearchButton)
                {
                    LeftCancelSearchButton.Visible = false;
                    left_cancellation_src.Dispose();
                }
            });
        }
        public void HideRightCancelSearchButton()
        {
            this.Invoke((Action)delegate
            {
                lock (RightCancelSearchButton)
                {
                    RightCancelSearchButton.Visible = false;
                    right_cancellation_src.Dispose();
                }
            });     
        }

        private void LeftCancelSearchButton_Click(object sender, EventArgs e)
        {
            left_cancellation_src.Cancel();
        }
        public void HideDownloadCancelButton()
        {
            this.Invoke((Action)delegate
            {
                lock (DownloadButton)
                {
                    CancelDownloadButton.Visible = false;
                }
            });
        }
    }
}
