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
            this.grupa = new System.Windows.Forms.TabPage();
            this.update_grup_btn = new System.Windows.Forms.Button();
            this.grupa_table_data = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.delete_grup_btn = new System.Windows.Forms.Button();
            this.edit_grup_btn = new System.Windows.Forms.Button();
            this.add_grup_btn = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.TabPage();
            this.grup_filter = new System.Windows.Forms.ComboBox();
            this.update_student = new System.Windows.Forms.Button();
            this.table_student = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_student = new System.Windows.Forms.Button();
            this.edit_student = new System.Windows.Forms.Button();
            this.add_student = new System.Windows.Forms.Button();
            this.kurc_completed = new System.Windows.Forms.TabPage();
            this.fillter_kurs_completed = new System.Windows.Forms.ComboBox();
            this.fillter_categorie_kurs_completed = new System.Windows.Forms.ComboBox();
            this.update_kurs_completed = new System.Windows.Forms.Button();
            this.kurs_completed_table = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.delete_kurs_completed = new System.Windows.Forms.Button();
            this.edit_kurs_completed = new System.Windows.Forms.Button();
            this.add_kurs_complited_btn = new System.Windows.Forms.Button();
            this.otchet = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.otchet_table = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.check_grup = new System.Windows.Forms.CheckBox();
            this.check_ocenki = new System.Windows.Forms.CheckBox();
            this.check_kurs = new System.Windows.Forms.CheckBox();
            this.grup_check_cmb = new System.Windows.Forms.ComboBox();
            this.kurs_check_cmb = new System.Windows.Forms.ComboBox();
            this.ocenki_check_cmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_kurs.SuspendLayout();
            this.Prepodavatel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_prepodavatel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.kurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_data_kurs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grupa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupa_table_data)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_student)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.kurc_completed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kurs_completed_table)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.otchet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otchet_table)).BeginInit();
            this.groupBox6.SuspendLayout();
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
            this.tab_kurs.Controls.Add(this.grupa);
            this.tab_kurs.Controls.Add(this.Student);
            this.tab_kurs.Controls.Add(this.kurc_completed);
            this.tab_kurs.Controls.Add(this.otchet);
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
            this.Prepodavatel.BackColor = System.Drawing.Color.SteelBlue;
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
            this.kurs.BackColor = System.Drawing.Color.SteelBlue;
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
            this.delete_kurs_btn.Click += new System.EventHandler(this.delete_kurs_btn_Click);
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
            // grupa
            // 
            this.grupa.BackColor = System.Drawing.Color.SteelBlue;
            this.grupa.Controls.Add(this.update_grup_btn);
            this.grupa.Controls.Add(this.grupa_table_data);
            this.grupa.Controls.Add(this.groupBox4);
            this.grupa.Location = new System.Drawing.Point(4, 4);
            this.grupa.Name = "grupa";
            this.grupa.Size = new System.Drawing.Size(789, 421);
            this.grupa.TabIndex = 3;
            this.grupa.Text = "Группы";
            // 
            // update_grup_btn
            // 
            this.update_grup_btn.Location = new System.Drawing.Point(13, 127);
            this.update_grup_btn.Name = "update_grup_btn";
            this.update_grup_btn.Size = new System.Drawing.Size(92, 23);
            this.update_grup_btn.TabIndex = 9;
            this.update_grup_btn.Text = "Обновить";
            this.update_grup_btn.UseVisualStyleBackColor = true;
            this.update_grup_btn.Click += new System.EventHandler(this.update_grup_btn_Click);
            // 
            // grupa_table_data
            // 
            this.grupa_table_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupa_table_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grupa_table_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupa_table_data.Location = new System.Drawing.Point(116, 4);
            this.grupa_table_data.Name = "grupa_table_data";
            this.grupa_table_data.Size = new System.Drawing.Size(667, 412);
            this.grupa_table_data.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox4.Controls.Add(this.delete_grup_btn);
            this.groupBox4.Controls.Add(this.edit_grup_btn);
            this.groupBox4.Controls.Add(this.add_grup_btn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 114);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление";
            // 
            // delete_grup_btn
            // 
            this.delete_grup_btn.Location = new System.Drawing.Point(6, 80);
            this.delete_grup_btn.Name = "delete_grup_btn";
            this.delete_grup_btn.Size = new System.Drawing.Size(92, 23);
            this.delete_grup_btn.TabIndex = 2;
            this.delete_grup_btn.Text = "Удалить";
            this.delete_grup_btn.UseVisualStyleBackColor = true;
            this.delete_grup_btn.Click += new System.EventHandler(this.delete_grup_btn_Click);
            // 
            // edit_grup_btn
            // 
            this.edit_grup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_grup_btn.Location = new System.Drawing.Point(6, 51);
            this.edit_grup_btn.Name = "edit_grup_btn";
            this.edit_grup_btn.Size = new System.Drawing.Size(92, 23);
            this.edit_grup_btn.TabIndex = 1;
            this.edit_grup_btn.Text = "Изменить";
            this.edit_grup_btn.UseVisualStyleBackColor = true;
            this.edit_grup_btn.Click += new System.EventHandler(this.edit_grup_btn_Click);
            // 
            // add_grup_btn
            // 
            this.add_grup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_grup_btn.Location = new System.Drawing.Point(6, 22);
            this.add_grup_btn.Name = "add_grup_btn";
            this.add_grup_btn.Size = new System.Drawing.Size(92, 23);
            this.add_grup_btn.TabIndex = 0;
            this.add_grup_btn.Text = "Добавить";
            this.add_grup_btn.UseVisualStyleBackColor = true;
            this.add_grup_btn.Click += new System.EventHandler(this.add_grup_btn_Click);
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.SteelBlue;
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
            this.delete_student.Click += new System.EventHandler(this.delete_student_Click);
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
            this.edit_student.Click += new System.EventHandler(this.edit_student_Click);
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
            this.add_student.Click += new System.EventHandler(this.add_student_Click);
            // 
            // kurc_completed
            // 
            this.kurc_completed.BackColor = System.Drawing.Color.SteelBlue;
            this.kurc_completed.Controls.Add(this.fillter_kurs_completed);
            this.kurc_completed.Controls.Add(this.fillter_categorie_kurs_completed);
            this.kurc_completed.Controls.Add(this.update_kurs_completed);
            this.kurc_completed.Controls.Add(this.kurs_completed_table);
            this.kurc_completed.Controls.Add(this.groupBox5);
            this.kurc_completed.Location = new System.Drawing.Point(4, 4);
            this.kurc_completed.Name = "kurc_completed";
            this.kurc_completed.Size = new System.Drawing.Size(789, 421);
            this.kurc_completed.TabIndex = 5;
            this.kurc_completed.Text = "Пройденые курсы";
            // 
            // fillter_kurs_completed
            // 
            this.fillter_kurs_completed.FormattingEnabled = true;
            this.fillter_kurs_completed.Location = new System.Drawing.Point(7, 183);
            this.fillter_kurs_completed.Name = "fillter_kurs_completed";
            this.fillter_kurs_completed.Size = new System.Drawing.Size(103, 21);
            this.fillter_kurs_completed.TabIndex = 11;
            this.fillter_kurs_completed.SelectedIndexChanged += new System.EventHandler(this.fillter_kurs_completed_SelectedIndexChanged);
            // 
            // fillter_categorie_kurs_completed
            // 
            this.fillter_categorie_kurs_completed.DisplayMember = "0";
            this.fillter_categorie_kurs_completed.FormattingEnabled = true;
            this.fillter_categorie_kurs_completed.Items.AddRange(new object[] {
            "По курсам",
            "По группам"});
            this.fillter_categorie_kurs_completed.Location = new System.Drawing.Point(7, 156);
            this.fillter_categorie_kurs_completed.Name = "fillter_categorie_kurs_completed";
            this.fillter_categorie_kurs_completed.Size = new System.Drawing.Size(103, 21);
            this.fillter_categorie_kurs_completed.TabIndex = 10;
            this.fillter_categorie_kurs_completed.ValueMember = "0";
            this.fillter_categorie_kurs_completed.SelectedIndexChanged += new System.EventHandler(this.fillter_categorie_kurs_completed_SelectedIndexChanged);
            // 
            // update_kurs_completed
            // 
            this.update_kurs_completed.Location = new System.Drawing.Point(13, 127);
            this.update_kurs_completed.Name = "update_kurs_completed";
            this.update_kurs_completed.Size = new System.Drawing.Size(92, 23);
            this.update_kurs_completed.TabIndex = 9;
            this.update_kurs_completed.Text = "Обновить";
            this.update_kurs_completed.UseVisualStyleBackColor = true;
            this.update_kurs_completed.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kurs_completed_table
            // 
            this.kurs_completed_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kurs_completed_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kurs_completed_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kurs_completed_table.Location = new System.Drawing.Point(116, 4);
            this.kurs_completed_table.Name = "kurs_completed_table";
            this.kurs_completed_table.Size = new System.Drawing.Size(667, 412);
            this.kurs_completed_table.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.delete_kurs_completed);
            this.groupBox5.Controls.Add(this.edit_kurs_completed);
            this.groupBox5.Controls.Add(this.add_kurs_complited_btn);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(7, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(104, 114);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление";
            // 
            // delete_kurs_completed
            // 
            this.delete_kurs_completed.Location = new System.Drawing.Point(6, 80);
            this.delete_kurs_completed.Name = "delete_kurs_completed";
            this.delete_kurs_completed.Size = new System.Drawing.Size(92, 23);
            this.delete_kurs_completed.TabIndex = 2;
            this.delete_kurs_completed.Text = "Удалить";
            this.delete_kurs_completed.UseVisualStyleBackColor = true;
            this.delete_kurs_completed.Click += new System.EventHandler(this.delete_kurs_completed_Click);
            // 
            // edit_kurs_completed
            // 
            this.edit_kurs_completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_kurs_completed.Location = new System.Drawing.Point(6, 51);
            this.edit_kurs_completed.Name = "edit_kurs_completed";
            this.edit_kurs_completed.Size = new System.Drawing.Size(92, 23);
            this.edit_kurs_completed.TabIndex = 1;
            this.edit_kurs_completed.Text = "Изменить";
            this.edit_kurs_completed.UseVisualStyleBackColor = true;
            this.edit_kurs_completed.Click += new System.EventHandler(this.edit_kurs_completed_Click);
            // 
            // add_kurs_complited_btn
            // 
            this.add_kurs_complited_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_kurs_complited_btn.Location = new System.Drawing.Point(6, 22);
            this.add_kurs_complited_btn.Name = "add_kurs_complited_btn";
            this.add_kurs_complited_btn.Size = new System.Drawing.Size(92, 23);
            this.add_kurs_complited_btn.TabIndex = 0;
            this.add_kurs_complited_btn.Text = "Добавить";
            this.add_kurs_complited_btn.UseVisualStyleBackColor = true;
            this.add_kurs_complited_btn.Click += new System.EventHandler(this.add_kurs_complited_btn_Click);
            // 
            // otchet
            // 
            this.otchet.BackColor = System.Drawing.Color.SteelBlue;
            this.otchet.Controls.Add(this.groupBox6);
            this.otchet.Controls.Add(this.otchet_table);
            this.otchet.Location = new System.Drawing.Point(4, 4);
            this.otchet.Name = "otchet";
            this.otchet.Size = new System.Drawing.Size(789, 421);
            this.otchet.TabIndex = 4;
            this.otchet.Text = "Отчёт";
            // 
            // otchet_table
            // 
            this.otchet_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otchet_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otchet_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otchet_table.Location = new System.Drawing.Point(151, 3);
            this.otchet_table.Name = "otchet_table";
            this.otchet_table.Size = new System.Drawing.Size(635, 412);
            this.otchet_table.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.ocenki_check_cmb);
            this.groupBox6.Controls.Add(this.kurs_check_cmb);
            this.groupBox6.Controls.Add(this.grup_check_cmb);
            this.groupBox6.Controls.Add(this.check_kurs);
            this.groupBox6.Controls.Add(this.check_ocenki);
            this.groupBox6.Controls.Add(this.check_grup);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(9, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 408);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Фильтры";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // check_grup
            // 
            this.check_grup.AutoSize = true;
            this.check_grup.Location = new System.Drawing.Point(6, 20);
            this.check_grup.Name = "check_grup";
            this.check_grup.Size = new System.Drawing.Size(83, 19);
            this.check_grup.TabIndex = 0;
            this.check_grup.Text = "По группе";
            this.check_grup.UseVisualStyleBackColor = true;
            this.check_grup.CheckedChanged += new System.EventHandler(this.check_grup_CheckedChanged);
            // 
            // check_ocenki
            // 
            this.check_ocenki.AutoSize = true;
            this.check_ocenki.Location = new System.Drawing.Point(6, 70);
            this.check_ocenki.Name = "check_ocenki";
            this.check_ocenki.Size = new System.Drawing.Size(95, 19);
            this.check_ocenki.TabIndex = 1;
            this.check_ocenki.Text = "По оценкам";
            this.check_ocenki.UseVisualStyleBackColor = true;
            this.check_ocenki.CheckedChanged += new System.EventHandler(this.check_ocenki_CheckedChanged);
            // 
            // check_kurs
            // 
            this.check_kurs.AutoSize = true;
            this.check_kurs.Location = new System.Drawing.Point(6, 45);
            this.check_kurs.Name = "check_kurs";
            this.check_kurs.Size = new System.Drawing.Size(85, 19);
            this.check_kurs.TabIndex = 2;
            this.check_kurs.Text = "По курсам";
            this.check_kurs.UseVisualStyleBackColor = true;
            this.check_kurs.CheckedChanged += new System.EventHandler(this.check_kurs_CheckedChanged);
            // 
            // grup_check_cmb
            // 
            this.grup_check_cmb.FormattingEnabled = true;
            this.grup_check_cmb.Location = new System.Drawing.Point(6, 95);
            this.grup_check_cmb.Name = "grup_check_cmb";
            this.grup_check_cmb.Size = new System.Drawing.Size(124, 23);
            this.grup_check_cmb.TabIndex = 3;
            this.grup_check_cmb.SelectedIndexChanged += new System.EventHandler(this.grup_check_cmb_SelectedIndexChanged);
            // 
            // kurs_check_cmb
            // 
            this.kurs_check_cmb.FormattingEnabled = true;
            this.kurs_check_cmb.Location = new System.Drawing.Point(6, 124);
            this.kurs_check_cmb.Name = "kurs_check_cmb";
            this.kurs_check_cmb.Size = new System.Drawing.Size(124, 23);
            this.kurs_check_cmb.TabIndex = 4;
            // 
            // ocenki_check_cmb
            // 
            this.ocenki_check_cmb.FormattingEnabled = true;
            this.ocenki_check_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ocenki_check_cmb.Location = new System.Drawing.Point(6, 153);
            this.ocenki_check_cmb.Name = "ocenki_check_cmb";
            this.ocenki_check_cmb.Size = new System.Drawing.Size(124, 23);
            this.ocenki_check_cmb.TabIndex = 5;
            this.ocenki_check_cmb.SelectedIndexChanged += new System.EventHandler(this.ocenki_check_cmb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_kurs);
            this.Name = "main_screen";
            this.Text = "АРМ Метадиста";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_screen_FormClosed);
            this.Load += new System.EventHandler(this.main_screen_Load);
            this.tab_kurs.ResumeLayout(false);
            this.Prepodavatel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_prepodavatel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.kurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_data_kurs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grupa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupa_table_data)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.Student.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_student)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.kurc_completed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kurs_completed_table)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.otchet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otchet_table)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.TabPage grupa;
        private System.Windows.Forms.Button update_grup_btn;
        private System.Windows.Forms.DataGridView grupa_table_data;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button delete_grup_btn;
        private System.Windows.Forms.Button edit_grup_btn;
        private System.Windows.Forms.Button add_grup_btn;
        private System.Windows.Forms.TabPage kurc_completed;
        private System.Windows.Forms.TabPage otchet;
        private System.Windows.Forms.Button update_kurs_completed;
        private System.Windows.Forms.DataGridView kurs_completed_table;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button delete_kurs_completed;
        private System.Windows.Forms.Button edit_kurs_completed;
        private System.Windows.Forms.Button add_kurs_complited_btn;
        private System.Windows.Forms.ComboBox fillter_categorie_kurs_completed;
        private System.Windows.Forms.ComboBox fillter_kurs_completed;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox grup_check_cmb;
        private System.Windows.Forms.CheckBox check_kurs;
        private System.Windows.Forms.CheckBox check_ocenki;
        private System.Windows.Forms.CheckBox check_grup;
        private System.Windows.Forms.DataGridView otchet_table;
        private System.Windows.Forms.ComboBox ocenki_check_cmb;
        private System.Windows.Forms.ComboBox kurs_check_cmb;
        private System.Windows.Forms.Button button1;
    }
}

