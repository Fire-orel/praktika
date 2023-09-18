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

namespace praktika
{
    public partial class edit_prepodavatel : Form
    {
        int id {  get; set; }
        public edit_prepodavatel(int id_con)
        {
            InitializeComponent();
            id = id_con;
            SQLiteConnection con=new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "SELECT Familia,Name,Otchestvo FROM prepodavatel WHERE ID_prepodavatel=" + id;
            SQLiteCommand cmd = new SQLiteCommand(sql,con);
            using(SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    edit_familia.Text = reader.GetString(0);
                    edit_name.Text = reader.GetString(1);
                    edit_otchestvo.Text = reader.GetString(2);
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "UPDATE prepodavatel SET Familia='" + edit_familia.Text + "',Name='" + edit_name.Text + "',Otchestvo='" + edit_otchestvo.Text + "' WHERE ID_prepodavatel=" + id;

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
