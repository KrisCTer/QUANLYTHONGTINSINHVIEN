namespace QUANLYTHONGTINSINHVIEN
{
    partial class Form2
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
            this.Fac = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.addAndF = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // Fac
            // 
            this.Fac.Controls.Add(this.txtTotalProfessor);
            this.Fac.Controls.Add(this.txtFacultyName);
            this.Fac.Controls.Add(this.txtFacultyID);
            this.Fac.Controls.Add(this.label3);
            this.Fac.Controls.Add(this.label2);
            this.Fac.Controls.Add(this.label1);
            this.Fac.Location = new System.Drawing.Point(21, 25);
            this.Fac.Name = "Fac";
            this.Fac.Size = new System.Drawing.Size(320, 206);
            this.Fac.TabIndex = 0;
            this.Fac.TabStop = false;
            this.Fac.Text = "Thông tin khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng số giáo sư";
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(116, 44);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(198, 22);
            this.txtFacultyID.TabIndex = 3;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(116, 94);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(198, 22);
            this.txtFacultyName.TabIndex = 4;
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Location = new System.Drawing.Point(116, 144);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(198, 22);
            this.txtTotalProfessor.TabIndex = 5;
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacultyID,
            this.FacultyName,
            this.TotalProfessor});
            this.dgvFaculty.Location = new System.Drawing.Point(347, 25);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(511, 413);
            this.dgvFaculty.TabIndex = 1;
            // 
            // addAndF
            // 
            this.addAndF.Location = new System.Drawing.Point(30, 280);
            this.addAndF.Name = "addAndF";
            this.addAndF.Size = new System.Drawing.Size(129, 23);
            this.addAndF.TabIndex = 2;
            this.addAndF.Text = "Thêm | Sửa";
            this.addAndF.UseVisualStyleBackColor = true;
            this.addAndF.Click += new System.EventHandler(this.addAndF_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(206, 280);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // FacultyID
            // 
            this.FacultyID.HeaderText = "Mã khoa";
            this.FacultyID.MinimumWidth = 6;
            this.FacultyID.Name = "FacultyID";
            this.FacultyID.ReadOnly = true;
            this.FacultyID.Width = 125;
            // 
            // FacultyName
            // 
            this.FacultyName.HeaderText = "Tên khoa";
            this.FacultyName.MinimumWidth = 6;
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            this.FacultyName.Width = 125;
            // 
            // TotalProfessor
            // 
            this.TotalProfessor.HeaderText = "Tổng số giáo sư";
            this.TotalProfessor.MinimumWidth = 6;
            this.TotalProfessor.Name = "TotalProfessor";
            this.TotalProfessor.ReadOnly = true;
            this.TotalProfessor.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.addAndF);
            this.Controls.Add(this.dgvFaculty);
            this.Controls.Add(this.Fac);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Fac.ResumeLayout(false);
            this.Fac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Fac;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Button addAndF;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProfessor;
    }
}