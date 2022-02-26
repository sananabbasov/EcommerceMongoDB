using Entities.Concrete;
using MongoDB.Driver;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class ProductServices : IProductServices
    {
        private readonly IMongoCollection<Product> _products;

        public ProductServices(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("Ecommerce");
            _products = database.GetCollection<Product>("products");
        }
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> Get()
        {
            return _products.Find(product => true).ToList();
        }

        public Product Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
