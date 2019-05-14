using System;
using Newtonsoft.Json;

namespace FreshShopBM.Data.Models
{
    public class MainCategoryModel
    {
        [JsonProperty(propertyName:"id")]
        public Guid Id { get; set; }

        [JsonProperty(propertyName:"name")]
        public string Name { get; set; }
    }
}
