
namespace DuesManagement
{
    partial class StudentPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.UpgradeBTN = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.TelnotextBox = new System.Windows.Forms.TextBox();
            this.NottextBox = new System.Windows.Forms.TextBox();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.StudentTCtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.StudenPaidInfoBTN = new System.Windows.Forms.Button();
            this.paidInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackBTN = new System.Windows.Forms.Button();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPaymentInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTelnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRegdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(365, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Bilgileri";
            // 
            // StudentInfoDataGridView
            // 
            this.StudentInfoDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentPaymentInfoDataGridViewTextBoxColumn,
            this.studentTelnoDataGridViewTextBoxColumn,
            this.studentRegdayDataGridViewTextBoxColumn,
            this.studentBirthdayDataGridViewTextBoxColumn,
            this.studentNotDataGridViewTextBoxColumn});
            this.StudentInfoDataGridView.DataSource = this.studentInfoBindingSource5;
            this.StudentInfoDataGridView.Location = new System.Drawing.Point(2, 79);
            this.StudentInfoDataGridView.MultiSelect = false;
            this.StudentInfoDataGridView.Name = "StudentInfoDataGridView";
            this.StudentInfoDataGridView.ReadOnly = true;
            this.StudentInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentInfoDataGridView.Size = new System.Drawing.Size(1115, 647);
            this.StudentInfoDataGridView.TabIndex = 1;
            this.StudentInfoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentInfoDataGridView_CellClick);
            // 
            // UpgradeBTN
            // 
            this.UpgradeBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpgradeBTN.Location = new System.Drawing.Point(1259, 490);
            this.UpgradeBTN.Name = "UpgradeBTN";
            this.UpgradeBTN.Size = new System.Drawing.Size(120, 44);
            this.UpgradeBTN.TabIndex = 2;
            this.UpgradeBTN.Text = "Güncelle";
            this.UpgradeBTN.UseVisualStyleBackColor = true;
            this.UpgradeBTN.Click += new System.EventHandler(this.UpgradeBTN_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(1171, 94);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(120, 25);
            this.NametextBox.TabIndex = 3;
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Location = new System.Drawing.Point(1171, 143);
            this.SurnametextBox.Multiline = true;
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(120, 25);
            this.SurnametextBox.TabIndex = 4;
            // 
            // TelnotextBox
            // 
            this.TelnotextBox.Location = new System.Drawing.Point(1171, 241);
            this.TelnotextBox.Multiline = true;
            this.TelnotextBox.Name = "TelnotextBox";
            this.TelnotextBox.Size = new System.Drawing.Size(120, 30);
            this.TelnotextBox.TabIndex = 5;
            // 
            // NottextBox
            // 
            this.NottextBox.Location = new System.Drawing.Point(1171, 434);
            this.NottextBox.Multiline = true;
            this.NottextBox.Name = "NottextBox";
            this.NottextBox.Size = new System.Drawing.Size(120, 30);
            this.NottextBox.TabIndex = 8;
            // 
            // InsertBTN
            // 
            this.InsertBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InsertBTN.Location = new System.Drawing.Point(1123, 490);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(120, 44);
            this.InsertBTN.TabIndex = 9;
            this.InsertBTN.Text = "Ekle";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1171, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1171, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1171, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tel No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1171, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1171, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kayıt Olma Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1171, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Not";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1147, 378);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1147, 321);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Location = new System.Drawing.Point(1168, 18);
            this.StudentIdTextBox.Multiline = true;
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.ReadOnly = true;
            this.StudentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.StudentIdTextBox.TabIndex = 13;
            this.StudentIdTextBox.Visible = false;
            // 
            // StudentTCtextBox
            // 
            this.StudentTCtextBox.Location = new System.Drawing.Point(1171, 192);
            this.StudentTCtextBox.Multiline = true;
            this.StudentTCtextBox.Name = "StudentTCtextBox";
            this.StudentTCtextBox.Size = new System.Drawing.Size(120, 25);
            this.StudentTCtextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1171, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tc Kimlik Numarası";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBTN.Location = new System.Drawing.Point(1396, 490);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(120, 44);
            this.DeleteBTN.TabIndex = 16;
            this.DeleteBTN.Text = "Kaydı Sil";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // StudenPaidInfoBTN
            // 
            this.StudenPaidInfoBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudenPaidInfoBTN.Location = new System.Drawing.Point(1230, 567);
            this.StudenPaidInfoBTN.Name = "StudenPaidInfoBTN";
            this.StudenPaidInfoBTN.Size = new System.Drawing.Size(158, 73);
            this.StudenPaidInfoBTN.TabIndex = 17;
            this.StudenPaidInfoBTN.Text = "Öğrenci Bilgilerini Gör";
            this.StudenPaidInfoBTN.UseVisualStyleBackColor = true;
            this.StudenPaidInfoBTN.Click += new System.EventHandler(this.StudenPaidInfoBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBTN.Location = new System.Drawing.Point(1147, 670);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(336, 75);
            this.BackBTN.TabIndex = 18;
            this.BackBTN.Text = "Geri";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentSurnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentSurnameDataGridViewTextBoxColumn.Width = 110;
            // 
            // studentPaymentInfoDataGridViewTextBoxColumn
            // 
            this.studentPaymentInfoDataGridViewTextBoxColumn.DataPropertyName = "StudentTC";
            this.studentPaymentInfoDataGridViewTextBoxColumn.HeaderText = "Tc Kimlik Numarası";
            this.studentPaymentInfoDataGridViewTextBoxColumn.Name = "studentPaymentInfoDataGridViewTextBoxColumn";
            this.studentPaymentInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentPaymentInfoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentPaymentInfoDataGridViewTextBoxColumn.Width = 127;
            // 
            // studentTelnoDataGridViewTextBoxColumn
            // 
            this.studentTelnoDataGridViewTextBoxColumn.DataPropertyName = "StudentTelno";
            this.studentTelnoDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.studentTelnoDataGridViewTextBoxColumn.Name = "studentTelnoDataGridViewTextBoxColumn";
            this.studentTelnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentTelnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentTelnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentRegdayDataGridViewTextBoxColumn
            // 
            this.studentRegdayDataGridViewTextBoxColumn.DataPropertyName = "StudentRegday";
            this.studentRegdayDataGridViewTextBoxColumn.HeaderText = "Kayıt Olma Tarihi";
            this.studentRegdayDataGridViewTextBoxColumn.Name = "studentRegdayDataGridViewTextBoxColumn";
            this.studentRegdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentRegdayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentRegdayDataGridViewTextBoxColumn.Width = 127;
            // 
            // studentBirthdayDataGridViewTextBoxColumn
            // 
            this.studentBirthdayDataGridViewTextBoxColumn.DataPropertyName = "StudentBirthday";
            this.studentBirthdayDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.studentBirthdayDataGridViewTextBoxColumn.Name = "studentBirthdayDataGridViewTextBoxColumn";
            this.studentBirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentBirthdayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentBirthdayDataGridViewTextBoxColumn.Width = 127;
            // 
            // studentNotDataGridViewTextBoxColumn
            // 
            this.studentNotDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentNotDataGridViewTextBoxColumn.DataPropertyName = "StudentNot";
            this.studentNotDataGridViewTextBoxColumn.HeaderText = "Not";
            this.studentNotDataGridViewTextBoxColumn.Name = "studentNotDataGridViewTextBoxColumn";
            this.studentNotDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNotDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // studentInfoBindingSource5
            // 
            this.studentInfoBindingSource5.DataSource = typeof(DuesManagement.StudentInfo);
            // 
            // studentInfoBindingSource4
            // 
            this.studentInfoBindingSource4.DataSource = typeof(DuesManagement.StudentInfo);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataSource = typeof(DuesManagement.StudentInfo);
            // 
            // studentInfoBindingSource1
            // 
            this.studentInfoBindingSource1.DataSource = typeof(DuesManagement.StudentInfo);
            // 
            // studentInfoBindingSource2
            // 
            this.studentInfoBindingSource2.DataSource = typeof(DuesManagement.StudentInfo);
            // 
            // studentInfoBindingSource3
            // 
            this.studentInfoBindingSource3.DataSource = typeof(DuesManagement.StudentInfo);
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 795);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.StudenPaidInfoBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StudentTCtextBox);
            this.Controls.Add(this.StudentIdTextBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.NottextBox);
            this.Controls.Add(this.TelnotextBox);
            this.Controls.Add(this.SurnametextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.UpgradeBTN);
            this.Controls.Add(this.StudentInfoDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "StudentPanel";
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentInfoDataGridView;
        private System.Windows.Forms.BindingSource paidInfoBindingSource;
        private System.Windows.Forms.BindingSource studentInfoBindingSource1;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenRegdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button UpgradeBTN;
        private System.Windows.Forms.TextBox TelnotextBox;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource studentInfoBindingSource2;
        private System.Windows.Forms.BindingSource studentInfoBindingSource3;
        private System.Windows.Forms.BindingSource studentInfoBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPaymentInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentTelnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRegdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNotDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentInfoBindingSource5;
        private System.Windows.Forms.TextBox StudentTCtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button StudenPaidInfoBTN;
        public System.Windows.Forms.TextBox NametextBox;
        public System.Windows.Forms.TextBox StudentIdTextBox;
        public System.Windows.Forms.TextBox SurnametextBox;
        public System.Windows.Forms.TextBox NottextBox;
        private System.Windows.Forms.Button BackBTN;
    }
}