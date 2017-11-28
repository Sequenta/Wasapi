using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Wasapi
{
    public class Associations
    {
        private readonly string _url;

        public Associations(string url)
        {
            _url = url;
        }
        
        public async Task<Response> GetAssociationsAsync(string[] words, RequestSettings settings = null)
        {
            using (var client = new HttpClient())
            {
                var set = settings ?? RequestSettings.Default;
                var urlWithParams = $"{_url}&text={string.Join("&text=", words)}&{set.ToUrlString()}";
                var data = await client.GetStringAsync(urlWithParams);
                return GetResponse(data);
            }
        }

        private Response GetResponse(string data)
        {
            var parsedData = JObject.Parse(data);
            var code = parsedData["code"].Value<int>();
            
            if ((ResponseCode) code != ResponseCode.Ok) 
                return Response.Error(code);
            
            var result = parsedData["response"].ToObject<List<AssociationResult>>();
            return Response.Success(result);
        }
    }
}