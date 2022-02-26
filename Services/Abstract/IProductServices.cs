using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IProductServices
    {
        List<Product> Get();
        Product Get(string id);
        Product Create(Product product);
        void Remove(string id);
        void Update(string id, Product product);
    }
}
