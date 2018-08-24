using API.Attributes;
using API.Enums;
using API.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Objects
{
    [InfTable("2i_Users")]
   public class _2iUsers: IDataObject
    {
        public object _id { get; set; }
        
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public int Mobile_Number { get; set; }
        public DateTime Birthdate { get; set; }
        public string Occuption { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public DateTime Date { get; set; }
    }
}
