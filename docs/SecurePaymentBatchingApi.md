# openapi_client.SecurePaymentBatchingApi

All URIs are relative to *https://api.uat.anddone.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**secure_batches_details_post**](SecurePaymentBatchingApi.md#secure_batches_details_post) | **POST** /secure/batches/details | This API is used for getting Secure Payment Batch Details
[**secure_batches_execute_post**](SecurePaymentBatchingApi.md#secure_batches_execute_post) | **POST** /secure/batches/execute | This API execute on-demand batch transaction.
[**secure_batches_post**](SecurePaymentBatchingApi.md#secure_batches_post) | **POST** /secure/batches | This API is used for getting Secure Payment Batches
[**secure_batches_timelines_post**](SecurePaymentBatchingApi.md#secure_batches_timelines_post) | **POST** /secure/batches/timelines | This API will returns batch timeline.
[**secure_batches_transactions_cancel_post**](SecurePaymentBatchingApi.md#secure_batches_transactions_cancel_post) | **POST** /secure/batches/transactions/cancel | This API cancels transactions from an active batch.


# **secure_batches_details_post**
> List[PaymentBatchDetailsResponse] secure_batches_details_post(x_api_key, x_app_key, x_version, origin, secure_payment_batch_details_request)

This API is used for getting Secure Payment Batch Details

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.payment_batch_details_response import PaymentBatchDetailsResponse
from openapi_client.models.secure_payment_batch_details_request import SecurePaymentBatchDetailsRequest
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
    api_instance = openapi_client.SecurePaymentBatchingApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_payment_batch_details_request = openapi_client.SecurePaymentBatchDetailsRequest() # SecurePaymentBatchDetailsRequest | Secure Payment Batch Details Request

    try:
        # This API is used for getting Secure Payment Batch Details
        api_response = api_instance.secure_batches_details_post(x_api_key, x_app_key, x_version, origin, secure_payment_batch_details_request)
        print("The response of SecurePaymentBatchingApi->secure_batches_details_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentBatchingApi->secure_batches_details_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_payment_batch_details_request** | [**SecurePaymentBatchDetailsRequest**](SecurePaymentBatchDetailsRequest.md)| Secure Payment Batch Details Request | 

### Return type

[**List[PaymentBatchDetailsResponse]**](PaymentBatchDetailsResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Successful operation |  -  |
**401** | Unauthorized |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_batches_execute_post**
> secure_batches_execute_post(x_api_key, x_app_key, x_version, origin, secure_batch_execute_request)

This API execute on-demand batch transaction.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_batch_execute_request import SecureBatchExecuteRequest
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
    api_instance = openapi_client.SecurePaymentBatchingApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_batch_execute_request = openapi_client.SecureBatchExecuteRequest() # SecureBatchExecuteRequest | Payment Batch Execution Request

    try:
        # This API execute on-demand batch transaction.
        api_instance.secure_batches_execute_post(x_api_key, x_app_key, x_version, origin, secure_batch_execute_request)
    except Exception as e:
        print("Exception when calling SecurePaymentBatchingApi->secure_batches_execute_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_batch_execute_request** | [**SecureBatchExecuteRequest**](SecureBatchExecuteRequest.md)| Payment Batch Execution Request | 

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
**200** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_batches_post**
> PaymentBatchResponse secure_batches_post(x_api_key, x_app_key, x_version, origin, start_row=start_row, page_size=page_size, sort_field=sort_field, asc=asc)

This API is used for getting Secure Payment Batches

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.payment_batch_response import PaymentBatchResponse
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
    api_instance = openapi_client.SecurePaymentBatchingApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    start_row = 56 # int | Set StartRow (optional)
    page_size = 56 # int | Set PageSize (optional)
    sort_field = 'sort_field_example' # str | Set SortField (optional)
    asc = True # bool | Set Asc (optional)

    try:
        # This API is used for getting Secure Payment Batches
        api_response = api_instance.secure_batches_post(x_api_key, x_app_key, x_version, origin, start_row=start_row, page_size=page_size, sort_field=sort_field, asc=asc)
        print("The response of SecurePaymentBatchingApi->secure_batches_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentBatchingApi->secure_batches_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **start_row** | **int**| Set StartRow | [optional] 
 **page_size** | **int**| Set PageSize | [optional] 
 **sort_field** | **str**| Set SortField | [optional] 
 **asc** | **bool**| Set Asc | [optional] 

### Return type

[**PaymentBatchResponse**](PaymentBatchResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Successful operation |  -  |
**401** | Unauthorized |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_batches_timelines_post**
> List[PaymentBatchEventLogResponse] secure_batches_timelines_post(x_api_key, x_app_key, x_version, origin, secure_payment_batch_details_request)

This API will returns batch timeline.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.payment_batch_event_log_response import PaymentBatchEventLogResponse
from openapi_client.models.secure_payment_batch_details_request import SecurePaymentBatchDetailsRequest
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
    api_instance = openapi_client.SecurePaymentBatchingApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_payment_batch_details_request = openapi_client.SecurePaymentBatchDetailsRequest() # SecurePaymentBatchDetailsRequest | Payment Batch Timeline Request

    try:
        # This API will returns batch timeline.
        api_response = api_instance.secure_batches_timelines_post(x_api_key, x_app_key, x_version, origin, secure_payment_batch_details_request)
        print("The response of SecurePaymentBatchingApi->secure_batches_timelines_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentBatchingApi->secure_batches_timelines_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_payment_batch_details_request** | [**SecurePaymentBatchDetailsRequest**](SecurePaymentBatchDetailsRequest.md)| Payment Batch Timeline Request | 

### Return type

[**List[PaymentBatchEventLogResponse]**](PaymentBatchEventLogResponse.md)

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

# **secure_batches_transactions_cancel_post**
> secure_batches_transactions_cancel_post(x_api_key, x_app_key, x_version, origin, payment_batch_cancellation_request)

This API cancels transactions from an active batch.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.payment_batch_cancellation_request import PaymentBatchCancellationRequest
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
    api_instance = openapi_client.SecurePaymentBatchingApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    payment_batch_cancellation_request = openapi_client.PaymentBatchCancellationRequest() # PaymentBatchCancellationRequest | Payment Batch Cancellation Request

    try:
        # This API cancels transactions from an active batch.
        api_instance.secure_batches_transactions_cancel_post(x_api_key, x_app_key, x_version, origin, payment_batch_cancellation_request)
    except Exception as e:
        print("Exception when calling SecurePaymentBatchingApi->secure_batches_transactions_cancel_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **payment_batch_cancellation_request** | [**PaymentBatchCancellationRequest**](PaymentBatchCancellationRequest.md)| Payment Batch Cancellation Request | 

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
**200** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

