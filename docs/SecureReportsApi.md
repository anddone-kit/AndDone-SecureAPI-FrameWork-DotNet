# Org.OpenAPITools.Api.SecureReportsApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureReportsDownloadsPost**](SecureReportsApi.md#securereportsdownloadspost) | **POST** /secure/reports/downloads | This API will add system report. |

<a id="securereportsdownloadspost"></a>
# **SecureReportsDownloadsPost**
> void SecureReportsDownloadsPost (string xApiKey, string xAppKey, float xVersion, string origin, ReportDownloadRequest? reportDownloadRequest = null)

This API will add system report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureReportsDownloadsPostExample
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

            var apiInstance = new SecureReportsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var reportDownloadRequest = new ReportDownloadRequest?(); // ReportDownloadRequest? | ReportDownloadRequest (optional) 

            try
            {
                // This API will add system report.
                apiInstance.SecureReportsDownloadsPost(xApiKey, xAppKey, xVersion, origin, reportDownloadRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureReportsApi.SecureReportsDownloadsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureReportsDownloadsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will add system report.
    apiInstance.SecureReportsDownloadsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, reportDownloadRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureReportsApi.SecureReportsDownloadsPostWithHttpInfo: " + e.Message);
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
| **reportDownloadRequest** | [**ReportDownloadRequest?**](ReportDownloadRequest?.md) | ReportDownloadRequest | [optional]  |

### Return type

void (empty response body)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful CSV file download |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

