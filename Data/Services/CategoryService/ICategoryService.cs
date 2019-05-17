using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FreshShopBM.Data.Models;

namespace FreshShopBM.Data.Services.CategoryService
{
    public interface ICategoryService
    {
         Task<bool> AddOrUpdateMainCategoryAsync(string token, MainCategoryModel model);
         Task<bool> DeleteMainCategoryAsync(string token, Guid id);
         Task<bool> AddOrUpdateSubCategoryAsync(string token, SubCategoryModel model);
         Task<bool> DeleteSubCategoryAsync(string token, Guid id);
         Task<List<SubCategoryModel>> GetAllSubcategoryAsync(string token);
    }
}