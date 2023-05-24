namespace ChapeauUI
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            pictureBoxChapeauLogo = new PictureBox();
            labelForgotPassword = new Label();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            panelLogin = new Panel();
            labelIncorrectInput = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(61, 44);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(280, 157);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChapeauLogo.TabIndex = 1;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // labelForgotPassword
            // 
            labelForgotPassword.AutoSize = true;
            labelForgotPassword.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Underline, GraphicsUnit.Point);
            labelForgotPassword.Location = new Point(125, 299);
            labelForgotPassword.Name = "labelForgotPassword";
            labelForgotPassword.Size = new Size(120, 20);
            labelForgotPassword.TabIndex = 12;
            labelForgotPassword.Text = "Forgot password";
            labelForgotPassword.Click += labelForgotPassword_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(138, 210, 176);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(125, 237);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(120, 42);
            buttonLogin.TabIndex = 11;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(229, 229, 229);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(176, 108);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.RightToLeft = RightToLeft.No;
            textBoxPassword.Size = new Size(152, 31);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(229, 229, 229);
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(176, 44);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.RightToLeft = RightToLeft.No;
            textBoxUsername.Size = new Size(152, 31);
            textBoxUsername.TabIndex = 9;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(48, 108);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(122, 25);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "PASSWORD: ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 13.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(48, 44);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(121, 25);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "USERNAME: ";
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(labelForgotPassword);
            panelLogin.Controls.Add(textBoxUsername);
            panelLogin.Controls.Add(labelPassword);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(labelUsername);
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Controls.Add(labelIncorrectInput);
            panelLogin.Location = new Point(12, 271);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(374, 412);
            panelLogin.TabIndex = 13;
            // 
            // labelIncorrectInput
            // 
            labelIncorrectInput.AutoSize = true;
            labelIncorrectInput.Font = new Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIncorrectInput.ForeColor = Color.Red;
            labelIncorrectInput.Location = new Point(84, 178);
            labelIncorrectInput.Name = "labelIncorrectInput";
            labelIncorrectInput.Size = new Size(210, 19);
            labelIncorrectInput.TabIndex = 12;
            labelIncorrectInput.Text = "Incorrect username or password!";
            labelIncorrectInput.Visible = false;
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(pictureBoxChapeauLogo);
            Controls.Add(panelLogin);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(414, 736);
            MinimumSize = new Size(414, 736);
            Name = "LoginUI";
            Text = "Chapeau Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxChapeauLogo;
        private Label labelForgotPassword;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private Label labelUsername;
        private Panel panelLogin;
        private Label labelIncorrectInput;
    }
}