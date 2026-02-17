using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
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
    public class PaymentAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecurePaymentsApi _apiInstance;
        public PaymentAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecurePaymentsApi(config);
        }
        static public ApiResponse<TransactionDetailResponse> Create(PaymentRequest request)
        {
            try
            {
                ApiResponse<TransactionDetailResponse> response = _apiInstance.SecurePaymentsPostWithHttpInfo(
                   _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<MerchantTransactionEntityResponse> Search(string startDate, string endDate,
            int startRow)
        {
            try
            {
                ApiResponse<MerchantTransactionEntityResponse> response = _apiInstance.SecurePaymentsSearchPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, startDate: startDate, 
                    endDate: endDate, startRow: startRow);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static public ApiResponse<Object> Export(string startDate, string endDate,
            int startRow)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.SecurePaymentsExportPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, startDate: startDate, 
                    endDate: endDate, startRow: startRow, asc: true, exportToCsv: true);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
