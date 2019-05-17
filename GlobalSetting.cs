public class GlobalSetting
{
    private const string DefaultEndpoint = "http://localhost:32770";

    private string _baseEndpoint;

    public GlobalSetting()
    {
        BaseEndpoint = DefaultEndpoint;
    }

    public static GlobalSetting Instance { get; } = new GlobalSetting();

    public string AccessToken { get; set; }

    public string LoginEndpoint { get; set; }

    public string MainCategoryEndpoint { get; set; }

    public string SubCategoryEndpoint { get; set; }

    public string SubCategoryByCompanyEndpoint { get; set; }

    public string ProductsEndpoint { get; set; }

    public string AddOrUpdateProductEndpoint { get; set; }

    public string DeleteProductEndpoint { get; set; }

    public string AddOrUpdateMainCategoryEndpoint { get; set; }

    public string DeleteMainCategoryEndpoint { get; set; }

    public string AddOrUpdateSubCategoryEndpoing { get; set; }

    public string DeleteSubCategory { get; set; }

    public string UploadImageEndpoint { get; set; }

    public string BaseEndpoint
    {
        get => _baseEndpoint;
        set
        {
            _baseEndpoint = value;
            UpdateEndpoint(_baseEndpoint);
        }
    }

    private void UpdateEndpoint(string baseEndpoint)
    {
        var accoutBaseEndpoint = $"{BaseEndpoint}/Account";
        var categoryBaseEndpoint = $"{BaseEndpoint}/Categories";
        var productBaseEndpoint = $"{BaseEndpoint}/Products";
        var productBmBaseEndpoint = $"{BaseEndpoint}/ProductsBm";
        var categoryBmBaseEndPoint = $"{BaseEndpoint}/CategoryBm";;

        LoginEndpoint = $"{accoutBaseEndpoint}/Login";
        MainCategoryEndpoint = $"{categoryBaseEndpoint}/GetMainCategories";
        SubCategoryEndpoint = $"{categoryBaseEndpoint}/GetSubCategoriesByMain";
        SubCategoryByCompanyEndpoint = $"{categoryBaseEndpoint}/GetSubCategories";
        ProductsEndpoint = $"{productBaseEndpoint}/GetProductList";
        UploadImageEndpoint = $"{productBaseEndpoint}/UploadImage";
        AddOrUpdateProductEndpoint = $"{productBmBaseEndpoint}/AddOrUpdateProduct";
        DeleteProductEndpoint = $"{productBmBaseEndpoint}/DeleteProduct";
        AddOrUpdateMainCategoryEndpoint = $"{categoryBmBaseEndPoint}/AddOrUpdateMainCategory";
        DeleteMainCategoryEndpoint = $"{categoryBmBaseEndPoint}/DeleteMainCategory";
        AddOrUpdateSubCategoryEndpoing = $"{categoryBmBaseEndPoint}/AddOrUpdateSubCategory";
        DeleteSubCategory = $"{categoryBmBaseEndPoint}/DeleteSubCategory";
    }
}