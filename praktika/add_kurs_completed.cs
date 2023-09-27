using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika
{
    public partial class add_kurs_completed : Form
    {
        public add_kurs_completed()

        {
            InitializeComponent();
            SQLiteConnection con = new SQLiteConnection("data source=../../../praktika_BD.db");
            con.Open();
            string name_kurs = "SELECT ID_kurs [ID], Name FROM kurs";
            string name_tovara = "SELECT ID_student [ID],Name||\" \"||Familia||\" \"||Otchestvo[name] FROM student";
            SQLiteCommand cmd = new SQLiteCommand(name_kurs, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            name_kurs_cmb.DataSource = dt;
            name_kurs_cmb.DisplayMember = "name";
            name_kurs_cmb.ValueMember = "ID";

            SQLiteCommand cmd1 = new SQLiteCommand(name_tovara, con);
            DataTable dt1 = new DataTable();
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(cmd1);
            adapter1.Fill(dt1);

            FIO_cmb.DataSource = dt1;
            FIO_cmb.DisplayMember = "name";
            FIO_cmb.ValueMember = "ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void grup_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void edit_otchestvo_student_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void edit_name_student_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_btn_grup_Click(object sender, EventArgs e)
        {

        }

        private void edit_familia_student_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_kurs_completed_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_kurs_completed_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=../../../praktika_BD.db");
            con.Open();
            string sql = "INSERT INTO kurs_completed (ID_kurs,ID_student,ocenka)  VALUES ('" + name_kurs_cmb.SelectedValue.ToString() + "', '" + FIO_cmb.SelectedValue.ToString() + "','" + ocenka.Value.ToString() + "')";


            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
