namespace Повышение_квалификации
{
    partial class CreateUser
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
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label16 = new System.Windows.Forms.Label();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.midleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.coursesDataSet = new Повышение_квалификации.CoursesDataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.userDataTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.UserDataTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userData1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
			this.button1.Location = new System.Drawing.Point(29, 659);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 71);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(80, 35);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(256, 24);
			this.label10.TabIndex = 28;
			this.label10.Text = "Добавление пользователя";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label11.Location = new System.Drawing.Point(25, 87);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 24);
			this.label11.TabIndex = 31;
			this.label11.Text = "Логин ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label12.Location = new System.Drawing.Point(146, 390);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(58, 24);
			this.label12.TabIndex = 44;
			this.label12.Text = "Роли";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(191, 87);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(170, 25);
			this.textBox6.TabIndex = 29;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label13.Location = new System.Drawing.Point(25, 345);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(151, 24);
			this.label13.TabIndex = 43;
			this.label13.Text = "Дата рождения";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(191, 135);
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(170, 25);
			this.textBox7.TabIndex = 30;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(191, 351);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(170, 20);
			this.dateTimePicker2.TabIndex = 42;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label14.Location = new System.Drawing.Point(25, 135);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(82, 24);
			this.label14.TabIndex = 32;
			this.label14.Text = "Пароль";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label15.Location = new System.Drawing.Point(25, 301);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(98, 24);
			this.label15.TabIndex = 41;
			this.label15.Text = "Отчество";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button3.Location = new System.Drawing.Point(65, 539);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(239, 73);
			this.button3.TabIndex = 33;
			this.button3.Text = "Добавить пользователя";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(191, 194);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(170, 25);
			this.textBox8.TabIndex = 40;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.BackColor = System.Drawing.Color.Transparent;
			this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.radioButton3.Location = new System.Drawing.Point(29, 431);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(118, 28);
			this.radioButton3.TabIndex = 34;
			this.radioButton3.Text = "Методист";
			this.radioButton3.UseVisualStyleBackColor = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label16.Location = new System.Drawing.Point(25, 248);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(101, 24);
			this.label16.TabIndex = 39;
			this.label16.Text = "Фамилия";
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.BackColor = System.Drawing.Color.Transparent;
			this.radioButton4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.radioButton4.Location = new System.Drawing.Point(26, 487);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(121, 28);
			this.radioButton4.TabIndex = 35;
			this.radioButton4.Text = "Кадровик";
			this.radioButton4.UseVisualStyleBackColor = false;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label17.Location = new System.Drawing.Point(25, 194);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(51, 24);
			this.label17.TabIndex = 38;
			this.label17.Text = "Имя";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(191, 301);
			this.textBox9.Multiline = true;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(170, 25);
			this.textBox9.TabIndex = 36;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(191, 244);
			this.textBox10.Multiline = true;
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(170, 25);
			this.textBox10.TabIndex = 37;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.BackColor = System.Drawing.Color.Transparent;
			this.radioButton5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.radioButton5.Location = new System.Drawing.Point(176, 431);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(172, 28);
			this.radioButton5.TabIndex = 45;
			this.radioButton5.Text = "Преподаватель";
			this.radioButton5.UseVisualStyleBackColor = false;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.radioButton1.Location = new System.Drawing.Point(175, 487);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(175, 28);
			this.radioButton1.TabIndex = 46;
			this.radioButton1.Text = "Администратор";
			this.radioButton1.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.midleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userData1BindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(369, 86);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(851, 663);
			this.dataGridView1.TabIndex = 47;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Код";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// midleNameDataGridViewTextBoxColumn
			// 
			this.midleNameDataGridViewTextBoxColumn.DataPropertyName = "midleName";
			this.midleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.midleNameDataGridViewTextBoxColumn.Name = "midleNameDataGridViewTextBoxColumn";
			this.midleNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// roleNameDataGridViewTextBoxColumn
			// 
			this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "roleName";
			this.roleNameDataGridViewTextBoxColumn.HeaderText = "Роль";
			this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
			this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userData1BindingSource
			// 
			this.userData1BindingSource.DataMember = "UserData1";
			this.userData1BindingSource.DataSource = this.coursesDataSet;
			// 
			// coursesDataSet
			// 
			this.coursesDataSet.DataSetName = "CoursesDataSet";
			this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(668, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 24);
			this.label1.TabIndex = 48;
			this.label1.Text = "Таблица пользователей";
			// 
			// userDataTableAdapter
			// 
			this.userDataTableAdapter.ClearBeforeFill = true;
			// 
			// CreateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Повышение_квалификации.Properties.Resources.фон;
			this.ClientSize = new System.Drawing.Size(1222, 761);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.radioButton5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button1);
			this.MaximumSize = new System.Drawing.Size(1238, 800);
			this.MinimumSize = new System.Drawing.Size(1238, 800);
			this.Name = "CreateUser";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление пользователя";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
			this.Load += new System.EventHandler(this.CreateUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userData1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource userData1BindingSource;
		private CoursesDataSetTableAdapters.UserDataTableAdapter userDataTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn midleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
	}
}