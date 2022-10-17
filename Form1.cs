using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Diagnostics.Tracing;
using System.Diagnostics;
using System.Windows.Input;
using System.Threading;
using static ShotPics.Data;

namespace ShotPics
{
    public partial class ShotPics : Form
    {
        Data data = new Data();

        public void panelLoad()
        {
            if (data.files1 != null) { Array.Clear(data.files1, 0, data.files1.Length); }
            if (data.files2 != null) { Array.Clear(data.files2, 0, data.files2.Length); }
            data.numberofJPG = 0;
            data.numberofPNG = 0;

            data.files1 = Directory.GetFiles(@data.selectedPath, "*.jpg");
            data.files2 = Directory.GetFiles(@data.selectedPath, "*.png");

            foreach (string file in Directory.EnumerateFiles(data.selectedPath, "*.jpg"))
            {
                data.numberofJPG += 1;
            }

            foreach (string file in Directory.EnumerateFiles(data.selectedPath, "*.png"))
            {
                data.numberofPNG += 1;
            }

            if (data.numberofJPG != 0 || data.numberofPNG != 0)
            {
                Panel.Controls.Clear();

                for (int i = 0; i < data.numberofJPG; i++)
                {
                    PictureBox newPic = new PictureBox();
                    ContextMenuStrip newContext = new ContextMenuStrip();
                    newPic.Height = 150;
                    newPic.Width = 215;
                    newPic.SizeMode = PictureBoxSizeMode.Zoom;
                    newPic.Image = Image.FromFile(data.files1[i]);
                    newPic.BorderStyle = BorderStyle.FixedSingle;
                    newPic.ContextMenuStrip = newContext;
                    newContext.Items.Add("Upload");
                    newContext.Items.Add("Open");
                    newContext.Items.Add("Open file location");
                    newContext.Items.Add("Copy to clipboard");
                    newContext.Items.Add("Delete");
                    for (int j = 0; j < newContext.Items.Count; j++)
                    {
                        newContext.BackgroundImage = Image.FromFile("D:\\C#\\ShotPics\\BackColor.png");
                        newContext.Items[j].BackgroundImage = Image.FromFile("D:\\C#\\ShotPics\\BackColor.png");
                        newContext.Items[j].Image = Image.FromFile("D:\\C#\\ShotPics\\raiden.jpg");
                        newContext.Items[j].Margin = new Padding(0);
                        newContext.Items[j].Tag = data.files1[i];
                    }
                    newPic.Tag = data.files1[i];
                    newContext.Items[0].Click += new EventHandler(Upload_click);
                    newContext.Items[1].Click += new EventHandler(Open_click);
                    newContext.Items[2].Click += new EventHandler(OpenLocation_click);
                    newContext.Items[3].Click += new EventHandler(CopyToClipboard_click);
                    newContext.Items[4].Click += new EventHandler(Delete_click);
                    newPic.Click += new EventHandler(Picture_Click);
                    Panel.Controls.Add(newPic);
                }

                for (int i = 0; i < data.numberofPNG; i++)
                {
                    PictureBox newPic = new PictureBox();
                    ContextMenuStrip newContext = new ContextMenuStrip();
                    newPic.Height = 150;
                    newPic.Width = 215;
                    newPic.SizeMode = PictureBoxSizeMode.Zoom;
                    newPic.Image = Image.FromFile(data.files1[i]);
                    newPic.BorderStyle = BorderStyle.FixedSingle;
                    newPic.ContextMenuStrip = newContext;
                    newContext.Items.Add("Upload");
                    newContext.Items.Add("Open");
                    newContext.Items.Add("Open file location");
                    newContext.Items.Add("Copy to clipboard");
                    newContext.Items.Add("Delete");
                    for (int j = 0; j < newContext.Items.Count; j++)
                    {
                        newContext.BackgroundImage = Image.FromFile("D:\\C#\\ShotPics\\BackColor.png");
                        newContext.Items[j].BackgroundImage = Image.FromFile("D:\\C#\\ShotPics\\BackColor.png");
                        newContext.Items[j].Image = Image.FromFile("D:\\C#\\ShotPics\\raiden.jpg");
                        newContext.Items[j].Margin = new Padding(0);
                        newContext.Items[j].Tag = data.files2[i];
                    }
                    newPic.Tag = data.files2[i];
                    newContext.Items[0].Click += new EventHandler(Upload_click);
                    newContext.Items[1].Click += new EventHandler(Open_click);
                    newContext.Items[2].Click += new EventHandler(OpenLocation_click);
                    newContext.Items[3].Click += new EventHandler(CopyToClipboard_click);
                    newContext.Items[4].Click += new EventHandler(Delete_click);
                    newPic.Click += new EventHandler(Picture_Click);
                    Panel.Controls.Add(newPic);
                }
            }
            else
            {
                Panel.Controls.Clear();

                Label newLbl = new Label();
                newLbl.Width = 670;
                newLbl.Height = 475;
                newLbl.BackColor = Color.FromArgb(24, 20, 23);
                newLbl.Text = "The selected folder is empty!";
                newLbl.TextAlign = ContentAlignment.MiddleCenter;
                newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
                Panel.Controls.Add(newLbl);
            }
        }
        public ShotPics()
        {
            InitializeComponent();
        }
        private void ShotPics_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            try
            {
                data.selectedPath = File.ReadAllText("D:\\C#\\ShotPics\\Path.txt").ToString();
                try
                {
                    panelLoad();
                }
                catch
                {
                    Label newLbl = new Label();
                    newLbl.Width = 670;
                    newLbl.Height = 475;
                    newLbl.BackColor = Color.FromArgb(24, 20, 23);
                    newLbl.Text = "Selected folder is empty!";
                    newLbl.TextAlign = ContentAlignment.MiddleCenter;
                    newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
                    Panel.Controls.Add(newLbl);
                }
            }
            catch
            {
                Label newLbl = new Label();
                newLbl.Width = 670;
                newLbl.Height = 475;
                newLbl.BackColor = Color.FromArgb(24, 20, 23);
                newLbl.Text = "No folder path selected!";
                newLbl.TextAlign = ContentAlignment.MiddleCenter;
                newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
                Panel.Controls.Add(newLbl);
                File.WriteAllText("D:\\Path.txt", string.Empty);
            }
        }

        private void BrowseFolders_Click(object sender, EventArgs e)
        {
            DialogResult DiaResult = folderBrowserDialog1.ShowDialog();
            if (DiaResult == DialogResult.OK)
            {
                data.selectedPath = folderBrowserDialog1.SelectedPath;
                File.WriteAllText("D:\\C#\\ShotPics\\Path.txt", data.selectedPath);
                panelLoad();
            }
            else
            {
                Panel.Controls.Clear();
                Label newLbl = new Label();
                newLbl.Width = 670;
                newLbl.Height = 475;
                newLbl.BackColor = Color.FromArgb(24, 20, 23);
                newLbl.Text = "No folder path selected!";
                newLbl.TextAlign = ContentAlignment.MiddleCenter;
                newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
                Panel.Controls.Add(newLbl);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
            notifyIcons1.Visible = true;
        }

        private void Icon_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Show();
                this.ShowInTaskbar = true;
                notifyIcons1.Visible = false;
            }
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            Process.Start(((PictureBox)sender).Tag.ToString());
        }

        private void ShotPics_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                this.Hide();
                System.Threading.Thread.Sleep(100);
                SendKeys.Send("{PRTSC}");
                Image myImage = Clipboard.GetImage();
                if (data.selectedPath != null)
                {
                    myImage.Save(string.Format("{0}{1}{2}{3}", data.selectedPath, "\\", DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss"), ".jpg"));
                    panelLoad();
                }
                else
                {
                    MessageBox.Show("Incorrect selected path!");
                }
                this.Show();
            }
        }
        private void Upload_click(object sender, EventArgs e)
        {
            
        }
        private void Open_click(object sender, EventArgs e)
        {
            Process.Start(((ToolStripMenuItem)sender).Tag.ToString());
        }
        private void OpenLocation_click(object sender, EventArgs e)
        {
            Process.Start(data.selectedPath);
        }
        private void CopyToClipboard_click(object sender, EventArgs e)
        {
            Clipboard.SetImage(Image.FromFile(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        private void Delete_click(object sender, EventArgs e)
        {
            panelLoad();
        }
    }
}