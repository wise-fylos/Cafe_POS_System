namespace quiz1111
{
    partial class MenuManageForm
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
            menuBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            name_i = new TextBox();
            price_i = new TextBox();
            price_u = new TextBox();
            name_u = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            insert = new Button();
            update = new Button();
            SuspendLayout();
            // 
            // menuBox
            // 
            menuBox.FormattingEnabled = true;
            menuBox.Location = new Point(72, 64);
            menuBox.Margin = new Padding(2, 2, 2, 2);
            menuBox.Name = "menuBox";
            menuBox.Size = new Size(118, 23);
            menuBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "메뉴 수정";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "메뉴 추가";
            // 
            // name_i
            // 
            name_i.Location = new Point(256, 19);
            name_i.Margin = new Padding(2, 2, 2, 2);
            name_i.Name = "name_i";
            name_i.Size = new Size(98, 23);
            name_i.TabIndex = 8;
            // 
            // price_i
            // 
            price_i.Location = new Point(403, 19);
            price_i.Margin = new Padding(2, 2, 2, 2);
            price_i.Name = "price_i";
            price_i.Size = new Size(98, 23);
            price_i.TabIndex = 9;
            // 
            // price_u
            // 
            price_u.Location = new Point(403, 66);
            price_u.Margin = new Padding(2, 2, 2, 2);
            price_u.Name = "price_u";
            price_u.Size = new Size(98, 23);
            price_u.TabIndex = 11;
            // 
            // name_u
            // 
            name_u.Location = new Point(256, 66);
            name_u.Margin = new Padding(2, 2, 2, 2);
            name_u.Name = "name_u";
            name_u.Size = new Size(98, 23);
            name_u.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 12;
            label3.Text = "품목명";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 13;
            label4.Text = "품목명";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 71);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 14;
            label5.Text = "가격";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 24);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 15;
            label6.Text = "가격";
            // 
            // insert
            // 
            insert.Location = new Point(513, 18);
            insert.Margin = new Padding(2, 2, 2, 2);
            insert.Name = "insert";
            insert.Size = new Size(73, 22);
            insert.TabIndex = 16;
            insert.Text = "확인";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.Location = new Point(513, 66);
            update.Margin = new Padding(2, 2, 2, 2);
            update.Name = "update";
            update.Size = new Size(73, 22);
            update.TabIndex = 17;
            update.Text = "확인";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // MenuManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 109);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(price_u);
            Controls.Add(name_u);
            Controls.Add(price_i);
            Controls.Add(name_i);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MenuManageForm";
            Text = "메뉴 매니지먼트";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox menuBox;
        private Label label1;
        private Label label2;
        private TextBox name_i;
        private TextBox price_i;
        private TextBox price_u;
        private TextBox name_u;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button insert;
        private Button update;
    }
}