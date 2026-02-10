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
    public class VendorAPIProcessor
    {
        static public ApiResponse<SecureVendorResponseDTO> Create(VendorRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<SecureVendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<VendorResponseDTO> Details(SecureVendorRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<VendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsDetailsPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<PageVendorResponseDTO> Search(string vendorId, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<PageVendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsSearchPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, vendorId: vendorId);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Suspend(SecureVendorStatusRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.VendorapiSecureMerchantsVendorsSuspendPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Unsuspend(SecureVendorStatusRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.VendorapiSecureMerchantsVendorsUnsuspendPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<Object> Delete(SecureVendorStatusRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<Object> response = apiInstance.VendorapiSecureMerchantsVendorsDeletePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<List<VendorTimelineResponseListInner>> Timeline(SecureVendorTimelineRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<List<VendorTimelineResponseListInner>> response = apiInstance.VendorapiSecureMerchantsVendorsTimelinePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public ApiResponse<SecureVendorResponseDTO> Edit(SecureVendorUpdateRequestDTO request, ConfigSettings _settings)
        {
            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath2;
            var apiInstance = new SecureVendorManagementApi(config);
            try
            {
                ApiResponse<SecureVendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsEditPostWithHttpInfo(
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
