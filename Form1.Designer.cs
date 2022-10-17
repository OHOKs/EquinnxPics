namespace EquinxPictures
{
    partial class loginPanel
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
            this.GunaForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.loginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.userBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitButton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loginLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passwordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.userLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // GunaForm1
            // 
            this.GunaForm1.BorderRadius = 80;
            this.GunaForm1.ContainerControl = this;
            this.GunaForm1.DockForm = false;
            this.GunaForm1.DockIndicatorTransparencyValue = 1D;
            this.GunaForm1.ResizeForm = false;
            this.GunaForm1.TransparentWhileDrag = true;
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 20;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(200, 413);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.BorderRadius = 80;
            this.loginButton.Size = new System.Drawing.Size(200, 45);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Log in";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userBox
            // 
            this.userBox.BorderRadius = 15;
            this.userBox.BorderThickness = 0;
            this.userBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userBox.DefaultText = "";
            this.userBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.userBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userBox.ForeColor = System.Drawing.Color.White;
            this.userBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userBox.Location = new System.Drawing.Point(125, 228);
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '\0';
            this.userBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.userBox.PlaceholderText = "";
            this.userBox.SelectedText = "";
            this.userBox.Size = new System.Drawing.Size(350, 45);
            this.userBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderRadius = 15;
            this.passwordBox.BorderThickness = 0;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Location = new System.Drawing.Point(125, 313);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordBox.PlaceholderText = "";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(350, 45);
            this.passwordBox.TabIndex = 10;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.IsSelectionEnabled = false;
            this.exitButton.Location = new System.Drawing.Point(538, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 44);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "X";
            this.exitButton.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.form1Close_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = false;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.IsSelectionEnabled = false;
            this.loginLabel.Location = new System.Drawing.Point(125, 71);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(350, 71);
            this.loginLabel.TabIndex = 14;
            this.loginLabel.Text = "Login Panel";
            this.loginLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = false;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.IsSelectionEnabled = false;
            this.passwordLabel.Location = new System.Drawing.Point(105, 284);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(139, 23);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = false;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.IsSelectionEnabled = false;
            this.userLabel.Location = new System.Drawing.Point(105, 199);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(139, 23);
            this.userLabel.TabIndex = 16;
            this.userLabel.Text = "Username";
            this.userLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginPanel";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm GunaForm1;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2TextBox userBox;
        private Guna.UI2.WinForms.Guna2GradientButton loginButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel loginLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel exitButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel passwordLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel userLabel;
    }
}

