namespace quiz1111
{
    partial class PasswordUpdateForm
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
            label1 = new Label();
            pwBox = new TextBox();
            label2 = new Label();
            pwUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "변경할 비밀번호";
            // 
            // pwBox
            // 
            pwBox.Location = new Point(159, 26);
            pwBox.Margin = new Padding(2, 2, 2, 2);
            pwBox.Name = "pwBox";
            pwBox.Size = new Size(98, 23);
            pwBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(320, 30);
            label2.TabIndex = 2;
            label2.Text = "*사용자 패스워드는 1개 이상의 대문자, 특수문자,\r\n숫자를 포함하여야 하며, 8자 이상으로 구성되어야 합니다.";
            // 
            // pwUpdate
            // 
            pwUpdate.Location = new Point(117, 51);
            pwUpdate.Margin = new Padding(2, 2, 2, 2);
            pwUpdate.Name = "pwUpdate";
            pwUpdate.Size = new Size(79, 24);
            pwUpdate.TabIndex = 3;
            pwUpdate.Text = "확인";
            pwUpdate.UseVisualStyleBackColor = true;
            pwUpdate.Click += pwUpdate_Click;
            // 
            // PasswordUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 133);
            Controls.Add(pwUpdate);
            Controls.Add(label2);
            Controls.Add(pwBox);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PasswordUpdateForm";
            Text = "비밀번호 변경";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox pwBox;
        private Label label2;
        private Button pwUpdate;
    }
}