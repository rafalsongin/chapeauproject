namespace ChapeauUI
{
    partial class AllTablesViewUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTablesViewUI));
            pictureBoxChapeauLogo = new PictureBox();
            panelNameBackground = new Panel();
            labelName = new Label();
            panelLegendFree = new Panel();
            panelStatusOccupied = new Panel();
            panelLegendReserved = new Panel();
            panelLegendOrdered = new Panel();
            labelLegendFree = new Label();
            labelLegendOccupied = new Label();
            labelLegendReserved = new Label();
            labelLegendOrdered = new Label();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            panelNameBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(14, 15);
            pictureBoxChapeauLogo.Margin = new Padding(5, 6, 5, 6);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(132, 71);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChapeauLogo.TabIndex = 10;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // panelNameBackground
            // 
            panelNameBackground.AutoSize = true;
            panelNameBackground.BackColor = Color.FromArgb(255, 179, 71);
            panelNameBackground.Controls.Add(labelName);
            panelNameBackground.Location = new Point(278, 15);
            panelNameBackground.Name = "panelNameBackground";
            panelNameBackground.Size = new Size(92, 28);
            panelNameBackground.TabIndex = 11;
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
            // panelLegendFree
            // 
            panelLegendFree.BackColor = Color.FromArgb(138, 210, 176);
            panelLegendFree.Location = new Point(25, 635);
            panelLegendFree.Name = "panelLegendFree";
            panelLegendFree.Size = new Size(28, 23);
            panelLegendFree.TabIndex = 13;
            // 
            // panelStatusOccupied
            // 
            panelStatusOccupied.BackColor = Color.FromArgb(255, 179, 71);
            panelStatusOccupied.Location = new Point(133, 635);
            panelStatusOccupied.Name = "panelStatusOccupied";
            panelStatusOccupied.Size = new Size(28, 23);
            panelStatusOccupied.TabIndex = 13;
            // 
            // panelLegendReserved
            // 
            panelLegendReserved.BackColor = Color.FromArgb(196, 196, 196);
            panelLegendReserved.Location = new Point(246, 635);
            panelLegendReserved.Name = "panelLegendReserved";
            panelLegendReserved.Size = new Size(28, 23);
            panelLegendReserved.TabIndex = 13;
            // 
            // panelLegendOrdered
            // 
            panelLegendOrdered.BackColor = Color.FromArgb(248, 102, 39);
            panelLegendOrdered.Location = new Point(342, 635);
            panelLegendOrdered.Name = "panelLegendOrdered";
            panelLegendOrdered.Size = new Size(28, 23);
            panelLegendOrdered.TabIndex = 13;
            // 
            // labelLegendFree
            // 
            labelLegendFree.AutoSize = true;
            labelLegendFree.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLegendFree.Location = new Point(21, 661);
            labelLegendFree.Name = "labelLegendFree";
            labelLegendFree.Size = new Size(32, 15);
            labelLegendFree.TabIndex = 14;
            labelLegendFree.Text = "FREE";
            // 
            // labelLegendOccupied
            // 
            labelLegendOccupied.AutoSize = true;
            labelLegendOccupied.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLegendOccupied.Location = new Point(117, 661);
            labelLegendOccupied.Name = "labelLegendOccupied";
            labelLegendOccupied.Size = new Size(64, 15);
            labelLegendOccupied.TabIndex = 14;
            labelLegendOccupied.Text = "OCCUPIED";
            // 
            // labelLegendReserved
            // 
            labelLegendReserved.AutoSize = true;
            labelLegendReserved.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLegendReserved.Location = new Point(230, 661);
            labelLegendReserved.Name = "labelLegendReserved";
            labelLegendReserved.Size = new Size(60, 15);
            labelLegendReserved.TabIndex = 14;
            labelLegendReserved.Text = "RESERVED";
            // 
            // labelLegendOrdered
            // 
            labelLegendOrdered.AutoSize = true;
            labelLegendOrdered.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLegendOrdered.Location = new Point(328, 661);
            labelLegendOrdered.Name = "labelLegendOrdered";
            labelLegendOrdered.Size = new Size(58, 15);
            labelLegendOrdered.TabIndex = 14;
            labelLegendOrdered.Text = "ORDERED";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(201, 201, 201);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.Location = new Point(278, 56);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(92, 30);
            buttonLogout.TabIndex = 15;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // AllTablesViewUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(buttonLogout);
            Controls.Add(labelLegendOrdered);
            Controls.Add(labelLegendReserved);
            Controls.Add(labelLegendOccupied);
            Controls.Add(labelLegendFree);
            Controls.Add(panelLegendOrdered);
            Controls.Add(panelLegendReserved);
            Controls.Add(panelStatusOccupied);
            Controls.Add(panelLegendFree);
            Controls.Add(panelNameBackground);
            Controls.Add(pictureBoxChapeauLogo);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(414, 736);
            MinimumSize = new Size(414, 736);
            Name = "AllTablesViewUI";
            Text = "Chapeau Waiter";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            panelNameBackground.ResumeLayout(false);
            panelNameBackground.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxChapeauLogo;
        private Panel panelNameBackground;
        private Label labelName;
        private Panel panelLegendFree;
        private Panel panelStatusOccupied;
        private Panel panelLegendReserved;
        private Panel panelLegendOrdered;
        private Label labelLegendFree;
        private Label labelLegendOccupied;
        private Label labelLegendReserved;
        private Label labelLegendOrdered;
        private Button buttonLogout;
    }
}