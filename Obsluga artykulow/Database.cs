using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Obsluga_artykulow
{
    class Database
    {
        SQLiteConnection connection;
        SQLiteCommand command;
        SQLiteDataReader reader;

        public void CreateDataBase()
        {
            if (!File.Exists("Formularz.sqlite"))
            {
                SQLiteConnection.CreateFile("Formularz.sqlite");

                string SQL = @"CREATE TABLE formularze(
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nazwa TEXT NOT NULL,
                    Kategoria TEXT NOT NULL,
                    Data_utworzenia DATE NOT NULL,
                    Data_modyfikacji DATE NOT NULL,
                    Tresc TEXT NOT NULL
                )";
                connection = new SQLiteConnection("Data Source=Formularz.sqlite;Version=3;");
                connection.Open();
                command = new SQLiteCommand(SQL, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                connection = new SQLiteConnection("Data Source=Formularz.sqlite;Version=3;");
        }
        public void AddData(string name, string category, string creationDate, string modificationDate, string text)
        {
            command = new SQLiteCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "INSERT INTO formularze (Nazwa,Kategoria,Data_utworzenia,Data_modyfikacji, Tresc) VALUES ('" + name + "','" + category + "','" + creationDate + "','" + modificationDate + "','" + text +"');";
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void GetName()
        {
            command = new SQLiteCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT Nazwa FROM formularze";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<string> ID = new List<string>();
        public List<string> Name = new List<string>();
        public void GetDataToDisplay()
        {
            command = new SQLiteCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM formularze";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ID.Add(reader[0].ToString());
                Name.Add(reader[1].ToString());
            }

            connection.Close();

        }
        


    }
}
