using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Wahyudingultom_test.Lib
{
    public class MyLib : IMyLib
    {
        public T ApiGetMethod<T>(string baseURL, string urlParam)
        {
            T result = default(T);
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpResponseMessage response = client.GetAsync(urlParam).Result;
            if (!response.IsSuccessStatusCode)
                return result;

            var content = response.Content.ReadAsStringAsync().Result;
            result = JsonConvert.DeserializeObject<T>(content);

            return result;
        }

        public T ApiPostMethod<T>()
        {
            throw new NotImplementedException();
        }
    }
}
