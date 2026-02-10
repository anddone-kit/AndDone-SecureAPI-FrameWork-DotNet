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
    public class PaymentLinksAPIProcessor
    {
        static public ApiResponse<PaymentLinkResponse> Create(PaymentLinkRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentLinksApi(config);
            try
            {
                ApiResponse<PaymentLinkResponse> response = apiInstance.SecurePaymentlinksPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static public ApiResponse<PaymentLinkResponse> Details(SecurePaymentLinkRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentLinksApi(config);
            try
            {
                ApiResponse<PaymentLinkResponse> response = apiInstance.SecurePaymentlinksDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentLinkResponse> Update(SecureUpdatePaymentLinkRequest request, 
            string payLinkId, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentLinksApi(config);
            try
            {
                ApiResponse<PaymentLinkResponse> response = apiInstance.SecurePaymentlinksIdPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, 
                    payLinkId, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentLinkExpiresResponse> Exprirations(SecurePaymentLinkRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentLinksApi(config);
            try
            {
                ApiResponse<PaymentLinkExpiresResponse> response = apiInstance.SecurePaymentlinksExpirationsPostWithHttpInfo(
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
