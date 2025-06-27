# Org.OpenAPITools.Api.SecureEmbeddedPremiumFinanceApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureEpfMerchantsQuotesPolicyPut**](SecureEmbeddedPremiumFinanceApi.md#secureepfmerchantsquotespolicyput) | **PUT** /secure/epf/merchants/quotes/policy | This API is will update the policy number |
| [**SecureEpfQuotesBookingPut**](SecureEmbeddedPremiumFinanceApi.md#secureepfquotesbookingput) | **PUT** /secure/epf/quotes/booking | This API will update PFA to book a quote. |
| [**SecureEpfQuotesCaptureesignPut**](SecureEmbeddedPremiumFinanceApi.md#secureepfquotescaptureesignput) | **PUT** /secure/epf/quotes/captureesign | This API will eSign the pfa with insured name. |
| [**SecureEpfQuotesGeneratePost**](SecureEmbeddedPremiumFinanceApi.md#secureepfquotesgeneratepost) | **POST** /secure/epf/quotes/generate | This API is used to Generate Quotes |
| [**SecureEpfQuotesIntentPost**](SecureEmbeddedPremiumFinanceApi.md#secureepfquotesintentpost) | **POST** /secure/epf/quotes/intent | This API will return quotes created againsts a payment intent. |
| [**SecureEpfQuotesPost**](SecureEmbeddedPremiumFinanceApi.md#secureepfquotespost) | **POST** /secure/epf/quotes | This API will return quote by QuoteKey. |
| [**SecureEpfRetrievepfaPost**](SecureEmbeddedPremiumFinanceApi.md#secureepfretrievepfapost) | **POST** /secure/epf/retrievepfa | This API will return PFA for given quoteKey. |

<a id="secureepfmerchantsquotespolicyput"></a>
# **SecureEpfMerchantsQuotesPolicyPut**
> PFPolicyUpdateResponse SecureEpfMerchantsQuotesPolicyPut (string xApiKey, string xAppKey, float xVersion, string origin, PFPolicyUpdateRequestDTO? pFPolicyUpdateRequestDTO = null)

This API is will update the policy number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfMerchantsQuotesPolicyPutExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var pFPolicyUpdateRequestDTO = new PFPolicyUpdateRequestDTO?(); // PFPolicyUpdateRequestDTO? | Signature Request details (optional) 

            try
            {
                // This API is will update the policy number
                PFPolicyUpdateResponse result = apiInstance.SecureEpfMerchantsQuotesPolicyPut(xApiKey, xAppKey, xVersion, origin, pFPolicyUpdateRequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfMerchantsQuotesPolicyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfMerchantsQuotesPolicyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is will update the policy number
    ApiResponse<PFPolicyUpdateResponse> response = apiInstance.SecureEpfMerchantsQuotesPolicyPutWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFPolicyUpdateRequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfMerchantsQuotesPolicyPutWithHttpInfo: " + e.Message);
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
| **pFPolicyUpdateRequestDTO** | [**PFPolicyUpdateRequestDTO?**](PFPolicyUpdateRequestDTO?.md) | Signature Request details | [optional]  |

### Return type

[**PFPolicyUpdateResponse**](PFPolicyUpdateResponse.md)

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

<a id="secureepfquotesbookingput"></a>
# **SecureEpfQuotesBookingPut**
> PFUpdatePFAResponse SecureEpfQuotesBookingPut (string xApiKey, string xAppKey, float xVersion, string origin, PFQuoteBookingRequest pFQuoteBookingRequest)

This API will update PFA to book a quote.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfQuotesBookingPutExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var pFQuoteBookingRequest = new PFQuoteBookingRequest(); // PFQuoteBookingRequest | PFQuoteBooking Request details

            try
            {
                // This API will update PFA to book a quote.
                PFUpdatePFAResponse result = apiInstance.SecureEpfQuotesBookingPut(xApiKey, xAppKey, xVersion, origin, pFQuoteBookingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesBookingPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfQuotesBookingPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will update PFA to book a quote.
    ApiResponse<PFUpdatePFAResponse> response = apiInstance.SecureEpfQuotesBookingPutWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFQuoteBookingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesBookingPutWithHttpInfo: " + e.Message);
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

<a id="secureepfquotescaptureesignput"></a>
# **SecureEpfQuotesCaptureesignPut**
> void SecureEpfQuotesCaptureesignPut (string xApiKey, string xAppKey, float xVersion, string origin, PFQuoteEsignRequest? pFQuoteEsignRequest = null)

This API will eSign the pfa with insured name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfQuotesCaptureesignPutExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var pFQuoteEsignRequest = new PFQuoteEsignRequest?(); // PFQuoteEsignRequest? | PFQuote Request (optional) 

            try
            {
                // This API will eSign the pfa with insured name.
                apiInstance.SecureEpfQuotesCaptureesignPut(xApiKey, xAppKey, xVersion, origin, pFQuoteEsignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesCaptureesignPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfQuotesCaptureesignPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will eSign the pfa with insured name.
    apiInstance.SecureEpfQuotesCaptureesignPutWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFQuoteEsignRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesCaptureesignPutWithHttpInfo: " + e.Message);
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
| **pFQuoteEsignRequest** | [**PFQuoteEsignRequest?**](PFQuoteEsignRequest?.md) | PFQuote Request | [optional]  |

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
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="secureepfquotesgeneratepost"></a>
# **SecureEpfQuotesGeneratePost**
> List&lt;PFGenerateQuoteResponse&gt; SecureEpfQuotesGeneratePost (string xApiKey, string xAppKey, float xVersion, string origin, QuoteRequest? quoteRequest = null)

This API is used to Generate Quotes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfQuotesGeneratePostExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var quoteRequest = new QuoteRequest?(); // QuoteRequest? | Quote Request (optional) 

            try
            {
                // This API is used to Generate Quotes
                List<PFGenerateQuoteResponse> result = apiInstance.SecureEpfQuotesGeneratePost(xApiKey, xAppKey, xVersion, origin, quoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesGeneratePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfQuotesGeneratePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used to Generate Quotes
    ApiResponse<List<PFGenerateQuoteResponse>> response = apiInstance.SecureEpfQuotesGeneratePostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, quoteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesGeneratePostWithHttpInfo: " + e.Message);
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
| **quoteRequest** | [**QuoteRequest?**](QuoteRequest?.md) | Quote Request | [optional]  |

### Return type

[**List&lt;PFGenerateQuoteResponse&gt;**](PFGenerateQuoteResponse.md)

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

<a id="secureepfquotesintentpost"></a>
# **SecureEpfQuotesIntentPost**
> List&lt;QuoteResponse&gt; SecureEpfQuotesIntentPost (string xApiKey, string xAppKey, float xVersion, string origin, GetQuoteRequest? getQuoteRequest = null)

This API will return quotes created againsts a payment intent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfQuotesIntentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var getQuoteRequest = new GetQuoteRequest?(); // GetQuoteRequest? | Signature Request details (optional) 

            try
            {
                // This API will return quotes created againsts a payment intent.
                List<QuoteResponse> result = apiInstance.SecureEpfQuotesIntentPost(xApiKey, xAppKey, xVersion, origin, getQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesIntentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfQuotesIntentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will return quotes created againsts a payment intent.
    ApiResponse<List<QuoteResponse>> response = apiInstance.SecureEpfQuotesIntentPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, getQuoteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesIntentPostWithHttpInfo: " + e.Message);
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
| **getQuoteRequest** | [**GetQuoteRequest?**](GetQuoteRequest?.md) | Signature Request details | [optional]  |

### Return type

[**List&lt;QuoteResponse&gt;**](QuoteResponse.md)

### Authorization

No authorization required

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

<a id="secureepfquotespost"></a>
# **SecureEpfQuotesPost**
> QuoteResponse SecureEpfQuotesPost (string xApiKey, string xAppKey, float xVersion, string origin, GetQuoteKeyRequest? getQuoteKeyRequest = null)

This API will return quote by QuoteKey.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfQuotesPostExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var getQuoteKeyRequest = new GetQuoteKeyRequest?(); // GetQuoteKeyRequest? | Signature Request details (optional) 

            try
            {
                // This API will return quote by QuoteKey.
                QuoteResponse result = apiInstance.SecureEpfQuotesPost(xApiKey, xAppKey, xVersion, origin, getQuoteKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfQuotesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will return quote by QuoteKey.
    ApiResponse<QuoteResponse> response = apiInstance.SecureEpfQuotesPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, getQuoteKeyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfQuotesPostWithHttpInfo: " + e.Message);
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
| **getQuoteKeyRequest** | [**GetQuoteKeyRequest?**](GetQuoteKeyRequest?.md) | Signature Request details | [optional]  |

### Return type

[**QuoteResponse**](QuoteResponse.md)

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

<a id="secureepfretrievepfapost"></a>
# **SecureEpfRetrievepfaPost**
> string SecureEpfRetrievepfaPost (string xApiKey, string xAppKey, float xVersion, string origin, PFRetrievePFARequestDTO? pFRetrievePFARequestDTO = null)

This API will return PFA for given quoteKey.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfRetrievepfaPostExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var pFRetrievePFARequestDTO = new PFRetrievePFARequestDTO?(); // PFRetrievePFARequestDTO? | PFRetrieve PFA Request (optional) 

            try
            {
                // This API will return PFA for given quoteKey.
                string result = apiInstance.SecureEpfRetrievepfaPost(xApiKey, xAppKey, xVersion, origin, pFRetrievePFARequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfRetrievepfaPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfRetrievepfaPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will return PFA for given quoteKey.
    ApiResponse<string> response = apiInstance.SecureEpfRetrievepfaPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFRetrievePFARequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureEpfRetrievepfaPostWithHttpInfo: " + e.Message);
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
| **pFRetrievePFARequestDTO** | [**PFRetrievePFARequestDTO?**](PFRetrievePFARequestDTO?.md) | PFRetrieve PFA Request | [optional]  |

### Return type

**string**

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

