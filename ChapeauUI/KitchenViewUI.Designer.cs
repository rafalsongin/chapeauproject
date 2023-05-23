namespace ChapeauUI
{
    partial class KitchenViewUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenViewUI));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            employeeNameLabel = new Label();
            ordersListView = new ListView();
            panel4 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBoxChapeauLogo = new PictureBox();
            label7 = new Label();
            panel5 = new Panel();
            ListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            preparedButton = new Button();
            servedButton = new Button();
            inPreparationButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 47);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 0;
            label1.Text = "Kitchen View";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(employeeNameLabel);
            panel2.Location = new Point(763, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(89, 30);
            panel2.TabIndex = 1;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.BorderStyle = BorderStyle.FixedSingle;
            employeeNameLabel.Location = new Point(23, 8);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(41, 17);
            employeeNameLabel.TabIndex = 0;
            employeeNameLabel.Text = "Name";
            // 
            // ordersListView
            // 
            ordersListView.BackColor = SystemColors.ControlLightLight;
            ordersListView.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ordersListView.FullRowSelect = true;
            ordersListView.GridLines = true;
            ordersListView.Location = new Point(33, 162);
            ordersListView.Name = "ordersListView";
            ordersListView.Size = new Size(565, 261);
            ordersListView.TabIndex = 2;
            ordersListView.UseCompatibleStateImageBehavior = false;
            ordersListView.View = View.Details;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrange;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(33, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(819, 36);
            panel4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(643, 11);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 10;
            label6.Text = "Change Order Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 11);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Order ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 11);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 11);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "Order Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 11);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(33, 1);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(87, 41);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChapeauLogo.TabIndex = 9;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(62, 9);
            label7.Name = "label7";
            label7.Size = new Size(120, 19);
            label7.TabIndex = 10;
            label7.Text = "View Order Status";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkOrange;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(596, 226);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 36);
            panel5.TabIndex = 12;
            // 
            // ListView
            // 
            ListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            ListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListView.FullRowSelect = true;
            ListView.GridLines = true;
            ListView.Location = new Point(596, 257);
            ListView.Name = "ListView";
            ListView.Size = new Size(256, 166);
            ListView.TabIndex = 13;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Select order ID";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order status";
            columnHeader2.Width = 120;
            // 
            // preparedButton
            // 
            preparedButton.BackColor = Color.DarkOrange;
            preparedButton.Location = new Point(685, 177);
            preparedButton.Name = "preparedButton";
            preparedButton.Size = new Size(75, 32);
            preparedButton.TabIndex = 14;
            preparedButton.Text = "Prepared";
            preparedButton.UseVisualStyleBackColor = false;
            // 
            // servedButton
            // 
            servedButton.BackColor = Color.YellowGreen;
            servedButton.Location = new Point(766, 177);
            servedButton.Margin = new Padding(0);
            servedButton.Name = "servedButton";
            servedButton.Size = new Size(75, 32);
            servedButton.TabIndex = 15;
            servedButton.Text = "Served";
            servedButton.UseVisualStyleBackColor = false;
            // 
            // inPreparationButton
            // 
            inPreparationButton.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            inPreparationButton.Location = new Point(604, 177);
            inPreparationButton.Name = "inPreparationButton";
            inPreparationButton.Size = new Size(75, 32);
            inPreparationButton.TabIndex = 16;
            inPreparationButton.Text = "In preparation";
            inPreparationButton.UseVisualStyleBackColor = true;
            // 
            // KitchenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 469);
            Controls.Add(inPreparationButton);
            Controls.Add(servedButton);
            Controls.Add(preparedButton);
            Controls.Add(ListView);
            Controls.Add(panel5);
            Controls.Add(pictureBoxChapeauLogo);
            Controls.Add(panel4);
            Controls.Add(ordersListView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "KitchenForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label employeeNameLabel;
        private Label label1;
        private ListView ordersListView;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private PictureBox pictureBoxChapeauLogo;
        private Label label6;
        private Label label7;
        private Panel panel5;
        private ListView ListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button preparedButton;
        private Button servedButton;
        private Button inPreparationButton;
    }
}