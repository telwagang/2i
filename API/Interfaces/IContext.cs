using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Interfaces
{
    public interface IContext
    {
        List<T> GetCollection<T>() where T: class; 
        
        void Add<T>(T item) where T: class, new();

        void Drop<T>() where T: class, new();

        void Delete<T>(T item) where T: class, new();

        void Update<T>(T item) where T : class, IDataObject;
    }
}
