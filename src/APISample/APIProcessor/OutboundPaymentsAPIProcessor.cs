using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
using APISample.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.APIProcessor
{
    public class OutboundPaymentsAPIProcessor
    {
        static public ApiResponse<PaymentResponseDto> Create(PaymentRequestDto request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureOutboundPaymentsApi(config);
            try
            {
                ApiResponse<PaymentResponseDto> response = apiInstance.VendorapiSecureOutboundpaymentsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PaymentDetailResponseDTO> Details(PaymentRequestDetailDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureOutboundPaymentsApi(config);
            try
            {
                ApiResponse<PaymentDetailResponseDTO> response = apiInstance.VendorapiSecureOutboundpaymentsDetailPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Cancel(CancelPaymentRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureOutboundPaymentsApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.VendorapiSecureOutboundpaymentsCancelPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<OutboundPaymentTimelineResponseDTOInner>> Timelines(PaymentTimeLineRequestDto request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureOutboundPaymentsApi(config);
            try
            {
                ApiResponse<List<OutboundPaymentTimelineResponseDTOInner>> response = apiInstance.VendorapiSecureOutboundPaymentsTimelinesPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PagePaymentListResponseDTO> Search(string paymentId, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureOutboundPaymentsApi(config);
            try
            {
                ApiResponse<PagePaymentListResponseDTO> response = apiInstance.VendorapiSecureOutboundpaymentsSearchPostWithHttpInfo(
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
