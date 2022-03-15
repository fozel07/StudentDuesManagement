
namespace DuesManagement
{
    partial class MonthSelectionPage
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
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.OcakInfoBTN = new System.Windows.Forms.Button();
            this.ŞubatBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MartBTN = new System.Windows.Forms.Button();
            this.NisanBTN = new System.Windows.Forms.Button();
            this.MayısBTN = new System.Windows.Forms.Button();
            this.KasımBTN = new System.Windows.Forms.Button();
            this.HaziranBTN = new System.Windows.Forms.Button();
            this.TemmuzBTN = new System.Windows.Forms.Button();
            this.AğustosBTN = new System.Windows.Forms.Button();
            this.EylülBTN = new System.Windows.Forms.Button();
            this.EkimBTN = new System.Windows.Forms.Button();
            this.AralıkBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // OcakInfoBTN
            // 
            this.OcakInfoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OcakInfoBTN.Location = new System.Drawing.Point(9, 51);
            this.OcakInfoBTN.Name = "OcakInfoBTN";
            this.OcakInfoBTN.Size = new System.Drawing.Size(99, 34);
            this.OcakInfoBTN.TabIndex = 0;
            this.OcakInfoBTN.Text = "Ocak";
            this.OcakInfoBTN.UseVisualStyleBackColor = true;
            this.OcakInfoBTN.Click += new System.EventHandler(this.OcakInfoBTN_Click);
            // 
            // ŞubatBTN
            // 
            this.ŞubatBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ŞubatBTN.Location = new System.Drawing.Point(114, 51);
            this.ŞubatBTN.Name = "ŞubatBTN";
            this.ŞubatBTN.Size = new System.Drawing.Size(99, 34);
            this.ŞubatBTN.TabIndex = 1;
            this.ŞubatBTN.Text = "Şubat";
            this.ŞubatBTN.UseVisualStyleBackColor = true;
            this.ŞubatBTN.Click += new System.EventHandler(this.ŞubatBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.StudentTC});
            this.dataGridView1.DataSource = this.studentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 497);
            this.dataGridView1.TabIndex = 2;
            // 
            // StudentTC
            // 
            this.StudentTC.DataPropertyName = "StudentTC";
            this.StudentTC.HeaderText = "Tc Kimlik Numarası";
            this.StudentTC.Name = "StudentTC";
            this.StudentTC.ReadOnly = true;
            this.StudentTC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StudentTC.Width = 130;
            // 
            // MartBTN
            // 
            this.MartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MartBTN.Location = new System.Drawing.Point(219, 51);
            this.MartBTN.Name = "MartBTN";
            this.MartBTN.Size = new System.Drawing.Size(99, 34);
            this.MartBTN.TabIndex = 3;
            this.MartBTN.Text = "Mart";
            this.MartBTN.UseVisualStyleBackColor = true;
            this.MartBTN.Click += new System.EventHandler(this.MartBTN_Click);
            // 
            // NisanBTN
            // 
            this.NisanBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NisanBTN.Location = new System.Drawing.Point(324, 51);
            this.NisanBTN.Name = "NisanBTN";
            this.NisanBTN.Size = new System.Drawing.Size(99, 34);
            this.NisanBTN.TabIndex = 4;
            this.NisanBTN.Text = "Nisan";
            this.NisanBTN.UseVisualStyleBackColor = true;
            this.NisanBTN.Click += new System.EventHandler(this.NisanBTN_Click);
            // 
            // MayısBTN
            // 
            this.MayısBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MayısBTN.Location = new System.Drawing.Point(429, 51);
            this.MayısBTN.Name = "MayısBTN";
            this.MayısBTN.Size = new System.Drawing.Size(99, 34);
            this.MayısBTN.TabIndex = 4;
            this.MayısBTN.Text = "Mayıs";
            this.MayısBTN.UseVisualStyleBackColor = true;
            this.MayısBTN.Click += new System.EventHandler(this.MayısBTN_Click);
            // 
            // KasımBTN
            // 
            this.KasımBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KasımBTN.Location = new System.Drawing.Point(651, 261);
            this.KasımBTN.Name = "KasımBTN";
            this.KasımBTN.Size = new System.Drawing.Size(99, 34);
            this.KasımBTN.TabIndex = 4;
            this.KasımBTN.Text = "Kasım";
            this.KasımBTN.UseVisualStyleBackColor = true;
            this.KasımBTN.Click += new System.EventHandler(this.KasımBTN_Click);
            // 
            // HaziranBTN
            // 
            this.HaziranBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HaziranBTN.Location = new System.Drawing.Point(534, 51);
            this.HaziranBTN.Name = "HaziranBTN";
            this.HaziranBTN.Size = new System.Drawing.Size(99, 34);
            this.HaziranBTN.TabIndex = 4;
            this.HaziranBTN.Text = "Haziran";
            this.HaziranBTN.UseVisualStyleBackColor = true;
            this.HaziranBTN.Click += new System.EventHandler(this.HaziranBTN_Click);
            // 
            // TemmuzBTN
            // 
            this.TemmuzBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemmuzBTN.Location = new System.Drawing.Point(651, 51);
            this.TemmuzBTN.Name = "TemmuzBTN";
            this.TemmuzBTN.Size = new System.Drawing.Size(99, 34);
            this.TemmuzBTN.TabIndex = 4;
            this.TemmuzBTN.Text = "Temmuz";
            this.TemmuzBTN.UseVisualStyleBackColor = true;
            this.TemmuzBTN.Click += new System.EventHandler(this.TemmuzBTN_Click);
            // 
            // AğustosBTN
            // 
            this.AğustosBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AğustosBTN.Location = new System.Drawing.Point(651, 103);
            this.AğustosBTN.Name = "AğustosBTN";
            this.AğustosBTN.Size = new System.Drawing.Size(99, 34);
            this.AğustosBTN.TabIndex = 4;
            this.AğustosBTN.Text = "Ağustos";
            this.AğustosBTN.UseVisualStyleBackColor = true;
            this.AğustosBTN.Click += new System.EventHandler(this.AğustosBTN_Click);
            // 
            // EylülBTN
            // 
            this.EylülBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EylülBTN.Location = new System.Drawing.Point(651, 155);
            this.EylülBTN.Name = "EylülBTN";
            this.EylülBTN.Size = new System.Drawing.Size(99, 34);
            this.EylülBTN.TabIndex = 4;
            this.EylülBTN.Text = "Eylül";
            this.EylülBTN.UseVisualStyleBackColor = true;
            this.EylülBTN.Click += new System.EventHandler(this.EylülBTN_Click);
            // 
            // EkimBTN
            // 
            this.EkimBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkimBTN.Location = new System.Drawing.Point(651, 208);
            this.EkimBTN.Name = "EkimBTN";
            this.EkimBTN.Size = new System.Drawing.Size(99, 34);
            this.EkimBTN.TabIndex = 4;
            this.EkimBTN.Text = "Ekim";
            this.EkimBTN.UseVisualStyleBackColor = true;
            this.EkimBTN.Click += new System.EventHandler(this.EkimBTN_Click);
            // 
            // AralıkBTN
            // 
            this.AralıkBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AralıkBTN.Location = new System.Drawing.Point(651, 314);
            this.AralıkBTN.Name = "AralıkBTN";
            this.AralıkBTN.Size = new System.Drawing.Size(99, 34);
            this.AralıkBTN.TabIndex = 4;
            this.AralıkBTN.Text = "Aralık";
            this.AralıkBTN.UseVisualStyleBackColor = true;
            this.AralıkBTN.Click += new System.EventHandler(this.AralıkBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBTN.Location = new System.Drawing.Point(651, 380);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(116, 58);
            this.BackBTN.TabIndex = 5;
            this.BackBTN.Text = "Geri";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentSurnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentSurnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataSource = typeof(DuesManagement.StudentInfo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aidatını Vermeyen Öğrenciler";
            // 
            // MonthSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.EkimBTN);
            this.Controls.Add(this.EylülBTN);
            this.Controls.Add(this.AğustosBTN);
            this.Controls.Add(this.TemmuzBTN);
            this.Controls.Add(this.HaziranBTN);
            this.Controls.Add(this.AralıkBTN);
            this.Controls.Add(this.KasımBTN);
            this.Controls.Add(this.MayısBTN);
            this.Controls.Add(this.NisanBTN);
            this.Controls.Add(this.MartBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ŞubatBTN);
            this.Controls.Add(this.OcakInfoBTN);
            this.Name = "MonthSelectionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthSelectionPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Button ŞubatBTN;
        public System.Windows.Forms.Button OcakInfoBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private System.Windows.Forms.Button MartBTN;
        private System.Windows.Forms.Button NisanBTN;
        private System.Windows.Forms.Button MayısBTN;
        private System.Windows.Forms.Button KasımBTN;
        private System.Windows.Forms.Button HaziranBTN;
        private System.Windows.Forms.Button TemmuzBTN;
        private System.Windows.Forms.Button AğustosBTN;
        private System.Windows.Forms.Button EylülBTN;
        private System.Windows.Forms.Button EkimBTN;
        private System.Windows.Forms.Button AralıkBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentTC;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Label label2;
    }
}