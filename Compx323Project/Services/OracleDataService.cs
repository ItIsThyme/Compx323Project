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
        public StoreContext(string username, string password, string address) : base($"Data Source={address}:1521/XE;User Id={username};Password={password}") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("accounts")
                .HasKey(user => user.Username);

            modelBuilder.HasDefaultSchema("C##_NOJUNK");

            base.OnModelCreating(modelBuilder);
        }
    }

    internal class OracleDataService : IDataService
    {
        StoreContext client;

        public string Address { get; set; }

        public void Initialise(string address)
        {
            Address = address;
            client = new StoreContext("C##_nojunk", "Imgoingtogetna1234", Address);
        }

        public List<Product> GetProducts()
        {
            return client.Products.SqlQuery("SELECT * FROM product where id=20", null).ToList();
        }

        public List<Review> GetReviewsForProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsOwnedByUser()
        {
            throw new NotImplementedException();
        }

        public Publisher GetPublisherForProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertReview(Review review, Product reviewProduct)
        {
            throw new NotImplementedException();
        }

        public bool AttemptLogin(string username, string password)
        {
            var user = client.Users.First();

            if (user is null)
                return false;

            return true;
        }
    }
}
