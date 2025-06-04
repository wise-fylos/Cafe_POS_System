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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.유저로그확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.커피판매품목관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계자료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자별일일판매액ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자별일일판매량ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.수정내역조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문검ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBox = new System.Windows.Forms.ComboBox();
            this.pos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.ordersCount = new System.Windows.Forms.ListBox();
            this.패스워드변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그아웃ToolStripMenuItem,
            this.관리자기능ToolStripMenuItem,
            this.주문검ToolStripMenuItem,
            this.패스워드변경ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 관리자기능ToolStripMenuItem
            // 
            this.관리자기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유저로그확인ToolStripMenuItem,
            this.커피판매품목관리ToolStripMenuItem,
            this.통계자료ToolStripMenuItem,
            this.수정내역조회ToolStripMenuItem});
            this.관리자기능ToolStripMenuItem.Name = "관리자기능ToolStripMenuItem";
            this.관리자기능ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.관리자기능ToolStripMenuItem.Text = "관리자 기능";
            // 
            // 유저로그확인ToolStripMenuItem
            // 
            this.유저로그확인ToolStripMenuItem.Name = "유저로그확인ToolStripMenuItem";
            this.유저로그확인ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.유저로그확인ToolStripMenuItem.Text = "유저 로그 확인";
            this.유저로그확인ToolStripMenuItem.Click += new System.EventHandler(this.유저로그확인ToolStripMenuItem_Click);
            // 
            // 커피판매품목관리ToolStripMenuItem
            // 
            this.커피판매품목관리ToolStripMenuItem.Name = "커피판매품목관리ToolStripMenuItem";
            this.커피판매품목관리ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.커피판매품목관리ToolStripMenuItem.Text = "커피 판매 품목 관리";
            this.커피판매품목관리ToolStripMenuItem.Click += new System.EventHandler(this.커피판매품목관리ToolStripMenuItem_Click);
            // 
            // 통계자료ToolStripMenuItem
            // 
            this.통계자료ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자별일일판매액ToolStripMenuItem,
            this.사용자별일일판매량ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.통계자료ToolStripMenuItem.Name = "통계자료ToolStripMenuItem";
            this.통계자료ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.통계자료ToolStripMenuItem.Text = "통계자료";
            // 
            // 사용자별일일판매액ToolStripMenuItem
            // 
            this.사용자별일일판매액ToolStripMenuItem.Name = "사용자별일일판매액ToolStripMenuItem";
            this.사용자별일일판매액ToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.사용자별일일판매액ToolStripMenuItem.Text = "사용자별 일일 판매액/판매량";
            this.사용자별일일판매액ToolStripMenuItem.Click += new System.EventHandler(this.사용자별일일판매액ToolStripMenuItem_Click);
            // 
            // 사용자별일일판매량ToolStripMenuItem
            // 
            this.사용자별일일판매량ToolStripMenuItem.Name = "사용자별일일판매량ToolStripMenuItem";
            this.사용자별일일판매량ToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.사용자별일일판매량ToolStripMenuItem.Text = "커피종류별 일일 판매액/판매량";
            this.사용자별일일판매량ToolStripMenuItem.Click += new System.EventHandler(this.사용자별일일판매량ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(338, 26);
            this.toolStripMenuItem1.Text = "커피종류별 월별 누적 판매액/판매량";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 수정내역조회ToolStripMenuItem
            // 
            this.수정내역조회ToolStripMenuItem.Name = "수정내역조회ToolStripMenuItem";
            this.수정내역조회ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.수정내역조회ToolStripMenuItem.Text = "수정내역 조회";
            this.수정내역조회ToolStripMenuItem.Click += new System.EventHandler(this.수정내역조회ToolStripMenuItem_Click);
            // 
            // 주문검ToolStripMenuItem
            // 
            this.주문검ToolStripMenuItem.Name = "주문검ToolStripMenuItem";
            this.주문검ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.주문검ToolStripMenuItem.Text = "시간별 주문 검색";
            this.주문검ToolStripMenuItem.Click += new System.EventHandler(this.주문검ToolStripMenuItem_Click);
            // 
            // menuBox
            // 
            this.menuBox.FormattingEnabled = true;
            this.menuBox.Location = new System.Drawing.Point(58, 67);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(151, 28);
            this.menuBox.TabIndex = 4;
            this.menuBox.SelectedIndexChanged += new System.EventHandler(this.menuBox_SelectedIndexChanged);
            // 
            // pos
            // 
            this.pos.Location = new System.Drawing.Point(524, 64);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(79, 31);
            this.pos.TabIndex = 5;
            this.pos.Text = "주문";
            this.pos.UseVisualStyleBackColor = true;
            this.pos.Click += new System.EventHandler(this.pos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "메뉴";
            // 
            // adminView
            // 
            this.adminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminView.Location = new System.Drawing.Point(12, 275);
            this.adminView.Name = "adminView";
            this.adminView.RowHeadersWidth = 51;
            this.adminView.RowTemplate.Height = 29;
            this.adminView.Size = new System.Drawing.Size(591, 159);
            this.adminView.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "관리자용 그리드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "수량";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(268, 67);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(51, 27);
            this.count.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(325, 64);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 32);
            this.add.TabIndex = 11;
            this.add.Text = "추가";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // orders
            // 
            this.orders.FormattingEnabled = true;
            this.orders.ItemHeight = 20;
            this.orders.Location = new System.Drawing.Point(58, 105);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(151, 124);
            this.orders.TabIndex = 12;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(425, 64);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 32);
            this.delete.TabIndex = 13;
            this.delete.Text = "삭제";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ordersCount
            // 
            this.ordersCount.FormattingEnabled = true;
            this.ordersCount.ItemHeight = 20;
            this.ordersCount.Location = new System.Drawing.Point(268, 105);
            this.ordersCount.Name = "ordersCount";
            this.ordersCount.Size = new System.Drawing.Size(51, 124);
            this.ordersCount.TabIndex = 14;
            this.ordersCount.Click += new System.EventHandler(this.ordersCount_Click);
            // 
            // 패스워드변경ToolStripMenuItem
            // 
            this.패스워드변경ToolStripMenuItem.Name = "패스워드변경ToolStripMenuItem";
            this.패스워드변경ToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.패스워드변경ToolStripMenuItem.Text = "패스워드 변경";
            this.패스워드변경ToolStripMenuItem.Click += new System.EventHandler(this.패스워드변경ToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 446);
            this.Controls.Add(this.ordersCount);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.add);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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