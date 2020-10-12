using MVShop2._1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVShop2._1.Data
{
    public class MVRepo : IMVRepo
    {
        private readonly MVContext _ctx;

        public MVRepo(MVContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _ctx.Products
                        .OrderBy(p => p.Name)
                        .ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products
                        .Where(p => p.Category == category)
                        .ToList();
        }
    }
}
