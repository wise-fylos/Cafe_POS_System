namespace quiz1111
{
    partial class LoginForm
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
            login = new Button();
            label1 = new Label();
            idBox = new TextBox();
            pwBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(125, 165);
            login.Margin = new Padding(2, 2, 2, 2);
            login.Name = "login";
            login.Size = new Size(73, 22);
            login.TabIndex = 0;
            login.Text = "로그인";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "아이디";
            // 
            // idBox
            // 
            idBox.Location = new Point(113, 93);
            idBox.Margin = new Padding(2, 2, 2, 2);
            idBox.Name = "idBox";
            idBox.Size = new Size(98, 23);
            idBox.TabIndex = 2;
            // 
            // pwBox
            // 
            pwBox.Location = new Point(113, 126);
            pwBox.Margin = new Padding(2, 2, 2, 2);
            pwBox.Name = "pwBox";
            pwBox.Size = new Size(98, 23);
            pwBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "비밀번호";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 290);
            Controls.Add(label2);
            Controls.Add(pwBox);
            Controls.Add(idBox);
            Controls.Add(label1);
            Controls.Add(login);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            Text = "로그인";
            FormClosing += Form2_FormClosing;
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Label label1;
        private TextBox idBox;
        private TextBox pwBox;
        private Label label2;
    }
}