# Org.OpenAPITools.Api.SecureEmbeddedPremiumFinanceEndorsementsApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureEpfEndorsementsPost**](SecureEmbeddedPremiumFinanceEndorsementsApi.md#secureepfendorsementspost) | **POST** /secure/epf/endorsements | This API will do a check of eligibility of account |
| [**SecureEpfQuoteEndorsementBookingPut**](SecureEmbeddedPremiumFinanceEndorsementsApi.md#secureepfquoteendorsementbookingput) | **PUT** /secure/epf/quote/endorsement/booking | This API will update PFA to book a endorsement quote. |
| [**SecureEpfQuoteEndorsementPost**](SecureEmbeddedPremiumFinanceEndorsementsApi.md#secureepfquoteendorsementpost) | **POST** /secure/epf/quote/endorsement | This API will do return a quote for an existing policy or new policy for an existing account |

<a id="secureepfendorsementspost"></a>
# **SecureEpfEndorsementsPost**
> PFCheckEndorsementsResponse SecureEpfEndorsementsPost (string xApiKey, string xAppKey, float xVersion, string origin, PFCheckEndorsementsRequest pFCheckEndorsementsRequest)

This API will do a check of eligibility of account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfEndorsementsPostExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceEndorsementsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var pFCheckEndorsementsRequest = new PFCheckEndorsementsRequest(); // PFCheckEndorsementsRequest | PF Check Endorsement Request details

            try
            {
                // This API will do a check of eligibility of account
                PFCheckEndorsementsResponse result = apiInstance.SecureEpfEndorsementsPost(xApiKey, xAppKey, xVersion, origin, pFCheckEndorsementsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi.SecureEpfEndorsementsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfEndorsementsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will do a check of eligibility of account
    ApiResponse<PFCheckEndorsementsResponse> response = apiInstance.SecureEpfEndorsementsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFCheckEndorsementsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi.SecureEpfEndorsementsPostWithHttpInfo: " + e.Message);
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
| **pFCheckEndorsementsRequest** | [**PFCheckEndorsementsRequest**](PFCheckEndorsementsRequest.md) | PF Check Endorsement Request details |  |

### Return type

[**PFCheckEndorsementsResponse**](PFCheckEndorsementsResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="secureepfquoteendorsementbookingput"></a>
# **SecureEpfQuoteEndorsementBookingPut**
> PFUpdatePFAResponse SecureEpfQuoteEndorsementBookingPut (string xApiKey, string xAppKey, float xVersion, string origin, PFQuoteBookingRequest pFQuoteBookingRequest)

This API will update PFA to book a endorsement quote.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfQuoteEndorsementBookingPutExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceEndorsementsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var pFQuoteBookingRequest = new PFQuoteBookingRequest(); // PFQuoteBookingRequest | PFQuoteBooking Request details

            try
            {
                // This API will update PFA to book a endorsement quote.
                PFUpdatePFAResponse result = apiInstance.SecureEpfQuoteEndorsementBookingPut(xApiKey, xAppKey, xVersion, origin, pFQuoteBookingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi.SecureEpfQuoteEndorsementBookingPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfQuoteEndorsementBookingPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will update PFA to book a endorsement quote.
    ApiResponse<PFUpdatePFAResponse> response = apiInstance.SecureEpfQuoteEndorsementBookingPutWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFQuoteBookingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi.SecureEpfQuoteEndorsementBookingPutWithHttpInfo: " + e.Message);
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
| **pFQuoteBookingRequest** | [**PFQuoteBookingRequest**](PFQuoteBookingRequest.md) | PFQuoteBooking Request details |  |

### Return type

[**PFUpdatePFAResponse**](PFUpdatePFAResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="secureepfquoteendorsementpost"></a>
# **SecureEpfQuoteEndorsementPost**
> PFEndorsementResponse SecureEpfQuoteEndorsementPost (string xApiKey, string xAppKey, float xVersion, string origin, PFEndorsementRequest pFEndorsementRequest)

This API will do return a quote for an existing policy or new policy for an existing account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfQuoteEndorsementPostExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceEndorsementsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var pFEndorsementRequest = new PFEndorsementRequest(); // PFEndorsementRequest | PF Endorsement Request details

            try
            {
                // This API will do return a quote for an existing policy or new policy for an existing account
                PFEndorsementResponse result = apiInstance.SecureEpfQuoteEndorsementPost(xApiKey, xAppKey, xVersion, origin, pFEndorsementRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi.SecureEpfQuoteEndorsementPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfQuoteEndorsementPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will do return a quote for an existing policy or new policy for an existing account
    ApiResponse<PFEndorsementResponse> response = apiInstance.SecureEpfQuoteEndorsementPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFEndorsementRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi.SecureEpfQuoteEndorsementPostWithHttpInfo: " + e.Message);
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
| **pFEndorsementRequest** | [**PFEndorsementRequest**](PFEndorsementRequest.md) | PF Endorsement Request details |  |

### Return type

[**PFEndorsementResponse**](PFEndorsementResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

