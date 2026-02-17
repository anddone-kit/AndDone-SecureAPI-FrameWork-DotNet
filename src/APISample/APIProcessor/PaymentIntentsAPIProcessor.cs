using APISample.Settings;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace APISample.APIProcessor
{
    public class PaymentIntentsAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecurePaymentIntentApi _apiInstance;
        public PaymentIntentsAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecurePaymentIntentApi(config);
        }
        public static ApiResponse<PaymentIntentResponse> Create(PaymentIntentRequest request)
        {
            try
            {
                ApiResponse<PaymentIntentResponse> response = _apiInstance.SecurePaymentintentsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentIntentExpiresResponse> Expiration(string expToken)
        {
            try
            {
                ApiResponse<PaymentIntentExpiresResponse> response = _apiInstance.SecurePaymentintentsExpirationsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, expToken);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
