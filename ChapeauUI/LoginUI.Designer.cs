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
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(69, 48);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(343, 178);
            pictureBoxChapeauLogo.TabIndex = 1;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // labelForgotPassword
            // 
            labelForgotPassword.AutoSize = true;
            labelForgotPassword.Font = new Font("Segoe UI", 9.142858F, FontStyle.Underline, GraphicsUnit.Point);
            labelForgotPassword.Location = new Point(156, 588);
            labelForgotPassword.Name = "labelForgotPassword";
            labelForgotPassword.Size = new Size(176, 30);
            labelForgotPassword.TabIndex = 12;
            labelForgotPassword.Text = "Forgot password";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.MediumSeaGreen;
            buttonLogin.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(152, 506);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(180, 64);
            buttonLogin.TabIndex = 11;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(249, 381);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.RightToLeft = RightToLeft.No;
            textBoxPassword.Size = new Size(175, 42);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Location = new Point(249, 306);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.RightToLeft = RightToLeft.No;
            textBoxUsername.Size = new Size(175, 42);
            textBoxUsername.TabIndex = 9;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(51, 384);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(180, 37);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "PASSWORD: ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(53, 309);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(178, 37);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "USERNAME: ";
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 736);
            Controls.Add(labelForgotPassword);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(pictureBoxChapeauLogo);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(500, 800);
            MinimumSize = new Size(500, 800);
            Name = "LoginUI";
            Text = "Chapeau Restaurant";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxChapeauLogo;
        private Label labelForgotPassword;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private Label labelUsername;
    }
}