using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using FreshShopBM.Data.Models;
using FreshShopBM.Data.Services.RequestService;

namespace FreshShopBM.Data.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IRequestProvider _iRequstProvider;
        private readonly IJSRuntime _iJSRuntiem;

        public ProductService(
            IRequestProvider iRequestProvider,
            IJSRuntime iJSRuntime)
        {
            _iRequstProvider = iRequestProvider;
            _iJSRuntiem = iJSRuntime;
        }

        public async Task<List<MainCategoryModel>> GetMainCategoriesAsync(string token)
        {
            return await _iRequstProvider.PostAsync<List<MainCategoryModel>>(
                GlobalSetting.Instance.MainCategoryEndpoint,
                JsonConvert.SerializeObject("99bc735d-c5bf-4fe6-bc66-4d23548b1b11"),
                token
            );
        }

        public async Task<List<SubCategoryModel>> GetSubCategoriesAsync(string token, Guid mainCategoryId)
        {
            return await _iRequstProvider.PostAsync<List<SubCategoryModel>>(
                GlobalSetting.Instance.SubCategoryEndpoint,
                JsonConvert.SerializeObject(mainCategoryId.ToString()),
                token
            );
        }

        public async Task<List<ProductsModel>> GetProductsAsync(string token, Guid subCategoryId)
        {
            return await _iRequstProvider.PostAsync<List<ProductsModel>>(
                GlobalSetting.Instance.ProductsEndpoint,
                JsonConvert.SerializeObject(subCategoryId.ToString()),
                token
            );
        }

        public async Task<object> UploadImage(string token, string data)
        {
            return await _iRequstProvider.PostAsync<object>(
                GlobalSetting.Instance.UploadImageEndpoint,
                JsonConvert.SerializeObject(data),
                token
            );
        }

        public async Task<bool> AddOrUpdateProductAsync(string token, ProductsModel model)
        {
            return await _iRequstProvider.PostAsync<bool>(
                GlobalSetting.Instance.AddOrUpdateProductEndpoint,
                JsonConvert.SerializeObject(model),
                token
            );
        }

        public async Task<bool> DeleteProductAsync(string token, Guid productId)
        {
            return await _iRequstProvider.PostAsync<bool>(
                GlobalSetting.Instance.AddOrUpdateProductEndpoint,
                JsonConvert.SerializeObject(productId.ToString()),
                token
            );
        }

    }
}