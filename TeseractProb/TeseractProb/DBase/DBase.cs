using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace TeseractProb.DBase
{
   public class DBase
    {
        public string Error = "";
        private SQLiteConnection connection;
        private string connectionString ="Data Source = " +Directory.GetCurrentDirectory() + @"\DBLight\Tes.db; Cashe = Shared";
            public DBase()
        {
            connection = new SQLiteConnection(connectionString);
            
        }

        public List<string> readDB() 
        {
            Error = "";
            List<string> result = new List<string>();
            string query = "SELECT Text FROM TableMain;";            
            try
            {
                
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();                
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add("" + reader["Text"].ToString());
                    }
                }
            }
            catch (SQLiteException ex) 
            {
                Error = ex.Message;
                connection.Close();
                return result = null;
            }
            connection.Close();
            return result;
        }
      
        // Записать в БД полученные данные
        public void insertTextDb(string Text) 
        {
            Error = "";
            string query = "INSERT INTO TableMain (Text) VALUES ('" + Text + "');";
            try
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SQLiteException ex) 
            {
                Error = ex.Message;
                connection.Close();
            }
        }

    }
}
