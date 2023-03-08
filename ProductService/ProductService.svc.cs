using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ProductService : IProductService
    {
        private readonly NorthwindEntities _context = new NorthwindEntities();

        public IEnumerable<Product> GetProducts(int categoryId)
        {
            return _context.Products.Where(p => p.CategoryID == categoryId).ToList();
        }
    }
}
