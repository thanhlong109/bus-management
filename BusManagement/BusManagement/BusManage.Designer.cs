namespace BusManagement
{
    partial class BusManage
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
            btnLogout = new Button();
            btnAccountManage = new Button();
            btnDriverManage = new Button();
            btnBusManage = new Button();
            btnUnitManage = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvListBus = new DataGridView();
<<<<<<< HEAD
=======
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label1 = new Label();
            btnRoutesManage = new Button();
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            BusId = new DataGridViewTextBoxColumn();
            RoutesId = new DataGridViewTextBoxColumn();
            NumberPlate = new DataGridViewTextBoxColumn();
            BusType = new DataGridViewTextBoxColumn();
            SeatQuantity = new DataGridViewTextBoxColumn();
            EngineOuput = new DataGridViewTextBoxColumn();
            ManufacturingDate = new DataGridViewTextBoxColumn();
            RegistrationDate = new DataGridViewTextBoxColumn();
            PeriodicMaintenance = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
<<<<<<< HEAD
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label1 = new Label();
            btnRoutesManage = new Button();
            label2 = new Label();
=======
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            ((System.ComponentModel.ISupportInitialize)dgvListBus).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonHighlight;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(37, 651);
=======
            btnLogout.Location = new Point(29, 572);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 60);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
<<<<<<< HEAD
            btnLogout.Click += btnLogout_Click;
=======
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            // 
            // btnAccountManage
            // 
            btnAccountManage.BackColor = SystemColors.ButtonHighlight;
            btnAccountManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btnAccountManage.Location = new Point(37, 560);
=======
            btnAccountManage.Location = new Point(29, 506);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            btnAccountManage.Name = "btnAccountManage";
            btnAccountManage.Size = new Size(191, 60);
            btnAccountManage.TabIndex = 22;
            btnAccountManage.Text = "Quản Lý Nhân Viên";
            btnAccountManage.UseVisualStyleBackColor = false;
<<<<<<< HEAD
            btnAccountManage.Click += btnAccountManage_Click;
=======
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            // 
            // btnDriverManage
            // 
            btnDriverManage.BackColor = SystemColors.ButtonHighlight;
            btnDriverManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btnDriverManage.Location = new Point(37, 476);
            btnDriverManage.Name = "btnDriverManage";
            btnDriverManage.Size = new Size(191, 60);
            btnDriverManage.TabIndex = 21;
            btnDriverManage.Text = "Quản Lý Tài Xế";
            btnDriverManage.UseVisualStyleBackColor = false;
            btnDriverManage.Click += btnDriverManage_Click;
            // 
            // btnBusManage
            // 
            btnBusManage.BackColor = SystemColors.ButtonHighlight;
            btnBusManage.Enabled = false;
            btnBusManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusManage.ForeColor = SystemColors.ActiveCaptionText;
            btnBusManage.Location = new Point(37, 394);
=======
            btnDriverManage.Location = new Point(29, 440);
            btnDriverManage.Name = "btnDriverManage";
            btnDriverManage.Size = new Size(191, 60);
            btnDriverManage.TabIndex = 21;
            btnDriverManage.Text = "Quản lý Tài Xế";
            btnDriverManage.UseVisualStyleBackColor = false;
            // 
            // btnBusManage
            // 
            btnBusManage.BackColor = SystemColors.Info;
            btnBusManage.Enabled = false;
            btnBusManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusManage.ForeColor = SystemColors.ActiveCaptionText;
            btnBusManage.Location = new Point(29, 374);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            btnBusManage.Name = "btnBusManage";
            btnBusManage.Size = new Size(191, 60);
            btnBusManage.TabIndex = 20;
            btnBusManage.Text = "Quản Lý Xe";
            btnBusManage.UseVisualStyleBackColor = false;
            // 
            // btnUnitManage
            // 
            btnUnitManage.BackColor = SystemColors.ButtonHighlight;
            btnUnitManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btnUnitManage.Location = new Point(37, 313);
=======
            btnUnitManage.Location = new Point(29, 308);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            btnUnitManage.Name = "btnUnitManage";
            btnUnitManage.Size = new Size(191, 60);
            btnUnitManage.TabIndex = 19;
            btnUnitManage.Text = "Quản Lý Đơn Vị";
            btnUnitManage.UseVisualStyleBackColor = false;
<<<<<<< HEAD
            btnUnitManage.Click += btnUnitManage_Click;
=======
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Control;
<<<<<<< HEAD
            btnRemove.Location = new Point(1006, 651);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(137, 60);
=======
            btnRemove.Location = new Point(778, 593);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(117, 52);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            btnRemove.TabIndex = 18;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
<<<<<<< HEAD
            btnUpdate.Location = new Point(753, 651);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 60);
=======
            btnUpdate.Location = new Point(558, 593);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 52);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
<<<<<<< HEAD
            btnAdd.Location = new Point(489, 651);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 60);
=======
            btnAdd.Location = new Point(334, 593);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 52);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvListBus
            // 
            dgvListBus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBus.Columns.AddRange(new DataGridViewColumn[] { BusId, RoutesId, NumberPlate, BusType, SeatQuantity, EngineOuput, ManufacturingDate, RegistrationDate, PeriodicMaintenance, IsActive });
<<<<<<< HEAD
            dgvListBus.Location = new Point(269, 230);
            dgvListBus.Name = "dgvListBus";
            dgvListBus.RowHeadersWidth = 51;
            dgvListBus.RowTemplate.Height = 29;
            dgvListBus.Size = new Size(1076, 390);
=======
            dgvListBus.Location = new Point(284, 242);
            dgvListBus.Name = "dgvListBus";
            dgvListBus.RowHeadersWidth = 51;
            dgvListBus.RowTemplate.Height = 29;
            dgvListBus.Size = new Size(918, 324);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            dgvListBus.TabIndex = 15;
            dgvListBus.CellClick += dgvListBus_CellClick;
            dgvListBus.CellDoubleClick += dgvListBus_CellDoubleClick;
            // 
<<<<<<< HEAD
=======
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(284, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 62);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Thông Tin Xe";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 69);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 13;
            label1.Text = "Quản Lý Xe Bus";
            // 
            // btnRoutesManage
            // 
            btnRoutesManage.BackColor = SystemColors.ButtonHighlight;
            btnRoutesManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoutesManage.Location = new Point(29, 242);
            btnRoutesManage.Name = "btnRoutesManage";
            btnRoutesManage.Size = new Size(191, 60);
            btnRoutesManage.TabIndex = 12;
            btnRoutesManage.Text = "Quản Lý Tuyến Xe";
            btnRoutesManage.UseVisualStyleBackColor = false;
            // 
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            // BusId
            // 
            BusId.DataPropertyName = "BusId";
            BusId.HeaderText = "Mã xe";
            BusId.MinimumWidth = 6;
            BusId.Name = "BusId";
            BusId.ReadOnly = true;
            BusId.Width = 125;
            // 
            // RoutesId
            // 
            RoutesId.DataPropertyName = "RoutesId";
            RoutesId.HeaderText = "Tuyến đường";
            RoutesId.MinimumWidth = 6;
            RoutesId.Name = "RoutesId";
            RoutesId.ReadOnly = true;
            RoutesId.Width = 125;
            // 
            // NumberPlate
            // 
            NumberPlate.DataPropertyName = "NumberPlate";
            NumberPlate.HeaderText = "Biển số xe";
            NumberPlate.MinimumWidth = 6;
            NumberPlate.Name = "NumberPlate";
            NumberPlate.ReadOnly = true;
            NumberPlate.Width = 125;
            // 
            // BusType
            // 
            BusType.DataPropertyName = "BusType";
            BusType.HeaderText = "Loại xe";
            BusType.MinimumWidth = 6;
            BusType.Name = "BusType";
            BusType.ReadOnly = true;
            BusType.Width = 125;
            // 
            // SeatQuantity
            // 
            SeatQuantity.DataPropertyName = "SeatQuantity";
            SeatQuantity.HeaderText = "Số ghế";
            SeatQuantity.MinimumWidth = 6;
            SeatQuantity.Name = "SeatQuantity";
            SeatQuantity.ReadOnly = true;
            SeatQuantity.Width = 125;
            // 
            // EngineOuput
            // 
            EngineOuput.DataPropertyName = "EngineOuput";
            EngineOuput.HeaderText = "Công suất";
            EngineOuput.MinimumWidth = 6;
            EngineOuput.Name = "EngineOuput";
            EngineOuput.ReadOnly = true;
            EngineOuput.Width = 125;
            // 
            // ManufacturingDate
            // 
            ManufacturingDate.DataPropertyName = "ManufacturingDate";
            ManufacturingDate.HeaderText = "Ngày sản xuất";
            ManufacturingDate.MinimumWidth = 6;
            ManufacturingDate.Name = "ManufacturingDate";
            ManufacturingDate.ReadOnly = true;
            ManufacturingDate.Width = 125;
            // 
            // RegistrationDate
            // 
            RegistrationDate.DataPropertyName = "RegistrationDate";
            RegistrationDate.HeaderText = "Hạn đăng kiểm xe";
            RegistrationDate.MinimumWidth = 6;
            RegistrationDate.Name = "RegistrationDate";
            RegistrationDate.ReadOnly = true;
            RegistrationDate.Width = 125;
            // 
            // PeriodicMaintenance
            // 
            PeriodicMaintenance.DataPropertyName = "PeriodicMaintenance";
            PeriodicMaintenance.HeaderText = "Ngày bảo dưỡng định kì";
            PeriodicMaintenance.MinimumWidth = 6;
            PeriodicMaintenance.Name = "PeriodicMaintenance";
            PeriodicMaintenance.ReadOnly = true;
            PeriodicMaintenance.Width = 125;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "Trạng thái";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 125;
            // 
<<<<<<< HEAD
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(269, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 62);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Thông Tin Xe";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(644, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 13;
            label1.Text = "Phần Mềm Quản Lý Xe Bus";
            // 
            // btnRoutesManage
            // 
            btnRoutesManage.BackColor = SystemColors.ButtonHighlight;
            btnRoutesManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoutesManage.Location = new Point(37, 230);
            btnRoutesManage.Name = "btnRoutesManage";
            btnRoutesManage.Size = new Size(191, 60);
            btnRoutesManage.TabIndex = 12;
            btnRoutesManage.Text = "Quản Lý Tuyến Xe";
            btnRoutesManage.UseVisualStyleBackColor = false;
            btnRoutesManage.Click += btnRoutesManage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(764, 68);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 25;
            label2.Text = "Quản Lý Xe";
            // 
=======
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            // BusManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(1384, 723);
            Controls.Add(label2);
=======
            ClientSize = new Size(1231, 714);
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            Controls.Add(btnLogout);
            Controls.Add(btnAccountManage);
            Controls.Add(btnDriverManage);
            Controls.Add(btnBusManage);
            Controls.Add(btnUnitManage);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvListBus);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnRoutesManage);
            Name = "BusManage";
            Text = "BusManage";
            ((System.ComponentModel.ISupportInitialize)dgvListBus).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnAccountManage;
        private Button btnDriverManage;
        private Button btnBusManage;
        private Button btnUnitManage;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvListBus;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnRoutesManage;
        private DataGridViewTextBoxColumn BusId;
        private DataGridViewTextBoxColumn RoutesId;
        private DataGridViewTextBoxColumn NumberPlate;
        private DataGridViewTextBoxColumn BusType;
        private DataGridViewTextBoxColumn SeatQuantity;
        private DataGridViewTextBoxColumn EngineOuput;
        private DataGridViewTextBoxColumn ManufacturingDate;
        private DataGridViewTextBoxColumn RegistrationDate;
        private DataGridViewTextBoxColumn PeriodicMaintenance;
        private DataGridViewTextBoxColumn IsActive;
<<<<<<< HEAD
        private Label label2;
=======
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
    }
}