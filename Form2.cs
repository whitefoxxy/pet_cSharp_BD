using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_user_program
{
    public partial class Form2 : Form
    {
        int[] prices = new int[5] { 0, 0, 0, 0, 0 };

        private void LoadBD()
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            // запросы
            string sql1 = "SELECT name FROM schema.oprava where count > 0";
            string sql2 = "SELECT name FROM schema.salfetka where count > 0";
            string sql3 = "SELECT name FROM schema.chehol where count > 0";
            string sql4 = "SELECT name FROM schema.oprava";
            string sql5 = "SELECT name FROM schema.oprava";

            // объект для выполнения SQL-запроса
            MySqlCommand command1 = new MySqlCommand(sql1, conn);
            MySqlCommand command2 = new MySqlCommand(sql2, conn);
            MySqlCommand command3 = new MySqlCommand(sql3, conn);

            // объект для чтения ответа сервера
            MySqlDataReader reader = command1.ExecuteReader();
            //очищаем буфер
            oprav.Items.Clear();
            // читаем результат
            while (reader.Read())
                oprav.Items.Add(reader[0].ToString());
            reader.Close(); // закрываем reader

            reader = command2.ExecuteReader();
            salfetka.Items.Clear();
            while (reader.Read())
                salfetka.Items.Add(reader[0].ToString());
            reader.Close();

            reader = command3.ExecuteReader();
            chehol.Items.Clear();
            while (reader.Read())
                chehol.Items.Add(reader[0].ToString());
            reader.Close();

            // закрываем соединение с БД
            conn.Close();

        }

        Form1 f1;
        public Form2(Form1 f)
        {

            InitializeComponent();
            LoadBD();
            f1 = f;
            f.Visible = false;
        }


        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                dioptr2.Visible = true;
            else
                dioptr2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Visible = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Visible = true;
        }

        private void ochk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ochk.Text == "Контактные линзы")
            {
                dioptr1.Enabled = true;
                dioptr2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                oprav.Enabled = false;
                salfetka.Enabled = false;
                chehol.Enabled = false;
                string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql1 = "SELECT dioptr FROM schema.linz where count > 0 and type like \"Контактные%\"";
                MySqlCommand command1 = new MySqlCommand(sql1, conn);
                MySqlDataReader reader = command1.ExecuteReader();
                dioptr1.Items.Clear();
                dioptr2.Items.Clear();
                while (reader.Read())
                {
                    dioptr1.Items.Add(reader[0].ToString());
                    dioptr2.Items.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                if (ochk.Text == "Корректирующие")
                {
                    dioptr1.Enabled = true;
                    dioptr2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox1.Enabled = true;
                    oprav.Enabled = true;
                    salfetka.Enabled = true;
                    chehol.Enabled = true;
                    string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    string sql1 = "SELECT dioptr FROM schema.linz where count > 0 and type like \"Корректир%\"";
                    MySqlCommand command1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader reader = command1.ExecuteReader();
                    dioptr1.Items.Clear();
                    dioptr2.Items.Clear();
                    while (reader.Read())
                    {
                        dioptr1.Items.Add(reader[0].ToString());
                        dioptr2.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                    conn.Close();
                }
                else
                {
                    dioptr1.Enabled = false;
                    dioptr2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox2.Enabled = true;
                    checkBox1.Enabled = true;
                    oprav.Enabled = true;
                    salfetka.Enabled = true;
                    chehol.Enabled = true;
                    string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    string sql1 = "SELECT dioptr FROM schema.linz where count > 0 and type like \"Солнце%\"";
                    MySqlCommand command1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader reader = command1.ExecuteReader();
                    dioptr1.Items.Clear();
                    dioptr2.Items.Clear();
                    while (reader.Read())
                    {
                        dioptr1.Items.Add(reader[0].ToString());
                        dioptr2.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            if (checkBox1.Checked)
                chehol.Enabled = true;
            else
                chehol.Enabled = false;
            if (checkBox2.Checked)
                salfetka.Enabled = true;
            else
                salfetka.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                chehol.Enabled = true;
            else
                chehol.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                salfetka.Enabled = true;
            else
                salfetka.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int ch in prices)
                sum += ch;
            price_text.Text = "Цена: " + sum.ToString();
        }

        private void dioptr1_SelectedValueChanged(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string temp = ochk.Text;
            if (ochk.Text == "Контактные линзы")
                temp = "Контактные";
            string sql1 = "SELECT price FROM schema.linz where dioptr = " + dioptr1.Text + " and type = \"" + temp + "\"";
            sql1 = sql1.Replace(",", ".");
            MySqlCommand command1 = new MySqlCommand(sql1, conn);
            prices[0] = int.Parse(command1.ExecuteScalar().ToString());
            conn.Close();
        }

        private void dioptr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string temp = ochk.Text;
            if (ochk.Text == "Контактные линзы")
                temp = "Контактные";
            string sql1 = "SELECT price FROM schema.linz where dioptr = " + dioptr2.Text + " and type = \"" + temp + "\"";
            sql1 = sql1.Replace(",", ".");
            MySqlCommand command1 = new MySqlCommand(sql1, conn);
            prices[1] = int.Parse(command1.ExecuteScalar().ToString());
            conn.Close();
        }

        private void oprav_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql1 = "SELECT price FROM schema.oprava where name = \"" + oprav.Text + "\"";
            sql1 = sql1.Replace(",", ".");
            MySqlCommand command1 = new MySqlCommand(sql1, conn);
            prices[2] = int.Parse(command1.ExecuteScalar().ToString());
            conn.Close();
        }

        private void chehol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql1 = "SELECT price FROM schema.chehol where name = \"" + chehol.Text + "\"";
            sql1 = sql1.Replace(",", ".");
            MySqlCommand command1 = new MySqlCommand(sql1, conn);
            prices[3] = int.Parse(command1.ExecuteScalar().ToString());
            conn.Close();
        }

        private void salfetka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql1 = "SELECT price FROM schema.salfetka where name = \"" + salfetka.Text + "\"";
            sql1 = sql1.Replace(",", ".");
            MySqlCommand command1 = new MySqlCommand(sql1, conn);
            prices[4] = int.Parse(command1.ExecuteScalar().ToString());
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql_oprav = "SELECT id from schema.oprava where name = \"" + oprav.Text + "\"";
            MySqlCommand command = new MySqlCommand(sql_oprav, conn);
            string id_oprav = command.ExecuteScalar().ToString();
            string id_linz, id_ch, id_salf;
            try
            {
                string sql_ch = "SELECT id from schema.chehol where name = \"" + chehol.Text + "\"";
                command = new MySqlCommand(sql_ch, conn);
                id_ch = command.ExecuteScalar().ToString();
            }
            catch (System.NullReferenceException)
            {
                id_ch = "";
            }

            try
            {
                string sql_salf = "SELECT id from schema.salfetka where name = \"" + salfetka.Text + "\"";
                command = new MySqlCommand(sql_salf, conn);
                id_salf = command.ExecuteScalar().ToString();
            }
            catch (System.NullReferenceException)
            {
                id_salf = "";
            }

            try
            {
                string temp = ochk.Text;
                if (ochk.Text == "Контактные линзы")
                    temp = "Контактные";

                if (dioptr1.Text == "")
                    dioptr1.Text = "0";

                string sql_linz = "SELECT id FROM schema.linz where dioptr = " + dioptr1.Text + " and type = \"" + temp + "\"";
                sql_linz = sql_linz.Replace(",", ".");
                command = new MySqlCommand(sql_linz, conn);
                id_linz = command.ExecuteScalar().ToString();
            }
            catch (System.NullReferenceException)
            {
                id_linz = "";
            }

            int sum = 0;
            foreach (int ch in prices)
                sum += ch;

            string sql_zakaz = "insert into schema.zakaz (id_ch, id_salf, id_oprav, id_linz, price_itog) values (" + id_ch + ", " + id_salf + ", " + id_oprav + ", " + id_linz + ", " + sum.ToString() + ")";
            MySqlCommand command1 = new MySqlCommand(sql_zakaz, conn);
            command1.ExecuteNonQuery();
            conn.Close();


        }
    }
}
