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
            this.View1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.viewID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.View2 = new System.Windows.Forms.DataGridView();
            this.cancelID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteDrink = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.menuBox = new System.Windows.Forms.ComboBox();
            this.addDrink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).BeginInit();
            this.SuspendLayout();
            // 
            // View1
            // 
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Location = new System.Drawing.Point(12, 79);
            this.View1.Name = "View1";
            this.View1.RowHeadersWidth = 51;
            this.View1.RowTemplate.Height = 29;
            this.View1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.View1.Size = new System.Drawing.Size(294, 237);
            this.View1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(58, 46);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(71, 27);
            this.timeBox.TabIndex = 2;
            // 
            // viewID
            // 
            this.viewID.Location = new System.Drawing.Point(12, 322);
            this.viewID.Name = "viewID";
            this.viewID.Size = new System.Drawing.Size(94, 29);
            this.viewID.TabIndex = 3;
            this.viewID.Text = "주문 조회";
            this.viewID.UseVisualStyleBackColor = true;
            this.viewID.Click += new System.EventHandler(this.viewID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "시간";
            // 
            // View2
            // 
            this.View2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View2.Location = new System.Drawing.Point(330, 79);
            this.View2.Name = "View2";
            this.View2.RowHeadersWidth = 51;
            this.View2.RowTemplate.Height = 29;
            this.View2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.View2.Size = new System.Drawing.Size(257, 237);
            this.View2.TabIndex = 5;
            // 
            // cancelID
            // 
            this.cancelID.Location = new System.Drawing.Point(112, 322);
            this.cancelID.Name = "cancelID";
            this.cancelID.Size = new System.Drawing.Size(94, 29);
            this.cancelID.TabIndex = 6;
            this.cancelID.Text = "주문 취소";
            this.cancelID.UseVisualStyleBackColor = true;
            this.cancelID.Click += new System.EventHandler(this.cancelID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "수정";
            // 
            // deleteDrink
            // 
            this.deleteDrink.Location = new System.Drawing.Point(593, 102);
            this.deleteDrink.Name = "deleteDrink";
            this.deleteDrink.Size = new System.Drawing.Size(239, 29);
            this.deleteDrink.TabIndex = 8;
            this.deleteDrink.Text = "뷰에서 선택한 음료 삭제";
            this.deleteDrink.UseVisualStyleBackColor = true;
            this.deleteDrink.Click += new System.EventHandler(this.deleteDrink_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.Location = new System.Drawing.Point(212, 322);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(94, 29);
            this.viewOrders.TabIndex = 9;
            this.viewOrders.Text = "주문 상세";
            this.viewOrders.UseVisualStyleBackColor = true;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // menuBox
            // 
            this.menuBox.FormattingEnabled = true;
            this.menuBox.Location = new System.Drawing.Point(593, 137);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(141, 28);
            this.menuBox.TabIndex = 10;
            // 
            // addDrink
            // 
            this.addDrink.Location = new System.Drawing.Point(740, 134);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(94, 32);
            this.addDrink.TabIndex = 12;
            this.addDrink.Text = "추가";
            this.addDrink.UseVisualStyleBackColor = true;
            this.addDrink.Click += new System.EventHandler(this.addDrink_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 386);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.viewOrders);
            this.Controls.Add(this.deleteDrink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelID);
            this.Controls.Add(this.View2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewID);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.View1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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