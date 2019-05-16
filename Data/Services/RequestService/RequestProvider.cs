using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using FreshShopBM.Data.Services.RequestService;

public class RequestProvider : IRequestProvider
{
    private readonly JsonSerializerSettings _serializerSettings;
    public RequestProvider()
    {
        _serializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            NullValueHandling = NullValueHandling.Ignore
        };
        _serializerSettings.Converters.Add(new StringEnumConverter());
    }

    public async Task<TResult> PostAsync<TResult>(string uri, ByteArrayContent data, string token = "")
    {
        try
        {
            var httpClient = CreateHttpClient(token);

            data.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await httpClient.PostAsync(uri, data);

            await HandleResponse(response);
            var serialized = await response.Content.ReadAsStringAsync();

            var result = await Task.Run(() =>
            JsonConvert.DeserializeObject<TResult>(serialized, _serializerSettings));

            return result;
        }
        catch (WebException ex)
        {
            throw new WebException(ex.Message);
        }
    }
    public async Task<TResult> PostAsync<TResult>(string uri, string data, string token = "")
    {
        try
        {
            var httpClient = CreateHttpClient(token);

            var content = new StringContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await httpClient.PostAsync(uri, content);

            await HandleResponse(response);
            var serialized = await response.Content.ReadAsStringAsync();

            var result = await Task.Run(() =>
            JsonConvert.DeserializeObject<TResult>(serialized, _serializerSettings));

            return result;
        }
        catch (WebException ex)
        {
            throw new WebException(ex.Message);
        }
    }

    private HttpClient CreateHttpClient(string token = "")
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        if (!string.IsNullOrEmpty(token))
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        return httpClient;
    }

    private async Task HandleResponse(HttpResponseMessage response)
    {
        if (!response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.Forbidden ||
                response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new WebException(content);
            }

            throw new WebException(response.StatusCode.ToString() + content);
        }
    }
}