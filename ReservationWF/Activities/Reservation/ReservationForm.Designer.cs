namespace ReservationWF
{
    partial class ReservationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            homeTitlelbl = new Label();
            firstNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            startDateDtp = new DateTimePicker();
            endDateDtp = new DateTimePicker();
            totalPeopleTxt = new NumericUpDown();
            firstNameLbl = new Label();
            lastNameLbl = new Label();
            startDateLbl = new Label();
            endDateLbl = new Label();
            totalPeopleLbl = new Label();
            saveBtn = new Button();
            clearBtn = new Button();
            authenticatedUserLbl = new Label();
            authenticatedUserTxt = new Label();
            logoutBtn = new Button();
            listBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)totalPeopleTxt).BeginInit();
            SuspendLayout();
            // 
            // homeTitlelbl
            // 
            homeTitlelbl.AutoSize = true;
            homeTitlelbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            homeTitlelbl.Location = new Point(12, 9);
            homeTitlelbl.Name = "homeTitlelbl";
            homeTitlelbl.Size = new Size(169, 25);
            homeTitlelbl.TabIndex = 0;
            homeTitlelbl.Text = "Reservation Form";
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(22, 71);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(451, 23);
            firstNameTxt.TabIndex = 1;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(20, 127);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(453, 23);
            lastNameTxt.TabIndex = 2;
            // 
            // startDateDtp
            // 
            startDateDtp.Location = new Point(22, 182);
            startDateDtp.Name = "startDateDtp";
            startDateDtp.Size = new Size(200, 23);
            startDateDtp.TabIndex = 3;
            // 
            // endDateDtp
            // 
            endDateDtp.Location = new Point(273, 182);
            endDateDtp.Name = "endDateDtp";
            endDateDtp.Size = new Size(200, 23);
            endDateDtp.TabIndex = 4;
            // 
            // totalPeopleTxt
            // 
            totalPeopleTxt.Location = new Point(22, 259);
            totalPeopleTxt.Name = "totalPeopleTxt";
            totalPeopleTxt.Size = new Size(120, 23);
            totalPeopleTxt.TabIndex = 5;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(22, 53);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(64, 15);
            firstNameLbl.TabIndex = 6;
            firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(22, 109);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(63, 15);
            lastNameLbl.TabIndex = 7;
            lastNameLbl.Text = "Last Name";
            // 
            // startDateLbl
            // 
            startDateLbl.AutoSize = true;
            startDateLbl.Location = new Point(22, 164);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(58, 15);
            startDateLbl.TabIndex = 8;
            startDateLbl.Text = "Start Date";
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Location = new Point(273, 164);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(54, 15);
            endDateLbl.TabIndex = 9;
            endDateLbl.Text = "End Date";
            // 
            // totalPeopleLbl
            // 
            totalPeopleLbl.AutoSize = true;
            totalPeopleLbl.Location = new Point(22, 241);
            totalPeopleLbl.Name = "totalPeopleLbl";
            totalPeopleLbl.Size = new Size(109, 15);
            totalPeopleLbl.TabIndex = 10;
            totalPeopleLbl.Text = "How many people?";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(22, 333);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += onSaveBtnClick;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(106, 333);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 12;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += onClearBtnClick;
            // 
            // authenticatedUserLbl
            // 
            authenticatedUserLbl.AutoSize = true;
            authenticatedUserLbl.Location = new Point(537, 9);
            authenticatedUserLbl.Name = "authenticatedUserLbl";
            authenticatedUserLbl.Size = new Size(99, 15);
            authenticatedUserLbl.TabIndex = 13;
            authenticatedUserLbl.Text = "Authenticated as:";
            // 
            // authenticatedUserTxt
            // 
            authenticatedUserTxt.AutoSize = true;
            authenticatedUserTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            authenticatedUserTxt.Location = new Point(642, 9);
            authenticatedUserTxt.Name = "authenticatedUserTxt";
            authenticatedUserTxt.Size = new Size(40, 15);
            authenticatedUserTxt.TabIndex = 14;
            authenticatedUserTxt.Text = "Guest";
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(268, 333);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(75, 23);
            logoutBtn.TabIndex = 15;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += onLogoutBtnClick;
            // 
            // listBtn
            // 
            listBtn.Location = new Point(187, 333);
            listBtn.Name = "listBtn";
            listBtn.Size = new Size(75, 23);
            listBtn.TabIndex = 16;
            listBtn.Text = "List";
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += onListBtnClick;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(listBtn);
            Controls.Add(logoutBtn);
            Controls.Add(authenticatedUserTxt);
            Controls.Add(authenticatedUserLbl);
            Controls.Add(clearBtn);
            Controls.Add(saveBtn);
            Controls.Add(totalPeopleLbl);
            Controls.Add(endDateLbl);
            Controls.Add(startDateLbl);
            Controls.Add(lastNameLbl);
            Controls.Add(firstNameLbl);
            Controls.Add(totalPeopleTxt);
            Controls.Add(endDateDtp);
            Controls.Add(startDateDtp);
            Controls.Add(lastNameTxt);
            Controls.Add(firstNameTxt);
            Controls.Add(homeTitlelbl);
            Name = "ReservationForm";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)totalPeopleTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label homeTitlelbl;
        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private DateTimePicker startDateDtp;
        private DateTimePicker endDateDtp;
        private NumericUpDown totalPeopleTxt;
        private Label firstNameLbl;
        private Label lastNameLbl;
        private Label startDateLbl;
        private Label endDateLbl;
        private Label totalPeopleLbl;
        private Button saveBtn;
        private Button clearBtn;
        private Label authenticatedUserLbl;
        private Label authenticatedUserTxt;
        private Button logoutBtn;
        private Button listBtn;
    }
}
