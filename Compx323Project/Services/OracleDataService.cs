using Compx323Project.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Services
{
    public class StoreContext : DbContext
    {
        public StoreContext(string username, string password) : base($"Data Source=localhost;Port=1521;User Id={username};Password={password}") { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    internal class OracleDataService : IDataService
    {
        StoreContext client;

        public void Initialise()
        {
            client = new StoreContext("", "");
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
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
