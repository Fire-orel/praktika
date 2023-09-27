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
    public partial class add_grup : Form
    {
        public add_grup()
        {
            InitializeComponent();
        }

        private void exit_btn_grup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_grup_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            con.Open();
            string sql = "INSERT INTO grupa (Name_grup) VALUES ('" + name_grup.Text + "')";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
