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
    public partial class add_kurs : Form
    {
        public add_kurs()
        {
            InitializeComponent();
            SQLiteConnection connection = new SQLiteConnection(@"data source=../../../praktika_BD.db");
            connection.Open();
            string sql = "SELECT prepodavatel.ID_prepodavatel [ID],prepodavatel.Familia||\" \"|| prepodavatel.Name||\" \"||prepodavatel.otchestvo  [name] FROM prepodavatel";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            DataTable dt =new DataTable();
            SQLiteDataAdapter adapter=new SQLiteDataAdapter(command);
            adapter.Fill(dt);

            kurs_prepodovatel.DataSource = dt;
            kurs_prepodovatel.DisplayMember = "name";
            kurs_prepodovatel.ValueMember = "ID";

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
