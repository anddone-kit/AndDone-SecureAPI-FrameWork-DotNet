# Org.OpenAPITools.Api.SecurePaymentsApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurePaymentsExportPost**](SecurePaymentsApi.md#securepaymentsexportpost) | **POST** /secure/payments/export | This API gets Secure payment by search criteria for the merchant. |
| [**SecurePaymentsPost**](SecurePaymentsApi.md#securepaymentspost) | **POST** /secure/payments | This API posts new Secure payment request for the merchant. |
| [**SecurePaymentsSearchPost**](SecurePaymentsApi.md#securepaymentssearchpost) | **POST** /secure/payments/search | This API gets Secure payment by search criteria for the merchant. |
| [**SecurePaymentsdetailsPost**](SecurePaymentsApi.md#securepaymentsdetailspost) | **POST** /secure/paymentsdetails | This API is used for getting details of Payments |

<a id="securepaymentsexportpost"></a>
# **SecurePaymentsExportPost**
> void SecurePaymentsExportPost (string xApiKey, string xAppKey, string origin, string xVersion, Object? adminTransactionSearchCriteria = null, Object? pageInfo = null)

This API gets Secure payment by search criteria for the merchant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentsExportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: Origin
            config.AddApiKey("Origin", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Origin", "Bearer");
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecurePaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var adminTransactionSearchCriteria = new Object?(); // Object? | Transaction search criteria (optional) 
            var pageInfo = new Object?(); // Object? | Set Page Info (optional) 

            try
            {
                // This API gets Secure payment by search criteria for the merchant.
                apiInstance.SecurePaymentsExportPost(xApiKey, xAppKey, origin, xVersion, adminTransactionSearchCriteria, pageInfo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsExportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentsExportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API gets Secure payment by search criteria for the merchant.
    apiInstance.SecurePaymentsExportPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, adminTransactionSearchCriteria, pageInfo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsExportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **xVersion** | **string** | x-version |  |
| **adminTransactionSearchCriteria** | [**Object?**](Object?.md) | Transaction search criteria | [optional]  |
| **pageInfo** | [**Object?**](Object?.md) | Set Page Info | [optional]  |

### Return type

void (empty response body)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation - SSE stream initiated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securepaymentspost"></a>
# **SecurePaymentsPost**
> PaymentDetailsResponse SecurePaymentsPost (string xApiKey, string xAppKey, string origin, string xVersion, SecurePaymentRequest paymentRequest)

This API posts new Secure payment request for the merchant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: Origin
            config.AddApiKey("Origin", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Origin", "Bearer");
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecurePaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var paymentRequest = new SecurePaymentRequest(); // SecurePaymentRequest | payment Detail

            try
            {
                // This API posts new Secure payment request for the merchant.
                PaymentDetailsResponse result = apiInstance.SecurePaymentsPost(xApiKey, xAppKey, origin, xVersion, paymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API posts new Secure payment request for the merchant.
    ApiResponse<PaymentDetailsResponse> response = apiInstance.SecurePaymentsPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, paymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **xVersion** | **string** | x-version |  |
| **paymentRequest** | [**SecurePaymentRequest**](SecurePaymentRequest.md) | payment Detail |  |

### Return type

[**PaymentDetailsResponse**](PaymentDetailsResponse.md)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securepaymentssearchpost"></a>
# **SecurePaymentsSearchPost**
> AdminTransactionEntityResponse SecurePaymentsSearchPost (string xApiKey, string xAppKey, string origin, string xVersion, Object? adminTransactionSearchCriteria = null, Object? pageInfo = null)

This API gets Secure payment by search criteria for the merchant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentsSearchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: Origin
            config.AddApiKey("Origin", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Origin", "Bearer");
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecurePaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var adminTransactionSearchCriteria = new Object?(); // Object? | Transaction search criteria (optional) 
            var pageInfo = new Object?(); // Object? | Set Page Info (optional) 

            try
            {
                // This API gets Secure payment by search criteria for the merchant.
                AdminTransactionEntityResponse result = apiInstance.SecurePaymentsSearchPost(xApiKey, xAppKey, origin, xVersion, adminTransactionSearchCriteria, pageInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API gets Secure payment by search criteria for the merchant.
    ApiResponse<AdminTransactionEntityResponse> response = apiInstance.SecurePaymentsSearchPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, adminTransactionSearchCriteria, pageInfo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **xVersion** | **string** | x-version |  |
| **adminTransactionSearchCriteria** | [**Object?**](Object?.md) | Transaction search criteria | [optional]  |
| **pageInfo** | [**Object?**](Object?.md) | Set Page Info | [optional]  |

### Return type

[**AdminTransactionEntityResponse**](AdminTransactionEntityResponse.md)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securepaymentsdetailspost"></a>
# **SecurePaymentsdetailsPost**
> SecurePaymentDetailsResponse SecurePaymentsdetailsPost (string xApiKey, string xAppKey, string origin, string xVersion, SecurePaymentDetailsRequest securePaymentDetailsRequest)

This API is used for getting details of Payments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentsdetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: Origin
            config.AddApiKey("Origin", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Origin", "Bearer");
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecurePaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var securePaymentDetailsRequest = new SecurePaymentDetailsRequest(); // SecurePaymentDetailsRequest | Payment Details Request

            try
            {
                // This API is used for getting details of Payments
                SecurePaymentDetailsResponse result = apiInstance.SecurePaymentsdetailsPost(xApiKey, xAppKey, origin, xVersion, securePaymentDetailsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsdetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentsdetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for getting details of Payments
    ApiResponse<SecurePaymentDetailsResponse> response = apiInstance.SecurePaymentsdetailsPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, securePaymentDetailsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentsApi.SecurePaymentsdetailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **xVersion** | **string** | x-version |  |
| **securePaymentDetailsRequest** | [**SecurePaymentDetailsRequest**](SecurePaymentDetailsRequest.md) | Payment Details Request |  |

### Return type

[**SecurePaymentDetailsResponse**](SecurePaymentDetailsResponse.md)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

