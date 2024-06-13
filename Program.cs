using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace BD_user_program
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            createTable();
        }

        static void createTable()
        {
            string connStr = "server=127.0.0.1;user=root;database=ass;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT name FROM schema.oprava where count = 100";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            string name = command.ExecuteScalar().ToString();
            // выводим ответ в консоль
            Console.WriteLine(name);
            // закрываем соединение с БД
            conn.Close();
        }
    }
}
