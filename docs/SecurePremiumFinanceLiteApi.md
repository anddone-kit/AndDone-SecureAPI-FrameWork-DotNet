# Org.OpenAPITools.Api.SecurePremiumFinanceLiteApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureEpfliteQuotesGeneratePost**](SecurePremiumFinanceLiteApi.md#secureepflitequotesgeneratepost) | **POST** /secure/epflite/quotes/generate | This API is used to generate the quote from the provider. |
| [**SecureEpfliteQuotesLinkPost**](SecurePremiumFinanceLiteApi.md#secureepflitequoteslinkpost) | **POST** /secure/epflite/quotes/link | This API will return quotes created againsts a payment link. |
| [**SecureEpfliteQuotesLinktestPost**](SecurePremiumFinanceLiteApi.md#secureepflitequoteslinktestpost) | **POST** /secure/epflite/quotes/linktest | This API will return quotes created againsts a payment link. |
| [**SecureEpfliteQuotesPaymentlinksPost**](SecurePremiumFinanceLiteApi.md#secureepflitequotespaymentlinkspost) | **POST** /secure/epflite/quotes/paymentlinks | This API is used to generate the quote from the provider. |

<a id="secureepflitequotesgeneratepost"></a>
# **SecureEpfliteQuotesGeneratePost**
> PFGenerateQuoteResponse SecureEpfliteQuotesGeneratePost (string xApiKey, string xAppKey, string xVersion, string origin, PFLiteSecureQuoteRequest? pFLiteSecureQuoteRequest = null)

This API is used to generate the quote from the provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfliteQuotesGeneratePostExample
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

            var apiInstance = new SecurePremiumFinanceLiteApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = "xVersion_example";  // string | x-version
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var pFLiteSecureQuoteRequest = new PFLiteSecureQuoteRequest?(); // PFLiteSecureQuoteRequest? | PFLite Quote Secure Request details (optional) 

            try
            {
                // This API is used to generate the quote from the provider.
                PFGenerateQuoteResponse result = apiInstance.SecureEpfliteQuotesGeneratePost(xApiKey, xAppKey, xVersion, origin, pFLiteSecureQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesGeneratePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfliteQuotesGeneratePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used to generate the quote from the provider.
    ApiResponse<PFGenerateQuoteResponse> response = apiInstance.SecureEpfliteQuotesGeneratePostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFLiteSecureQuoteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesGeneratePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **string** | x-version |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **pFLiteSecureQuoteRequest** | [**PFLiteSecureQuoteRequest?**](PFLiteSecureQuoteRequest?.md) | PFLite Quote Secure Request details | [optional]  |

### Return type

[**PFGenerateQuoteResponse**](PFGenerateQuoteResponse.md)

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

<a id="secureepflitequoteslinkpost"></a>
# **SecureEpfliteQuotesLinkPost**
> List&lt;PFLiteQuoteByPaymentLinkResponse&gt; SecureEpfliteQuotesLinkPost (string xApiKey, string xAppKey, string xVersion, string origin, PFLiteGetQuoteRequest? pFLiteGetQuoteRequest = null)

This API will return quotes created againsts a payment link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfliteQuotesLinkPostExample
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

            var apiInstance = new SecurePremiumFinanceLiteApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = "xVersion_example";  // string | x-version
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var pFLiteGetQuoteRequest = new PFLiteGetQuoteRequest?(); // PFLiteGetQuoteRequest? | Signature Request details (optional) 

            try
            {
                // This API will return quotes created againsts a payment link.
                List<PFLiteQuoteByPaymentLinkResponse> result = apiInstance.SecureEpfliteQuotesLinkPost(xApiKey, xAppKey, xVersion, origin, pFLiteGetQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesLinkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfliteQuotesLinkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will return quotes created againsts a payment link.
    ApiResponse<List<PFLiteQuoteByPaymentLinkResponse>> response = apiInstance.SecureEpfliteQuotesLinkPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFLiteGetQuoteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesLinkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **string** | x-version |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **pFLiteGetQuoteRequest** | [**PFLiteGetQuoteRequest?**](PFLiteGetQuoteRequest?.md) | Signature Request details | [optional]  |

### Return type

[**List&lt;PFLiteQuoteByPaymentLinkResponse&gt;**](PFLiteQuoteByPaymentLinkResponse.md)

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

<a id="secureepflitequoteslinktestpost"></a>
# **SecureEpfliteQuotesLinktestPost**
> List&lt;PFLiteQuoteByPaymentLinkResponse&gt; SecureEpfliteQuotesLinktestPost (string xApiKey, string xAppKey, string xVersion, string origin, PFLiteGetQuoteRequest? pFLiteGetQuoteRequest = null)

This API will return quotes created againsts a payment link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfliteQuotesLinktestPostExample
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

            var apiInstance = new SecurePremiumFinanceLiteApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = "xVersion_example";  // string | x-version
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var pFLiteGetQuoteRequest = new PFLiteGetQuoteRequest?(); // PFLiteGetQuoteRequest? | Signature Request details (optional) 

            try
            {
                // This API will return quotes created againsts a payment link.
                List<PFLiteQuoteByPaymentLinkResponse> result = apiInstance.SecureEpfliteQuotesLinktestPost(xApiKey, xAppKey, xVersion, origin, pFLiteGetQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesLinktestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfliteQuotesLinktestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will return quotes created againsts a payment link.
    ApiResponse<List<PFLiteQuoteByPaymentLinkResponse>> response = apiInstance.SecureEpfliteQuotesLinktestPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFLiteGetQuoteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesLinktestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **string** | x-version |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **pFLiteGetQuoteRequest** | [**PFLiteGetQuoteRequest?**](PFLiteGetQuoteRequest?.md) | Signature Request details | [optional]  |

### Return type

[**List&lt;PFLiteQuoteByPaymentLinkResponse&gt;**](PFLiteQuoteByPaymentLinkResponse.md)

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

<a id="secureepflitequotespaymentlinkspost"></a>
# **SecureEpfliteQuotesPaymentlinksPost**
> List&lt;PaymentLinkResponse&gt; SecureEpfliteQuotesPaymentlinksPost (string xApiKey, string xAppKey, string xVersion, string origin, PFLitePaymentLinkRequest? pFLitePaymentLinkRequest = null)

This API is used to generate the quote from the provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfliteQuotesPaymentlinksPostExample
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

            var apiInstance = new SecurePremiumFinanceLiteApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = "xVersion_example";  // string | x-version
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var pFLitePaymentLinkRequest = new PFLitePaymentLinkRequest?(); // PFLitePaymentLinkRequest? | PFlite PaymentLink Request Details (optional) 

            try
            {
                // This API is used to generate the quote from the provider.
                List<PaymentLinkResponse> result = apiInstance.SecureEpfliteQuotesPaymentlinksPost(xApiKey, xAppKey, xVersion, origin, pFLitePaymentLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesPaymentlinksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfliteQuotesPaymentlinksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used to generate the quote from the provider.
    ApiResponse<List<PaymentLinkResponse>> response = apiInstance.SecureEpfliteQuotesPaymentlinksPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, pFLitePaymentLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePremiumFinanceLiteApi.SecureEpfliteQuotesPaymentlinksPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **string** | x-version |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **pFLitePaymentLinkRequest** | [**PFLitePaymentLinkRequest?**](PFLitePaymentLinkRequest?.md) | PFlite PaymentLink Request Details | [optional]  |

### Return type

[**List&lt;PaymentLinkResponse&gt;**](PaymentLinkResponse.md)

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

