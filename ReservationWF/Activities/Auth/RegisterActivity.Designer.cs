namespace ReservationWF.Activities.Auth
{
    partial class RegisterActivity
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
            registerFormTitleLbl = new Label();
            firstNameInputLbl = new Label();
            usernameInputLbl = new Label();
            lastNameInputLbl = new Label();
            passwordInputLbl = new Label();
            registerBtn = new Button();
            loginBtn = new Button();
            clearBtn = new Button();
            firstNameInputTxt = new TextBox();
            lastNameInputTxt = new TextBox();
            usernameInputTxt = new TextBox();
            passwordInputTxt = new TextBox();
            SuspendLayout();
            // 
            // registerFormTitleLbl
            // 
            registerFormTitleLbl.AutoSize = true;
            registerFormTitleLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            registerFormTitleLbl.Location = new Point(12, 9);
            registerFormTitleLbl.Name = "registerFormTitleLbl";
            registerFormTitleLbl.Size = new Size(157, 30);
            registerFormTitleLbl.TabIndex = 0;
            registerFormTitleLbl.Text = "Register Form";
            // 
            // firstNameInputLbl
            // 
            firstNameInputLbl.AutoSize = true;
            firstNameInputLbl.Location = new Point(12, 51);
            firstNameInputLbl.Name = "firstNameInputLbl";
            firstNameInputLbl.Size = new Size(64, 15);
            firstNameInputLbl.TabIndex = 1;
            firstNameInputLbl.Text = "First Name";
            // 
            // usernameInputLbl
            // 
            usernameInputLbl.AutoSize = true;
            usernameInputLbl.Location = new Point(304, 51);
            usernameInputLbl.Name = "usernameInputLbl";
            usernameInputLbl.Size = new Size(60, 15);
            usernameInputLbl.TabIndex = 2;
            usernameInputLbl.Text = "Username";
            // 
            // lastNameInputLbl
            // 
            lastNameInputLbl.AutoSize = true;
            lastNameInputLbl.Location = new Point(12, 107);
            lastNameInputLbl.Name = "lastNameInputLbl";
            lastNameInputLbl.Size = new Size(63, 15);
            lastNameInputLbl.TabIndex = 3;
            lastNameInputLbl.Text = "Last Name";
            // 
            // passwordInputLbl
            // 
            passwordInputLbl.AutoSize = true;
            passwordInputLbl.Location = new Point(304, 107);
            passwordInputLbl.Name = "passwordInputLbl";
            passwordInputLbl.Size = new Size(57, 15);
            passwordInputLbl.TabIndex = 4;
            passwordInputLbl.Text = "Password";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(12, 226);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += onRegisterBtnClick;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(93, 226);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login?";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += onLoginBtnClick;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(174, 226);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += onClearBtnClick;
            // 
            // firstNameInputTxt
            // 
            firstNameInputTxt.Location = new Point(12, 69);
            firstNameInputTxt.Name = "firstNameInputTxt";
            firstNameInputTxt.Size = new Size(240, 23);
            firstNameInputTxt.TabIndex = 8;
            // 
            // lastNameInputTxt
            // 
            lastNameInputTxt.Location = new Point(12, 125);
            lastNameInputTxt.Name = "lastNameInputTxt";
            lastNameInputTxt.Size = new Size(237, 23);
            lastNameInputTxt.TabIndex = 9;
            // 
            // usernameInputTxt
            // 
            usernameInputTxt.Location = new Point(304, 69);
            usernameInputTxt.Name = "usernameInputTxt";
            usernameInputTxt.Size = new Size(168, 23);
            usernameInputTxt.TabIndex = 10;
            // 
            // passwordInputTxt
            // 
            passwordInputTxt.Location = new Point(304, 125);
            passwordInputTxt.Name = "passwordInputTxt";
            passwordInputTxt.PasswordChar = '*';
            passwordInputTxt.Size = new Size(168, 23);
            passwordInputTxt.TabIndex = 11;
            // 
            // RegisterActivity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(passwordInputTxt);
            Controls.Add(usernameInputTxt);
            Controls.Add(lastNameInputTxt);
            Controls.Add(firstNameInputTxt);
            Controls.Add(clearBtn);
            Controls.Add(loginBtn);
            Controls.Add(registerBtn);
            Controls.Add(passwordInputLbl);
            Controls.Add(lastNameInputLbl);
            Controls.Add(usernameInputLbl);
            Controls.Add(firstNameInputLbl);
            Controls.Add(registerFormTitleLbl);
            Name = "RegisterActivity";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerFormTitleLbl;
        private Label firstNameInputLbl;
        private Label usernameInputLbl;
        private Label lastNameInputLbl;
        private Label passwordInputLbl;
        private Button registerBtn;
        private Button loginBtn;
        private Button clearBtn;
        private TextBox firstNameInputTxt;
        private TextBox lastNameInputTxt;
        private TextBox usernameInputTxt;
        private TextBox passwordInputTxt;
    }
}