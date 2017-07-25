using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Initialization_01.Base;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace Test_Initialization_01.Data
{
    public class DataBase
    {
        //Get value from DB
        public string columnValue;

        public void DB_Query_GetValue(string query, string getColumn)
        {
            string dataBase = @"server=server_address;userid=user;password=pass111222";

            MySqlConnection connection = null;
            MySqlDataReader reader = null;

            connection = new MySqlConnection(dataBase);
            connection.Open();

            string stm = query;
            Console.WriteLine(stm);

            MySqlCommand cmd = new MySqlCommand(stm, connection);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    columnValue = reader.GetString(getColumn);
                    Console.WriteLine("Column value: " + columnValue);
                }
            }
            else
            {
                throw new Exception("Record NOT found");
            }

            connection.Close();
        }

        //Verify if row exists in DB table 
        public void DB_Query_VerifyTrue(string query)
        {
            string dataBase = @"server=server_address;userid=user;password=pass111222";

            MySqlConnection connection = null;
            MySqlDataReader reader = null;

            connection = new MySqlConnection(dataBase);
            connection.Open();

            string stm = query;
            Console.WriteLine(stm);

            MySqlCommand cmd = new MySqlCommand(stm, connection);
            reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                throw new Exception("Record NOT found");
            }

            connection.Close();
        }

        //The query
        public void DB_Query(string query)
        {
            string dataBase = @"server=server_address;userid=user;password=pass111222";

            MySqlConnection connection = null;
            MySqlDataReader reader = null;

            connection = new MySqlConnection(dataBase);
            connection.Open();

            string stm = query;
            Console.WriteLine(stm);

            MySqlCommand cmd = new MySqlCommand(stm, connection);
            reader = cmd.ExecuteReader();

            connection.Close();
        }
    }
}