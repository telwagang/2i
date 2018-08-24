using API.Helpers;
using API.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Controllers
{
    internal class ContextController : IContext
    {
        private readonly IMongoDatabase Provider;
        private readonly ISettings _setting;
        

        public ContextController(ISettings settings)
        {
            _setting = settings;
            Provider = Connect();
            
        }

        private IMongoCollection<T> SettUpReferrenceCollection<T>() where T: class
        {
            var tablename = _2iHelper.GetTableName<T>();

            return Provider.GetCollection<T>(tablename);
        }

        public IMongoDatabase Connect()
        {
           var client = new MongoClient(_setting.ConnectionString);
            var database = client.GetDatabase(_setting.DataBase);

            return database;
        }

        public void Add<T>(T item) where T : class, new()
        {
            
           SettUpReferrenceCollection<T>().InsertOne(item);
               
        }

        public void Delete<T>(T item) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void Drop<T>() where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T item) where T : class, IDataObject
        {
            var query = Builders<T>.Filter.Eq(x => x._id, item._id);
            var update = Builders<T>.Update.Set(x=> x._id, item); 
            SettUpReferrenceCollection<T>().UpdateOne(query, update); 
        }

        public List<T> GetCollection<T>() where T: class
        {
            return SettUpReferrenceCollection<T>().AsQueryable().ToList(); 
        }
    }
}
