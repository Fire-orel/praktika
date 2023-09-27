using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace praktika
{

    public partial class main_screen : Form
    {
        public main_screen()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(table_data_kurs.CurrentRow.Cells[0].Value.ToString());
            edit_kurs windows = new edit_kurs(id);
            DialogResult result = windows.ShowDialog();
            if (result == DialogResult.OK)
            {
                update_kurs_Click(sender, e);
            }
        }

        private void update_prepodavatel_Click(object sender, EventArgs e)
        {
            SQLiteConnection con =new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string query = "SELECT ID_prepodavatel [ID],Familia[Фамилия],Name[Имя],Otchestvo[Отчество] FROM prepodavatel";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt =new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);
            table_prepodavatel.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_student_Click(sender, e);
           
        }

        private void update_student_Click(object sender, EventArgs e)
        {

            if (grup_filter.Text == "Все"){ 
                SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
                con.Open();
                string query = "SELECT student.ID_student [ID],student.Familia[Фамилия],student.Name[Имя],student.Otchestvo[Отчество],grupa.Name_grup[Название группы] FROM student INNER JOIN grupa ON grupa.ID_grup=student.ID_grup";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                adapter.Fill(dt);
                table_student.DataSource = dt;
                con.Close();
                
            }
            else
            {
                string znachenie= grup_filter.Text.ToString();
                
                SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
                con.Open();
                string query = "SELECT student.ID_student [ID],student.Familia[Фамилия],student.Name[Имя],student.Otchestvo[Отчество],grupa.Name_grup[Название группы] FROM student INNER JOIN grupa ON grupa.ID_grup=student.ID_grup WHERE student.ID_grup=(SELECT ID_grup FROM grupa WHERE Name_grup=\""+znachenie+"\")";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                adapter.Fill(dt);
                table_student.DataSource = dt;
                con.Close();
                
            }

        }

        private void table_kurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tab_kurs.SelectedIndex.ToString()) 
            {
                case ("0"):
                    update_prepodavatel_Click(sender, e);
                    break; 
                case ("1"):
                    update_kurs_Click(sender, e);
                    break;
                case ("2"):
                    update_grup_btn_Click(sender, e);
                    break;
                case ("3"):
                    grup_filter.Items.Clear();
                    grup_filter.Items.Add("Все");
                    grup_filter.SelectedIndex = 0;
                    update_student_Click (sender, e);
                    SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
                    con.Open();
                    string query = "SELECT ID_grup, Name_grup FROM grupa";
                    SQLiteCommand command = new SQLiteCommand(query, con);
                    DataTable dt=new DataTable();
                    SQLiteDataReader DR = command.ExecuteReader();

                    while (DR.Read())
                    {
                        grup_filter.Items.Add(DR[1]);

                    }



                    break;
            }
        }

        private void main_screen_Load(object sender, EventArgs e)
        {
            update_prepodavatel_Click(sender, e);
        }

        private void update_kurs_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string query = "SELECT kurs.ID_kurs[ID курса],kurs.Name[Название курса],prepodavatel.Familia||\" \"|| prepodavatel.Name||\" \"||prepodavatel.otchestvo  [ФИО] FROM kurs INNER JOIN prepodavatel on kurs.ID_prepodavatel=prepodavatel.ID_prepodavatel ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);
            table_data_kurs.DataSource = dt;
            con.Close();
        }

        private void add_prepodavatel_Click(object sender, EventArgs e)
        {
            add_prepodavatel windows =new add_prepodavatel();
            DialogResult result = windows.ShowDialog();
            if (result == DialogResult.OK)
            {
                update_prepodavatel_Click(sender, e);
            }
        }

        private void edit_prepodavatel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(table_prepodavatel.CurrentRow.Cells[0].Value.ToString());
            edit_prepodavatel windows = new edit_prepodavatel(id);
            DialogResult result =windows.ShowDialog();
            if (result==DialogResult.OK)
            {
                update_prepodavatel_Click(sender, e);
            }
        }

        private void delete_prepodavatel_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(table_prepodavatel.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM prepodavatel WHERE ID_prepodavatel =" + id;

                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();

                update_prepodavatel_Click(sender, e);
            }
            con.Close();
        }

        private void add_kurs_btn_Click(object sender, EventArgs e)
        {
            add_kurs windows = new add_kurs();
            DialogResult result = windows.ShowDialog();
            if (result == DialogResult.OK)
            {
                update_kurs_Click(sender, e);
            }
        }

        private void delete_kurs_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(table_data_kurs.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM kurs WHERE ID_kurs =" + id;

                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();

                update_kurs_Click(sender, e);
            }
            con.Close();
        }

        private void update_grup_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string query = "SELECT ID_grup [ID группы], Name_grup[Название группы] FROM grupa  ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);
            grupa_table_data.DataSource = dt;
            con.Close();
        }

        private void add_grup_btn_Click(object sender, EventArgs e)
        {
            add_grup windows = new add_grup();
            DialogResult result = windows.ShowDialog();
            if (result == DialogResult.OK)
            {
                update_grup_btn_Click(sender, e);
            }
        }

        private void edit_student_Click(object sender, EventArgs e)
        {
            int id = int.Parse(table_student.CurrentRow.Cells[0].Value.ToString());
            edit_student windows = new edit_student(id);
            DialogResult result = windows.ShowDialog();
            if (result == DialogResult.OK)
            {
                update_student_Click(sender, e);
            }
        }

        private void edit_grup_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grupa_table_data.CurrentRow.Cells[0].Value.ToString());
            edit_grup windows = new edit_grup(id);
            DialogResult result = windows.ShowDialog();
            if (result == DialogResult.OK)
            {
                update_grup_btn_Click(sender, e);
            }
        }

        private void delete_grup_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grupa_table_data.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM prupa WHERE ID_grup =" + id;

                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();

                update_grup_btn_Click(sender, e);
            }
            con.Close();
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            add_student windows = new add_student();
            DialogResult result = windows.ShowDialog();
            if (result == DialogResult.OK)
            {
                update_student_Click(sender, e);
            }
        }

        private void delete_student_Click(object sender, EventArgs e)
        {
            int id = int.Parse(table_student.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM student WHERE ID_student =" + id;

                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();

                update_student_Click(sender, e);
            }
            con.Close();
        }
    }
}
