using System;
using System.Windows.Forms;
using System.IO;

namespace Conductor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string path;

        private void MainForm_Load(object sender, EventArgs e)
        {          
            //Загрузка TreeView
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                MainTreeView.Nodes.Add(new TreeNode(drive.Name));

                if (Directory.Exists(drive.Name))
                {
                    ///Сделать рекурсию
                    
                    //Подкаталоги
                    string[] directories = Directory.GetDirectories(drive.Name);
                    foreach (string directory in directories)
                    {
                        MainTreeView.Nodes[Array.IndexOf(drives, drive)].Nodes.Add(directory);

                    }

                    //Файлы
                    string[] files = Directory.GetFiles(drive.Name);
                    foreach (string file in files)
                    {
                        MainTreeView.Nodes[Array.IndexOf(drives, drive)].Nodes.Add(file);
                    }
                }
            }

            TreeNode userNode = new TreeNode() { Name = "User", Text = "Пользователь" };
            TreeNode desktopNode = new TreeNode() { Name = "Desktop", Text = "Рабочий стол" };
            TreeNode documentsNode = new TreeNode() { Name = "Documents", Text = "Мои документы" };

            MainTreeView.Nodes.Add(userNode);
            MainTreeView.Nodes.Add(desktopNode);
            MainTreeView.Nodes.Add(documentsNode);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Выберите путь" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    MainWebBrowser.Url = new Uri(fbd.SelectedPath);
                    PathTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainWebBrowser.CanGoBack)
                MainWebBrowser.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (MainWebBrowser.CanGoForward)
                MainWebBrowser.GoForward();
        }

        private void PathTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    MainWebBrowser.Url = new Uri(PathTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Такой путь отсутствует.", "Ошибка");        
            }
        }

        private void FolderTSMI_Click(object sender, EventArgs e)
        {
            CreateFile("");
        }

        private void NoteBookTSMI_Click(object sender, EventArgs e)
        {
            CreateFile(".txt");
        }
        private void WordTSMI_Click(object sender, EventArgs e)
        {
            CreateFile(".docx");
        }
        private void PowerPointTSMI_Click(object sender, EventArgs e)
        {
            CreateFile(".pptx");
        }

        private void ExcelTSMI_Click(object sender, EventArgs e)
        {
            CreateFile(".xlsx");
        }

        private void CreateFile(string fileFormat)
        {
            if (PathTextBox.Text == "")
            {
                MessageBox.Show("Сначала откройте директорию", "Ошибка");
                return;
            }

            AddForm addform = new AddForm();

            if (addform.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(addform.File);
                File.Create(PathTextBox.Text + "/" + addform.File + fileFormat).Close();

                MainWebBrowser.Url = new Uri(PathTextBox.Text);
            }
        }

        private void MainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (MainTreeView.SelectedNode.Text)
            {
                case "Мои документы":
                    {
                        path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                        PathTextBox.Text = path;
                        MainWebBrowser.Url = new Uri(path);
                        break;
                    }
                case "Рабочий стол":
                    {
                        path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        PathTextBox.Text = path;
                        MainWebBrowser.Url = new Uri(path); 
                        break;
                    }
                case "Пользователь":
                    {
                        path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        PathTextBox.Text = path;
                        MainWebBrowser.Url = new Uri(path);
                        break;
                    }
                default:
                    {
                        PathTextBox.Text = MainTreeView.SelectedNode.Text;
                        MainWebBrowser.Url = new Uri(MainTreeView.SelectedNode.Text);
                        break;
                    }
            }
        }

        private void CloseTSMI_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
