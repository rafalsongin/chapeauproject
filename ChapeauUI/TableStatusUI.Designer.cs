namespace ChapeauUI
{
    partial class TableStatusUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableStatusUI));
            buttonAvailable = new Button();
            buttonOccupied = new Button();
            buttonReserved = new Button();
            labelTableHeading = new Label();
            buttonGoToTable = new Button();
            buttonBack = new Button();
            panelNameBackground = new Panel();
            labelName = new Label();
            pictureBoxChapeauLogo = new PictureBox();
            buttonLogout = new Button();
            panelNameBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonAvailable
            // 
            buttonAvailable.BackColor = Color.FromArgb(138, 210, 176);
            buttonAvailable.FlatAppearance.BorderColor = Color.Black;
            buttonAvailable.FlatAppearance.BorderSize = 3;
            buttonAvailable.FlatStyle = FlatStyle.Flat;
            buttonAvailable.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAvailable.Location = new Point(19, 324);
            buttonAvailable.Name = "buttonAvailable";
            buttonAvailable.Size = new Size(96, 46);
            buttonAvailable.TabIndex = 15;
            buttonAvailable.Text = "FREE";
            buttonAvailable.UseVisualStyleBackColor = false;
            buttonAvailable.Click += buttonSetTableFree_Click;
            // 
            // buttonOccupied
            // 
            buttonOccupied.BackColor = Color.FromArgb(255, 179, 71);
            buttonOccupied.FlatAppearance.BorderColor = Color.Black;
            buttonOccupied.FlatStyle = FlatStyle.Flat;
            buttonOccupied.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOccupied.Location = new Point(151, 324);
            buttonOccupied.Name = "buttonOccupied";
            buttonOccupied.Size = new Size(96, 46);
            buttonOccupied.TabIndex = 15;
            buttonOccupied.Text = "OCCUPIED";
            buttonOccupied.UseVisualStyleBackColor = false;
            buttonOccupied.Click += buttonSetTableOccupied_Click;
            // 
            // buttonReserved
            // 
            buttonReserved.BackColor = Color.FromArgb(196, 196, 196);
            buttonReserved.FlatAppearance.BorderColor = Color.Black;
            buttonReserved.FlatStyle = FlatStyle.Flat;
            buttonReserved.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReserved.Location = new Point(279, 324);
            buttonReserved.Name = "buttonReserved";
            buttonReserved.Size = new Size(96, 46);
            buttonReserved.TabIndex = 15;
            buttonReserved.Text = "RESERVED";
            buttonReserved.UseVisualStyleBackColor = false;
            buttonReserved.Click += buttonSetTableReserved_Click;
            // 
            // labelTableHeading
            // 
            labelTableHeading.AutoSize = true;
            labelTableHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTableHeading.Location = new Point(151, 185);
            labelTableHeading.Name = "labelTableHeading";
            labelTableHeading.Size = new Size(104, 32);
            labelTableHeading.TabIndex = 16;
            labelTableHeading.Text = "TABLE 1";
            // 
            // buttonGoToTable
            // 
            buttonGoToTable.BackColor = Color.White;
            buttonGoToTable.FlatAppearance.BorderColor = Color.Black;
            buttonGoToTable.FlatAppearance.BorderSize = 2;
            buttonGoToTable.FlatStyle = FlatStyle.Flat;
            buttonGoToTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGoToTable.Location = new Point(117, 432);
            buttonGoToTable.Name = "buttonGoToTable";
            buttonGoToTable.Size = new Size(155, 43);
            buttonGoToTable.TabIndex = 17;
            buttonGoToTable.Text = "Go to table";
            buttonGoToTable.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(255, 179, 71);
            buttonBack.FlatAppearance.BorderColor = Color.Black;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(0, 631);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(87, 39);
            buttonBack.TabIndex = 18;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelNameBackground
            // 
            panelNameBackground.AutoSize = true;
            panelNameBackground.BackColor = Color.FromArgb(255, 179, 71);
            panelNameBackground.Controls.Add(labelName);
            panelNameBackground.Location = new Point(278, 15);
            panelNameBackground.Name = "panelNameBackground";
            panelNameBackground.Size = new Size(92, 28);
            panelNameBackground.TabIndex = 20;
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
            pictureBoxChapeauLogo.Location = new Point(14, 15);
            pictureBoxChapeauLogo.Margin = new Padding(5, 6, 5, 6);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(132, 71);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChapeauLogo.TabIndex = 19;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(201, 201, 201);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.Location = new Point(278, 56);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(92, 30);
            buttonLogout.TabIndex = 21;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // TableStatusUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(buttonLogout);
            Controls.Add(panelNameBackground);
            Controls.Add(pictureBoxChapeauLogo);
            Controls.Add(buttonBack);
            Controls.Add(buttonGoToTable);
            Controls.Add(labelTableHeading);
            Controls.Add(buttonReserved);
            Controls.Add(buttonOccupied);
            Controls.Add(buttonAvailable);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(414, 736);
            MinimumSize = new Size(414, 736);
            Name = "TableStatusUI";
            Text = "Chapeau Waiter";
            panelNameBackground.ResumeLayout(false);
            panelNameBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAvailable;
        private Button buttonOccupied;
        private Button buttonReserved;
        private Label labelTableHeading;
        private Button buttonGoToTable;
        private Button buttonBack;
        private Panel panelNameBackground;
        private Label labelName;
        private PictureBox pictureBoxChapeauLogo;
        private Button buttonLogout;
    }
}