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
    public class PaymentAPIProcessor
    {
        static public ApiResponse<TransactionDetailResponse> Create(PaymentRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentsApi(config);
            try
            {
                ApiResponse<TransactionDetailResponse> response = apiInstance.SecurePaymentsPostWithHttpInfo(
                   _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<MerchantTransactionEntityResponse> Search(string startDate, string endDate,
            int startRow, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentsApi(config);
            try
            {
                ApiResponse<MerchantTransactionEntityResponse> response = apiInstance.SecurePaymentsSearchPostWithHttpInfo(
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
            int startRow, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentsApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.SecurePaymentsExportPostWithHttpInfo(
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
