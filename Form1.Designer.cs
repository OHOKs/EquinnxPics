namespace ShotPics
{
    partial class ShotPics
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
            System.Windows.Forms.Button BrowseFolders;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShotPics));
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.path = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.notifyIcons1 = new System.Windows.Forms.NotifyIcon(this.components);
            BrowseFolders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AllowDrop = true;
            this.Panel.AutoScroll = true;
            this.Panel.Location = new System.Drawing.Point(9, 57);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(682, 484);
            this.Panel.TabIndex = 0;
            // 
            // BrowseFolders
            // 
            BrowseFolders.FlatAppearance.BorderSize = 0;
            BrowseFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BrowseFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            BrowseFolders.Location = new System.Drawing.Point(12, 7);
            BrowseFolders.Margin = new System.Windows.Forms.Padding(0);
            BrowseFolders.Name = "BrowseFolders";
            BrowseFolders.Size = new System.Drawing.Size(147, 47);
            BrowseFolders.TabIndex = 1;
            BrowseFolders.Text = "BrowseFolders";
            BrowseFolders.UseVisualStyleBackColor = true;
            BrowseFolders.Click += new System.EventHandler(this.BrowseFolders_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_Button.Location = new System.Drawing.Point(641, 7);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(47, 47);
            this.Exit_Button.TabIndex = 2;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Click);
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(19, 6);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 30);
            this.path.TabIndex = 3;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimizeButton.Location = new System.Drawing.Point(588, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(47, 47);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // notifyIcons1
            // 
            this.notifyIcons1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcons1.Icon")));
            this.notifyIcons1.Text = "ShotPics";
            this.notifyIcons1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseClick);
            // 
            // ShotPics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.path);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(BrowseFolders);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShotPics";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.ShotPics_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShotPics_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.NotifyIcon notifyIcons1;
    }
}

