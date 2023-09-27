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
    public partial class edit_grup : Form
    {
        int id {  get; set; }
        public edit_grup(int id_con)
        {
            InitializeComponent();
            id = id_con;
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "SELECT Name_grup FROM grupa WHERE ID_grup=" + id;
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    name_grup.Text = reader.GetString(0);
                    
                }
            }
        }

        private void edit_grup_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_grup_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "UPDATE grupa SET Name_grup='" + name_grup.Text + "' WHERE ID_grup=" + id;

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
