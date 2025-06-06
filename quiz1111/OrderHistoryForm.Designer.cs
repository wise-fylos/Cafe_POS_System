namespace quiz1111
{
    partial class OrderHistoryForm
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
            View1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            timeBox = new TextBox();
            viewID = new Button();
            label1 = new Label();
            View2 = new DataGridView();
            cancelID = new Button();
            label2 = new Label();
            deleteDrink = new Button();
            viewOrders = new Button();
            menuBox = new ComboBox();
            addDrink = new Button();
            ((System.ComponentModel.ISupportInitialize)View1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)View2).BeginInit();
            SuspendLayout();
            // 
            // View1
            // 
            View1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            View1.Location = new Point(9, 59);
            View1.Margin = new Padding(2, 2, 2, 2);
            View1.Name = "View1";
            View1.RowHeadersWidth = 51;
            View1.RowTemplate.Height = 29;
            View1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            View1.Size = new Size(229, 178);
            View1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(9, 9);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // timeBox
            // 
            timeBox.Location = new Point(45, 34);
            timeBox.Margin = new Padding(2, 2, 2, 2);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(56, 23);
            timeBox.TabIndex = 2;
            // 
            // viewID
            // 
            viewID.Location = new Point(9, 242);
            viewID.Margin = new Padding(2, 2, 2, 2);
            viewID.Name = "viewID";
            viewID.Size = new Size(73, 22);
            viewID.TabIndex = 3;
            viewID.Text = "주문 조회";
            viewID.UseVisualStyleBackColor = true;
            viewID.Click += viewID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "시간";
            // 
            // View2
            // 
            View2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            View2.Location = new Point(257, 59);
            View2.Margin = new Padding(2, 2, 2, 2);
            View2.Name = "View2";
            View2.RowHeadersWidth = 51;
            View2.RowTemplate.Height = 29;
            View2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            View2.Size = new Size(200, 178);
            View2.TabIndex = 5;
            // 
            // cancelID
            // 
            cancelID.Location = new Point(87, 242);
            cancelID.Margin = new Padding(2, 2, 2, 2);
            cancelID.Name = "cancelID";
            cancelID.Size = new Size(73, 22);
            cancelID.TabIndex = 6;
            cancelID.Text = "주문 취소";
            cancelID.UseVisualStyleBackColor = true;
            cancelID.Click += cancelID_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "수정";
            // 
            // deleteDrink
            // 
            deleteDrink.Location = new Point(461, 76);
            deleteDrink.Margin = new Padding(2, 2, 2, 2);
            deleteDrink.Name = "deleteDrink";
            deleteDrink.Size = new Size(186, 22);
            deleteDrink.TabIndex = 8;
            deleteDrink.Text = "뷰에서 선택한 음료 삭제";
            deleteDrink.UseVisualStyleBackColor = true;
            deleteDrink.Click += deleteDrink_Click;
            // 
            // viewOrders
            // 
            viewOrders.Location = new Point(165, 242);
            viewOrders.Margin = new Padding(2, 2, 2, 2);
            viewOrders.Name = "viewOrders";
            viewOrders.Size = new Size(73, 22);
            viewOrders.TabIndex = 9;
            viewOrders.Text = "주문 상세";
            viewOrders.UseVisualStyleBackColor = true;
            viewOrders.Click += viewOrders_Click;
            // 
            // menuBox
            // 
            menuBox.FormattingEnabled = true;
            menuBox.Location = new Point(461, 103);
            menuBox.Margin = new Padding(2, 2, 2, 2);
            menuBox.Name = "menuBox";
            menuBox.Size = new Size(111, 23);
            menuBox.TabIndex = 10;
            // 
            // addDrink
            // 
            addDrink.Location = new Point(576, 100);
            addDrink.Margin = new Padding(2, 2, 2, 2);
            addDrink.Name = "addDrink";
            addDrink.Size = new Size(73, 24);
            addDrink.TabIndex = 12;
            addDrink.Text = "추가";
            addDrink.UseVisualStyleBackColor = true;
            addDrink.Click += addDrink_Click;
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 290);
            Controls.Add(addDrink);
            Controls.Add(menuBox);
            Controls.Add(viewOrders);
            Controls.Add(deleteDrink);
            Controls.Add(label2);
            Controls.Add(cancelID);
            Controls.Add(View2);
            Controls.Add(label1);
            Controls.Add(viewID);
            Controls.Add(timeBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(View1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrderHistoryForm";
            Text = "주문 기록";
            ((System.ComponentModel.ISupportInitialize)View1).EndInit();
            ((System.ComponentModel.ISupportInitialize)View2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView View1;
        private DateTimePicker dateTimePicker1;
        private TextBox timeBox;
        private Button viewID;
        private Label label1;
        private DataGridView View2;
        private Button cancelID;
        private Label label2;
        private Button deleteDrink;
        private Button viewOrders;
        private ComboBox menuBox;
        private Button addDrink;
    }
}