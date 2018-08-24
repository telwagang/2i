using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Helpers
{
    internal class _2iSettings : ISettings
    {
        
        public string ConnectionString { get; set; }
        public string DataBase { get; set; }

        public void SetConnectionString(string con)
        {
            ConnectionString = con; 
        }

        public void SetDataBase(string database)
        {
            DataBase = database;  
        }
    }
}
