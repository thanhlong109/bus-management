namespace BusManagement
{
    partial class Management
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnManageBusRoute = new Button();
            btnManageTransUnit = new Button();
            btnManageBus = new Button();
            btnManageDriver = new Button();
            btnManageAccount = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 46);
            label1.TabIndex = 0;
            label1.Text = "Bus Management";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(191, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(709, 317);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 81);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(279, 391);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(93, 36);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(401, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(526, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 36);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnManageBusRoute
            // 
            btnManageBusRoute.Location = new Point(12, 36);
            btnManageBusRoute.Name = "btnManageBusRoute";
            btnManageBusRoute.Size = new Size(149, 53);
            btnManageBusRoute.TabIndex = 6;
            btnManageBusRoute.Text = "Manage Bus Route ";
            btnManageBusRoute.UseVisualStyleBackColor = true;
            // 
            // btnManageTransUnit
            // 
            btnManageTransUnit.Location = new Point(12, 104);
            btnManageTransUnit.Name = "btnManageTransUnit";
            btnManageTransUnit.Size = new Size(149, 61);
            btnManageTransUnit.TabIndex = 7;
            btnManageTransUnit.Text = "Manage Transport Unit ";
            btnManageTransUnit.UseVisualStyleBackColor = true;
            // 
            // btnManageBus
            // 
            btnManageBus.Location = new Point(12, 187);
            btnManageBus.Name = "btnManageBus";
            btnManageBus.Size = new Size(149, 50);
            btnManageBus.TabIndex = 8;
            btnManageBus.Text = "Manage Bus";
            btnManageBus.UseVisualStyleBackColor = true;
            // 
            // btnManageDriver
            // 
            btnManageDriver.Location = new Point(12, 255);
            btnManageDriver.Name = "btnManageDriver";
            btnManageDriver.Size = new Size(149, 52);
            btnManageDriver.TabIndex = 9;
            btnManageDriver.Text = "Manage Driver";
            btnManageDriver.UseVisualStyleBackColor = true;
            // 
            // btnManageAccount
            // 
            btnManageAccount.Location = new Point(12, 325);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.Size = new Size(149, 50);
            btnManageAccount.TabIndex = 10;
            btnManageAccount.Text = "Manage Account";
            btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 391);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(149, 36);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnManageAccount);
            Controls.Add(btnManageDriver);
            Controls.Add(btnManageBus);
            Controls.Add(btnManageTransUnit);
            Controls.Add(btnManageBusRoute);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnManageBusRoute;
        private Button btnManageTransUnit;
        private Button btnManageBus;
        private Button btnManageDriver;
        private Button btnManageAccount;
        private Button btnLogout;
    }
}