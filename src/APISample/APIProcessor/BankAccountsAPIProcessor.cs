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
    public class BankAccountsAPIProcessor
    {
        static public ApiResponse<VerifyBankAccountResponse> Verify(VerifyBankAccountRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureOrumApi(config);
            try
            {
                ApiResponse<VerifyBankAccountResponse> response = apiInstance.SecureBankaccountsVerifyPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<VerifyBankAccountResponse> Details(VerificationEntityRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureOrumApi(config);
            //decimal id = Convert.ToDecimal(request.Id);

            try
            {
                ApiResponse<VerifyBankAccountResponse> response = apiInstance.SecureBankaccountsDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, verificationEntityRequest: request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
