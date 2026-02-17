using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
using APISample.Settings;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.APIProcessor
{
    public class OutboundPaymentsAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureOutboundPaymentsApi _apiInstance;
        public OutboundPaymentsAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            _apiInstance = new SecureOutboundPaymentsApi(config);
        }
        static public ApiResponse<PaymentResponseDto> Create(PaymentRequestDto request)
        {
            try
            {
                ApiResponse<PaymentResponseDto> response = _apiInstance.VendorapiSecureOutboundpaymentsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentDetailResponseDTO> Details(PaymentRequestDetailDTO request)
        {
            try
            {
                ApiResponse<PaymentDetailResponseDTO> response = _apiInstance.VendorapiSecureOutboundpaymentsDetailPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Cancel(CancelPaymentRequestDTO request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.VendorapiSecureOutboundpaymentsCancelPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<OutboundPaymentTimelineResponseDTOInner>> Timelines(PaymentTimeLineRequestDto request)
        {
            try
            {
                ApiResponse<List<OutboundPaymentTimelineResponseDTOInner>> response = _apiInstance.VendorapiSecureOutboundPaymentsTimelinesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PagePaymentListResponseDTO> Search(string paymentId)
        {
            try
            {
                ApiResponse<PagePaymentListResponseDTO> response = _apiInstance.VendorapiSecureOutboundpaymentsSearchPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, paymentId: paymentId);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
