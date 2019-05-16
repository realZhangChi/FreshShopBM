using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace FreshShopBM.Data.Models
{
    public class ProductsModel
    {
        [Required]
        [JsonProperty(propertyName: "productId")]
        public Guid ProductId { get; set; }

        [JsonProperty(propertyName:"productUserId")]
        public Guid ProductUserId { get; set; }

        [JsonProperty(propertyName:"userId")]
        public Guid UserId { get; set; }

        [JsonProperty(propertyName:"subCategoryId")]
        public Guid SubCategoryId { get; set; }

        [Display(Name = "商品名")]
        [StringLength(maximumLength:20, ErrorMessage = "商品名长度超出限制。")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "商品名不能为空。")]
        [JsonProperty(propertyName: "productName")]
        public string ProductName { get; set; }

        [Display(Name = "单位")]
        [StringLength(maximumLength:6, ErrorMessage = "单位长度超出限制。")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "计价单位不能为空。")]
        [JsonProperty(propertyName: "unit")]
        public string Unit { get; set; }

        [Display(Name = "单价")]
        [Required(ErrorMessage = "单价不能为空。")]
        [JsonProperty(propertyName: "unitPrice")]
        public double UnitPrice { get; set; }

        [Display(Name = "图片地址")]
        [Url]
        [Required(AllowEmptyStrings = false, ErrorMessage = "商品图片URL不能为空。")]
        [JsonProperty(propertyName: "pictureUrl")]
        public string PictureUrl { get; set; }

        [Display(Name = "起购量")]
        [Required(ErrorMessage = "起购量不能为空。")]
        [JsonProperty(propertyName: "minOrderQuantity")]
        public int MinOrderQuantity { get; set; }
    }
}