namespace praktika
{
    partial class add_kurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_kurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kurs_prepodovatel = new System.Windows.Forms.ComboBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название курса";
            // 
            // name_kurs
            // 
            this.name_kurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_kurs.Location = new System.Drawing.Point(129, 12);
            this.name_kurs.Name = "name_kurs";
            this.name_kurs.Size = new System.Drawing.Size(205, 23);
            this.name_kurs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Преподаватель";
            // 
            // kurs_prepodovatel
            // 
            this.kurs_prepodovatel.FormattingEnabled = true;
            this.kurs_prepodovatel.Location = new System.Drawing.Point(130, 42);
            this.kurs_prepodovatel.Name = "kurs_prepodovatel";
            this.kurs_prepodovatel.Size = new System.Drawing.Size(204, 21);
            this.kurs_prepodovatel.TabIndex = 3;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(15, 74);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(92, 25);
            this.save_btn.TabIndex = 15;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(242, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_kurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(346, 111);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.kurs_prepodovatel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_kurs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "add_kurs";
            this.Text = "Добавления курса";
            this.Load += new System.EventHandler(this.add_kurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_kurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kurs_prepodovatel;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button button1;
    }
}