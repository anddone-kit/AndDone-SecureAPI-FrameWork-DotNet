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
    public class TokensAPIProcessor
    {
        static public ApiResponse<SecureMerchantTokenShortResponse> Details(SecureTokenLinkRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureTokenManagementApi(config);
            try
            {
                ApiResponse<SecureMerchantTokenShortResponse> response = apiInstance.SecureTokensDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Deaactivate(TokenRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureTokenManagementApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.SecureTokensActivationsDeleteWithHttpInfo(
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
