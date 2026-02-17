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
    public class TokensAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureTokenManagementApi _apiInstance;
        public TokensAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecureTokenManagementApi(config);
        }
        static public ApiResponse<SecureMerchantTokenShortResponse> Details(SecureTokenLinkRequest request)
        {
            try
            {
                ApiResponse<SecureMerchantTokenShortResponse> response = _apiInstance.SecureTokensDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Deaactivate(TokenRequest request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.SecureTokensActivationsDeleteWithHttpInfo(
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
