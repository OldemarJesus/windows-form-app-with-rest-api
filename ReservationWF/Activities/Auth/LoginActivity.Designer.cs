namespace ReservationWF.Activities.Auth
{
    partial class LoginActivity
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
            loginFormTitlelbl = new Label();
            userNameLbl = new Label();
            passLbl = new Label();
            usernameInputTxt = new TextBox();
            passwordInputTxt = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // loginFormTitlelbl
            // 
            loginFormTitlelbl.AutoSize = true;
            loginFormTitlelbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            loginFormTitlelbl.Location = new Point(12, 9);
            loginFormTitlelbl.Name = "loginFormTitlelbl";
            loginFormTitlelbl.Size = new Size(129, 30);
            loginFormTitlelbl.TabIndex = 0;
            loginFormTitlelbl.Text = "Login Form";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(12, 57);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(63, 15);
            userNameLbl.TabIndex = 1;
            userNameLbl.Text = "Username:";
            // 
            // passLbl
            // 
            passLbl.AutoSize = true;
            passLbl.Location = new Point(12, 136);
            passLbl.Name = "passLbl";
            passLbl.Size = new Size(60, 15);
            passLbl.TabIndex = 2;
            passLbl.Text = "Password:";
            passLbl.Visible = false;
            // 
            // usernameInputTxt
            // 
            usernameInputTxt.Location = new Point(12, 75);
            usernameInputTxt.Name = "usernameInputTxt";
            usernameInputTxt.Size = new Size(260, 23);
            usernameInputTxt.TabIndex = 3;
            // 
            // passwordInputTxt
            // 
            passwordInputTxt.Location = new Point(12, 154);
            passwordInputTxt.Name = "passwordInputTxt";
            passwordInputTxt.PasswordChar = '*';
            passwordInputTxt.Size = new Size(260, 23);
            passwordInputTxt.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(63, 226);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += onLoginBtnClick;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(144, 226);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register?";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += onRegisterBtnClick;
            // 
            // LoginActivity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordInputTxt);
            Controls.Add(usernameInputTxt);
            Controls.Add(passLbl);
            Controls.Add(userNameLbl);
            Controls.Add(loginFormTitlelbl);
            Name = "LoginActivity";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginFormTitlelbl;
        private Label userNameLbl;
        private Label passLbl;
        private TextBox usernameInputTxt;
        private TextBox passwordInputTxt;
        private Button loginBtn;
        private Button registerBtn;
    }
}