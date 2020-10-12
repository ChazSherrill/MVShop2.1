using MVShop2._1.Data.Entities;
using System.Collections.Generic;

namespace MVShop2._1.Data
{
    public interface IMVRepo
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
    }
}