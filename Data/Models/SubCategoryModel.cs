using System;
using Newtonsoft.Json;

namespace FreshShopBM.Data.Models
{
    public class SubCategoryModel
    {
        
        public Guid Id { get; set; }

        public Guid MainCategoryId { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public string MainCategoryName { get; set; }
    }
}