using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Birbiz.WebServices.Common.Results
{
    public class LowerCaseJsonSerializerSettings : JsonSerializerSettings
    {
        public LowerCaseJsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}