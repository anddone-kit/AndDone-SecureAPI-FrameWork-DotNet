using APISample.Settings;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace APISample.APIProcessor
{
    public class PaymentLinksAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecurePaymentLinksApi _apiInstance;
        public PaymentLinksAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecurePaymentLinksApi(config);
        }
        static public ApiResponse<PaymentLinkResponse> Create(PaymentLinkRequest request)
        {
            try
            {
                ApiResponse<PaymentLinkResponse> response = _apiInstance.SecurePaymentlinksPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static public ApiResponse<PaymentLinkResponse> Details(SecurePaymentLinkRequest request)
        {
            try
            {
                ApiResponse<PaymentLinkResponse> response = _apiInstance.SecurePaymentlinksDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentLinkResponse> Update(SecureUpdatePaymentLinkRequest request, 
            string payLinkId)
        {
            try
            {
                ApiResponse<PaymentLinkResponse> response = _apiInstance.SecurePaymentlinksIdPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, 
                    payLinkId, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentLinkExpiresResponse> Exprirations(SecurePaymentLinkRequest request)
        {
            try
            {
                ApiResponse<PaymentLinkExpiresResponse> response = _apiInstance.SecurePaymentlinksExpirationsPostWithHttpInfo(
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
