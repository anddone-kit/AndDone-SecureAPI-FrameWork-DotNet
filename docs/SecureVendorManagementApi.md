# Org.OpenAPITools.Api.SecureVendorManagementApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VendorapiSecureMerchantsVendorsDeletePost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorsdeletepost) | **POST** /vendorapi/secure/merchants/vendors/delete | This API deletes vendor into system |
| [**VendorapiSecureMerchantsVendorsDetailsPost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorsdetailspost) | **POST** /vendorapi/secure/merchants/vendors/details | This API gets details of particular vendor |
| [**VendorapiSecureMerchantsVendorsEditPost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorseditpost) | **POST** /vendorapi/secure/merchants/vendors/edit | This API Updates the existing vendor |
| [**VendorapiSecureMerchantsVendorsPost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorspost) | **POST** /vendorapi/secure/merchants/vendors | This API creates vendor into system |
| [**VendorapiSecureMerchantsVendorsSearchPost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorssearchpost) | **POST** /vendorapi/secure/merchants/vendors/search | This API returns list of all the Vendors of Merchant |
| [**VendorapiSecureMerchantsVendorsSuspendPost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorssuspendpost) | **POST** /vendorapi/secure/merchants/vendors/suspend | This API suspends vendor into system |
| [**VendorapiSecureMerchantsVendorsTimelinePost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorstimelinepost) | **POST** /vendorapi/secure/merchants/vendors/timeline | This API gets timeline of particular vendor |
| [**VendorapiSecureMerchantsVendorsUnsuspendPost**](SecureVendorManagementApi.md#vendorapisecuremerchantsvendorsunsuspendpost) | **POST** /vendorapi/secure/merchants/vendors/unsuspend | This API unsuspends vendor into system |

<a id="vendorapisecuremerchantsvendorsdeletepost"></a>
# **VendorapiSecureMerchantsVendorsDeletePost**
> void VendorapiSecureMerchantsVendorsDeletePost (string xApiKey, string xAppKey, float xVersion, string origin, SecureVendorStatusRequestDTO secureVendorStatusRequestDTO)

This API deletes vendor into system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsDeletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureVendorStatusRequestDTO = new SecureVendorStatusRequestDTO(); // SecureVendorStatusRequestDTO | SecureVendorStatusRequestDTO

            try
            {
                // This API deletes vendor into system
                apiInstance.VendorapiSecureMerchantsVendorsDeletePost(xApiKey, xAppKey, xVersion, origin, secureVendorStatusRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsDeletePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsDeletePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API deletes vendor into system
    apiInstance.VendorapiSecureMerchantsVendorsDeletePostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureVendorStatusRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsDeletePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureVendorStatusRequestDTO** | [**SecureVendorStatusRequestDTO**](SecureVendorStatusRequestDTO.md) | SecureVendorStatusRequestDTO |  |

### Return type

void (empty response body)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vendor deleted successfully |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecuremerchantsvendorsdetailspost"></a>
# **VendorapiSecureMerchantsVendorsDetailsPost**
> VendorResponseDTO VendorapiSecureMerchantsVendorsDetailsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureVendorRequestDTO secureVendorRequestDTO)

This API gets details of particular vendor

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsDetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureVendorRequestDTO = new SecureVendorRequestDTO(); // SecureVendorRequestDTO | SecureVendorRequestDTO

            try
            {
                // This API gets details of particular vendor
                VendorResponseDTO result = apiInstance.VendorapiSecureMerchantsVendorsDetailsPost(xApiKey, xAppKey, xVersion, origin, secureVendorRequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API gets details of particular vendor
    ApiResponse<VendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsDetailsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureVendorRequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsDetailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureVendorRequestDTO** | [**SecureVendorRequestDTO**](SecureVendorRequestDTO.md) | SecureVendorRequestDTO |  |

### Return type

[**VendorResponseDTO**](VendorResponseDTO.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vendor details fetched successfully |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecuremerchantsvendorseditpost"></a>
# **VendorapiSecureMerchantsVendorsEditPost**
> SecureVendorResponseDTO VendorapiSecureMerchantsVendorsEditPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureVendorUpdateRequestDTO secureVendorUpdateRequestDTO)

This API Updates the existing vendor

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsEditPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureVendorUpdateRequestDTO = new SecureVendorUpdateRequestDTO(); // SecureVendorUpdateRequestDTO | SecureVendorUpdateRequestDTO

            try
            {
                // This API Updates the existing vendor
                SecureVendorResponseDTO result = apiInstance.VendorapiSecureMerchantsVendorsEditPost(xApiKey, xAppKey, xVersion, origin, secureVendorUpdateRequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsEditPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsEditPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API Updates the existing vendor
    ApiResponse<SecureVendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsEditPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureVendorUpdateRequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsEditPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureVendorUpdateRequestDTO** | [**SecureVendorUpdateRequestDTO**](SecureVendorUpdateRequestDTO.md) | SecureVendorUpdateRequestDTO |  |

### Return type

[**SecureVendorResponseDTO**](SecureVendorResponseDTO.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vendor updated successfully |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecuremerchantsvendorspost"></a>
# **VendorapiSecureMerchantsVendorsPost**
> SecureVendorResponseDTO VendorapiSecureMerchantsVendorsPost (string xApiKey, string xAppKey, float xVersion, string origin, VendorRequestDTO vendorRequestDTO)

This API creates vendor into system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var vendorRequestDTO = new VendorRequestDTO(); // VendorRequestDTO | VendorRequestDTO

            try
            {
                // This API creates vendor into system
                SecureVendorResponseDTO result = apiInstance.VendorapiSecureMerchantsVendorsPost(xApiKey, xAppKey, xVersion, origin, vendorRequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API creates vendor into system
    ApiResponse<SecureVendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, vendorRequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **vendorRequestDTO** | [**VendorRequestDTO**](VendorRequestDTO.md) | VendorRequestDTO |  |

### Return type

[**SecureVendorResponseDTO**](SecureVendorResponseDTO.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | SecureVendorResponseDTO |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecuremerchantsvendorssearchpost"></a>
# **VendorapiSecureMerchantsVendorsSearchPost**
> PageVendorResponseDTO VendorapiSecureMerchantsVendorsSearchPost (string xApiKey, string xAppKey, float xVersion, string origin, string? paymentMethodType = null, string? attention = null, string? vendorId = null, string? vendorName = null, string? vendorStatus = null, string? createdBy = null, string? startDate = null, string? endDate = null, float? pageSize = null, string? searchText = null, string? sortField = null, string? startRow = null, bool? asc = null)

This API returns list of all the Vendors of Merchant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsSearchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentMethodType = "Check";  // string? | Set paymentMethodType (optional) 
            var attention = "attention_example";  // string? | Set attention (optional) 
            var vendorId = "vendorId_example";  // string? | Set vendorId (optional) 
            var vendorName = "vendorName_example";  // string? | Set vendorName (optional) 
            var vendorStatus = "vendorStatus_example";  // string? | Set vendorStatus (optional) 
            var createdBy = "createdBy_example";  // string? | Set createdBy (optional) 
            var startDate = "startDate_example";  // string? | set start Date (optional) 
            var endDate = "endDate_example";  // string? | set end Date (optional) 
            var pageSize = 8.14D;  // float? | Set PageSize (optional) 
            var searchText = "searchText_example";  // string? | search Text (optional) 
            var sortField = "sortField_example";  // string? | Set SortField (optional) 
            var startRow = "startRow_example";  // string? | Set StartRow (optional) 
            var asc = true;  // bool? | Set Asc (optional) 

            try
            {
                // This API returns list of all the Vendors of Merchant
                PageVendorResponseDTO result = apiInstance.VendorapiSecureMerchantsVendorsSearchPost(xApiKey, xAppKey, xVersion, origin, paymentMethodType, attention, vendorId, vendorName, vendorStatus, createdBy, startDate, endDate, pageSize, searchText, sortField, startRow, asc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API returns list of all the Vendors of Merchant
    ApiResponse<PageVendorResponseDTO> response = apiInstance.VendorapiSecureMerchantsVendorsSearchPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentMethodType, attention, vendorId, vendorName, vendorStatus, createdBy, startDate, endDate, pageSize, searchText, sortField, startRow, asc);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **paymentMethodType** | **string?** | Set paymentMethodType | [optional]  |
| **attention** | **string?** | Set attention | [optional]  |
| **vendorId** | **string?** | Set vendorId | [optional]  |
| **vendorName** | **string?** | Set vendorName | [optional]  |
| **vendorStatus** | **string?** | Set vendorStatus | [optional]  |
| **createdBy** | **string?** | Set createdBy | [optional]  |
| **startDate** | **string?** | set start Date | [optional]  |
| **endDate** | **string?** | set end Date | [optional]  |
| **pageSize** | **float?** | Set PageSize | [optional]  |
| **searchText** | **string?** | search Text | [optional]  |
| **sortField** | **string?** | Set SortField | [optional]  |
| **startRow** | **string?** | Set StartRow | [optional]  |
| **asc** | **bool?** | Set Asc | [optional]  |

### Return type

[**PageVendorResponseDTO**](PageVendorResponseDTO.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vendor searched successfully |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecuremerchantsvendorssuspendpost"></a>
# **VendorapiSecureMerchantsVendorsSuspendPost**
> void VendorapiSecureMerchantsVendorsSuspendPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureVendorStatusRequestDTO secureVendorStatusRequestDTO)

This API suspends vendor into system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsSuspendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureVendorStatusRequestDTO = new SecureVendorStatusRequestDTO(); // SecureVendorStatusRequestDTO | SecureVendorStatusRequestDTO

            try
            {
                // This API suspends vendor into system
                apiInstance.VendorapiSecureMerchantsVendorsSuspendPost(xApiKey, xAppKey, xVersion, origin, secureVendorStatusRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsSuspendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsSuspendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API suspends vendor into system
    apiInstance.VendorapiSecureMerchantsVendorsSuspendPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureVendorStatusRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsSuspendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureVendorStatusRequestDTO** | [**SecureVendorStatusRequestDTO**](SecureVendorStatusRequestDTO.md) | SecureVendorStatusRequestDTO |  |

### Return type

void (empty response body)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vendor suspended successfully |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecuremerchantsvendorstimelinepost"></a>
# **VendorapiSecureMerchantsVendorsTimelinePost**
> List&lt;VendorTimelineResponseListInner&gt; VendorapiSecureMerchantsVendorsTimelinePost (string xApiKey, string xAppKey, float xVersion, string origin, SecureVendorTimelineRequestDTO secureVendorTimelineRequestDTO)

This API gets timeline of particular vendor

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsTimelinePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureVendorTimelineRequestDTO = new SecureVendorTimelineRequestDTO(); // SecureVendorTimelineRequestDTO | SecureVendorTimelineRequestDTO

            try
            {
                // This API gets timeline of particular vendor
                List<VendorTimelineResponseListInner> result = apiInstance.VendorapiSecureMerchantsVendorsTimelinePost(xApiKey, xAppKey, xVersion, origin, secureVendorTimelineRequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsTimelinePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsTimelinePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API gets timeline of particular vendor
    ApiResponse<List<VendorTimelineResponseListInner>> response = apiInstance.VendorapiSecureMerchantsVendorsTimelinePostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureVendorTimelineRequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsTimelinePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureVendorTimelineRequestDTO** | [**SecureVendorTimelineRequestDTO**](SecureVendorTimelineRequestDTO.md) | SecureVendorTimelineRequestDTO |  |

### Return type

[**List&lt;VendorTimelineResponseListInner&gt;**](VendorTimelineResponseListInner.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vendor timeline fetched successfully |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecuremerchantsvendorsunsuspendpost"></a>
# **VendorapiSecureMerchantsVendorsUnsuspendPost**
> void VendorapiSecureMerchantsVendorsUnsuspendPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureVendorStatusRequestDTO secureVendorStatusRequestDTO)

This API unsuspends vendor into system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VendorapiSecureMerchantsVendorsUnsuspendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureVendorManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureVendorStatusRequestDTO = new SecureVendorStatusRequestDTO(); // SecureVendorStatusRequestDTO | SecureVendorStatusRequestDTO

            try
            {
                // This API unsuspends vendor into system
                apiInstance.VendorapiSecureMerchantsVendorsUnsuspendPost(xApiKey, xAppKey, xVersion, origin, secureVendorStatusRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsUnsuspendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureMerchantsVendorsUnsuspendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API unsuspends vendor into system
    apiInstance.VendorapiSecureMerchantsVendorsUnsuspendPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureVendorStatusRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVendorManagementApi.VendorapiSecureMerchantsVendorsUnsuspendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureVendorStatusRequestDTO** | [**SecureVendorStatusRequestDTO**](SecureVendorStatusRequestDTO.md) | SecureVendorStatusRequestDTO |  |

### Return type

void (empty response body)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vendor unsuspended successfully |  -  |
| **400** | Bad request or validation error |  -  |
| **404** | Vendor not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

