namespace praktika
{
    partial class main_screen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_kurs = new System.Windows.Forms.TabControl();
            this.Prepodavatel = new System.Windows.Forms.TabPage();
            this.update_prepodavatel = new System.Windows.Forms.Button();
            this.table_prepodavatel = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete_prepodavatel_btn = new System.Windows.Forms.Button();
            this.edit_prepodavatel_btn = new System.Windows.Forms.Button();
            this.add_prepodavatel_btn = new System.Windows.Forms.Button();
            this.kurs = new System.Windows.Forms.TabPage();
            this.table_data_kurs = new System.Windows.Forms.DataGridView();
            this.update_kurs_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_kurs_btn = new System.Windows.Forms.Button();
            this.edit_kurs_btn = new System.Windows.Forms.Button();
            this.add_kurs_btn = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.TabPage();
            this.grup_filter = new System.Windows.Forms.ComboBox();
            this.update_student = new System.Windows.Forms.Button();
            this.table_student = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_student = new System.Windows.Forms.Button();
            this.edit_student = new System.Windows.Forms.Button();
            this.add_student = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tab_kurs.SuspendLayout();
            this.Prepodavatel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_prepodavatel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.kurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_data_kurs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_student)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_kurs
            // 
            this.tab_kurs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_kurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_kurs.Controls.Add(this.Prepodavatel);
            this.tab_kurs.Controls.Add(this.kurs);
            this.tab_kurs.Controls.Add(this.Student);
            this.tab_kurs.Location = new System.Drawing.Point(2, 1);
            this.tab_kurs.Multiline = true;
            this.tab_kurs.Name = "tab_kurs";
            this.tab_kurs.SelectedIndex = 0;
            this.tab_kurs.Size = new System.Drawing.Size(797, 447);
            this.tab_kurs.TabIndex = 0;
            this.tab_kurs.SelectedIndexChanged += new System.EventHandler(this.table_kurs_SelectedIndexChanged);
            // 
            // Prepodavatel
            // 
            this.Prepodavatel.BackColor = System.Drawing.Color.Silver;
            this.Prepodavatel.Controls.Add(this.update_prepodavatel);
            this.Prepodavatel.Controls.Add(this.table_prepodavatel);
            this.Prepodavatel.Controls.Add(this.groupBox2);
            this.Prepodavatel.Location = new System.Drawing.Point(4, 4);
            this.Prepodavatel.Name = "Prepodavatel";
            this.Prepodavatel.Padding = new System.Windows.Forms.Padding(3);
            this.Prepodavatel.Size = new System.Drawing.Size(789, 421);
            this.Prepodavatel.TabIndex = 1;
            this.Prepodavatel.Text = "Преподаватели";
            // 
            // update_prepodavatel
            // 
            this.update_prepodavatel.Location = new System.Drawing.Point(12, 126);
            this.update_prepodavatel.Name = "update_prepodavatel";
            this.update_prepodavatel.Size = new System.Drawing.Size(92, 23);
            this.update_prepodavatel.TabIndex = 3;
            this.update_prepodavatel.Text = "Обновить";
            this.update_prepodavatel.UseVisualStyleBackColor = true;
            this.update_prepodavatel.Click += new System.EventHandler(this.update_prepodavatel_Click);
            // 
            // table_prepodavatel
            // 
            this.table_prepodavatel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_prepodavatel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_prepodavatel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_prepodavatel.Location = new System.Drawing.Point(116, 3);
            this.table_prepodavatel.Name = "table_prepodavatel";
            this.table_prepodavatel.Size = new System.Drawing.Size(667, 412);
            this.table_prepodavatel.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_prepodavatel_btn);
            this.groupBox2.Controls.Add(this.edit_prepodavatel_btn);
            this.groupBox2.Controls.Add(this.add_prepodavatel_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // delete_prepodavatel_btn
            // 
            this.delete_prepodavatel_btn.Location = new System.Drawing.Point(6, 80);
            this.delete_prepodavatel_btn.Name = "delete_prepodavatel_btn";
            this.delete_prepodavatel_btn.Size = new System.Drawing.Size(92, 23);
            this.delete_prepodavatel_btn.TabIndex = 2;
            this.delete_prepodavatel_btn.Text = "Удалить";
            this.delete_prepodavatel_btn.UseVisualStyleBackColor = true;
            this.delete_prepodavatel_btn.Click += new System.EventHandler(this.delete_prepodavatel_btn_Click);
            // 
            // edit_prepodavatel_btn
            // 
            this.edit_prepodavatel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_prepodavatel_btn.Location = new System.Drawing.Point(6, 51);
            this.edit_prepodavatel_btn.Name = "edit_prepodavatel_btn";
            this.edit_prepodavatel_btn.Size = new System.Drawing.Size(92, 23);
            this.edit_prepodavatel_btn.TabIndex = 1;
            this.edit_prepodavatel_btn.Text = "Изменить";
            this.edit_prepodavatel_btn.UseVisualStyleBackColor = true;
            this.edit_prepodavatel_btn.Click += new System.EventHandler(this.edit_prepodavatel_Click);
            // 
            // add_prepodavatel_btn
            // 
            this.add_prepodavatel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_prepodavatel_btn.Location = new System.Drawing.Point(6, 22);
            this.add_prepodavatel_btn.Name = "add_prepodavatel_btn";
            this.add_prepodavatel_btn.Size = new System.Drawing.Size(92, 23);
            this.add_prepodavatel_btn.TabIndex = 0;
            this.add_prepodavatel_btn.Text = "Добавить";
            this.add_prepodavatel_btn.UseVisualStyleBackColor = true;
            this.add_prepodavatel_btn.Click += new System.EventHandler(this.add_prepodavatel_Click);
            // 
            // kurs
            // 
            this.kurs.BackColor = System.Drawing.Color.Silver;
            this.kurs.Controls.Add(this.table_data_kurs);
            this.kurs.Controls.Add(this.update_kurs_btn);
            this.kurs.Controls.Add(this.groupBox1);
            this.kurs.Location = new System.Drawing.Point(4, 4);
            this.kurs.Name = "kurs";
            this.kurs.Padding = new System.Windows.Forms.Padding(3);
            this.kurs.Size = new System.Drawing.Size(789, 421);
            this.kurs.TabIndex = 0;
            this.kurs.Text = "Курсы";
            // 
            // table_data_kurs
            // 
            this.table_data_kurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_data_kurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_data_kurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_data_kurs.Location = new System.Drawing.Point(115, 3);
            this.table_data_kurs.Name = "table_data_kurs";
            this.table_data_kurs.Size = new System.Drawing.Size(667, 412);
            this.table_data_kurs.TabIndex = 5;
            // 
            // update_kurs_btn
            // 
            this.update_kurs_btn.Location = new System.Drawing.Point(12, 126);
            this.update_kurs_btn.Name = "update_kurs_btn";
            this.update_kurs_btn.Size = new System.Drawing.Size(92, 23);
            this.update_kurs_btn.TabIndex = 4;
            this.update_kurs_btn.Text = "Обновить";
            this.update_kurs_btn.UseVisualStyleBackColor = true;
            this.update_kurs_btn.Click += new System.EventHandler(this.update_kurs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_kurs_btn);
            this.groupBox1.Controls.Add(this.edit_kurs_btn);
            this.groupBox1.Controls.Add(this.add_kurs_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // delete_kurs_btn
            // 
            this.delete_kurs_btn.Location = new System.Drawing.Point(6, 80);
            this.delete_kurs_btn.Name = "delete_kurs_btn";
            this.delete_kurs_btn.Size = new System.Drawing.Size(92, 23);
            this.delete_kurs_btn.TabIndex = 2;
            this.delete_kurs_btn.Text = "Удалить";
            this.delete_kurs_btn.UseVisualStyleBackColor = true;
            // 
            // edit_kurs_btn
            // 
            this.edit_kurs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_kurs_btn.Location = new System.Drawing.Point(6, 51);
            this.edit_kurs_btn.Name = "edit_kurs_btn";
            this.edit_kurs_btn.Size = new System.Drawing.Size(92, 23);
            this.edit_kurs_btn.TabIndex = 1;
            this.edit_kurs_btn.Text = "Изменить";
            this.edit_kurs_btn.UseVisualStyleBackColor = true;
            this.edit_kurs_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_kurs_btn
            // 
            this.add_kurs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_kurs_btn.Location = new System.Drawing.Point(6, 22);
            this.add_kurs_btn.Name = "add_kurs_btn";
            this.add_kurs_btn.Size = new System.Drawing.Size(92, 23);
            this.add_kurs_btn.TabIndex = 0;
            this.add_kurs_btn.Text = "Добавить";
            this.add_kurs_btn.UseVisualStyleBackColor = true;
            this.add_kurs_btn.Click += new System.EventHandler(this.add_kurs_btn_Click);
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.Silver;
            this.Student.Controls.Add(this.grup_filter);
            this.Student.Controls.Add(this.update_student);
            this.Student.Controls.Add(this.table_student);
            this.Student.Controls.Add(this.groupBox3);
            this.Student.Location = new System.Drawing.Point(4, 4);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(789, 421);
            this.Student.TabIndex = 2;
            this.Student.Text = "Студенты";
            // 
            // grup_filter
            // 
            this.grup_filter.DisplayMember = "0";
            this.grup_filter.FormattingEnabled = true;
            this.grup_filter.Items.AddRange(new object[] {
            "Все"});
            this.grup_filter.Location = new System.Drawing.Point(5, 155);
            this.grup_filter.Name = "grup_filter";
            this.grup_filter.Size = new System.Drawing.Size(104, 21);
            this.grup_filter.TabIndex = 6;
            this.grup_filter.Tag = "";
            this.grup_filter.ValueMember = "0";
            this.grup_filter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // update_student
            // 
            this.update_student.Location = new System.Drawing.Point(12, 126);
            this.update_student.Name = "update_student";
            this.update_student.Size = new System.Drawing.Size(92, 23);
            this.update_student.TabIndex = 5;
            this.update_student.Text = "Обновить";
            this.update_student.UseVisualStyleBackColor = true;
            this.update_student.Click += new System.EventHandler(this.update_student_Click);
            // 
            // table_student
            // 
            this.table_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_student.Location = new System.Drawing.Point(115, 3);
            this.table_student.Name = "table_student";
            this.table_student.Size = new System.Drawing.Size(667, 412);
            this.table_student.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delete_student);
            this.groupBox3.Controls.Add(this.edit_student);
            this.groupBox3.Controls.Add(this.add_student);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 114);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // delete_student
            // 
            this.delete_student.Location = new System.Drawing.Point(6, 80);
            this.delete_student.Name = "delete_student";
            this.delete_student.Size = new System.Drawing.Size(92, 23);
            this.delete_student.TabIndex = 2;
            this.delete_student.Text = "Удалить";
            this.delete_student.UseVisualStyleBackColor = true;
            // 
            // edit_student
            // 
            this.edit_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_student.Location = new System.Drawing.Point(6, 51);
            this.edit_student.Name = "edit_student";
            this.edit_student.Size = new System.Drawing.Size(92, 23);
            this.edit_student.TabIndex = 1;
            this.edit_student.Text = "Изменить";
            this.edit_student.UseVisualStyleBackColor = true;
            // 
            // add_student
            // 
            this.add_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_student.Location = new System.Drawing.Point(6, 22);
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(92, 23);
            this.add_student.TabIndex = 0;
            this.add_student.Text = "Добавить";
            this.add_student.UseVisualStyleBackColor = true;
            // 
            // main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_kurs);
            this.Name = "main_screen";
            this.Text = "АРМ Метадиста";
            this.Load += new System.EventHandler(this.main_screen_Load);
            this.tab_kurs.ResumeLayout(false);
            this.Prepodavatel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_prepodavatel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.kurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_data_kurs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Student.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_student)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_kurs;
        private System.Windows.Forms.TabPage kurs;
        private System.Windows.Forms.TabPage Prepodavatel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Student;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button delete_kurs_btn;
        private System.Windows.Forms.Button edit_kurs_btn;
        private System.Windows.Forms.Button add_kurs_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delete_prepodavatel_btn;
        private System.Windows.Forms.Button edit_prepodavatel_btn;
        private System.Windows.Forms.Button add_prepodavatel_btn;
        private System.Windows.Forms.DataGridView table_prepodavatel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete_student;
        private System.Windows.Forms.Button edit_student;
        private System.Windows.Forms.Button add_student;
        private System.Windows.Forms.Button update_prepodavatel;
        private System.Windows.Forms.DataGridView table_data_kurs;
        private System.Windows.Forms.Button update_kurs_btn;
        private System.Windows.Forms.Button update_student;
        private System.Windows.Forms.DataGridView table_student;
        private System.Windows.Forms.ComboBox grup_filter;
    }
}

