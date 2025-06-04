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
            this.label1 = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pwUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "변경할 비밀번호";
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(204, 35);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(125, 27);
            this.pwBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "*사용자 패스워드는 1개 이상의 대문자, 특수문자,\r\n숫자를 포함하여야 하며, 8자 이상으로 구성되어야 합니다.";
            // 
            // pwUpdate
            // 
            this.pwUpdate.Location = new System.Drawing.Point(150, 68);
            this.pwUpdate.Name = "pwUpdate";
            this.pwUpdate.Size = new System.Drawing.Size(102, 32);
            this.pwUpdate.TabIndex = 3;
            this.pwUpdate.Text = "확인";
            this.pwUpdate.UseVisualStyleBackColor = true;
            this.pwUpdate.Click += new System.EventHandler(this.pwUpdate_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 177);
            this.Controls.Add(this.pwUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox pwBox;
        private Label label2;
        private Button pwUpdate;
    }
}