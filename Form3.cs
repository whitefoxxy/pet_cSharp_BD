using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_user_program
{
    public partial class Form3 : Form
    {
        Form1 f1; 

        public Form3(Form1 f)
        {
            InitializeComponent();
            f1 = f;
            f.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                date1.Enabled = false;
                date2.Enabled = false;
            } else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                date1.Enabled = true;
                date2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                date1.Enabled = false;
                date2.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                date1.Enabled = true;
                date2.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Visible = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Visible = true;
        }

        private void send_Click(object sender, EventArgs e)
        {
            view.Columns.Clear();
            view.Columns.Add("id_zakaz", "id_zakaz");
            view.Columns.Add("date", "date");
            view.Columns.Add("price", "price");

            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = "select id_zakaz, date, (select price_itog from schema.zakaz where zakaz.id = id_zakaz) as price from schema.list_zakaz";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                view.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()); 
            }
            reader.Close();
            conn.Close();
        }
    }
}
