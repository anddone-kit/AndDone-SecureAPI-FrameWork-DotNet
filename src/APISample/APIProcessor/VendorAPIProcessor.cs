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
    public class VendorAPIProcessor
    {
        private static ConfigSettings _settings;
        static SecureVendorManagementApi _apiInstance;
        public VendorAPIProcessor(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            _apiInstance = new SecureVendorManagementApi(config);
        }
        static public ApiResponse<SecureVendorResponseDTO> Create(VendorRequestDTO request)
        {
            try
            {
                ApiResponse<SecureVendorResponseDTO> response = _apiInstance.VendorapiSecureMerchantsVendorsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<VendorResponseDTO> Details(SecureVendorRequestDTO request)
        {
            try
            {
                ApiResponse<VendorResponseDTO> response = _apiInstance.VendorapiSecureMerchantsVendorsDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PageVendorResponseDTO> Search(string vendorId)
        {
            try
            {
                ApiResponse<PageVendorResponseDTO> response = _apiInstance.VendorapiSecureMerchantsVendorsSearchPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, vendorId: vendorId);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Suspend(SecureVendorStatusRequestDTO request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.VendorapiSecureMerchantsVendorsSuspendPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Unsuspend(SecureVendorStatusRequestDTO request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.VendorapiSecureMerchantsVendorsUnsuspendPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Delete(SecureVendorStatusRequestDTO request)
        {
            try
            {
                ApiResponse<Object> response = _apiInstance.VendorapiSecureMerchantsVendorsDeletePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<VendorTimelineResponseListInner>> Timeline(SecureVendorTimelineRequestDTO request)
        {
            try
            {
                ApiResponse<List<VendorTimelineResponseListInner>> response = _apiInstance.VendorapiSecureMerchantsVendorsTimelinePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<SecureVendorResponseDTO> Edit(SecureVendorUpdateRequestDTO request)
        {
            try
            {
                ApiResponse<SecureVendorResponseDTO> response = _apiInstance.VendorapiSecureMerchantsVendorsEditPostWithHttpInfo(
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
