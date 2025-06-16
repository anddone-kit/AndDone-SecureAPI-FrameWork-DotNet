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
> void SecurePaymentsExportPost (string xApiKey, string xAppKey, float xVersion, string origin, string? startDate = null, string? endDate = null, string? transactionIds = null, string? referenceTransactionId = null, string? transactionStatuses = null, string? customerIds = null, string? transactionType = null, string? authCode = null, string? cardHolderName = null, string? shopperName = null, float? amount = null, float? fromAmount = null, float? toAmount = null, string? channelTypes = null, string? maskAccount = null, string? customerName = null, string? recurringId = null, string? referenceNo = null, bool? exportToCsv = null, bool? exportToPDF = null, string? transactionOrigins = null, string? transactionSourceType = null, float? sourceId = null, string? traceNumbers = null, string? binNumber = null, string? processMethod = null, string? searchText = null, string? merchantReference = null, string? additionalFields = null, string? additionalFieldValue = null, string? paymentMethod = null, string? accountAlias = null, bool? isPaid = null, string? paymentTypes = null, string? merchantId = null, string? paymentCategories = null, bool? suppressTechnologyFee = null, string? batchId = null, string? sortField = null, int? startRow = null, float? pageSize = null, bool? asc = null)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var startDate = "startDate_example";  // string? | Start date for the transaction search (optional) 
            var endDate = "endDate_example";  // string? | End date for the transaction search (optional) 
            var transactionIds = "transactionIds_example";  // string? | Transaction identifier (optional) 
            var referenceTransactionId = "referenceTransactionId_example";  // string? | Reference transaction identifier (optional) 
            var transactionStatuses = "transactionStatuses_example";  // string? | Status of the transaction (optional) 
            var customerIds = "customerIds_example";  // string? | Customer IDs associated with the transaction (optional) 
            var transactionType = "Sale";  // string? | Type of the transaction (optional) 
            var authCode = "authCode_example";  // string? | Authorization code of the transaction (optional) 
            var cardHolderName = "cardHolderName_example";  // string? | Name of the cardholder (optional) 
            var shopperName = "shopperName_example";  // string? | ShopperName of the cardholder (optional) 
            var amount = 8.14D;  // float? | Transaction amount (optional) 
            var fromAmount = 8.14D;  // float? | Minimum transaction amount (optional) 
            var toAmount = 8.14D;  // float? | Maximum transaction amount (optional) 
            var channelTypes = "channelTypes_example";  // string? | Channel types used for the transaction (optional) 
            var maskAccount = "maskAccount_example";  // string? | Masked account number (optional) 
            var customerName = "customerName_example";  // string? | Name of the customer (optional) 
            var recurringId = "recurringId_example";  // string? | Recurring payment ID (optional) 
            var referenceNo = "referenceNo_example";  // string? | Reference number (optional) 
            var exportToCsv = true;  // bool? | Export To Csv (optional) 
            var exportToPDF = true;  // bool? | Export To PDF (optional) 
            var transactionOrigins = "transactionOrigins_example";  // string? | Type of origin used in the transaction (optional) 
            var transactionSourceType = "Independent";  // string? | Transaction source type of the transaction (optional) 
            var sourceId = 8.14D;  // float? | Set SourceId (optional) 
            var traceNumbers = "traceNumbers_example";  // string? | TraceNumbers associated with the transaction (optional) 
            var binNumber = "binNumber_example";  // string? | BinNumber (optional) 
            var processMethod = "NotDefined";  // string? | Process Method used for the transaction (optional) 
            var searchText = "searchText_example";  // string? | SearchText of the transaction (optional) 
            var merchantReference = "merchantReference_example";  // string? | Merchant Reference of the transaction (optional) 
            var additionalFields = "additionalFields_example";  // string? | Additional Fields (optional) 
            var additionalFieldValue = "additionalFieldValue_example";  // string? | AdditionalFieldValue (optional) 
            var paymentMethod = "paymentMethod_example";  // string? | Payment Method (optional) 
            var accountAlias = "accountAlias_example";  // string? | Set AccountAlias (optional) 
            var isPaid = true;  // bool? | Set IsPaid (optional) 
            var paymentTypes = "paymentTypes_example";  // string? | Type of payment used in the transaction (optional) 
            var merchantId = "merchantId_example";  // string? | Search with Merchant Id (optional) 
            var paymentCategories = "paymentCategories_example";  // string? | Set PaymentCategories (optional) 
            var suppressTechnologyFee = true;  // bool? | SuppressTechnologyFee (optional) 
            var batchId = "batchId_example";  // string? | BatchId (optional) 
            var sortField = "sortField_example";  // string? | SortField (optional) 
            var startRow = 56;  // int? | Set StartRow (optional) 
            var pageSize = 8.14D;  // float? | Set PageSize (optional) 
            var asc = true;  // bool? | Set Asc (optional) 

            try
            {
                // This API gets Secure payment by search criteria for the merchant.
                apiInstance.SecurePaymentsExportPost(xApiKey, xAppKey, xVersion, origin, startDate, endDate, transactionIds, referenceTransactionId, transactionStatuses, customerIds, transactionType, authCode, cardHolderName, shopperName, amount, fromAmount, toAmount, channelTypes, maskAccount, customerName, recurringId, referenceNo, exportToCsv, exportToPDF, transactionOrigins, transactionSourceType, sourceId, traceNumbers, binNumber, processMethod, searchText, merchantReference, additionalFields, additionalFieldValue, paymentMethod, accountAlias, isPaid, paymentTypes, merchantId, paymentCategories, suppressTechnologyFee, batchId, sortField, startRow, pageSize, asc);
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
    apiInstance.SecurePaymentsExportPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, startDate, endDate, transactionIds, referenceTransactionId, transactionStatuses, customerIds, transactionType, authCode, cardHolderName, shopperName, amount, fromAmount, toAmount, channelTypes, maskAccount, customerName, recurringId, referenceNo, exportToCsv, exportToPDF, transactionOrigins, transactionSourceType, sourceId, traceNumbers, binNumber, processMethod, searchText, merchantReference, additionalFields, additionalFieldValue, paymentMethod, accountAlias, isPaid, paymentTypes, merchantId, paymentCategories, suppressTechnologyFee, batchId, sortField, startRow, pageSize, asc);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **startDate** | **string?** | Start date for the transaction search | [optional]  |
| **endDate** | **string?** | End date for the transaction search | [optional]  |
| **transactionIds** | **string?** | Transaction identifier | [optional]  |
| **referenceTransactionId** | **string?** | Reference transaction identifier | [optional]  |
| **transactionStatuses** | **string?** | Status of the transaction | [optional]  |
| **customerIds** | **string?** | Customer IDs associated with the transaction | [optional]  |
| **transactionType** | **string?** | Type of the transaction | [optional]  |
| **authCode** | **string?** | Authorization code of the transaction | [optional]  |
| **cardHolderName** | **string?** | Name of the cardholder | [optional]  |
| **shopperName** | **string?** | ShopperName of the cardholder | [optional]  |
| **amount** | **float?** | Transaction amount | [optional]  |
| **fromAmount** | **float?** | Minimum transaction amount | [optional]  |
| **toAmount** | **float?** | Maximum transaction amount | [optional]  |
| **channelTypes** | **string?** | Channel types used for the transaction | [optional]  |
| **maskAccount** | **string?** | Masked account number | [optional]  |
| **customerName** | **string?** | Name of the customer | [optional]  |
| **recurringId** | **string?** | Recurring payment ID | [optional]  |
| **referenceNo** | **string?** | Reference number | [optional]  |
| **exportToCsv** | **bool?** | Export To Csv | [optional]  |
| **exportToPDF** | **bool?** | Export To PDF | [optional]  |
| **transactionOrigins** | **string?** | Type of origin used in the transaction | [optional]  |
| **transactionSourceType** | **string?** | Transaction source type of the transaction | [optional]  |
| **sourceId** | **float?** | Set SourceId | [optional]  |
| **traceNumbers** | **string?** | TraceNumbers associated with the transaction | [optional]  |
| **binNumber** | **string?** | BinNumber | [optional]  |
| **processMethod** | **string?** | Process Method used for the transaction | [optional]  |
| **searchText** | **string?** | SearchText of the transaction | [optional]  |
| **merchantReference** | **string?** | Merchant Reference of the transaction | [optional]  |
| **additionalFields** | **string?** | Additional Fields | [optional]  |
| **additionalFieldValue** | **string?** | AdditionalFieldValue | [optional]  |
| **paymentMethod** | **string?** | Payment Method | [optional]  |
| **accountAlias** | **string?** | Set AccountAlias | [optional]  |
| **isPaid** | **bool?** | Set IsPaid | [optional]  |
| **paymentTypes** | **string?** | Type of payment used in the transaction | [optional]  |
| **merchantId** | **string?** | Search with Merchant Id | [optional]  |
| **paymentCategories** | **string?** | Set PaymentCategories | [optional]  |
| **suppressTechnologyFee** | **bool?** | SuppressTechnologyFee | [optional]  |
| **batchId** | **string?** | BatchId | [optional]  |
| **sortField** | **string?** | SortField | [optional]  |
| **startRow** | **int?** | Set StartRow | [optional]  |
| **pageSize** | **float?** | Set PageSize | [optional]  |
| **asc** | **bool?** | Set Asc | [optional]  |

### Return type

void (empty response body)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation - SSE stream initiated |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securepaymentspost"></a>
# **SecurePaymentsPost**
> TransactionDetailResponse SecurePaymentsPost (string xApiKey, string xAppKey, float xVersion, string origin, PaymentRequest paymentRequest)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentRequest = new PaymentRequest(); // PaymentRequest | Payment Detail

            try
            {
                // This API posts new Secure payment request for the merchant.
                TransactionDetailResponse result = apiInstance.SecurePaymentsPost(xApiKey, xAppKey, xVersion, origin, paymentRequest);
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
    ApiResponse<TransactionDetailResponse> response = apiInstance.SecurePaymentsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentRequest);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **paymentRequest** | [**PaymentRequest**](PaymentRequest.md) | Payment Detail |  |

### Return type

[**TransactionDetailResponse**](TransactionDetailResponse.md)

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

<a id="securepaymentssearchpost"></a>
# **SecurePaymentsSearchPost**
> MerchantTransactionEntityResponse SecurePaymentsSearchPost (string xApiKey, string xAppKey, float xVersion, string origin, string? startDate = null, string? endDate = null, string? transactionIds = null, string? referenceTransactionId = null, string? transactionStatuses = null, string? customerIds = null, string? transactionType = null, string? authCode = null, string? cardHolderName = null, string? shopperName = null, float? amount = null, float? fromAmount = null, float? toAmount = null, string? channelTypes = null, string? maskAccount = null, string? customerName = null, string? recurringId = null, string? referenceNo = null, bool? exportToCsv = null, bool? exportToPDF = null, string? transactionOrigins = null, string? transactionSourceType = null, float? sourceId = null, string? traceNumbers = null, string? binNumber = null, string? processMethod = null, string? searchText = null, string? merchantReference = null, string? additionalFields = null, string? additionalFieldValue = null, string? paymentMethod = null, string? accountAlias = null, bool? isPaid = null, string? paymentTypes = null, string? merchantId = null, string? paymentCategories = null, bool? suppressTechnologyFee = null, string? batchId = null, string? sortField = null, int? startRow = null, float? pageSize = null, bool? asc = null)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var startDate = "startDate_example";  // string? | Start date for the transaction search (optional) 
            var endDate = "endDate_example";  // string? | End date for the transaction search (optional) 
            var transactionIds = "transactionIds_example";  // string? | Transaction identifier (optional) 
            var referenceTransactionId = "referenceTransactionId_example";  // string? | Reference transaction identifier (optional) 
            var transactionStatuses = "transactionStatuses_example";  // string? | Status of the transaction (optional) 
            var customerIds = "customerIds_example";  // string? | Customer IDs associated with the transaction (optional) 
            var transactionType = "Sale";  // string? | Type of the transaction (optional) 
            var authCode = "authCode_example";  // string? | Authorization code of the transaction (optional) 
            var cardHolderName = "cardHolderName_example";  // string? | Name of the cardholder (optional) 
            var shopperName = "shopperName_example";  // string? | ShopperName of the cardholder (optional) 
            var amount = 8.14D;  // float? | Transaction amount (optional) 
            var fromAmount = 8.14D;  // float? | Minimum transaction amount (optional) 
            var toAmount = 8.14D;  // float? | Maximum transaction amount (optional) 
            var channelTypes = "channelTypes_example";  // string? | Channel types used for the transaction (optional) 
            var maskAccount = "maskAccount_example";  // string? | Masked account number (optional) 
            var customerName = "customerName_example";  // string? | Name of the customer (optional) 
            var recurringId = "recurringId_example";  // string? | Recurring payment ID (optional) 
            var referenceNo = "referenceNo_example";  // string? | Reference number (optional) 
            var exportToCsv = true;  // bool? | Export To Csv (optional) 
            var exportToPDF = true;  // bool? | Export To PDF (optional) 
            var transactionOrigins = "transactionOrigins_example";  // string? | Type of origin used in the transaction (optional) 
            var transactionSourceType = "Independent";  // string? | Transaction source type of the transaction (optional) 
            var sourceId = 8.14D;  // float? | Set SourceId (optional) 
            var traceNumbers = "traceNumbers_example";  // string? | TraceNumbers associated with the transaction (optional) 
            var binNumber = "binNumber_example";  // string? | BinNumber (optional) 
            var processMethod = "NotDefined";  // string? | Process Method used for the transaction (optional) 
            var searchText = "searchText_example";  // string? | SearchText of the transaction (optional) 
            var merchantReference = "merchantReference_example";  // string? | Merchant Reference of the transaction (optional) 
            var additionalFields = "additionalFields_example";  // string? | Additional Fields (optional) 
            var additionalFieldValue = "additionalFieldValue_example";  // string? | AdditionalFieldValue (optional) 
            var paymentMethod = "paymentMethod_example";  // string? | Payment Method (optional) 
            var accountAlias = "accountAlias_example";  // string? | Set AccountAlias (optional) 
            var isPaid = true;  // bool? | Set IsPaid (optional) 
            var paymentTypes = "paymentTypes_example";  // string? | Type of payment used in the transaction (optional) 
            var merchantId = "merchantId_example";  // string? | Search with Merchant Id (optional) 
            var paymentCategories = "paymentCategories_example";  // string? | Set PaymentCategories (optional) 
            var suppressTechnologyFee = true;  // bool? | SuppressTechnologyFee (optional) 
            var batchId = "batchId_example";  // string? | BatchId (optional) 
            var sortField = "sortField_example";  // string? | SortField (optional) 
            var startRow = 56;  // int? | Set StartRow (optional) 
            var pageSize = 8.14D;  // float? | Set PageSize (optional) 
            var asc = true;  // bool? | Set Asc (optional) 

            try
            {
                // This API gets Secure payment by search criteria for the merchant.
                MerchantTransactionEntityResponse result = apiInstance.SecurePaymentsSearchPost(xApiKey, xAppKey, xVersion, origin, startDate, endDate, transactionIds, referenceTransactionId, transactionStatuses, customerIds, transactionType, authCode, cardHolderName, shopperName, amount, fromAmount, toAmount, channelTypes, maskAccount, customerName, recurringId, referenceNo, exportToCsv, exportToPDF, transactionOrigins, transactionSourceType, sourceId, traceNumbers, binNumber, processMethod, searchText, merchantReference, additionalFields, additionalFieldValue, paymentMethod, accountAlias, isPaid, paymentTypes, merchantId, paymentCategories, suppressTechnologyFee, batchId, sortField, startRow, pageSize, asc);
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
    ApiResponse<MerchantTransactionEntityResponse> response = apiInstance.SecurePaymentsSearchPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, startDate, endDate, transactionIds, referenceTransactionId, transactionStatuses, customerIds, transactionType, authCode, cardHolderName, shopperName, amount, fromAmount, toAmount, channelTypes, maskAccount, customerName, recurringId, referenceNo, exportToCsv, exportToPDF, transactionOrigins, transactionSourceType, sourceId, traceNumbers, binNumber, processMethod, searchText, merchantReference, additionalFields, additionalFieldValue, paymentMethod, accountAlias, isPaid, paymentTypes, merchantId, paymentCategories, suppressTechnologyFee, batchId, sortField, startRow, pageSize, asc);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **startDate** | **string?** | Start date for the transaction search | [optional]  |
| **endDate** | **string?** | End date for the transaction search | [optional]  |
| **transactionIds** | **string?** | Transaction identifier | [optional]  |
| **referenceTransactionId** | **string?** | Reference transaction identifier | [optional]  |
| **transactionStatuses** | **string?** | Status of the transaction | [optional]  |
| **customerIds** | **string?** | Customer IDs associated with the transaction | [optional]  |
| **transactionType** | **string?** | Type of the transaction | [optional]  |
| **authCode** | **string?** | Authorization code of the transaction | [optional]  |
| **cardHolderName** | **string?** | Name of the cardholder | [optional]  |
| **shopperName** | **string?** | ShopperName of the cardholder | [optional]  |
| **amount** | **float?** | Transaction amount | [optional]  |
| **fromAmount** | **float?** | Minimum transaction amount | [optional]  |
| **toAmount** | **float?** | Maximum transaction amount | [optional]  |
| **channelTypes** | **string?** | Channel types used for the transaction | [optional]  |
| **maskAccount** | **string?** | Masked account number | [optional]  |
| **customerName** | **string?** | Name of the customer | [optional]  |
| **recurringId** | **string?** | Recurring payment ID | [optional]  |
| **referenceNo** | **string?** | Reference number | [optional]  |
| **exportToCsv** | **bool?** | Export To Csv | [optional]  |
| **exportToPDF** | **bool?** | Export To PDF | [optional]  |
| **transactionOrigins** | **string?** | Type of origin used in the transaction | [optional]  |
| **transactionSourceType** | **string?** | Transaction source type of the transaction | [optional]  |
| **sourceId** | **float?** | Set SourceId | [optional]  |
| **traceNumbers** | **string?** | TraceNumbers associated with the transaction | [optional]  |
| **binNumber** | **string?** | BinNumber | [optional]  |
| **processMethod** | **string?** | Process Method used for the transaction | [optional]  |
| **searchText** | **string?** | SearchText of the transaction | [optional]  |
| **merchantReference** | **string?** | Merchant Reference of the transaction | [optional]  |
| **additionalFields** | **string?** | Additional Fields | [optional]  |
| **additionalFieldValue** | **string?** | AdditionalFieldValue | [optional]  |
| **paymentMethod** | **string?** | Payment Method | [optional]  |
| **accountAlias** | **string?** | Set AccountAlias | [optional]  |
| **isPaid** | **bool?** | Set IsPaid | [optional]  |
| **paymentTypes** | **string?** | Type of payment used in the transaction | [optional]  |
| **merchantId** | **string?** | Search with Merchant Id | [optional]  |
| **paymentCategories** | **string?** | Set PaymentCategories | [optional]  |
| **suppressTechnologyFee** | **bool?** | SuppressTechnologyFee | [optional]  |
| **batchId** | **string?** | BatchId | [optional]  |
| **sortField** | **string?** | SortField | [optional]  |
| **startRow** | **int?** | Set StartRow | [optional]  |
| **pageSize** | **float?** | Set PageSize | [optional]  |
| **asc** | **bool?** | Set Asc | [optional]  |

### Return type

[**MerchantTransactionEntityResponse**](MerchantTransactionEntityResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securepaymentsdetailspost"></a>
# **SecurePaymentsdetailsPost**
> TransactionPaymentResponse SecurePaymentsdetailsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecurePaymentDetailsRequest securePaymentDetailsRequest)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var securePaymentDetailsRequest = new SecurePaymentDetailsRequest(); // SecurePaymentDetailsRequest | Payment Details Request

            try
            {
                // This API is used for getting details of Payments
                TransactionPaymentResponse result = apiInstance.SecurePaymentsdetailsPost(xApiKey, xAppKey, xVersion, origin, securePaymentDetailsRequest);
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
    ApiResponse<TransactionPaymentResponse> response = apiInstance.SecurePaymentsdetailsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, securePaymentDetailsRequest);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **securePaymentDetailsRequest** | [**SecurePaymentDetailsRequest**](SecurePaymentDetailsRequest.md) | Payment Details Request |  |

### Return type

[**TransactionPaymentResponse**](TransactionPaymentResponse.md)

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

