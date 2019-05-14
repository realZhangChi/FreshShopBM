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

        LoginEndpoint = $"{accoutBaseEndpoint}/Login";
        MainCategoryEndpoint = $"{categoryBaseEndpoint}/GetMainCategories";
    }
}