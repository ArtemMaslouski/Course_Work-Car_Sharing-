namespace CarSharing
{
    partial class AuthorizationForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.RegistartionButton = new System.Windows.Forms.Button();
            this.ExitButtonAuthorizationForm = new System.Windows.Forms.Button();
            this.WarningLabelAuthorization = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(217, 139);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 27);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин";
            this.loginLabel.UseCompatibleTextRendering = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(217, 222);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(74, 27);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.UseCompatibleTextRendering = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(329, 136);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(156, 29);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(329, 222);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(156, 29);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(136, 398);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(144, 35);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // RegistartionButton
            // 
            this.RegistartionButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistartionButton.Location = new System.Drawing.Point(329, 398);
            this.RegistartionButton.Name = "RegistartionButton";
            this.RegistartionButton.Size = new System.Drawing.Size(201, 35);
            this.RegistartionButton.TabIndex = 0;
            this.RegistartionButton.Text = "Зарегистрироваться";
            this.RegistartionButton.Click += new System.EventHandler(this.RegistartionButton_Click);
            // 
            // ExitButtonAuthorizationForm
            // 
            this.ExitButtonAuthorizationForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonAuthorizationForm.Location = new System.Drawing.Point(587, 399);
            this.ExitButtonAuthorizationForm.Name = "ExitButtonAuthorizationForm";
            this.ExitButtonAuthorizationForm.Size = new System.Drawing.Size(144, 35);
            this.ExitButtonAuthorizationForm.TabIndex = 5;
            this.ExitButtonAuthorizationForm.Text = "Выход";
            this.ExitButtonAuthorizationForm.UseVisualStyleBackColor = true;
            this.ExitButtonAuthorizationForm.Click += new System.EventHandler(this.ExitButtonAuthorizationForm_Click);
            // 
            // WarningLabelAuthorization
            // 
            this.WarningLabelAuthorization.AutoSize = true;
            this.WarningLabelAuthorization.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLabelAuthorization.ForeColor = System.Drawing.Color.Red;
            this.WarningLabelAuthorization.Location = new System.Drawing.Point(240, 282);
            this.WarningLabelAuthorization.Name = "WarningLabelAuthorization";
            this.WarningLabelAuthorization.Size = new System.Drawing.Size(293, 15);
            this.WarningLabelAuthorization.TabIndex = 6;
            this.WarningLabelAuthorization.Text = "Неправильный логин или пароль. Повторите вход";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.WarningLabelAuthorization);
            this.Controls.Add(this.ExitButtonAuthorizationForm);
            this.Controls.Add(this.RegistartionButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button RegistartionButton;
        private System.Windows.Forms.Button ExitButtonAuthorizationForm;
        private System.Windows.Forms.Label WarningLabelAuthorization;
    }
}