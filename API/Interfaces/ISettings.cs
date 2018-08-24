using System;
using System.Collections.Generic;
using System.Text;

namespace API.Interfaces
{
   public interface ISettings
    {
        string ConnectionString { get;  }
        string DataBase { get; }

        void SetConnectionString(string con);
        void SetDataBase(string database);
    }
}
