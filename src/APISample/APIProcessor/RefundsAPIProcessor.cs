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
    public class RefundsAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureRefundsApi _apiInstance;
        public RefundsAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecureRefundsApi(config);
        }
        static public ApiResponse<RefundEligibility> Eligibility(TransactionRefundEligibilityRequest request)
        {
            try
            {
                ApiResponse<RefundEligibility> response = _apiInstance.SecureRefundsEligibilityPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<SecureTransactionDetailDTO> Request(SecureTransactionRefundRequest request)
        {
            try
            {
                ApiResponse<SecureTransactionDetailDTO> response = _apiInstance.SecureRefundsPostWithHttpInfo(
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
