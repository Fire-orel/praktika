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
    public partial class add_student : Form
    {
        public add_student()
        {
            InitializeComponent();
            SQLiteConnection connection = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            connection.Open();
            string sql = "SELECT ID_grup[ID],Name_grup[name] FROM grupa";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);

            grup_box.DataSource = dt;
            grup_box.DisplayMember = "name";
            grup_box.ValueMember = "ID";
            connection.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_student_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_grup_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "INSERT INTO student (Familia,Name,Otchestvo,ID_grup) VALUES ('" + add_familia_student.Text + "', '" + add_name_student.Text + "','" + add_otchestvo_student.Text + "','" + grup_box.SelectedValue.ToString() + "')";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }

        private void exit_btn_grup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
