using Compx323Project.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Services
{
    internal class MongoDataService : IDataService
    {
        MongoClient client;
        IMongoDatabase database;

        IMongoCollection<Product> products;

        public void Initialise()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("product_store");
        }

        public List<Product> GetProducts()
        {
            return products.Find(new BsonDocument()).ToList();
        }

        public List<Review> GetReviewsForProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetOwnedProducts()
        {
            throw new NotImplementedException();
        }

        public Publisher GetPublisherForProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertReview(Product reviewProduct)
        {
            throw new NotImplementedException();
        }

        public bool AttemptLogin(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
