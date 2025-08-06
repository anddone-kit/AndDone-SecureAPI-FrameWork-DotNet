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
    public class TokenLinksAPIProcessor
    {
        static public ApiResponse<SecureTokenLinkResponse> Create(TokenLinkSecureRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureTokenLinksApi(config);
            try
            {
                ApiResponse<SecureTokenLinkResponse> response = apiInstance.SecureTokenlinksPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<SecureTokenLinkByIdResponse> Details(SecureTokenLinkRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureTokenLinksApi(config);
            try
            {
                ApiResponse<SecureTokenLinkByIdResponse> response = apiInstance.SecureTokenlinksDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Update(SecureTokenLinkUpdateRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureTokenLinksApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.SecureTokenlinksPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<SecureTokenLinkExpiredResponse> Expire(SecureTokenLinkRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureTokenLinksApi(config);
            try
            {
                ApiResponse<SecureTokenLinkExpiredResponse> response = apiInstance.SecureTokenlinksExpirationsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<TokenLinkResponse> List(ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureTokenLinksApi(config);
            try
            {
                ApiResponse<TokenLinkResponse> response = apiInstance.SecureTokenlinksListPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
