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
    public class EPFAPIProcessor
    {
        static public ApiResponse<List<PFGenerateQuoteResponse>> Generate(QuoteRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            try
            {
                ApiResponse<List<PFGenerateQuoteResponse>> response = apiInstance.SecureEpfQuotesGeneratePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<QuoteResponse>> GetByIntent(GetQuoteRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            try
            {
                ApiResponse<List<QuoteResponse>> response = apiInstance.SecureEpfQuotesIntentPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<QuoteResponse> GetByKey(GetQuoteKeyRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            try
            {
                ApiResponse<QuoteResponse> response = apiInstance.SecureEpfQuotesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFPolicyUpdateResponse> UpdateIntent(PFPolicyUpdateRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            try
            {
                ApiResponse<PFPolicyUpdateResponse> response = apiInstance.SecureEpfMerchantsQuotesPolicyPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFCheckEndorsementsResponse> EndorsementEligibility(PFCheckEndorsementsRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceEndorsementsApi(config);
            try
            {
                ApiResponse<PFCheckEndorsementsResponse> response = apiInstance.SecureEpfEndorsementsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFEndorsementResponse> QuoteEndorsement(PFEndorsementRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceEndorsementsApi(config);
            try
            {
                ApiResponse<PFEndorsementResponse> response = apiInstance.SecureEpfQuoteEndorsementPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> QuoteESign(PFQuoteEsignRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.SecureEpfQuotesCaptureesignPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFUpdatePFAResponse> QuoteBooking(PFQuoteBookingRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            try
            {
                ApiResponse<PFUpdatePFAResponse> response = apiInstance.SecureEpfQuotesBookingPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFUpdatePFAResponse> QuoteEndorsementBooking(SecurePFQuoteBookingRequest request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceEndorsementsApi(config);
            try
            {
                ApiResponse<PFUpdatePFAResponse> response = apiInstance.SecureEpfQuoteEndorsementBookingPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<string> RetrievePFA(PFRetrievePFARequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            try
            {
                ApiResponse<string> response = apiInstance.SecureEpfRetrievepfaPostWithHttpInfo(
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
