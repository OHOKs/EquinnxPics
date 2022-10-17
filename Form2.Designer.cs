namespace EquinxPictures
{
    partial class eqMain
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
            this.GunaForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.exitButton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.folderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.currentfolderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.folderSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // GunaForm2
            // 
            this.GunaForm2.BorderRadius = 80;
            this.GunaForm2.ContainerControl = this;
            this.GunaForm2.DockForm = false;
            this.GunaForm2.DockIndicatorTransparencyValue = 1D;
            this.GunaForm2.ResizeForm = false;
            this.GunaForm2.TransparentWhileDrag = true;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.IsSelectionEnabled = false;
            this.exitButton.Location = new System.Drawing.Point(1138, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 31);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "X";
            this.exitButton.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = false;
            this.folderLabel.BackColor = System.Drawing.Color.Transparent;
            this.folderLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLabel.IsSelectionEnabled = false;
            this.folderLabel.Location = new System.Drawing.Point(12, 12);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(139, 23);
            this.folderLabel.TabIndex = 17;
            this.folderLabel.Text = "Current folder:";
            this.folderLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentfolderLabel
            // 
            this.currentfolderLabel.AutoSize = false;
            this.currentfolderLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentfolderLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentfolderLabel.Location = new System.Drawing.Point(143, 12);
            this.currentfolderLabel.Name = "currentfolderLabel";
            this.currentfolderLabel.Size = new System.Drawing.Size(844, 23);
            this.currentfolderLabel.TabIndex = 18;
            // 
            // picsPanel
            // 
            this.picsPanel.Location = new System.Drawing.Point(12, 41);
            this.picsPanel.Name = "picsPanel";
            this.picsPanel.Size = new System.Drawing.Size(1176, 534);
            this.picsPanel.TabIndex = 19;
            // 
            // folderSelect
            // 
            this.folderSelect.BorderRadius = 10;
            this.folderSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.folderSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.folderSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.folderSelect.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.folderSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.folderSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.folderSelect.ForeColor = System.Drawing.Color.White;
            this.folderSelect.Location = new System.Drawing.Point(993, 12);
            this.folderSelect.Name = "folderSelect";
            this.folderSelect.Size = new System.Drawing.Size(139, 23);
            this.folderSelect.TabIndex = 20;
            this.folderSelect.Text = "Select folder";
            this.folderSelect.Click += new System.EventHandler(this.folderSelect_Click);
            // 
            // eqMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.folderSelect);
            this.Controls.Add(this.picsPanel);
            this.Controls.Add(this.currentfolderLabel);
            this.Controls.Add(this.folderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eqMain";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm GunaForm2;
        private Guna.UI2.WinForms.Guna2HtmlLabel exitButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel currentfolderLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel folderLabel;
        private System.Windows.Forms.FlowLayoutPanel picsPanel;
        private Guna.UI2.WinForms.Guna2GradientButton folderSelect;
        private System.Windows.Forms.FolderBrowserDialog browserDialog;
    }
}