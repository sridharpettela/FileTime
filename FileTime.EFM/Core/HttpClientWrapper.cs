using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFM.Core
{
    public class HttpClientWrapper
    {

        private readonly HttpClient _httpClient;
        private Uri BaseEndpoint { get; set; }

        public HttpClientWrapper(Uri baseEndpoint)
        {
            if (baseEndpoint == null)
            {
                throw new ArgumentNullException("baseEndpoint");
            }
            BaseEndpoint = baseEndpoint;
            _httpClient = new HttpClient();
        }

        public async Task<T> GetAsync<T>(Uri requestUrl)
        {
            var response = await _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }

        public async Task<T> PostAsync<T>(string requestUrl, T content)
        {
            var response = await _httpClient.PostAsync(requestUrl, CreateHttpContent<T>(content));
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }
        public async Task<T1> PostAsync<T1, T2>(string requestUrl, T2 content)
        {
            var response = await _httpClient.PostAsync(requestUrl, CreateHttpContent<T2>(content));
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T1>(data);
        }

        public async Task<T> PutAsync<T>(string requestUrl, T content)
        {
	        var response = await _httpClient.PutAsync(requestUrl, CreateHttpContent<T>(content));
	        response.EnsureSuccessStatusCode();
	        var data = await response.Content.ReadAsStringAsync();
	        return JsonConvert.DeserializeObject<T>(data);
        }
        public async Task<T1> PutAsync<T1, T2>(string requestUrl, T2 content)
        {
	        var response = await _httpClient.PutAsync(requestUrl, CreateHttpContent<T2>(content));
	        response.EnsureSuccessStatusCode();
	        var data = await response.Content.ReadAsStringAsync();
	        return JsonConvert.DeserializeObject<T1>(data);
        }

        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }

    }
}
