namespace BusManagement
{
    partial class TransportUnitManagement
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
            dgvListTransportUnit = new DataGridView();
            button1 = new Button();
            btnQuanLyDonVi = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListTransportUnit).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListTransportUnit
            // 
            dgvListTransportUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTransportUnit.Location = new Point(220, 115);
            dgvListTransportUnit.Name = "dgvListTransportUnit";
            dgvListTransportUnit.RowHeadersWidth = 51;
            dgvListTransportUnit.RowTemplate.Height = 29;
            dgvListTransportUnit.Size = new Size(912, 393);
            dgvListTransportUnit.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(19, 56);
            button1.Name = "button1";
            button1.Size = new Size(139, 73);
            button1.TabIndex = 1;
            button1.Text = "Quản Lý Tuyến Xe";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyDonVi
            // 
            btnQuanLyDonVi.Location = new Point(19, 151);
            btnQuanLyDonVi.Name = "btnQuanLyDonVi";
            btnQuanLyDonVi.Size = new Size(139, 66);
            btnQuanLyDonVi.TabIndex = 2;
            btnQuanLyDonVi.Text = "Quản Lý Đơn Vị";
            btnQuanLyDonVi.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(19, 239);
            button3.Name = "button3";
            button3.Size = new Size(139, 54);
            button3.TabIndex = 3;
            button3.Text = "Quản Lý Xe";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(19, 318);
            button4.Name = "button4";
            button4.Size = new Size(139, 55);
            button4.TabIndex = 4;
            button4.Text = "Quản Lý Tài Xế";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(19, 394);
            button5.Name = "button5";
            button5.Size = new Size(139, 52);
            button5.TabIndex = 5;
            button5.Text = "Quản Lý Nhân Viên";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(19, 479);
            button6.Name = "button6";
            button6.Size = new Size(139, 45);
            button6.TabIndex = 6;
            button6.Text = "Đăng Xuất";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(314, 528);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 41);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(519, 528);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 41);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(734, 528);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 41);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 10;
            label1.Text = "Phần Mềm Quản Lý Xe Bus";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(258, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 53);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Thông Tin Đơn Vị Vận Chuyển";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 0;
            // 
            // TransportUnitManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 587);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnQuanLyDonVi);
            Controls.Add(button1);
            Controls.Add(dgvListTransportUnit);
            Name = "TransportUnitManagement";
            Text = "TransportUnitManagement";
            ((System.ComponentModel.ISupportInitialize)dgvListTransportUnit).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListTransportUnit;
        private Button button1;
        private Button btnQuanLyDonVi;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}