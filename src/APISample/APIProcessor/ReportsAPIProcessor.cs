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
    public class ReportsAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureReportsApi _apiInstance;
        public ReportsAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecureReportsApi(config);
        }
        static public ApiResponse<Object> Download(ReportDownloadRequest request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.SecureReportsDownloadsPostWithHttpInfo(
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
