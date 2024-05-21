namespace ReservationWF.Activities.Reservation
{
    partial class ReservationList
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
            reservationListTitle = new Label();
            reservationListDgv = new DataGridView();
            detailsBtn = new Button();
            deleteBtn = new Button();
            createBtn = new Button();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)reservationListDgv).BeginInit();
            SuspendLayout();
            // 
            // reservationListTitle
            // 
            reservationListTitle.AutoSize = true;
            reservationListTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            reservationListTitle.Location = new Point(12, 9);
            reservationListTitle.Name = "reservationListTitle";
            reservationListTitle.Size = new Size(177, 30);
            reservationListTitle.TabIndex = 0;
            reservationListTitle.Text = "Reservation List";
            // 
            // reservationListDgv
            // 
            reservationListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationListDgv.Location = new Point(12, 42);
            reservationListDgv.Name = "reservationListDgv";
            reservationListDgv.Size = new Size(695, 396);
            reservationListDgv.TabIndex = 1;
            // 
            // detailsBtn
            // 
            detailsBtn.Location = new Point(713, 42);
            detailsBtn.Name = "detailsBtn";
            detailsBtn.Size = new Size(75, 23);
            detailsBtn.TabIndex = 2;
            detailsBtn.Text = "Details";
            detailsBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(713, 71);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(713, 100);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(75, 23);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += onCreateBtnClick;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(713, 415);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(75, 23);
            logoutBtn.TabIndex = 5;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += onLogoutBtnClick;
            // 
            // ReservationList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutBtn);
            Controls.Add(createBtn);
            Controls.Add(deleteBtn);
            Controls.Add(detailsBtn);
            Controls.Add(reservationListDgv);
            Controls.Add(reservationListTitle);
            Name = "ReservationList";
            Text = "ReservationList";
            ((System.ComponentModel.ISupportInitialize)reservationListDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label reservationListTitle;
        private DataGridView reservationListDgv;
        private Button detailsBtn;
        private Button deleteBtn;
        private Button createBtn;
        private Button logoutBtn;
    }
}