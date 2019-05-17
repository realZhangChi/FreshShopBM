using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using FreshShopBM.Data.Models;

namespace FreshShopBM.Data.Services.ProductService
{
    public interface IProductService
    {
         Task<List<MainCategoryModel>> GetMainCategoriesAsync(string token);

         Task<List<SubCategoryModel>> GetSubCategoriesAsync(string token, Guid mainCategoryId);

         Task<List<ProductsModel>> GetProductsAsync(string token, Guid subCategoryId);

         Task<object> UploadImage(string token, string data);

         Task<bool> DeleteProductAsync(string token, Guid productId);

         Task<bool> AddOrUpdateProductAsync(string token, ProductsModel model);
    }
}