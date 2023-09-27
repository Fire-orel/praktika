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
    public partial class edit_kurs : Form
    {
        int id {  get; set; }
        public edit_kurs(int id_con)
        {
            InitializeComponent();
            id = id_con;
            SQLiteConnection connection = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            connection.Open();
            string sql = "SELECT prepodavatel.ID_prepodavatel [ID],prepodavatel.Familia||\" \"|| prepodavatel.Name||\" \"||prepodavatel.otchestvo  [name] FROM prepodavatel";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);

            edit_kurs_prepodovatel.DataSource = dt;
            edit_kurs_prepodovatel.DisplayMember = "name";
            edit_kurs_prepodovatel.ValueMember = "ID";

            string sql1 = "SELECT Name, ID_prepodavatel FROM kurs WHERE ID_kurs= "+id;
            SQLiteCommand command1 = new SQLiteCommand( sql1, connection);
            using(SQLiteDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    edit_name_kurs.Text = reader.GetString(0);
                    edit_kurs_prepodovatel.SelectedValue = reader.GetDecimal(1);
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "UPDATE kurs SET Name='" + edit_name_kurs.Text + "',ID_prepodavatel='" + edit_kurs_prepodovatel.SelectedValue.ToString() + "' WHERE ID_kurs=" + id;

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_kurs_Load(object sender, EventArgs e)
        {

        }
    }
}
