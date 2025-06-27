# Org.OpenAPITools.Api.SecureRefundsApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureRefundsEligibilityPost**](SecureRefundsApi.md#securerefundseligibilitypost) | **POST** /secure/refunds/eligibility | This API return refund eligibility of a transaction. |
| [**SecureRefundsPost**](SecureRefundsApi.md#securerefundspost) | **POST** /secure/refunds | This API will refund a transaction which has been settled by the processor. |

<a id="securerefundseligibilitypost"></a>
# **SecureRefundsEligibilityPost**
> RefundEligibility SecureRefundsEligibilityPost (string xApiKey, string xAppKey, float xVersion, string origin, TransactionRefundEligibilityRequest transactionRefundEligibilityRequest)

This API return refund eligibility of a transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureRefundsEligibilityPostExample
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

            var apiInstance = new SecureRefundsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var transactionRefundEligibilityRequest = new TransactionRefundEligibilityRequest(); // TransactionRefundEligibilityRequest | refund Detail

            try
            {
                // This API return refund eligibility of a transaction.
                RefundEligibility result = apiInstance.SecureRefundsEligibilityPost(xApiKey, xAppKey, xVersion, origin, transactionRefundEligibilityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureRefundsApi.SecureRefundsEligibilityPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureRefundsEligibilityPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API return refund eligibility of a transaction.
    ApiResponse<RefundEligibility> response = apiInstance.SecureRefundsEligibilityPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, transactionRefundEligibilityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureRefundsApi.SecureRefundsEligibilityPostWithHttpInfo: " + e.Message);
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
| **transactionRefundEligibilityRequest** | [**TransactionRefundEligibilityRequest**](TransactionRefundEligibilityRequest.md) | refund Detail |  |

### Return type

[**RefundEligibility**](RefundEligibility.md)

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

<a id="securerefundspost"></a>
# **SecureRefundsPost**
> SecureTransactionDetailDTO SecureRefundsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureTransactionRefundRequest secureTransactionRefundRequest)

This API will refund a transaction which has been settled by the processor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureRefundsPostExample
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

            var apiInstance = new SecureRefundsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureTransactionRefundRequest = new SecureTransactionRefundRequest(); // SecureTransactionRefundRequest | Refund Detail

            try
            {
                // This API will refund a transaction which has been settled by the processor.
                SecureTransactionDetailDTO result = apiInstance.SecureRefundsPost(xApiKey, xAppKey, xVersion, origin, secureTransactionRefundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureRefundsApi.SecureRefundsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureRefundsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will refund a transaction which has been settled by the processor.
    ApiResponse<SecureTransactionDetailDTO> response = apiInstance.SecureRefundsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureTransactionRefundRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureRefundsApi.SecureRefundsPostWithHttpInfo: " + e.Message);
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
| **secureTransactionRefundRequest** | [**SecureTransactionRefundRequest**](SecureTransactionRefundRequest.md) | Refund Detail |  |

### Return type

[**SecureTransactionDetailDTO**](SecureTransactionDetailDTO.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

