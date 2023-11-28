namespace CarSharing
{
    partial class RegistartionForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.LoginRegistartionTextBox = new System.Windows.Forms.TextBox();
            this.PasswordRegistrationFormTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordRegistartionFormTextBox = new System.Windows.Forms.TextBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.ExitButtonRegistrationForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(220, 101);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(65, 22);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(210, 159);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 22);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(126, 227);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(169, 22);
            this.RepeatPasswordLabel.TabIndex = 2;
            this.RepeatPasswordLabel.Text = "Повторите пароль";
            // 
            // LoginRegistartionTextBox
            // 
            this.LoginRegistartionTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginRegistartionTextBox.Location = new System.Drawing.Point(323, 96);
            this.LoginRegistartionTextBox.Name = "LoginRegistartionTextBox";
            this.LoginRegistartionTextBox.Size = new System.Drawing.Size(142, 29);
            this.LoginRegistartionTextBox.TabIndex = 3;
            // 
            // PasswordRegistrationFormTextBox
            // 
            this.PasswordRegistrationFormTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRegistrationFormTextBox.Location = new System.Drawing.Point(323, 159);
            this.PasswordRegistrationFormTextBox.Name = "PasswordRegistrationFormTextBox";
            this.PasswordRegistrationFormTextBox.PasswordChar = '*';
            this.PasswordRegistrationFormTextBox.Size = new System.Drawing.Size(142, 29);
            this.PasswordRegistrationFormTextBox.TabIndex = 4;
            // 
            // RepeatPasswordRegistartionFormTextBox
            // 
            this.RepeatPasswordRegistartionFormTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPasswordRegistartionFormTextBox.Location = new System.Drawing.Point(323, 222);
            this.RepeatPasswordRegistartionFormTextBox.Name = "RepeatPasswordRegistartionFormTextBox";
            this.RepeatPasswordRegistartionFormTextBox.PasswordChar = '*';
            this.RepeatPasswordRegistartionFormTextBox.Size = new System.Drawing.Size(142, 29);
            this.RepeatPasswordRegistartionFormTextBox.TabIndex = 5;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAccountButton.Location = new System.Drawing.Point(245, 397);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(172, 41);
            this.CreateAccountButton.TabIndex = 8;
            this.CreateAccountButton.Text = "Создать аккаунт";
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // ExitButtonRegistrationForm
            // 
            this.ExitButtonRegistrationForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonRegistrationForm.Location = new System.Drawing.Point(452, 397);
            this.ExitButtonRegistrationForm.Name = "ExitButtonRegistrationForm";
            this.ExitButtonRegistrationForm.Size = new System.Drawing.Size(139, 41);
            this.ExitButtonRegistrationForm.TabIndex = 7;
            this.ExitButtonRegistrationForm.Text = "Выход";
            this.ExitButtonRegistrationForm.UseVisualStyleBackColor = true;
            this.ExitButtonRegistrationForm.Click += new System.EventHandler(this.ExitButtonRegistrationForm_Click);
            // 
            // RegistartionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButtonRegistrationForm);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.RepeatPasswordRegistartionFormTextBox);
            this.Controls.Add(this.PasswordRegistrationFormTextBox);
            this.Controls.Add(this.LoginRegistartionTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Name = "RegistartionForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.TextBox LoginRegistartionTextBox;
        private System.Windows.Forms.TextBox PasswordRegistrationFormTextBox;
        private System.Windows.Forms.TextBox RepeatPasswordRegistartionFormTextBox;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Button ExitButtonRegistrationForm;
    }
}