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
            labelName = new Label();
            panelNameBackground = new Panel();
            pictureBoxChapeauLogo = new PictureBox();
            buttonSetTableFree = new Button();
            buttonSetTableOccupied = new Button();
            buttonSetTableReserved = new Button();
            labelTableHeading = new Label();
            buttonGoToTable = new Button();
            buttonBack = new Button();
            panelNameBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(18, 3);
            labelName.Name = "labelName";
            labelName.Size = new Size(83, 37);
            labelName.TabIndex = 0;
            labelName.Text = "Rafal";
            // 
            // panelNameBackground
            // 
            panelNameBackground.AutoSize = true;
            panelNameBackground.BackColor = Color.Gold;
            panelNameBackground.Controls.Add(labelName);
            panelNameBackground.Location = new Point(322, 12);
            panelNameBackground.MinimumSize = new Size(120, 45);
            panelNameBackground.Name = "panelNameBackground";
            panelNameBackground.Size = new Size(120, 45);
            panelNameBackground.TabIndex = 13;
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(14, 15);
            pictureBoxChapeauLogo.Margin = new Padding(5, 6, 5, 6);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(149, 82);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChapeauLogo.TabIndex = 12;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // buttonSetTableFree
            // 
            buttonSetTableFree.BackColor = Color.LightGreen;
            buttonSetTableFree.FlatAppearance.BorderColor = Color.Black;
            buttonSetTableFree.FlatAppearance.BorderSize = 3;
            buttonSetTableFree.FlatStyle = FlatStyle.Flat;
            buttonSetTableFree.Font = new Font("Segoe UI", 9.142858F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetTableFree.Location = new Point(25, 316);
            buttonSetTableFree.Name = "buttonSetTableFree";
            buttonSetTableFree.Size = new Size(131, 63);
            buttonSetTableFree.TabIndex = 15;
            buttonSetTableFree.Text = "FREE";
            buttonSetTableFree.UseVisualStyleBackColor = false;
            // 
            // buttonSetTableOccupied
            // 
            buttonSetTableOccupied.BackColor = Color.Gold;
            buttonSetTableOccupied.FlatAppearance.BorderColor = Color.Black;
            buttonSetTableOccupied.FlatStyle = FlatStyle.Flat;
            buttonSetTableOccupied.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetTableOccupied.Location = new Point(173, 316);
            buttonSetTableOccupied.Name = "buttonSetTableOccupied";
            buttonSetTableOccupied.Size = new Size(131, 63);
            buttonSetTableOccupied.TabIndex = 15;
            buttonSetTableOccupied.Text = "OCCUPIED";
            buttonSetTableOccupied.UseVisualStyleBackColor = false;
            // 
            // buttonSetTableReserved
            // 
            buttonSetTableReserved.BackColor = Color.Silver;
            buttonSetTableReserved.FlatAppearance.BorderColor = Color.Black;
            buttonSetTableReserved.FlatStyle = FlatStyle.Flat;
            buttonSetTableReserved.Font = new Font("Segoe UI", 9.142858F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetTableReserved.Location = new Point(322, 316);
            buttonSetTableReserved.Name = "buttonSetTableReserved";
            buttonSetTableReserved.Size = new Size(131, 63);
            buttonSetTableReserved.TabIndex = 15;
            buttonSetTableReserved.Text = "RESERVED";
            buttonSetTableReserved.UseVisualStyleBackColor = false;
            // 
            // labelTableHeading
            // 
            labelTableHeading.AutoSize = true;
            labelTableHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTableHeading.Location = new Point(147, 197);
            labelTableHeading.Name = "labelTableHeading";
            labelTableHeading.Size = new Size(183, 57);
            labelTableHeading.TabIndex = 16;
            labelTableHeading.Text = "TABLE 1";
            // 
            // buttonGoToTable
            // 
            buttonGoToTable.BackColor = Color.White;
            buttonGoToTable.FlatAppearance.BorderColor = Color.Black;
            buttonGoToTable.FlatAppearance.BorderSize = 2;
            buttonGoToTable.FlatStyle = FlatStyle.Flat;
            buttonGoToTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGoToTable.Location = new Point(129, 463);
            buttonGoToTable.Name = "buttonGoToTable";
            buttonGoToTable.Size = new Size(214, 56);
            buttonGoToTable.TabIndex = 17;
            buttonGoToTable.Text = "Go to table";
            buttonGoToTable.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gold;
            buttonBack.FlatAppearance.BorderColor = Color.Black;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(0, 631);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(87, 39);
            buttonBack.TabIndex = 18;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // TableStatusUI
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 736);
            Controls.Add(buttonBack);
            Controls.Add(buttonGoToTable);
            Controls.Add(labelTableHeading);
            Controls.Add(buttonSetTableReserved);
            Controls.Add(buttonSetTableOccupied);
            Controls.Add(buttonSetTableFree);
            Controls.Add(panelNameBackground);
            Controls.Add(pictureBoxChapeauLogo);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(500, 800);
            MinimumSize = new Size(500, 800);
            Name = "TableStatusUI";
            Text = "Chapeau Waiter";
            panelNameBackground.ResumeLayout(false);
            panelNameBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Panel panelNameBackground;
        private PictureBox pictureBoxChapeauLogo;
        private Button buttonSetTableFree;
        private Button buttonSetTableOccupied;
        private Button buttonSetTableReserved;
        private Label labelTableHeading;
        private Button buttonGoToTable;
        private Button buttonBack;
    }
}