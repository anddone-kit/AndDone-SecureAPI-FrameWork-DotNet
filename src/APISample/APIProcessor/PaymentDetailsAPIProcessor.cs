using APISample.Settings;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.APIProcessor
{
    public class PaymentDetailsAPIProcessor
    {
        static public ApiResponse<TransactionPaymentResponse> ById(SecurePaymentDetailsRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentsApi(config);
            try
            {
                ApiResponse<TransactionPaymentResponse> response = apiInstance.SecurePaymentsdetailsPostWithHttpInfo(
                   _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<TransactionPaymentResponse> ByToken(SecurePaymentDetailsRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentsApi(config);
            try
            {
                ApiResponse<TransactionPaymentResponse> response = apiInstance.SecurePaymentsdetailsPostWithHttpInfo(
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
