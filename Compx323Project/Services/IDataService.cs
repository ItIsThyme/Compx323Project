using Compx323Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Services
{
    internal interface IDataService
    {
        void Initialise();
        List<Product> GetProducts();
        List<Product> GetOwnedProducts();
        Publisher GetPublisherForProduct(Product product);
        List<Review> GetReviewsForProduct(Product product);
        void InsertOrder(Order order);
        void InsertReview(Product reviewProduct);
        bool AttemptLogin(string username, string password);
    }
}
