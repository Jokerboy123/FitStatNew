using System.Text;
using Newtonsoft.Json;
using Contracts.Base;
using Contracts.Models;
using Services.Abstractions.Database;

namespace Services.Database
{
    public class WebSiteApiConsumeService : IWebSiteApiConsumeService
    {
        private HttpClient _httpClient = null;
        private SettingsInfo _settings = null;
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);
        public WebSiteApiConsumeService(SettingsInfo settings)
        {
            _settings = settings;
            _httpClient = new HttpClient(new HttpClientHandler() { UseProxy = true });
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }
        public async Task<T> ConsumeService<T>(string RequestUrl,
             HttpMethod MethodRequest, object RequestParameters = null, TimeSpan? TimeOut = null)
            where T : BaseResponseModel, new()
        {
            try
            {
                var serializer = JsonSerializer.CreateDefault();
                JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
                var request = new HttpRequestMessage
                {
                    Method = MethodRequest,
                    RequestUri = new Uri(RequestUrl),
                    Content = RequestParameters != null ?
                   new StringContent(JsonConvert.SerializeObject(RequestParameters), Encoding.UTF8, "application/json") :
                   null
                };
                var httpResponseBase = await MakeRequest(async () => {
                    using (var cts = new CancellationTokenSource(TimeOut == null ? Timeout : TimeOut ?? Timeout))
                    {
                        var sendTask = _httpClient.SendAsync(request);

                        while (!sendTask.IsCompleted)
                        {
                            cts.Token.ThrowIfCancellationRequested();
                            await Task.Delay(10).ConfigureAwait(false);
                        }
                        return await sendTask.ConfigureAwait(false);
                    }
                });
                var httpResponse = httpResponseBase;
                httpResponse.EnsureSuccessStatusCode();
                if (httpResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return BaseResponseModelUtilities<T>.ErrorFormat(new Exception("Content format error"));
                }
                if (httpResponse.Content != null && httpResponse.Content is object &&
                   httpResponse.Content.Headers != null && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
                {
                    var contentStream = await httpResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(contentStream, microsoftDateFormatSettings);
                }
                else
                {
                    return BaseResponseModelUtilities<T>.ErrorFormat(new Exception("Content format error"));
                }
            }
            catch (OperationCanceledException)
            {
                return BaseResponseModelUtilities<T>.ErrorFormat(new Exception("Connection timeout exceed, please check Yours Internet connection"));
            }
            catch (Exception exp)
            {
                return BaseResponseModelUtilities<T>.ErrorFormat(exp);
            }
        }

        async Task<HttpResponseMessage> MakeRequest(Func<Task<HttpResponseMessage>> Action)
        {
            return await Action();
        }

        public string FormatRequestUrl(string baseUrl, string requestUrl)
        {
            return (baseUrl ?? "") + "/webapi/" + _settings.ApiVersionKey + (requestUrl ?? "").TrimStart(new char[] { '/' });
        }
    }
}
