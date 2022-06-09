using Compx323Project.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Services
{
    internal class MongoDataService : IDataService
    {
        public string Address { get; set; }

        MongoClient client;
        IMongoDatabase database;

        IMongoCollection<Publisher> publisherCollection;
        IMongoCollection<MongoUser> usersCollection;
        IMongoCollection<MongoReview> reviewCollection;
        MongoUser activeUser;

        public void Initialise(string address)
        {
            MapClasses();

            Address = address;
            client = new MongoClient($"mongodb://{Address}:27017");
            database = client.GetDatabase("product_store");
            publisherCollection = database.GetCollection<Publisher>("publishers");
            usersCollection = database.GetCollection<MongoUser>("accounts");
            reviewCollection = database.GetCollection<MongoReview>("reviews");
        }

        void MapClasses()
        {
            BsonClassMap.RegisterClassMap<User>(map =>
            {
                map.MapMember(x => x.Username).SetElementName("username");
                map.MapMember(x => x.DateOfBirth).SetElementName("date_of_birth").SetSerializer(new CustomDateTimeSerializer(false));
                map.MapMember(x => x.Email).SetElementName("email");
                map.MapMember(x => x.DisplayName).SetElementName("display_name");
                map.MapMember(x => x.Password).SetElementName("password");
                
            });

            BsonClassMap.RegisterClassMap<MongoUser>(map =>
            {
                map.MapMember(x => x.Orders).SetElementName("orders");
            });

            BsonClassMap.RegisterClassMap<Order>(map =>
            {
                map.MapMember(x => x.PurchaseTimestamp).SetElementName("purchase_timestamp").SetSerializer(new CustomDateTimeSerializer(true));
                map.MapMember(x => x.Products).SetElementName("products");
            });

            BsonClassMap.RegisterClassMap<Publisher>(map =>
            {
                map.MapMember(x => x.Products).SetElementName("products");
                map.MapMember(x => x.Country).SetElementName("country");
                map.MapMember(x => x.Name).SetElementName("name");
            });

            BsonClassMap.RegisterClassMap<MongoPublisher>(map =>
            {
                map.MapMember(x => x._id).SetElementName("_id");
            });

            BsonClassMap.RegisterClassMap<Product>(map =>
            {
                map.MapMember(x => x.ID).SetElementName("productId");
                map.MapMember(x => x.ListingDate).SetElementName("listingDate").SetSerializer(new CustomDateTimeSerializer(false));
                map.MapMember(x => x.Title).SetElementName("title");
                map.MapMember(x => x.Description).SetElementName("description");
                map.MapMember(x => x.Price).SetElementName("price");
                map.MapMember(x => x.AgeRating).SetElementName("ageRating");
            });

            BsonClassMap.RegisterClassMap<Review>(map =>
            {
                map.MapMember(x => x.ProductID).SetElementName("product_id");
                map.MapMember(x => x.Title).SetElementName("title");
                map.MapMember(x => x.Description).SetElementName("description");
                map.MapMember(x => x.Rating).SetElementName("rating");
                map.MapMember(x => x.Reviewer).SetElementName("username");
            });

            BsonClassMap.RegisterClassMap<MongoReview>(map =>
            {
                map.AutoMap();
            });
        }

        public List<Product> GetProducts()
        {
            var publishers = publisherCollection.Find(new BsonDocument()).ToList();
            var products = publishers.Where(publisher => publisher.Products != null)
                                     .SelectMany(publisher => publisher.Products)
                                     .ToList();

            return products;
        }

        public List<Review> GetReviewsForProduct(Product product)
        {
            var reviews = reviewCollection.Find(match => match.ProductID == product.ID).ToList();
            var baseReviews = new List<Review>();

            baseReviews.AddRange(reviews);

            return baseReviews;
        }

        public void InsertOrder(Order order)
        {
            order.PurchaseTimestamp = DateTime.Now;

            activeUser.Orders.Add(order);
            usersCollection.ReplaceOne(user => user.Username == activeUser.Username, activeUser);
        }

        public List<Product> GetProductsOwnedByUser()
        {
            var productsOwnedByUser = activeUser.Orders?
                .SelectMany(order => order.Products)
                .ToList();

            return productsOwnedByUser;
        }

        public Publisher GetPublisherForProduct(Product product)
        {
            var filter = Builders<Publisher>.Filter.ElemMatch(matchPublisher => matchPublisher.Products, match => match.ID == product.ID);
            var publisher = publisherCollection.Find(filter).FirstOrDefault();

            return publisher;
        }

        public void InsertReview(Review review, Product reviewProduct)
        {
            var mongoReview = new MongoReview()
            {
                Title = review.Title,
                Description = review.Description,
                Rating = review.Rating,
                Reviewer = App.ActiveUserName,
                ProductID = reviewProduct.ID
            };

            reviewCollection.InsertOne(mongoReview);
        }

        public bool AttemptLogin(string username, string password)
        {
            var user = usersCollection.Find(x => x.Username == username).FirstOrDefault();

            bool isMatch = user?.Password == password;

            if (isMatch)
                activeUser = user;

            return isMatch;
        }
    }

    public class MongoUser : User
    {
        public ObjectId _id { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class MongoPublisher : Publisher
    {
        public ObjectId _id { get; set; }
    }

    public class MongoReview : Review
    {
        public ObjectId _id { get; set; }
    }

    public class CustomDateTimeSerializer : DateTimeSerializer
    {
        bool longFormat = false;

        public CustomDateTimeSerializer(bool longFormat)
        {
            this.longFormat = longFormat;
        }

        public override DateTime Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            var dateString = context.Reader.ReadString();

            return DateTime.ParseExact(dateString, longFormat ? "dd/MM/yyyy HH:mm:ss:fff" : "dd/MM/yy", CultureInfo.InvariantCulture);
        }

        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, DateTime value)
        {
            string output = longFormat ? value.ToString("dd/MM/yyyy HH:mm:ss:fff") : value.ToString("dd/MM/yy");
            context.Writer.WriteString(output);
        }
    }
}
