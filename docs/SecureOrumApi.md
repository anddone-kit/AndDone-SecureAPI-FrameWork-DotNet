# Org.OpenAPITools.Api.SecureOrumApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureBankaccountsDetailsPost**](SecureOrumApi.md#securebankaccountsdetailspost) | **POST** /secure/bankaccounts/details | This API will request for verified bank account. |
| [**SecureBankaccountsVerifyPost**](SecureOrumApi.md#securebankaccountsverifypost) | **POST** /secure/bankaccounts/verify | This API will request for account verification. |

<a id="securebankaccountsdetailspost"></a>
# **SecureBankaccountsDetailsPost**
> List&lt;VerifyBankAccountResponse&gt; SecureBankaccountsDetailsPost (string xApiKey, string xAppKey, float xVersion, string origin, string? id = null, string? type = null, VerificationEntityRequest? verificationEntityRequest = null)

This API will request for verified bank account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureBankaccountsDetailsPostExample
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

            var apiInstance = new SecureOrumApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var id = "id_example";  // string? | The Bank Account Entity Id (optional) 
            var type = "None";  // string? | Set Type (optional) 
            var verificationEntityRequest = new VerificationEntityRequest?(); // VerificationEntityRequest? | Verification Entity (optional) 

            try
            {
                // This API will request for verified bank account.
                List<VerifyBankAccountResponse> result = apiInstance.SecureBankaccountsDetailsPost(xApiKey, xAppKey, xVersion, origin, id, type, verificationEntityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOrumApi.SecureBankaccountsDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureBankaccountsDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will request for verified bank account.
    ApiResponse<List<VerifyBankAccountResponse>> response = apiInstance.SecureBankaccountsDetailsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, id, type, verificationEntityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOrumApi.SecureBankaccountsDetailsPostWithHttpInfo: " + e.Message);
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
| **id** | **string?** | The Bank Account Entity Id | [optional]  |
| **type** | **string?** | Set Type | [optional]  |
| **verificationEntityRequest** | [**VerificationEntityRequest?**](VerificationEntityRequest?.md) | Verification Entity | [optional]  |

### Return type

[**List&lt;VerifyBankAccountResponse&gt;**](VerifyBankAccountResponse.md)

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

<a id="securebankaccountsverifypost"></a>
# **SecureBankaccountsVerifyPost**
> List&lt;VerifyBankAccountResponse&gt; SecureBankaccountsVerifyPost (string xApiKey, string xAppKey, float xVersion, string origin, VerifyBankAccountRequest? verifyBankAccountRequest = null)

This API will request for account verification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureBankaccountsVerifyPostExample
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

            var apiInstance = new SecureOrumApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var verifyBankAccountRequest = new VerifyBankAccountRequest?(); // VerifyBankAccountRequest? | Bank Accout detals (optional) 

            try
            {
                // This API will request for account verification.
                List<VerifyBankAccountResponse> result = apiInstance.SecureBankaccountsVerifyPost(xApiKey, xAppKey, xVersion, origin, verifyBankAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOrumApi.SecureBankaccountsVerifyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureBankaccountsVerifyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will request for account verification.
    ApiResponse<List<VerifyBankAccountResponse>> response = apiInstance.SecureBankaccountsVerifyPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, verifyBankAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOrumApi.SecureBankaccountsVerifyPostWithHttpInfo: " + e.Message);
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
| **verifyBankAccountRequest** | [**VerifyBankAccountRequest?**](VerifyBankAccountRequest?.md) | Bank Accout detals | [optional]  |

### Return type

[**List&lt;VerifyBankAccountResponse&gt;**](VerifyBankAccountResponse.md)

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

