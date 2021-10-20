
namespace Internet_service_provider
{
    partial class AuthorizationWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.logOnButton = new System.Windows.Forms.Button();
            this.loginText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logOnButton
            // 
            this.logOnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.logOnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOnButton.ForeColor = System.Drawing.Color.White;
            this.logOnButton.Location = new System.Drawing.Point(232, 234);
            this.logOnButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOnButton.Name = "logOnButton";
            this.logOnButton.Size = new System.Drawing.Size(124, 51);
            this.logOnButton.TabIndex = 2;
            this.logOnButton.Text = "Войти";
            this.logOnButton.UseVisualStyleBackColor = false;
            this.logOnButton.Click += new System.EventHandler(this.logOnButton_Click);
            this.logOnButton.MouseEnter += new System.EventHandler(this.logOnButton_MouseEnter);
            this.logOnButton.MouseLeave += new System.EventHandler(this.logOnButton_MouseLeave);
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.ForeColor = System.Drawing.Color.Black;
            this.loginText.Location = new System.Drawing.Point(184, 83);
            this.loginText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(57, 20);
            this.loginText.TabIndex = 3;
            this.loginText.Text = "Логин";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.ForeColor = System.Drawing.Color.Black;
            this.passwordText.Location = new System.Drawing.Point(184, 146);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(66, 20);
            this.passwordText.TabIndex = 4;
            this.passwordText.Text = "Пароль";
            // 
            // loginField
            // 
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginField.Location = new System.Drawing.Point(188, 107);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(223, 27);
            this.loginField.TabIndex = 0;
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordField.Location = new System.Drawing.Point(188, 170);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(223, 27);
            this.passwordField.TabIndex = 1;
            // 
            // AuthorizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.logOnButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginField);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorizationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOnButton;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
    }
}

