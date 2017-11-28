using System.ComponentModel;

namespace Wasapi
{
    public enum ResponseCode
    {
        [Description("Operation completed successfully")]
        Ok = 200,
        
        [Description("Invalid API key")]
        InvalidKey = 401,
        
        [Description("The monthly limit on the number of requests is exceeded")]
        LimitExceeded= 429,
        
        [Description("The specified language is not supported")]
        LanguageNotSupported = 501
    }
}