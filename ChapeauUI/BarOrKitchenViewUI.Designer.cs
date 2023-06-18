namespace ChapeauUI
{
    partial class BarOrKitchenViewUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarOrKitchenViewUI));
            panel1 = new Panel();
            typeOfViewLabel = new Label();
            panel2 = new Panel();
            employeeNameLabel = new Label();
            ordersListView = new ListView();
            orderID = new ColumnHeader();
            orderNumber = new ColumnHeader();
            count = new ColumnHeader();
            Description = new ColumnHeader();
            OrderTime = new ColumnHeader();
            Comments = new ColumnHeader();
            panel4 = new Panel();
            Comment = new Label();
            label6 = new Label();
            Time2 = new Label();
            Time = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBoxChapeauLogo = new PictureBox();
            label7 = new Label();
            panelStatus = new Panel();
            selectedOrderListView = new ListView();
            ID = new ColumnHeader();
            Status = new ColumnHeader();
            WaitingTime = new ColumnHeader();
            preparedButton = new Button();
            servedButton = new Button();
            inPreparationButton = new Button();
            buttonLogOut = new Button();
            comboBoxFiltering = new ComboBox();
            ChangeListView = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 179, 71);
            panel1.Controls.Add(typeOfViewLabel);
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(1689, 103);
            panel1.TabIndex = 0;
            // 
            // typeOfViewLabel
            // 
            typeOfViewLabel.AutoSize = true;
            typeOfViewLabel.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            typeOfViewLabel.Location = new Point(607, 4);
            typeOfViewLabel.Margin = new Padding(4, 0, 4, 0);
            typeOfViewLabel.Name = "typeOfViewLabel";
            typeOfViewLabel.Size = new Size(438, 93);
            typeOfViewLabel.TabIndex = 0;
            typeOfViewLabel.Text = "Kitchen View";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 179, 71);
            panel2.Controls.Add(employeeNameLabel);
            panel2.Location = new Point(1556, 2);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 50);
            panel2.TabIndex = 1;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(41, 11);
            employeeNameLabel.Margin = new Padding(4, 0, 4, 0);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(59, 25);
            employeeNameLabel.TabIndex = 0;
            employeeNameLabel.Text = "Name";
            // 
            // ordersListView
            // 
            ordersListView.BackColor = SystemColors.ControlLightLight;
            ordersListView.Columns.AddRange(new ColumnHeader[] { orderID, orderNumber, count, Description, OrderTime, Comments });
            ordersListView.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ordersListView.FullRowSelect = true;
            ordersListView.GridLines = true;
            ordersListView.Location = new Point(13, 270);
            ordersListView.Margin = new Padding(4, 5, 4, 5);
            ordersListView.Name = "ordersListView";
            ordersListView.Size = new Size(1129, 432);
            ordersListView.TabIndex = 2;
            ordersListView.UseCompatibleStateImageBehavior = false;
            ordersListView.View = View.Details;
            ordersListView.SelectedIndexChanged += ordersListView_SelectedIndexChanged;
            // 
            // orderID
            // 
            orderID.Text = "";
            orderID.Width = 110;
            // 
            // orderNumber
            // 
            orderNumber.Text = "";
            orderNumber.Width = 110;
            // 
            // count
            // 
            count.Text = "";
            count.Width = 130;
            // 
            // Description
            // 
            Description.Text = "";
            Description.Width = 450;
            // 
            // OrderTime
            // 
            OrderTime.Text = "";
            OrderTime.Width = 70;
            // 
            // Comments
            // 
            Comments.Text = "";
            Comments.Width = 250;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 179, 71);
            panel4.Controls.Add(Comment);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(Time2);
            panel4.Controls.Add(Time);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(13, 200);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1688, 60);
            panel4.TabIndex = 4;
            // 
            // Comment
            // 
            Comment.AutoSize = true;
            Comment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Comment.Location = new Point(947, 17);
            Comment.Name = "Comment";
            Comment.Size = new Size(99, 25);
            Comment.TabIndex = 21;
            Comment.Text = "Comments";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1337, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 25);
            label6.TabIndex = 10;
            label6.Text = "Change Order Status";
            // 
            // Time2
            // 
            Time2.AutoSize = true;
            Time2.Location = new Point(805, 28);
            Time2.Name = "Time2";
            Time2.Size = new Size(50, 25);
            Time2.TabIndex = 19;
            Time2.Text = "Time";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Location = new Point(803, 8);
            Time.Name = "Time";
            Time.Size = new Size(58, 25);
            Time.TabIndex = 20;
            Time.Text = "Order";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 7;
            label4.Text = "Order ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 8;
            label5.Text = "Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 17);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 6;
            label3.Text = "Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(12, 2);
            pictureBoxChapeauLogo.Margin = new Padding(4, 5, 4, 5);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(159, 68);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChapeauLogo.TabIndex = 9;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(189, 16);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(167, 28);
            label7.TabIndex = 10;
            label7.Text = "View Order Status";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(255, 179, 71);
            panelStatus.Controls.Add(label7);
            panelStatus.Location = new Point(1154, 356);
            panelStatus.Margin = new Padding(4, 5, 4, 5);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(549, 60);
            panelStatus.TabIndex = 12;
            // 
            // selectedOrderListView
            // 
            selectedOrderListView.Columns.AddRange(new ColumnHeader[] { ID, Status, WaitingTime });
            selectedOrderListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectedOrderListView.FullRowSelect = true;
            selectedOrderListView.GridLines = true;
            selectedOrderListView.Location = new Point(1154, 426);
            selectedOrderListView.Margin = new Padding(4, 5, 4, 5);
            selectedOrderListView.Name = "selectedOrderListView";
            selectedOrderListView.Size = new Size(549, 274);
            selectedOrderListView.TabIndex = 13;
            selectedOrderListView.UseCompatibleStateImageBehavior = false;
            selectedOrderListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "Select order ID";
            ID.Width = 180;
            // 
            // Status
            // 
            Status.Text = "Order status";
            Status.Width = 180;
            // 
            // WaitingTime
            // 
            WaitingTime.Text = "Waiting Time";
            WaitingTime.Width = 180;
            // 
            // preparedButton
            // 
            preparedButton.BackColor = Color.FromArgb(255, 179, 71);
            preparedButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            preparedButton.Location = new Point(1342, 293);
            preparedButton.Margin = new Padding(4, 5, 4, 5);
            preparedButton.Name = "preparedButton";
            preparedButton.Size = new Size(180, 55);
            preparedButton.TabIndex = 14;
            preparedButton.Text = "Prepared";
            preparedButton.UseVisualStyleBackColor = false;
            preparedButton.Click += PreparedButton_Click;
            // 
            // servedButton
            // 
            servedButton.BackColor = Color.FromArgb(138, 210, 176);
            servedButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            servedButton.Location = new Point(1526, 293);
            servedButton.Margin = new Padding(0);
            servedButton.Name = "servedButton";
            servedButton.Size = new Size(180, 55);
            servedButton.TabIndex = 15;
            servedButton.Text = "Served";
            servedButton.UseVisualStyleBackColor = false;
            servedButton.Click += ServedButton_Click;
            // 
            // inPreparationButton
            // 
            inPreparationButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inPreparationButton.Location = new Point(1154, 293);
            inPreparationButton.Margin = new Padding(4, 5, 4, 5);
            inPreparationButton.Name = "inPreparationButton";
            inPreparationButton.Size = new Size(180, 55);
            inPreparationButton.TabIndex = 16;
            inPreparationButton.Text = "In preparation";
            inPreparationButton.UseVisualStyleBackColor = true;
            inPreparationButton.Click += InPreparationButton_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(243, 218, 128);
            buttonLogOut.Location = new Point(1405, 1);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(117, 50);
            buttonLogOut.TabIndex = 17;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // comboBoxFiltering
            // 
            comboBoxFiltering.BackColor = Color.FromArgb(243, 218, 128);
            comboBoxFiltering.FormattingEnabled = true;
            comboBoxFiltering.Items.AddRange(new object[] { "Finished Orders", "Running Orders" });
            comboBoxFiltering.Location = new Point(758, 729);
            comboBoxFiltering.Name = "comboBoxFiltering";
            comboBoxFiltering.Size = new Size(266, 33);
            comboBoxFiltering.TabIndex = 18;
            comboBoxFiltering.SelectedIndexChanged += comboBoxFiltering_SelectedIndexChanged;
            // 
            // ChangeListView
            // 
            ChangeListView.AutoSize = true;
            ChangeListView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeListView.Location = new Point(558, 727);
            ChangeListView.Name = "ChangeListView";
            ChangeListView.Size = new Size(174, 30);
            ChangeListView.TabIndex = 19;
            ChangeListView.Text = "Change list view:";
            // 
            // BarOrKitchenViewUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 784);
            Controls.Add(ChangeListView);
            Controls.Add(comboBoxFiltering);
            Controls.Add(buttonLogOut);
            Controls.Add(inPreparationButton);
            Controls.Add(servedButton);
            Controls.Add(preparedButton);
            Controls.Add(selectedOrderListView);
            Controls.Add(panelStatus);
            Controls.Add(pictureBoxChapeauLogo);
            Controls.Add(panel4);
            Controls.Add(ordersListView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BarOrKitchenViewUI";
            Text = "Form1";
            Load += LoadForm;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label employeeNameLabel;
        private Label typeOfViewLabel;
        private ListView ordersListView;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private PictureBox pictureBoxChapeauLogo;
        private Label label6;
        private Label label7;
        private Panel panelStatus;
        private ListView selectedOrderListView;
        private ColumnHeader ID;
        private ColumnHeader Status;
        private Button preparedButton;
        private Button servedButton;
        private Button inPreparationButton;
        private ColumnHeader orderID;
        private ColumnHeader orderNumber;
        private ColumnHeader count;
        private ColumnHeader Description;
        private Button buttonLogOut;
        private ComboBox comboBoxFiltering;
        private ColumnHeader OrderTime;
        private ColumnHeader columnHeader3;
        private ColumnHeader Comments;
        private ColumnHeader WaitingTime;
        private Label Time2;
        private Label Time;
        private Label Comment;
        private Label ChangeListView;
    }
}