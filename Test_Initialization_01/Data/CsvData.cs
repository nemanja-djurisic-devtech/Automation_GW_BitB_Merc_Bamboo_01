﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Test_Initialization_01.Base;

namespace Test_Initialization_01.Data
{
    public class CsvData
    {
        // - Environments - //

        public Dictionary<string, string> envUrl = new Dictionary<string, string>();
        public Dictionary<string, string> envUserName = new Dictionary<string, string>();
        public Dictionary<string, string> envPassword = new Dictionary<string, string>();
        public Dictionary<string, string> envFirstName = new Dictionary<string, string>();
        public Dictionary<string, string> envLastName = new Dictionary<string, string>();
        public Dictionary<string, string> envAddress = new Dictionary<string, string>();
        public Dictionary<string, string> envCity = new Dictionary<string, string>();
        public Dictionary<string, string> envAccountNumber = new Dictionary<string, string>();

        public void GetEnvironmentData()
        {
            //StreamReader streamReader = new StreamReader(@"D:\\Automated_Tests\\Test_01\\Automation_GW_BitB_Merc_Bamboo_01\\Test_Initialization_01\\Data\\Environments.csv");
            StreamReader streamReader = new StreamReader(@"Test_Initialization_01\\Data\\Environments.csv");


            while (streamReader.Peek() >= 0)
            {
                string l = streamReader.ReadLine();
                string[] cols = l.Split(',');

                envUrl.Add(cols[0], cols[1]);
                envUserName.Add(cols[0], cols[2]);
                envPassword.Add(cols[0], cols[3]);
                envFirstName.Add(cols[0], cols[4]);
                envLastName.Add(cols[0], cols[5]);
                envCity.Add(cols[0], cols[6]);
                envAccountNumber.Add(cols[0], cols[7]);
            }
        }
    }
}