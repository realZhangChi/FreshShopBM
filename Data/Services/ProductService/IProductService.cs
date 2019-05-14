using System.Threading.Tasks;
using System.Collections.Generic;
using FreshShopBM.Data.Models;

namespace FreshShopBM.Data.Services.ProductService
{
    public interface IProductService
    {
         Task<List<MainCategoryModel>> GetMainCategory(string token);
    }
}