using AndDoneSecureClientLibrary.Model;
using AndDoneSecureClientLibrary.Api;
using APISample.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndDoneSecureClientLibrary.Client;
using Microsoft.Extensions.Options;

namespace APISample.APIProcessor
{
    public class PaymentDetailsAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecurePaymentsApi _apiInstance;
        public PaymentDetailsAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecurePaymentsApi(config);
        }
        static public ApiResponse<TransactionPaymentResponse> ById(SecurePaymentDetailsRequest request)
        {
            try
            {
                ApiResponse<TransactionPaymentResponse> response = _apiInstance.SecurePaymentsdetailsPostWithHttpInfo(
                   _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<TransactionPaymentResponse> ByToken(SecurePaymentDetailsRequest request)
        {
            try
            {
                ApiResponse<TransactionPaymentResponse> response = _apiInstance.SecurePaymentsdetailsPostWithHttpInfo(
                   _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
