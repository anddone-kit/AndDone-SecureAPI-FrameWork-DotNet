# openapi_client.SecureRefundsApi

All URIs are relative to *https://api.uat.anddone.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**secure_refunds_eligibility_post**](SecureRefundsApi.md#secure_refunds_eligibility_post) | **POST** /secure/refunds/eligibility | This API return refund eligibility of a transaction.
[**secure_refunds_post**](SecureRefundsApi.md#secure_refunds_post) | **POST** /secure/refunds | This API return refund a transaction.


# **secure_refunds_eligibility_post**
> RefundEligibility secure_refunds_eligibility_post(x_api_key, x_app_key, x_version, origin, transaction_refund_eligibility_request)

This API return refund eligibility of a transaction.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.refund_eligibility import RefundEligibility
from openapi_client.models.transaction_refund_eligibility_request import TransactionRefundEligibilityRequest
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://api.uat.anddone.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://api.uat.anddone.com"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: x-api-key
configuration.api_key['x-api-key'] = os.environ["API_KEY"]

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# Configure API key authorization: x-app-key
configuration.api_key['x-app-key'] = os.environ["API_KEY"]

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-app-key'] = 'Bearer'

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.SecureRefundsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    transaction_refund_eligibility_request = openapi_client.TransactionRefundEligibilityRequest() # TransactionRefundEligibilityRequest | refund Detail

    try:
        # This API return refund eligibility of a transaction.
        api_response = api_instance.secure_refunds_eligibility_post(x_api_key, x_app_key, x_version, origin, transaction_refund_eligibility_request)
        print("The response of SecureRefundsApi->secure_refunds_eligibility_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureRefundsApi->secure_refunds_eligibility_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **transaction_refund_eligibility_request** | [**TransactionRefundEligibilityRequest**](TransactionRefundEligibilityRequest.md)| refund Detail | 

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
**200** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_refunds_post**
> SecureTransactionDetailDTO secure_refunds_post(x_api_key, x_app_key, x_version, origin, secure_transaction_refund_request)

This API return refund a transaction.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_transaction_detail_dto import SecureTransactionDetailDTO
from openapi_client.models.secure_transaction_refund_request import SecureTransactionRefundRequest
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://api.uat.anddone.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://api.uat.anddone.com"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: x-api-key
configuration.api_key['x-api-key'] = os.environ["API_KEY"]

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# Configure API key authorization: x-app-key
configuration.api_key['x-app-key'] = os.environ["API_KEY"]

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-app-key'] = 'Bearer'

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.SecureRefundsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_transaction_refund_request = openapi_client.SecureTransactionRefundRequest() # SecureTransactionRefundRequest | Refund Detail

    try:
        # This API return refund a transaction.
        api_response = api_instance.secure_refunds_post(x_api_key, x_app_key, x_version, origin, secure_transaction_refund_request)
        print("The response of SecureRefundsApi->secure_refunds_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureRefundsApi->secure_refunds_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_transaction_refund_request** | [**SecureTransactionRefundRequest**](SecureTransactionRefundRequest.md)| Refund Detail | 

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
**200** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

