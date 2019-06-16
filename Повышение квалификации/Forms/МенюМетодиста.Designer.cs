namespace Повышение_квалификации
{
    partial class МенюМетодиста
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coursNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.educationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coursesView1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.coursesDataSet1 = new Повышение_квалификации.CoursesDataSet();
			this.coursesDataSet = new Повышение_квалификации.CoursesDataSet();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.coursTypeList = new System.Windows.Forms.ComboBox();
			this.видКурса1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.видКурсаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.educationFormList = new System.Windows.Forms.ComboBox();
			this.формаОбучения1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.формаОбученияBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.курсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.coursesViewTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.CoursesViewTableAdapter();
			this.видКурсаTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.ВидКурсаTableAdapter();
			this.формаОбученияTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.ФормаОбученияTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesView1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.видКурса1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.видКурсаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.формаОбучения1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.формаОбученияBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.курсыBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
			this.button1.Location = new System.Drawing.Point(12, 527);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 71);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new System.Drawing.Point(230, 536);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(263, 48);
			this.button2.TabIndex = 5;
			this.button2.Text = "Добавить курс";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.coursNameDataGridViewTextBoxColumn,
            this.courseVolumeDataGridViewTextBoxColumn,
            this.educationTypeDataGridViewTextBoxColumn,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.coursesView1BindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(380, 70);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(751, 449);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowClickEvent);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Код";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 35;
			// 
			// coursNameDataGridViewTextBoxColumn
			// 
			this.coursNameDataGridViewTextBoxColumn.DataPropertyName = "coursName";
			this.coursNameDataGridViewTextBoxColumn.HeaderText = "Название курса";
			this.coursNameDataGridViewTextBoxColumn.Name = "coursNameDataGridViewTextBoxColumn";
			this.coursNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.coursNameDataGridViewTextBoxColumn.Width = 180;
			// 
			// courseVolumeDataGridViewTextBoxColumn
			// 
			this.courseVolumeDataGridViewTextBoxColumn.DataPropertyName = "courseVolume";
			this.courseVolumeDataGridViewTextBoxColumn.HeaderText = "Объем курса";
			this.courseVolumeDataGridViewTextBoxColumn.Name = "courseVolumeDataGridViewTextBoxColumn";
			this.courseVolumeDataGridViewTextBoxColumn.ReadOnly = true;
			this.courseVolumeDataGridViewTextBoxColumn.Width = 80;
			// 
			// educationTypeDataGridViewTextBoxColumn
			// 
			this.educationTypeDataGridViewTextBoxColumn.DataPropertyName = "educationType";
			this.educationTypeDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
			this.educationTypeDataGridViewTextBoxColumn.Name = "educationTypeDataGridViewTextBoxColumn";
			this.educationTypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.educationTypeDataGridViewTextBoxColumn.Width = 80;
			// 
			// courseTypeNameDataGridViewTextBoxColumn
			// 
			this.courseTypeNameDataGridViewTextBoxColumn.DataPropertyName = "courseTypeName";
			this.courseTypeNameDataGridViewTextBoxColumn.HeaderText = "Вид курса";
			this.courseTypeNameDataGridViewTextBoxColumn.Name = "courseTypeNameDataGridViewTextBoxColumn";
			this.courseTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.courseTypeNameDataGridViewTextBoxColumn.Width = 130;
			// 
			// startDateDataGridViewTextBoxColumn
			// 
			this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
			this.startDateDataGridViewTextBoxColumn.HeaderText = "Дата начала";
			this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
			this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// endDateDataGridViewTextBoxColumn
			// 
			this.endDateDataGridViewTextBoxColumn.DataPropertyName = "endDate";
			this.endDateDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
			this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
			this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// coursesView1BindingSource
			// 
			this.coursesView1BindingSource.DataMember = "CoursesView1";
			this.coursesView1BindingSource.DataSource = this.coursesDataSet1;
			// 
			// coursesDataSet1
			// 
			this.coursesDataSet1.DataSetName = "CoursesDataSet";
			this.coursesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// coursesDataSet
			// 
			this.coursesDataSet.DataSetName = "CoursesDataSet";
			this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(12, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "Название курса";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(12, 228);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "Объем курса";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(204, 94);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(170, 25);
			this.textBox1.TabIndex = 12;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(12, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 24);
			this.label2.TabIndex = 13;
			this.label2.Text = "Вид курса";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(12, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 24);
			this.label4.TabIndex = 14;
			this.label4.Text = "Форма обучения";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(203, 227);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(170, 25);
			this.textBox2.TabIndex = 15;
			//this.textBox2.TextChanged += new System.EventHandler(this.CourseVolumeChanged);
			this.textBox2.Leave += new System.EventHandler(this.CouseTextBoxLeave);
			// 
			// coursTypeList
			// 
			this.coursTypeList.DataSource = this.видКурса1BindingSource;
			this.coursTypeList.DisplayMember = "coursName";
			this.coursTypeList.FormattingEnabled = true;
			this.coursTypeList.Location = new System.Drawing.Point(203, 138);
			this.coursTypeList.MaximumSize = new System.Drawing.Size(170, 0);
			this.coursTypeList.Name = "coursTypeList";
			this.coursTypeList.Size = new System.Drawing.Size(170, 21);
			this.coursTypeList.TabIndex = 17;
			this.coursTypeList.ValueMember = "id";
			// 
			// видКурса1BindingSource
			// 
			this.видКурса1BindingSource.DataMember = "ВидКурса1";
			this.видКурса1BindingSource.DataSource = this.coursesDataSet1;
			// 
			// educationFormList
			// 
			this.educationFormList.DataSource = this.формаОбучения1BindingSource;
			this.educationFormList.DisplayMember = "educationType";
			this.educationFormList.FormattingEnabled = true;
			this.educationFormList.Location = new System.Drawing.Point(204, 182);
			this.educationFormList.Name = "educationFormList";
			this.educationFormList.Size = new System.Drawing.Size(170, 21);
			this.educationFormList.TabIndex = 18;
			this.educationFormList.ValueMember = "id";
			// 
			// формаОбучения1BindingSource
			// 
			this.формаОбучения1BindingSource.DataMember = "ФормаОбучения1";
			this.формаОбучения1BindingSource.DataSource = this.coursesDataSet1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(656, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(159, 24);
			this.label6.TabIndex = 20;
			this.label6.Text = "Таблица курсов";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(135, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 24);
			this.label7.TabIndex = 21;
			this.label7.Text = "Ввод курса";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button3.Location = new System.Drawing.Point(552, 535);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(263, 48);
			this.button3.TabIndex = 22;
			this.button3.Text = "Редактировать курс";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button4.Location = new System.Drawing.Point(868, 535);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(263, 48);
			this.button4.TabIndex = 23;
			this.button4.Text = "Удалить курс";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(239, 272);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
			this.dateTimePicker1.TabIndex = 24;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.StartDateChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(239, 316);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(134, 20);
			this.dateTimePicker2.TabIndex = 25;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.EndDateChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(12, 268);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(186, 24);
			this.label8.TabIndex = 26;
			this.label8.Text = "Дата начала курса";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(12, 312);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(222, 24);
			this.label9.TabIndex = 27;
			this.label9.Text = "Дата окончания курса";
			// 
			// курсыBindingSource
			// 
			this.курсыBindingSource.DataMember = "Курсы";
			this.курсыBindingSource.DataSource = this.coursesDataSet;
			// 
			// coursesViewTableAdapter
			// 
			this.coursesViewTableAdapter.ClearBeforeFill = true;
			// 
			// видКурсаTableAdapter
			// 
			this.видКурсаTableAdapter.ClearBeforeFill = true;
			// 
			// формаОбученияTableAdapter
			// 
			this.формаОбученияTableAdapter.ClearBeforeFill = true;
			// 
			// МенюМетодиста
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Повышение_квалификации.Properties.Resources.фон;
			this.ClientSize = new System.Drawing.Size(1142, 611);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.educationFormList);
			this.Controls.Add(this.coursTypeList);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximumSize = new System.Drawing.Size(1158, 650);
			this.MinimumSize = new System.Drawing.Size(1158, 650);
			this.Name = "МенюМетодиста";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "МенюМетодиста";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
			this.Load += new System.EventHandler(this.МенюМетодиста_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesView1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.видКурса1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.видКурсаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.формаОбучения1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.формаОбученияBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.курсыBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox coursTypeList;
        private System.Windows.Forms.ComboBox educationFormList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
		private CoursesDataSet coursesDataSet;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource видКурсаBindingSource;
		private System.Windows.Forms.BindingSource формаОбученияBindingSource;
		private System.Windows.Forms.BindingSource курсыBindingSource;
		private CoursesDataSet coursesDataSet1;
		private System.Windows.Forms.BindingSource coursesView1BindingSource;
		private CoursesDataSetTableAdapters.CoursesViewTableAdapter coursesViewTableAdapter;
		private System.Windows.Forms.BindingSource видКурса1BindingSource;
		private CoursesDataSetTableAdapters.ВидКурсаTableAdapter видКурсаTableAdapter;
		private System.Windows.Forms.BindingSource формаОбучения1BindingSource;
		private CoursesDataSetTableAdapters.ФормаОбученияTableAdapter формаОбученияTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn coursNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseVolumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn educationTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
	}
}