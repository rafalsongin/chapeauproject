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
            buttonSetTableFree = new Button();
            buttonSetTableOccupied = new Button();
            buttonSetTableReserved = new Button();
            labelTableHeading = new Label();
            buttonGoToTable = new Button();
            buttonBack = new Button();
            panelNameBackground = new Panel();
            labelName = new Label();
            pictureBoxChapeauLogo = new PictureBox();
            panelNameBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonSetTableFree
            // 
            buttonSetTableFree.BackColor = Color.FromArgb(138, 210, 176);
            buttonSetTableFree.FlatAppearance.BorderColor = Color.Black;
            buttonSetTableFree.FlatAppearance.BorderSize = 3;
            buttonSetTableFree.FlatStyle = FlatStyle.Flat;
            buttonSetTableFree.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSetTableFree.Location = new Point(19, 324);
            buttonSetTableFree.Name = "buttonSetTableFree";
            buttonSetTableFree.Size = new Size(96, 46);
            buttonSetTableFree.TabIndex = 15;
            buttonSetTableFree.Text = "FREE";
            buttonSetTableFree.UseVisualStyleBackColor = false;
            // 
            // buttonSetTableOccupied
            // 
            buttonSetTableOccupied.BackColor = Color.FromArgb(255, 179, 71);
            buttonSetTableOccupied.FlatAppearance.BorderColor = Color.Black;
            buttonSetTableOccupied.FlatStyle = FlatStyle.Flat;
            buttonSetTableOccupied.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetTableOccupied.Location = new Point(151, 324);
            buttonSetTableOccupied.Name = "buttonSetTableOccupied";
            buttonSetTableOccupied.Size = new Size(96, 46);
            buttonSetTableOccupied.TabIndex = 15;
            buttonSetTableOccupied.Text = "OCCUPIED";
            buttonSetTableOccupied.UseVisualStyleBackColor = false;
            // 
            // buttonSetTableReserved
            // 
            buttonSetTableReserved.BackColor = Color.FromArgb(196, 196, 196);
            buttonSetTableReserved.FlatAppearance.BorderColor = Color.Black;
            buttonSetTableReserved.FlatStyle = FlatStyle.Flat;
            buttonSetTableReserved.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetTableReserved.Location = new Point(279, 324);
            buttonSetTableReserved.Name = "buttonSetTableReserved";
            buttonSetTableReserved.Size = new Size(96, 46);
            buttonSetTableReserved.TabIndex = 15;
            buttonSetTableReserved.Text = "RESERVED";
            buttonSetTableReserved.UseVisualStyleBackColor = false;
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
            labelName.Size = new Size(45, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Rafal";
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
            // TableStatusUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(panelNameBackground);
            Controls.Add(pictureBoxChapeauLogo);
            Controls.Add(buttonBack);
            Controls.Add(buttonGoToTable);
            Controls.Add(labelTableHeading);
            Controls.Add(buttonSetTableReserved);
            Controls.Add(buttonSetTableOccupied);
            Controls.Add(buttonSetTableFree);
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
        private Button buttonSetTableFree;
        private Button buttonSetTableOccupied;
        private Button buttonSetTableReserved;
        private Label labelTableHeading;
        private Button buttonGoToTable;
        private Button buttonBack;
        private Panel panelNameBackground;
        private Label labelName;
        private PictureBox pictureBoxChapeauLogo;
    }
}