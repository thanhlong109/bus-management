namespace BusManagement
{
    partial class UpdateAccount
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
            cbbRole = new ComboBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            txtPhoneNumber = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            dtpDob = new DateTimePicker();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtAccountID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(564, 262);
            cbbRole.Margin = new Padding(3, 2, 3, 2);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(232, 23);
            cbbRole.TabIndex = 62;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(481, 359);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 41);
            btnUpdate.TabIndex = 60;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(174, 359);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 41);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "Trở Lại";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(564, 216);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(232, 23);
            txtPhoneNumber.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(420, 260);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 57;
            label8.Text = "Chức Vụ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(420, 214);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 56;
            label6.Text = "Số Điện Thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(564, 168);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(420, 168);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 54;
            label5.Text = "Địa Chỉ Email";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(596, 119);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(200, 23);
            dtpDob.TabIndex = 53;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(160, 258);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(232, 23);
            txtFullName.TabIndex = 52;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 216);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 23);
            txtPassword.TabIndex = 51;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(160, 170);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(232, 23);
            txtUserName.TabIndex = 50;
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(160, 122);
            txtAccountID.Margin = new Padding(3, 2, 3, 2);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(232, 23);
            txtAccountID.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(420, 120);
            label4.Name = "label4";
            label4.Size = new Size(170, 21);
            label4.TabIndex = 48;
            label4.Text = "Ngày Tháng Năm Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 260);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 47;
            label3.Text = "Họ và Tên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(36, 214);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 46;
            label7.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 170);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 45;
            label2.Text = "Tên Tài Khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 120);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 44;
            label1.Text = "ID Nhân Viên";
            // 
            // UpdateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(cbbRole);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(dtpDob);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtAccountID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateAccount";
            Text = "UpdateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbRole;
        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtPhoneNumber;
        private Label label8;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private DateTimePicker dtpDob;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtAccountID;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label2;
        private Label label1;
    }
}