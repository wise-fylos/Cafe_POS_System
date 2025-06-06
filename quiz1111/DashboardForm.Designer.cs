namespace quiz1111
{
    partial class DashboardForm
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
            dateTimePicker2 = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            로그아웃ToolStripMenuItem = new ToolStripMenuItem();
            관리자기능ToolStripMenuItem = new ToolStripMenuItem();
            유저로그확인ToolStripMenuItem = new ToolStripMenuItem();
            커피판매품목관리ToolStripMenuItem = new ToolStripMenuItem();
            통계자료ToolStripMenuItem = new ToolStripMenuItem();
            사용자별일일판매액ToolStripMenuItem = new ToolStripMenuItem();
            사용자별일일판매량ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            수정내역조회ToolStripMenuItem = new ToolStripMenuItem();
            주문검ToolStripMenuItem = new ToolStripMenuItem();
            패스워드변경ToolStripMenuItem = new ToolStripMenuItem();
            menuBox = new ComboBox();
            pos = new Button();
            label1 = new Label();
            adminView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            count = new TextBox();
            add = new Button();
            orders = new ListBox();
            delete = new Button();
            ordersCount = new ListBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminView).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(9, 26);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(195, 23);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 로그아웃ToolStripMenuItem, 관리자기능ToolStripMenuItem, 주문검ToolStripMenuItem, 패스워드변경ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(481, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 로그아웃ToolStripMenuItem
            // 
            로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            로그아웃ToolStripMenuItem.Size = new Size(67, 20);
            로그아웃ToolStripMenuItem.Text = "로그아웃";
            로그아웃ToolStripMenuItem.Click += 로그아웃ToolStripMenuItem_Click;
            // 
            // 관리자기능ToolStripMenuItem
            // 
            관리자기능ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 유저로그확인ToolStripMenuItem, 커피판매품목관리ToolStripMenuItem, 통계자료ToolStripMenuItem, 수정내역조회ToolStripMenuItem });
            관리자기능ToolStripMenuItem.Name = "관리자기능ToolStripMenuItem";
            관리자기능ToolStripMenuItem.Size = new Size(83, 20);
            관리자기능ToolStripMenuItem.Text = "관리자 기능";
            // 
            // 유저로그확인ToolStripMenuItem
            // 
            유저로그확인ToolStripMenuItem.Name = "유저로그확인ToolStripMenuItem";
            유저로그확인ToolStripMenuItem.Size = new Size(182, 22);
            유저로그확인ToolStripMenuItem.Text = "유저 로그 확인";
            유저로그확인ToolStripMenuItem.Click += 유저로그확인ToolStripMenuItem_Click;
            // 
            // 커피판매품목관리ToolStripMenuItem
            // 
            커피판매품목관리ToolStripMenuItem.Name = "커피판매품목관리ToolStripMenuItem";
            커피판매품목관리ToolStripMenuItem.Size = new Size(182, 22);
            커피판매품목관리ToolStripMenuItem.Text = "커피 판매 품목 관리";
            커피판매품목관리ToolStripMenuItem.Click += 커피판매품목관리ToolStripMenuItem_Click;
            // 
            // 통계자료ToolStripMenuItem
            // 
            통계자료ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 사용자별일일판매액ToolStripMenuItem, 사용자별일일판매량ToolStripMenuItem, toolStripMenuItem1 });
            통계자료ToolStripMenuItem.Name = "통계자료ToolStripMenuItem";
            통계자료ToolStripMenuItem.Size = new Size(182, 22);
            통계자료ToolStripMenuItem.Text = "통계자료";
            // 
            // 사용자별일일판매액ToolStripMenuItem
            // 
            사용자별일일판매액ToolStripMenuItem.Name = "사용자별일일판매액ToolStripMenuItem";
            사용자별일일판매액ToolStripMenuItem.Size = new Size(271, 22);
            사용자별일일판매액ToolStripMenuItem.Text = "사용자별 일일 판매액/판매량";
            사용자별일일판매액ToolStripMenuItem.Click += 사용자별일일판매액ToolStripMenuItem_Click;
            // 
            // 사용자별일일판매량ToolStripMenuItem
            // 
            사용자별일일판매량ToolStripMenuItem.Name = "사용자별일일판매량ToolStripMenuItem";
            사용자별일일판매량ToolStripMenuItem.Size = new Size(271, 22);
            사용자별일일판매량ToolStripMenuItem.Text = "커피종류별 일일 판매액/판매량";
            사용자별일일판매량ToolStripMenuItem.Click += 사용자별일일판매량ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(271, 22);
            toolStripMenuItem1.Text = "커피종류별 월별 누적 판매액/판매량";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // 수정내역조회ToolStripMenuItem
            // 
            수정내역조회ToolStripMenuItem.Name = "수정내역조회ToolStripMenuItem";
            수정내역조회ToolStripMenuItem.Size = new Size(182, 22);
            수정내역조회ToolStripMenuItem.Text = "수정내역 조회";
            수정내역조회ToolStripMenuItem.Click += 수정내역조회ToolStripMenuItem_Click;
            // 
            // 주문검ToolStripMenuItem
            // 
            주문검ToolStripMenuItem.Name = "주문검ToolStripMenuItem";
            주문검ToolStripMenuItem.Size = new Size(111, 20);
            주문검ToolStripMenuItem.Text = "시간별 주문 검색";
            주문검ToolStripMenuItem.Click += 주문검ToolStripMenuItem_Click;
            // 
            // 패스워드변경ToolStripMenuItem
            // 
            패스워드변경ToolStripMenuItem.Name = "패스워드변경ToolStripMenuItem";
            패스워드변경ToolStripMenuItem.Size = new Size(95, 20);
            패스워드변경ToolStripMenuItem.Text = "패스워드 변경";
            패스워드변경ToolStripMenuItem.Click += 패스워드변경ToolStripMenuItem_Click;
            // 
            // menuBox
            // 
            menuBox.FormattingEnabled = true;
            menuBox.Location = new Point(45, 50);
            menuBox.Margin = new Padding(2, 2, 2, 2);
            menuBox.Name = "menuBox";
            menuBox.Size = new Size(118, 23);
            menuBox.TabIndex = 4;
            menuBox.SelectedIndexChanged += menuBox_SelectedIndexChanged;
            // 
            // pos
            // 
            pos.Location = new Point(408, 48);
            pos.Margin = new Padding(2, 2, 2, 2);
            pos.Name = "pos";
            pos.Size = new Size(61, 23);
            pos.TabIndex = 5;
            pos.Text = "주문";
            pos.UseVisualStyleBackColor = true;
            pos.Click += pos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "메뉴";
            // 
            // adminView
            // 
            adminView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminView.Location = new Point(9, 206);
            adminView.Margin = new Padding(2, 2, 2, 2);
            adminView.Name = "adminView";
            adminView.RowHeadersWidth = 51;
            adminView.RowTemplate.Height = 29;
            adminView.Size = new Size(460, 119);
            adminView.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 189);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 8;
            label2.Text = "관리자용 그리드";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "수량";
            // 
            // count
            // 
            count.Location = new Point(208, 50);
            count.Margin = new Padding(2, 2, 2, 2);
            count.Name = "count";
            count.Size = new Size(41, 23);
            count.TabIndex = 10;
            // 
            // add
            // 
            add.Location = new Point(253, 48);
            add.Margin = new Padding(2, 2, 2, 2);
            add.Name = "add";
            add.Size = new Size(73, 24);
            add.TabIndex = 11;
            add.Text = "추가";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // orders
            // 
            orders.FormattingEnabled = true;
            orders.ItemHeight = 15;
            orders.Location = new Point(45, 79);
            orders.Margin = new Padding(2, 2, 2, 2);
            orders.Name = "orders";
            orders.Size = new Size(118, 94);
            orders.TabIndex = 12;
            orders.Click += orders_Click;
            // 
            // delete
            // 
            delete.Location = new Point(331, 48);
            delete.Margin = new Padding(2, 2, 2, 2);
            delete.Name = "delete";
            delete.Size = new Size(73, 24);
            delete.TabIndex = 13;
            delete.Text = "삭제";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // ordersCount
            // 
            ordersCount.FormattingEnabled = true;
            ordersCount.ItemHeight = 15;
            ordersCount.Location = new Point(208, 79);
            ordersCount.Margin = new Padding(2, 2, 2, 2);
            ordersCount.Name = "ordersCount";
            ordersCount.Size = new Size(41, 94);
            ordersCount.TabIndex = 14;
            ordersCount.Click += ordersCount_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 334);
            Controls.Add(ordersCount);
            Controls.Add(delete);
            Controls.Add(orders);
            Controls.Add(add);
            Controls.Add(count);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(adminView);
            Controls.Add(label1);
            Controls.Add(pos);
            Controls.Add(menuBox);
            Controls.Add(dateTimePicker2);
            Controls.Add(menuStrip1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DashboardForm";
            Text = "대시보드";
            FormClosing += Form3_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private ToolStripMenuItem 관리자기능ToolStripMenuItem;
        private ToolStripMenuItem 유저로그확인ToolStripMenuItem;
        private ToolStripMenuItem 커피판매품목관리ToolStripMenuItem;
        private ToolStripMenuItem 통계자료ToolStripMenuItem;
        private ToolStripMenuItem 사용자별일일판매액ToolStripMenuItem;
        private ToolStripMenuItem 사용자별일일판매량ToolStripMenuItem;
        private ComboBox menuBox;
        private Button pos;
        private Label label1;
        private DataGridView adminView;
        private Label label2;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label3;
        private TextBox count;
        private Button add;
        private ListBox orders;
        private Button delete;
        private ListBox ordersCount;
        private ToolStripMenuItem 주문검ToolStripMenuItem;
        private ToolStripMenuItem 수정내역조회ToolStripMenuItem;
        private ToolStripMenuItem 패스워드변경ToolStripMenuItem;
    }
}