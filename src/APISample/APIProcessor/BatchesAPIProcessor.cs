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
    public class BatchesAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecurePaymentBatchingApi _apiInstance;

        public BatchesAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecurePaymentBatchingApi(config);
        }
        static public ApiResponse<PaymentBatchResponse> Get(int startRow)
        {
            try
            {
                ApiResponse<PaymentBatchResponse> response = _apiInstance.SecureBatchesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, startRow: startRow);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> TransactionCancel(PaymentBatchCancellationRequest request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.SecureBatchesTransactionsCancelPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Execute(SecureBatchExecuteRequest request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.SecureBatchesExecutePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<PaymentBatchEventLogResponse>> Timelines(SecurePaymentBatchDetailsRequest request)
        {
            try
            {
                ApiResponse<List<PaymentBatchEventLogResponse>> response = _apiInstance.SecureBatchesTimelinesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<PaymentBatchDetailsResponse>> Details(SecurePaymentBatchDetailsRequest request)
        {
            try
            {
                ApiResponse<List<PaymentBatchDetailsResponse>> response = _apiInstance.SecureBatchesDetailsPostWithHttpInfo(
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
