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

namespace APISample.APIProcessor
{
    public class BatchesAPIProcessor
    {
        static public ApiResponse<PaymentBatchResponse> Get(int startRow, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentBatchingApi(config);
            try
            {
                ApiResponse<PaymentBatchResponse> response = apiInstance.SecureBatchesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, startRow: startRow);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> TransactionCancel(PaymentBatchCancellationRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentBatchingApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.SecureBatchesTransactionsCancelPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Execute(SecureBatchExecuteRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentBatchingApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.SecureBatchesExecutePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<PaymentBatchEventLogResponse>> Timelines(SecurePaymentBatchDetailsRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentBatchingApi(config);
            try
            {
                ApiResponse<List<PaymentBatchEventLogResponse>> response = apiInstance.SecureBatchesTimelinesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<PaymentBatchDetailsResponse>> Details(SecurePaymentBatchDetailsRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecurePaymentBatchingApi(config);
            try
            {
                ApiResponse<List<PaymentBatchDetailsResponse>> response = apiInstance.SecureBatchesDetailsPostWithHttpInfo(
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
