namespace praktika
{
    partial class edit_grup
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
            this.exit_btn_grup = new System.Windows.Forms.Button();
            this.save_btn_grup = new System.Windows.Forms.Button();
            this.name_grup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_btn_grup
            // 
            this.exit_btn_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn_grup.Location = new System.Drawing.Point(246, 46);
            this.exit_btn_grup.Name = "exit_btn_grup";
            this.exit_btn_grup.Size = new System.Drawing.Size(92, 25);
            this.exit_btn_grup.TabIndex = 22;
            this.exit_btn_grup.Text = "Отменить";
            this.exit_btn_grup.UseVisualStyleBackColor = true;
            this.exit_btn_grup.Click += new System.EventHandler(this.exit_btn_grup_Click);
            // 
            // save_btn_grup
            // 
            this.save_btn_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn_grup.Location = new System.Drawing.Point(8, 46);
            this.save_btn_grup.Name = "save_btn_grup";
            this.save_btn_grup.Size = new System.Drawing.Size(92, 25);
            this.save_btn_grup.TabIndex = 21;
            this.save_btn_grup.Text = "Сохранить";
            this.save_btn_grup.UseVisualStyleBackColor = true;
            this.save_btn_grup.Click += new System.EventHandler(this.save_btn_grup_Click);
            // 
            // name_grup
            // 
            this.name_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_grup.Location = new System.Drawing.Point(133, 12);
            this.name_grup.Name = "name_grup";
            this.name_grup.Size = new System.Drawing.Size(205, 23);
            this.name_grup.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название группы";
            // 
            // edit_grup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(346, 82);
            this.Controls.Add(this.exit_btn_grup);
            this.Controls.Add(this.save_btn_grup);
            this.Controls.Add(this.name_grup);
            this.Controls.Add(this.label1);
            this.Name = "edit_grup";
            this.Text = "Изменения группы";
            this.Load += new System.EventHandler(this.edit_grup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn_grup;
        private System.Windows.Forms.Button save_btn_grup;
        private System.Windows.Forms.TextBox name_grup;
        private System.Windows.Forms.Label label1;
    }
}