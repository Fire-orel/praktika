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
    public partial class edit_kurs_completed : Form
    {
        int id {  get; set; }  
        public edit_kurs_completed(int id_con)
        {
            id= id_con;
            InitializeComponent();
            SQLiteConnection con = new SQLiteConnection("data source=../../../praktika_BD.db");
            con.Open();
            string name_kurs = "SELECT ID_kurs [ID_kurs], Name FROM kurs";
            string name_tovara = "SELECT ID_student [ID],Familia||\" \"||Name||\" \"||Otchestvo[name] FROM student";
            SQLiteCommand cmd = new SQLiteCommand(name_kurs, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            
            name_kurs_cmb.DataSource = dt;
            name_kurs_cmb.DisplayMember = "Name";
            name_kurs_cmb.ValueMember = "ID_kurs";

            SQLiteCommand cmd1 = new SQLiteCommand(name_tovara, con);
            DataTable dt1 = new DataTable();
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(cmd1);
            adapter1.Fill(dt1);

            FIO_cmb.DataSource = dt1;
            FIO_cmb.DisplayMember = "name";
            FIO_cmb.ValueMember = "ID";

            string sql = "SELECT ID,ID_kurs,ID_student,ocenka FROM kurs_completed WHERE ID=" + id;
            SQLiteCommand cmd2 = new SQLiteCommand(sql, con);
            using(SQLiteDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    name_kurs_cmb.SelectedValue = reader.GetDecimal(1);
                    
                    FIO_cmb.SelectedValue= reader.GetDecimal(2);
                    ocenka.Value=reader.GetDecimal(3);
                }
            }
            con.Close();
        }

        private void edit_kurs_completed_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_kurs_completed_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "UPDATE kurs_completed SET ID_kurs='" + name_kurs_cmb.SelectedValue.ToString() + "',ID_student='" + FIO_cmb.SelectedValue.ToString() + "',ocenka='"+ocenka.Value.ToString()+"' WHERE ID=" + id;

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
