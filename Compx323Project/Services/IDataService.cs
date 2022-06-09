using Compx323Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Services
{
    public interface IDataService
    {
        string Address { get; set; }

        void Initialise(string address);
        List<Product> GetProducts();
        List<Product> GetProductsOwnedByUser();
        Publisher GetPublisherForProduct(Product product);
        List<Review> GetReviewsForProduct(Product product);
        void InsertOrder(Order order);
        void InsertReview(Review review, Product reviewProduct);
        bool AttemptLogin(string username, string password);
    }
}
