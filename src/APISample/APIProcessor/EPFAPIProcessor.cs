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
    public class EPFAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureEmbeddedPremiumFinanceApi _apiInstance;
        static SecureEmbeddedPremiumFinanceEndorsementsApi _apiInstance2;
        public EPFAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;
            _apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            _apiInstance2 = new SecureEmbeddedPremiumFinanceEndorsementsApi(config);
        }
        static public ApiResponse<List<PFGenerateQuoteResponse>> Generate(QuoteRequest request)
        {
            try
            {
                ApiResponse<List<PFGenerateQuoteResponse>> response = _apiInstance.SecureEpfQuotesGeneratePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<QuoteResponse>> GetByIntent(GetQuoteRequest request)
        {
            try
            {
                ApiResponse<List<QuoteResponse>> response = _apiInstance.SecureEpfQuotesIntentPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<QuoteResponse> GetByKey(GetQuoteKeyRequest request)
        {
            try
            {
                ApiResponse<QuoteResponse> response = _apiInstance.SecureEpfQuotesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFPolicyUpdateResponse> UpdateIntent(PFPolicyUpdateRequestDTO request)
        {
            try
            {
                ApiResponse<PFPolicyUpdateResponse> response = _apiInstance.SecureEpfMerchantsQuotesPolicyPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFCheckEndorsementsResponse> EndorsementEligibility(PFCheckEndorsementsRequest request)
        {
            try
            {
                ApiResponse<PFCheckEndorsementsResponse> response = _apiInstance2.SecureEpfEndorsementsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFEndorsementResponse> QuoteEndorsement(PFEndorsementRequest request)
        {
            try
            {
                ApiResponse<PFEndorsementResponse> response = _apiInstance2.SecureEpfQuoteEndorsementPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> QuoteESign(PFQuoteEsignRequest request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.SecureEpfQuotesCaptureesignPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFUpdatePFAResponse> QuoteBooking(PFQuoteBookingRequest request)
        {
            try
            {
                ApiResponse<PFUpdatePFAResponse> response = _apiInstance.SecureEpfQuotesBookingPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PFUpdatePFAResponse> QuoteEndorsementBooking(SecurePFQuoteBookingRequest request)
        {
            try
            {
                ApiResponse<PFUpdatePFAResponse> response = _apiInstance2.SecureEpfQuoteEndorsementBookingPutWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<string> RetrievePFA(PFRetrievePFARequestDTO request)
        {
            try
            {
                ApiResponse<string> response = _apiInstance.SecureEpfRetrievepfaPostWithHttpInfo(
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
