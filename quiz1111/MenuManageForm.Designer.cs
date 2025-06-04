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
            this.menuBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_i = new System.Windows.Forms.TextBox();
            this.price_i = new System.Windows.Forms.TextBox();
            this.price_u = new System.Windows.Forms.TextBox();
            this.name_u = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuBox
            // 
            this.menuBox.FormattingEnabled = true;
            this.menuBox.Location = new System.Drawing.Point(92, 85);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(151, 28);
            this.menuBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "메뉴 수정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "메뉴 추가";
            // 
            // name_i
            // 
            this.name_i.Location = new System.Drawing.Point(329, 25);
            this.name_i.Name = "name_i";
            this.name_i.Size = new System.Drawing.Size(125, 27);
            this.name_i.TabIndex = 8;
            // 
            // price_i
            // 
            this.price_i.Location = new System.Drawing.Point(518, 25);
            this.price_i.Name = "price_i";
            this.price_i.Size = new System.Drawing.Size(125, 27);
            this.price_i.TabIndex = 9;
            // 
            // price_u
            // 
            this.price_u.Location = new System.Drawing.Point(518, 88);
            this.price_u.Name = "price_u";
            this.price_u.Size = new System.Drawing.Size(125, 27);
            this.price_u.TabIndex = 11;
            // 
            // name_u
            // 
            this.name_u.Location = new System.Drawing.Point(329, 88);
            this.name_u.Name = "name_u";
            this.name_u.Size = new System.Drawing.Size(125, 27);
            this.name_u.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "품목명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "품목명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "가격";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(660, 24);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(94, 29);
            this.insert.TabIndex = 16;
            this.insert.Text = "확인";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(660, 88);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 29);
            this.update.TabIndex = 17;
            this.update.Text = "확인";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 145);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_u);
            this.Controls.Add(this.name_u);
            this.Controls.Add(this.price_i);
            this.Controls.Add(this.name_i);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuBox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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