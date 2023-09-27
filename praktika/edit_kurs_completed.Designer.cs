namespace praktika
{
    partial class edit_kurs_completed
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
            this.ocenka = new System.Windows.Forms.NumericUpDown();
            this.name_kurs_cmb = new System.Windows.Forms.ComboBox();
            this.FIO_cmb = new System.Windows.Forms.ComboBox();
            this.exit_btn_grup = new System.Windows.Forms.Button();
            this.save_btn_kurs_completed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ocenka)).BeginInit();
            this.SuspendLayout();
            // 
            // ocenka
            // 
            this.ocenka.Location = new System.Drawing.Point(131, 73);
            this.ocenka.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ocenka.Name = "ocenka";
            this.ocenka.Size = new System.Drawing.Size(178, 20);
            this.ocenka.TabIndex = 55;
            // 
            // name_kurs_cmb
            // 
            this.name_kurs_cmb.FormattingEnabled = true;
            this.name_kurs_cmb.Location = new System.Drawing.Point(131, 8);
            this.name_kurs_cmb.Name = "name_kurs_cmb";
            this.name_kurs_cmb.Size = new System.Drawing.Size(178, 21);
            this.name_kurs_cmb.TabIndex = 54;
            // 
            // FIO_cmb
            // 
            this.FIO_cmb.FormattingEnabled = true;
            this.FIO_cmb.Location = new System.Drawing.Point(131, 40);
            this.FIO_cmb.Name = "FIO_cmb";
            this.FIO_cmb.Size = new System.Drawing.Size(178, 21);
            this.FIO_cmb.TabIndex = 53;
            // 
            // exit_btn_grup
            // 
            this.exit_btn_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn_grup.Location = new System.Drawing.Point(193, 99);
            this.exit_btn_grup.Name = "exit_btn_grup";
            this.exit_btn_grup.Size = new System.Drawing.Size(92, 25);
            this.exit_btn_grup.TabIndex = 52;
            this.exit_btn_grup.Text = "Отменить";
            this.exit_btn_grup.UseVisualStyleBackColor = true;
            // 
            // save_btn_kurs_completed
            // 
            this.save_btn_kurs_completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn_kurs_completed.Location = new System.Drawing.Point(20, 99);
            this.save_btn_kurs_completed.Name = "save_btn_kurs_completed";
            this.save_btn_kurs_completed.Size = new System.Drawing.Size(92, 25);
            this.save_btn_kurs_completed.TabIndex = 51;
            this.save_btn_kurs_completed.Text = "Сохранить";
            this.save_btn_kurs_completed.UseVisualStyleBackColor = true;
            this.save_btn_kurs_completed.Click += new System.EventHandler(this.save_btn_kurs_completed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Оценка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "ФИО студента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Название курса";
            // 
            // edit_kurs_completed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(325, 135);
            this.Controls.Add(this.ocenka);
            this.Controls.Add(this.name_kurs_cmb);
            this.Controls.Add(this.FIO_cmb);
            this.Controls.Add(this.exit_btn_grup);
            this.Controls.Add(this.save_btn_kurs_completed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "edit_kurs_completed";
            this.Text = "edit_kurs_completed";
            this.Load += new System.EventHandler(this.edit_kurs_completed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ocenka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ocenka;
        private System.Windows.Forms.ComboBox name_kurs_cmb;
        private System.Windows.Forms.ComboBox FIO_cmb;
        private System.Windows.Forms.Button exit_btn_grup;
        private System.Windows.Forms.Button save_btn_kurs_completed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}