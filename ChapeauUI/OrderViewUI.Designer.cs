namespace ChapeauUI
{
    partial class OrderViewUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderViewUI));
            buttonLogout = new Button();
            panelNameBackground = new Panel();
            labelName = new Label();
            pictureBoxChapeauLogo = new PictureBox();
            buttonBack = new Button();
            labelTableHeading = new Label();
            buttonPay = new Button();
            buttonServed = new Button();
            labelOrderStatus = new Label();
            panelNameBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(201, 201, 201);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.Location = new Point(279, 57);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(92, 30);
            buttonLogout.TabIndex = 26;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // panelNameBackground
            // 
            panelNameBackground.AutoSize = true;
            panelNameBackground.BackColor = Color.FromArgb(255, 179, 71);
            panelNameBackground.Controls.Add(labelName);
            panelNameBackground.Location = new Point(279, 16);
            panelNameBackground.Name = "panelNameBackground";
            panelNameBackground.Size = new Size(92, 28);
            panelNameBackground.TabIndex = 25;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.FromArgb(255, 179, 71);
            labelName.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(22, 3);
            labelName.Name = "labelName";
            labelName.Size = new Size(60, 20);
            labelName.TabIndex = 0;
            labelName.Text = "{name}";
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(15, 16);
            pictureBoxChapeauLogo.Margin = new Padding(5, 6, 5, 6);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(132, 71);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChapeauLogo.TabIndex = 24;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(255, 179, 71);
            buttonBack.FlatAppearance.BorderColor = Color.Black;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(1, 632);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(87, 39);
            buttonBack.TabIndex = 23;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelTableHeading
            // 
            labelTableHeading.AutoSize = true;
            labelTableHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTableHeading.Location = new Point(151, 122);
            labelTableHeading.Name = "labelTableHeading";
            labelTableHeading.Size = new Size(104, 32);
            labelTableHeading.TabIndex = 22;
            labelTableHeading.Text = "TABLE 1";
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.FromArgb(138, 210, 176);
            buttonPay.FlatAppearance.BorderColor = Color.Black;
            buttonPay.FlatStyle = FlatStyle.Flat;
            buttonPay.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPay.Location = new Point(272, 632);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(114, 39);
            buttonPay.TabIndex = 27;
            buttonPay.Text = "PAY";
            buttonPay.UseVisualStyleBackColor = false;
            // 
            // buttonServed
            // 
            buttonServed.BackColor = Color.FromArgb(255, 179, 71);
            buttonServed.FlatAppearance.BorderColor = Color.Black;
            buttonServed.FlatStyle = FlatStyle.Flat;
            buttonServed.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonServed.Location = new Point(141, 632);
            buttonServed.Name = "buttonServed";
            buttonServed.Size = new Size(114, 39);
            buttonServed.TabIndex = 28;
            buttonServed.Text = "SERVED";
            buttonServed.UseVisualStyleBackColor = false;
            // 
            // labelOrderStatus
            // 
            labelOrderStatus.AutoSize = true;
            labelOrderStatus.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrderStatus.Location = new Point(65, 284);
            labelOrderStatus.Name = "labelOrderStatus";
            labelOrderStatus.Size = new Size(155, 32);
            labelOrderStatus.TabIndex = 22;
            labelOrderStatus.Text = "Order status:";
            // 
            // OrderViewUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(buttonServed);
            Controls.Add(buttonPay);
            Controls.Add(buttonLogout);
            Controls.Add(panelNameBackground);
            Controls.Add(pictureBoxChapeauLogo);
            Controls.Add(buttonBack);
            Controls.Add(labelOrderStatus);
            Controls.Add(labelTableHeading);
            MaximumSize = new Size(414, 736);
            MinimumSize = new Size(414, 736);
            Name = "OrderViewUI";
            Text = "OrderViewUI";
            panelNameBackground.ResumeLayout(false);
            panelNameBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogout;
        private Panel panelNameBackground;
        private Label labelName;
        private PictureBox pictureBoxChapeauLogo;
        private Button buttonBack;
        private Label labelTableHeading;
        private Button buttonPay;
        private Button buttonServed;
        private Label labelOrderStatus;
    }
}