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
    public class CancellationsAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureVoidsApi _apiInstance;
        public CancellationsAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecureVoidsApi(config);
        }
        static public ApiResponse<SecureCancelledTransactionResponse> Cancel(SecureTransactionCancelRequest request)
        {
            try
            {
                ApiResponse<SecureCancelledTransactionResponse> response = _apiInstance.SecureCancellationsPostWithHttpInfo(
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
