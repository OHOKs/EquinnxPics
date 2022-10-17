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

namespace EquinxPictures
{
    public partial class eqMain : Form
    {
        Data data = new Data();

        public eqMain()
        {
            InitializeComponent();
        }

        public void picsLoad()
        {
            currentfolderLabel.Text = data.selectedPath;

            if (data.picsJPG != null) { Array.Clear(data.picsJPG, 0, data.picsJPG.Length); }
            if (data.picsPNG != null) { Array.Clear(data.picsPNG, 0, data.picsPNG.Length); }
            data.numberofJPG = 0;
            data.numberofPNG = 0;

            data.picsJPG = Directory.GetFiles(@data.selectedPath, "*.jpg");
            data.picsPNG = Directory.GetFiles(@data.selectedPath, "*.png");

            foreach (string file in Directory.EnumerateFiles(@data.selectedPath, "*.jpg"))
            {
                data.numberofJPG += 1;
            }

            foreach (string file in Directory.EnumerateFiles(@data.selectedPath, "*.png"))
            {
                data.numberofPNG += 1;
            }

            if (data.numberofJPG != 0 || data.numberofPNG != 0)
            {
                picsPanel.Controls.Clear();

                for (int i = 0; i < data.numberofJPG; i++)
                {
                    PictureBox newPic = new PictureBox();
                    newPic.Height = 150;
                    newPic.Width = 227;
                    newPic.SizeMode = PictureBoxSizeMode.Zoom;
                    newPic.Image = Image.FromFile(data.picsJPG[i]);
                    newPic.BorderStyle = BorderStyle.FixedSingle;
                    picsPanel.Controls.Add(newPic);
                }

                for (int i = 0; i < data.numberofPNG; i++)
                {
                    PictureBox newPic = new PictureBox();
                    newPic.Height = 150;
                    newPic.Width = 227;
                    newPic.SizeMode = PictureBoxSizeMode.Zoom;
                    newPic.Image = Image.FromFile(data.picsPNG[i]);
                    newPic.BorderStyle = BorderStyle.FixedSingle;
                    picsPanel.Controls.Add(newPic);
                }
            }
            else
            {
                picsPanel.Controls.Clear();

                Label newLbl = new Label();
                newLbl.Width = 1176;
                newLbl.Height = 534;
                newLbl.BackColor = Color.FromArgb(24, 41, 110);
                newLbl.Text = "The selected folder is empty!";
                newLbl.TextAlign = ContentAlignment.MiddleCenter;
                newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
                picsPanel.Controls.Add(newLbl);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                data.startupPath = Application.StartupPath;
                data.selectedPath = System.IO.File.ReadAllText(data.startupPath + "/SelectedPath.txt");
                currentfolderLabel.Text = data.selectedPath;
                picsLoad();
            }
            catch
            {
                File.WriteAllText(data.startupPath+"/SelectedPath.txt", string.Empty);
                picsPanel.Controls.Clear();
                Label newLbl = new Label();
                newLbl.Width = 1176;
                newLbl.Height = 534;
                newLbl.BackColor = Color.FromArgb(24, 41, 110);
                newLbl.Text = "No folder path selected!";
                newLbl.TextAlign = ContentAlignment.MiddleCenter;
                newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
                picsPanel.Controls.Add(newLbl);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void folderSelect_Click(object sender, EventArgs e)
        {
            DialogResult DiaResult = browserDialog.ShowDialog();
            if (DiaResult == DialogResult.OK)
            {
                data.selectedPath = browserDialog.SelectedPath;
                File.WriteAllText(data.startupPath+"/SelectedPath.txt", data.selectedPath);
                picsLoad();
            }
            else
            {
                File.WriteAllText(data.startupPath + "/SelectedPath.txt", string.Empty);
                currentfolderLabel.Text = string.Empty;
                picsPanel.Controls.Clear();
                Label newLbl = new Label();
                newLbl.Width = 1176;
                newLbl.Height = 534;
                newLbl.BackColor = Color.FromArgb(24, 41, 110);
                newLbl.Text = "No folder path selected!";
                newLbl.TextAlign = ContentAlignment.MiddleCenter;
                newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
                picsPanel.Controls.Add(newLbl);
            }
        }
    }
}
