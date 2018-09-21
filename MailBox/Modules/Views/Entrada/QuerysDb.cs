using MailBox.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.Modules.Views.Entrada
{
    class QuerysDb
    {
        public DataTable SelectEmails()
        {
            try
            {
                SQLiteConnection conexao = new SQLiteConnection(CreateDb.ConnDataStorage);
                conexao.Open();
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM box_mail", conexao);
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                DataTable emails = new DataTable();
                da.Fill(emails);
                conexao.Close();

                return emails;
            }
            catch { return null; }
        }

        public void ExecuteSqlCommand(string query)
        {
            try
            {
                SQLiteConnection conexao = new SQLiteConnection(CreateDb.ConnDataStorage);
                conexao.Open();
                SQLiteCommand command = new SQLiteCommand(query, conexao);
                command.ExecuteNonQuery();
                conexao.Close();
            }
            catch { }
        }
    }
}
