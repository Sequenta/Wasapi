using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wasapi
{
    public class AssociationResult
    {
        [JsonProperty(PropertyName = "text")]
        public string Word { get; set; }
        
        [JsonProperty(PropertyName = "items")]
        public IEnumerable<Association> Associations { get; set; }
    }

    public class Association
    {
        public string Item { get; set; }
        
        public int Weight { get; set; }
        
        public string Pos { get; set; }
    }
}