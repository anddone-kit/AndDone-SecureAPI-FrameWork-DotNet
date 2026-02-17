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
    public class TokenLinksAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureTokenLinksApi _apiInstance;
        public TokenLinksAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecureTokenLinksApi(config);
        }
        static public ApiResponse<SecureTokenLinkResponse> Create(TokenLinkSecureRequest request)
        {
            try
            {
                ApiResponse<SecureTokenLinkResponse> response = _apiInstance.SecureTokenlinksPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<SecureTokenLinkByIdResponse> Details(SecureTokenLinkRequest request)
        {
            try
            {
                ApiResponse<SecureTokenLinkByIdResponse> response = _apiInstance.SecureTokenlinksDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Update(SecureTokenLinkUpdateRequest request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.SecureTokenlinksPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<SecureTokenLinkExpiredResponse> Expire(SecureTokenLinkRequest request)
        {
            try
            {
                ApiResponse<SecureTokenLinkExpiredResponse> response = _apiInstance.SecureTokenlinksExpirationsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<TokenLinkResponse> List()
        {
            try
            {
                ApiResponse<TokenLinkResponse> response = _apiInstance.SecureTokenlinksListPostWithHttpInfo(
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
