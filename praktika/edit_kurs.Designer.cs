namespace praktika
{
    partial class edit_kurs
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
            this.btn_close = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.edit_kurs_prepodovatel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_name_kurs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.Location = new System.Drawing.Point(243, 74);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 25);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Отменить";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(16, 74);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(92, 25);
            this.save_btn.TabIndex = 21;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // edit_kurs_prepodovatel
            // 
            this.edit_kurs_prepodovatel.FormattingEnabled = true;
            this.edit_kurs_prepodovatel.Location = new System.Drawing.Point(131, 42);
            this.edit_kurs_prepodovatel.Name = "edit_kurs_prepodovatel";
            this.edit_kurs_prepodovatel.Size = new System.Drawing.Size(204, 21);
            this.edit_kurs_prepodovatel.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Преподаватель";
            // 
            // edit_name_kurs
            // 
            this.edit_name_kurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_name_kurs.Location = new System.Drawing.Point(130, 12);
            this.edit_name_kurs.Name = "edit_name_kurs";
            this.edit_name_kurs.Size = new System.Drawing.Size(205, 23);
            this.edit_name_kurs.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название курса";
            // 
            // edit_kurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(347, 110);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.edit_kurs_prepodovatel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_name_kurs);
            this.Controls.Add(this.label1);
            this.Name = "edit_kurs";
            this.Text = "edit_kurs";
            this.Load += new System.EventHandler(this.edit_kurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox edit_kurs_prepodovatel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edit_name_kurs;
        private System.Windows.Forms.Label label1;
    }
}