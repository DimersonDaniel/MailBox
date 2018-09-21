using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBox.DataBase
{
    class CreateDb
    {
        public static string DbDataStorage = "DataStorage";
        public static string ConnDataStorage = "Data Source=DataStorage";
        public void execute()
        {
            try
            {
                AppCreateDB();
            }
            catch { }

        }
        private async void AppCreateDB()
        {
            if (!File.Exists(DbDataStorage))
            {
                SQLiteConnection.CreateFile(DbDataStorage);
                await AppCreateTable();
            }
        }
        private async Task<bool> AppCreateTable()
        {

            string[] tables = new string[]
            {
                 "CREATE TABLE login (id INTEGER PRIMARY KEY AUTOINCREMENT, email VARCHAR(255) UNIQUE, password VARCHAR(255))",
                 "CREATE INDEX login_indexs ON login(email)",
                 "CREATE TABLE box_mail (id INTEGER PRIMARY KEY AUTOINCREMENT, dateId VARCHAR(255) UNIQUE, dominio VARCHAR(255) UNIQUE, mail_from VARCHAR(255), subject VARCHAR(255), body TEXT, tipo VARCHAR(50), status INTEGER)",
                 "CREATE INDEX box_mail_indexs ON box_mail(dominio, dateId, tipo, status)"
            };

            SQLiteConnection conexao = new SQLiteConnection(ConnDataStorage);
            conexao.Open();

            try
            {
                for (int i = 0; i < tables.Count(); i++)
                {
                    SQLiteCommand command = new SQLiteCommand(tables[i], conexao);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            conexao.Close();
            return true;
        }
        public void ExecuteSqlCommand(string query)
        {
            try
            {
                SQLiteConnection conexao = new SQLiteConnection(ConnDataStorage);
                conexao.Open();
                SQLiteCommand command = new SQLiteCommand(query, conexao);
                command.ExecuteNonQuery();
                conexao.Close();
            }
            catch { }
        }
    }
}
