using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;

namespace Sort
{
    public partial class Sorter : Form
    {
        public string imgFolderPath;
        public string catFolderPath;
        public string currentDir;
        public string imgPath;
        public FileSystemWatcher watcher = new FileSystemWatcher() { NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite };
        public static readonly Assembly ass = Assembly.GetExecutingAssembly();
        public Image bover = Image.FromStream(ass.GetManifestResourceStream("Sort.over.png"));
        public Image bd = Image.FromStream(ass.GetManifestResourceStream("Sort.b.png"));
        public Image bdown = Image.FromStream(ass.GetManifestResourceStream("Sort.down.png"));
        public Image deld = Image.FromStream(ass.GetManifestResourceStream("Sort.del.png"));
        public Image delover = Image.FromStream(ass.GetManifestResourceStream("Sort.delover.png"));
        public Image deldown = Image.FromStream(ass.GetManifestResourceStream("Sort.deldown.png"));
        public Image cat = Image.FromStream(ass.GetManifestResourceStream("Sort.cat.png"));
        public Image catover = Image.FromStream(ass.GetManifestResourceStream("Sort.catover.png"));
        public Image catdown = Image.FromStream(ass.GetManifestResourceStream("Sort.catdown.png"));
        public Image sortd = Image.FromStream(ass.GetManifestResourceStream("Sort.sort.png"));
        public Image sortover = Image.FromStream(ass.GetManifestResourceStream("Sort.sortover.png"));
        public Image sortdown = Image.FromStream(ass.GetManifestResourceStream("Sort.sortdown.png"));
        public Image n = Image.FromStream(ass.GetManifestResourceStream("Sort.n.png"));
        public Image folover = Image.FromStream(ass.GetManifestResourceStream("Sort.folover.png"));
        public Image foldown = Image.FromStream(ass.GetManifestResourceStream("Sort.foldown.png"));
        public Image fold = Image.FromStream(ass.GetManifestResourceStream("Sort.fol.png"));
        public Image plusd = Image.FromStream(ass.GetManifestResourceStream("Sort.plus.png"));
        public Image plusdown = Image.FromStream(ass.GetManifestResourceStream("Sort.plusdown.png"));
        public Image plusover = Image.FromStream(ass.GetManifestResourceStream("Sort.plusover.png"));
        //public Label l = new Label();
        //public TextBox t = new TextBox();
        public readonly List<string> ext = new List<string> { ".png", ".bmp", ".jpg", ".jpeg", ".webp" };
        public bool mD;
        public Point lL;
        public Sorter()
        {
            InitializeComponent();
            //t.Text = string.Empty;
            Color back = Color.FromArgb(23, 33, 43);
            Color fore = Color.FromArgb(56, 65, 71);
            DoubleBuffered = true;
            Visible = true;
            /*mover.MouseDown += mover_MouseDown;
            mover.MouseMove += mover_MouseMove;
            mover.MouseUp += mover_MouseUp;*/
        }

        //Image sequence iterator
        private void Imgchange(string fl)
        {
            Image img = Image.FromFile(fl);
            ImgView.Image = img;
            ImgView.Update();
            img.Dispose();
            //pB.Update();
        }


        //Navigation UI Handling
        private void MoveImg(string dir)
        {
            if (File.Exists(imgPath))
            {
                File.Move(imgPath, Path.Combine(dir, Path.GetFileName(imgPath)));
            }
            else
            {
                MessageBox.Show("File doesn't exist", "Error");
            }
        }

        private void LoadF(string path)
        {
            SuspendLayout();
            CatFoldersLayout.Controls.Clear();
            // Create a button for each directory path
            foreach (string directory in Directory.GetDirectories(path))
            {
                Button button = new Button
                {
                    Text = Path.GetFileName(directory),
                    Size = new Size(98, 31),
                    FlatStyle = FlatStyle.Flat
                };
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.Image = cat;
                button.MouseHover += (sender, e) =>
                {
                    button.Image = catover;
                };
                /*button.MouseDown += (sender, e) =>
                {
                    button.Image = catdown;
                };*/
                button.MouseLeave += (sender, e) =>
                {
                    button.Image = cat;
                };
                button.MouseDown += (object sender, MouseEventArgs e) =>
                {
                    button.Image = catdown;

                    if (e.Button == MouseButtons.Left)
                    {
                        if (Directory.GetDirectories(directory).Length == 0)
                        {
                            MoveImg(directory);
                        }
                        else
                        {
                            currentDir = directory;
                            SuspendLayout();
                            CatFoldersLayout.Controls.Clear();
                            foreach (string dir in Directory.GetDirectories(directory))
                            {
                                Button butt = new Button
                                {
                                    Text = Path.GetFileName(dir),
                                    Size = new Size(98, 31),
                                    FlatStyle = FlatStyle.Flat,
                                    BackColor = Color.Transparent
                                };
                                butt.FlatAppearance.MouseOverBackColor = Color.Transparent;
                                butt.FlatAppearance.MouseDownBackColor = Color.Transparent;
                                butt.FlatAppearance.BorderSize = 0;
                                butt.Image = cat;
                                butt.MouseHover += (s, ec) =>
                                {
                                    butt.Image = catover;
                                };
                                /*butt.MouseDown += (s, ec) =>
                                {
                                    butt.Image = catdown;
                                };*/
                                butt.MouseLeave += (s, ec) =>
                                {
                                    butt.Image = cat;
                                };
                                butt.MouseDown += (object s, MouseEventArgs ec) =>
                                {
                                    butt.Image = catdown;
                                    if (ec.Button == MouseButtons.Left)
                                    {
                                        if (Directory.GetDirectories(dir).Length == 0)
                                        {
                                            MoveImg(dir);
                                        }
                                        else
                                        {
                                            currentDir = dir;
                                            CatFoldersLayout.Controls.Clear();
                                            LoadF(dir);
                                        }
                                    }

                                    /*if (ec.Button == MouseButtons.Right)
                                    {
                                        MessageBox.Show("dfdf");
                                        //Rename(butt.Location, butt.Text, dir);
                                        //LoadF(dir);
                                    }*/
                                    
                                };
                                CatFoldersLayout.Controls.Add(butt);
                            }
                            ResumeLayout();
                        }
                    }
                };
                CatFoldersLayout.Controls.Add(button);
            }
            ResumeLayout();
        }

        /*private void Rename(Point p, string n, string d)
        {
            t.Location = p;
            t.Text = n;
            l.Text = n;
            l.Location = p;
            t.Focus();

            t.TextChanged += (se, eco) =>
            {
                Directory.Move(d + '\\' + n, d + '\\' + t.Text);
                fP.Controls.Remove(t);
                fP.Controls.Remove(l);
            };
        }*/


        //Event Handlers

            //Image Folder Browse Button
        private void ImgFolderBrowse_Click(object sender, EventArgs e)
        {
            // Show a folder browse dialog to allow the user to select a directory
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    ImgFolder.Text = folderBrowserDialog.SelectedPath;
                    imgFolderPath = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void ImgFolderBrowse_MouseHover(object sender, EventArgs e)
        {
            ImgFolderBrowse.Image = bover;
        }

        private void ImgFolderBrose_MouseLeave(object sender, EventArgs e)
        {
            ImgFolderBrowse.Image = bd;
        }

        private void ImgFolderBrowse_MouseDown(object sender, MouseEventArgs e)
        {
            ImgFolderBrowse.Image = bdown;
        }

            //Categories Folder Browse Button

        private void CatFolderBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    catFolderPath = folderBrowserDialog.SelectedPath;
                    CatFolder.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void CatFolderBrowse_MouseHover(object sender, EventArgs e)
        {
            CatFolderBrowse.Image = bover;
        }

        private void CatFolderBrowse_MouseLeave(object sender, EventArgs e)
        {
            CatFolderBrowse.Image = bd;
        }

        private void CatFolderBrowse_MouseDown(object sender, MouseEventArgs e)
        {
            CatFolderBrowse.Image = bdown;
        }

            //Sort Button

        private async void Sort_Click(object sender, EventArgs e)
        {
            if (ImgFolder.Text != "Images Folder" && CatFolder.Text != "Categories Folder"){
                foreach (string filePath in Directory.GetFiles(imgFolderPath))
                {
                    if (ext.Contains(Path.GetExtension(filePath)))
                    {
                        Del.Enabled = true;
                        CurrentImgName.Text = Path.GetFileName(filePath);
                        //Console.WriteLine(filePath);
                        TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                        Imgchange(filePath);
                        //LoadF();
                        imgPath = filePath;
                        watcher.Path = imgFolderPath;
                        watcher.Filter = Path.GetFileName(filePath);
                        watcher.EnableRaisingEvents = true;
                        watcher.Deleted += (s, ec) =>
                        {
                            if (ec.Name == Path.GetFileName(filePath))
                            {
                                // The file has been moved out of the directory
                                tcs.SetResult(true);
                            }
                        };
                        await tcs.Task;
                    }
                }
                if (Directory.GetFiles(imgFolderPath).Length == 0)
                {
                    MessageBox.Show("There are no images in this folder.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Choose valid folders", "Error");
            }
        }

        private void Sort_MouseHover(object sender, EventArgs e)
        {
            Sort.Image = sortover;
        }

        private void Sort_MouseLeave(object sender, EventArgs e)
        {
            Sort.Image = sortd;
        }

        private void Sort_MouseDown(object sender, MouseEventArgs e)
        {
            Sort.Image = sortdown;
        }

            //Categories Folders Label

        private void CatFoldersLabel_Click(object sender, EventArgs e)
        {
            if (CatFolder.Text != "Categories Folder")
            {
                currentDir = CatFolder.Text;
                LoadF(currentDir);
            }
            else
            {
                MessageBox.Show("Choose a valid categories folder", "Error");
            }
        }

        private void CatFoldersLabel_MouseHover(object sender, EventArgs e)
        {
            CatFoldersLabel.Image = folover;
        }

        private void CatFoldersLabel_MouseLeave(object sender, EventArgs e)
        {
            CatFoldersLabel.Image = fold;
        }

        private void CatFoldersLabel_MouseDown(object sender, MouseEventArgs e)
        {
            CatFoldersLabel.Image = foldown;
        }

        //

        private void CatFolder_TextChanged(object sender, EventArgs e)
        {
            currentDir = CatFolder.Text;
            CatFoldersLayout.Controls.Clear();
            LoadF(catFolderPath);
            Plus.Enabled = true;
            if (ImgFolder.Text != "Images Folder")
            {
                Sort.Enabled = true;
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (File.Exists(imgPath))
            {
                File.Delete(imgPath);
            }
            else
            {
                MessageBox.Show("No file", "Error");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Del_MouseHover(object sender, EventArgs e)
        {
            Del.Image = delover;
        }

        private void Del_MouseLeave(object sender, EventArgs e)
        {
            Del.Image = deld;
        }

        private void Del_MouseDown(object sender, MouseEventArgs e)
        {
            Del.Image = deldown;
        }



        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            /*if (!Directory.Exists(dpt + '\\' + "New Folder"))
            {
                Directory.CreateDirectory(dpt + '\\' + "New Folder");
                LoadF(dpt);
            }
            else
            {
                int i = 1;
                Console.WriteLine(dpt + $"\\New FoLder ({i})");
                bool ex = true;
                while (ex == true)
                {
                    if (!Directory.Exists(dpt + "\\New Folder (" + i.ToString().Trim() + ')'))
                    {
                        ex = false;
                    }
                    else
                    {
                        i++;
                    }
                }
                Directory.CreateDirectory(dpt + $"\\New Folder ({i})");
                LoadF(dpt);
            }*/
            if (NewDirName.Text == string.Empty)
            {
                NewDirName.Focus();
            }
            else {
                if (!Directory.Exists(currentDir + '\\' + NewDirName.Text))
                {
                    Directory.CreateDirectory(currentDir + '\\' + NewDirName.Text);
                    NewDirName.Text = string.Empty;
                    LoadF(currentDir);
                }
                else
                {
                    MessageBox.Show("The folder with such name already exists in this directory.", "Error");
                    NewDirName.Focus();
                }
            }
        }

        private void ImgFolder_TextChanged(object sender, EventArgs e)
        {
            if (Plus.Enabled)
            {
                Sort.Enabled = true;
            }
        }

        private void Plus_MouseDown(object sender, MouseEventArgs e)
        {
            Plus.Image = plusdown;
        }

        private void Plus_MouseHover(object sender, EventArgs e)
        {
            Plus.Image = plusover;
        }

        private void Plus_MouseLeave(object sender, EventArgs e)
        {
            Plus.Image = plusd;
        }

        private void Mover_MouseDown(object sender, MouseEventArgs e)
        {
            lL = new Point(e.X, e.Y);
        }

        private void Mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lL.X;
                this.Top += e.Y - lL.Y;
            }
        }

        private void Mover_MouseUp(object sender, MouseEventArgs e)
        {
            mD = false;
            this.Capture = false;
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.ForeColor= SystemColors.ButtonFace;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.FromArgb(93, 106, 115);
        }
    }
}
