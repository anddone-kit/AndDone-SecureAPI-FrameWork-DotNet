using APISample.Settings;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.APIProcessor
{
    public class PaymentIntentsAPIProcessor
    {
        static public ApiResponse<PaymentIntentResponse> Create(PaymentIntentRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentIntentApi(config);
            try
            {
                ApiResponse<PaymentIntentResponse> response = apiInstance.SecurePaymentintentsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentIntentExpiresResponse> Expiration(string expToken, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentIntentApi(config);
            try
            {
                ApiResponse<PaymentIntentExpiresResponse> response = apiInstance.SecurePaymentintentsExpirationsPostWithHttpInfo(
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
