namespace DBTestWinForm
{
    partial class AddUserForm
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
            this.UserName = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.UserSurName = new System.Windows.Forms.Label();
            this.UserAge = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserSurnameTextBox = new System.Windows.Forms.TextBox();
            this.UserAgeTextBox = new System.Windows.Forms.TextBox();
            this.UserLoginTextBox = new System.Windows.Forms.TextBox();
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(55, 34);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(223, 21);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Введите имя пользователя";
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLogin.Location = new System.Drawing.Point(39, 146);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(239, 21);
            this.UserLogin.TabIndex = 1;
            this.UserLogin.Text = "Введите логин пользователя";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(59, 253);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(71, 41);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // UserSurName
            // 
            this.UserSurName.AutoSize = true;
            this.UserSurName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSurName.Location = new System.Drawing.Point(11, 71);
            this.UserSurName.Name = "UserSurName";
            this.UserSurName.Size = new System.Drawing.Size(267, 21);
            this.UserSurName.TabIndex = 3;
            this.UserSurName.Text = "Введите фамилию пользователя";
            // 
            // UserAge
            // 
            this.UserAge.AutoSize = true;
            this.UserAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAge.Location = new System.Drawing.Point(24, 105);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(254, 21);
            this.UserAge.TabIndex = 4;
            this.UserAge.Text = "Введите возраст пользователя";
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPassword.Location = new System.Drawing.Point(30, 181);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(248, 21);
            this.UserPassword.TabIndex = 5;
            this.UserPassword.Text = "Введите пароль пользователя";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(312, 34);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.UserNameTextBox.TabIndex = 6;
            // 
            // UserSurnameTextBox
            // 
            this.UserSurnameTextBox.Location = new System.Drawing.Point(312, 72);
            this.UserSurnameTextBox.Name = "UserSurnameTextBox";
            this.UserSurnameTextBox.Size = new System.Drawing.Size(140, 20);
            this.UserSurnameTextBox.TabIndex = 7;
            // 
            // UserAgeTextBox
            // 
            this.UserAgeTextBox.Location = new System.Drawing.Point(312, 107);
            this.UserAgeTextBox.Name = "UserAgeTextBox";
            this.UserAgeTextBox.Size = new System.Drawing.Size(140, 20);
            this.UserAgeTextBox.TabIndex = 8;
            // 
            // UserLoginTextBox
            // 
            this.UserLoginTextBox.Location = new System.Drawing.Point(312, 148);
            this.UserLoginTextBox.Name = "UserLoginTextBox";
            this.UserLoginTextBox.Size = new System.Drawing.Size(140, 20);
            this.UserLoginTextBox.TabIndex = 9;
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.Location = new System.Drawing.Point(312, 183);
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.Size = new System.Drawing.Size(140, 20);
            this.UserPasswordTextBox.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(196, 253);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(91, 41);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 304);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UserPasswordTextBox);
            this.Controls.Add(this.UserLoginTextBox);
            this.Controls.Add(this.UserAgeTextBox);
            this.Controls.Add(this.UserSurnameTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserAge);
            this.Controls.Add(this.UserSurName);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.UserName);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserLogin;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label UserSurName;
        private System.Windows.Forms.Label UserAge;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox UserSurnameTextBox;
        private System.Windows.Forms.TextBox UserAgeTextBox;
        private System.Windows.Forms.TextBox UserLoginTextBox;
        private System.Windows.Forms.TextBox UserPasswordTextBox;
        private System.Windows.Forms.Button CancelButton;
    }
}