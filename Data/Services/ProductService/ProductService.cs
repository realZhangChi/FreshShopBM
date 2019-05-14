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

        public async Task<List<MainCategoryModel>> GetMainCategory(string token)
        {
            return await _iRequstProvider.PostAsync<List<MainCategoryModel>>(
                GlobalSetting.Instance.MainCategoryEndpoint,
                JsonConvert.SerializeObject("99bc735d-c5bf-4fe6-bc66-4d23548b1b11"),
                token
            );
        }

    }
}