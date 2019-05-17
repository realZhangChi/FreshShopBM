using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FreshShopBM.Data.Services.RequestService;
using FreshShopBM.Data.Models;
using Newtonsoft.Json;
// using Newtonsoft.Json.Converters;
namespace FreshShopBM.Data.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly IRequestProvider _iRequestProvider;

        public CategoryService(
            IRequestProvider iRequestProvider
        )
        {
            _iRequestProvider = iRequestProvider;
        }

        public async Task<bool> AddOrUpdateMainCategoryAsync(string token, MainCategoryModel model)
        {
            return await _iRequestProvider.PostAsync<bool>(
                GlobalSetting.Instance.AddOrUpdateMainCategoryEndpoint,
                JsonConvert.SerializeObject(model),
                token
            );
        }

        public async Task<bool> DeleteMainCategoryAsync(string token, Guid id)
        {
            return await _iRequestProvider.PostAsync<bool>(
                GlobalSetting.Instance.DeleteMainCategoryEndpoint,
                JsonConvert.SerializeObject(id.ToString()),
                token
            );
        }

        public async Task<bool> AddOrUpdateSubCategoryAsync(string token, SubCategoryModel model)
        {
            return await _iRequestProvider.PostAsync<bool>(
                GlobalSetting.Instance.AddOrUpdateSubCategoryEndpoing,
                JsonConvert.SerializeObject(model),
                token
            );
        }

        public async Task<bool> DeleteSubCategoryAsync(string token, Guid id)
        {
            return await _iRequestProvider.PostAsync<bool>(
                GlobalSetting.Instance.DeleteSubCategory,
                JsonConvert.SerializeObject(id.ToString()),
                token
            );
        }

        public async Task<List<SubCategoryModel>> GetAllSubcategoryAsync(string token)
        {
            return await _iRequestProvider.PostAsync<List<SubCategoryModel>>(
                GlobalSetting.Instance.SubCategoryByCompanyEndpoint,
                JsonConvert.SerializeObject("99bc735d-c5bf-4fe6-bc66-4d23548b1b11"),
                token
            );
        }
    }
}