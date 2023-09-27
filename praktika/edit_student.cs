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
    public partial class edit_student : Form
    {
        int id {  get; set; }
        public edit_student(int id_con)
        {
            id = id_con;
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

            string sql1 = "SELECT Familia,Name,Otchestvo,ID_grup FROM student WHERE ID_student= " + id;
            SQLiteCommand command1 = new SQLiteCommand(sql1, connection);
            using (SQLiteDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    edit_familia_student.Text = reader.GetString(0);
                    edit_name_student.Text = reader.GetString(1);
                    edit_otchestvo_student.Text = reader.GetString(2);
                    grup_box.SelectedValue = reader.GetDecimal(3);
                }
            }

        }

        private void edit_student_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_grup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_grup_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "UPDATE student SET Familia='" + edit_familia_student.Text + "',Name='" + edit_name_student.Text + "',Otchestvo='" + edit_otchestvo_student.Text + "',ID_grup='" + grup_box.SelectedValue.ToString() + "' WHERE ID_student=" + id;

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
