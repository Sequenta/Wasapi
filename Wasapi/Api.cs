namespace Wasapi
{
    public class Api
    {
        private readonly string _key;
        private string _baseUrl = "https://api.wordassociations.net/";

        public Api(string key)
        {
            _key = key;
        }
        
        public Associations Associations()
        {
            var url = $"{_baseUrl}associations/v1.0/json/search?apikey={_key}";
            return new Associations(url);
        }
    }
}