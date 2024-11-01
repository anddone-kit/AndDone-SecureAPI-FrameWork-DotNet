# openapi_client.SecurePaymentIntentApi

All URIs are relative to *https://api.uat.anddone.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**secure_epf_updateintent_put**](SecurePaymentIntentApi.md#secure_epf_updateintent_put) | **PUT** /secure/epf/updateintent | This API is use update the amount of payment intent.
[**secure_paymentintents_expirations_post**](SecurePaymentIntentApi.md#secure_paymentintents_expirations_post) | **POST** /secure/paymentintents/expirations | This API expires the payment Intent or link.
[**secure_paymentintents_post**](SecurePaymentIntentApi.md#secure_paymentintents_post) | **POST** /secure/paymentintents | This API is use to create Secure payment Intent.


# **secure_epf_updateintent_put**
> secure_epf_updateintent_put(x_api_key, x_app_key, x_version, origin, update_intent_request)

This API is use update the amount of payment intent.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.update_intent_request import UpdateIntentRequest
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
    api_instance = openapi_client.SecurePaymentIntentApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    update_intent_request = openapi_client.UpdateIntentRequest() # UpdateIntentRequest | Update Intent Request

    try:
        # This API is use update the amount of payment intent.
        api_instance.secure_epf_updateintent_put(x_api_key, x_app_key, x_version, origin, update_intent_request)
    except Exception as e:
        print("Exception when calling SecurePaymentIntentApi->secure_epf_updateintent_put: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **update_intent_request** | [**UpdateIntentRequest**](UpdateIntentRequest.md)| Update Intent Request | 

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

# **secure_paymentintents_expirations_post**
> PaymentIntentExpiresResponse secure_paymentintents_expirations_post(x_api_key, x_app_key, x_version, origin, id=id)

This API expires the payment Intent or link.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.payment_intent_expires_response import PaymentIntentExpiresResponse
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
    api_instance = openapi_client.SecurePaymentIntentApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    id = 'id_example' # str | Payment Intent Id (optional)

    try:
        # This API expires the payment Intent or link.
        api_response = api_instance.secure_paymentintents_expirations_post(x_api_key, x_app_key, x_version, origin, id=id)
        print("The response of SecurePaymentIntentApi->secure_paymentintents_expirations_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentIntentApi->secure_paymentintents_expirations_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **id** | **str**| Payment Intent Id | [optional] 

### Return type

[**PaymentIntentExpiresResponse**](PaymentIntentExpiresResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Successful operation |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_paymentintents_post**
> PaymentIntentResponse secure_paymentintents_post(x_api_key, x_app_key, x_version, origin, payment_intent_request=payment_intent_request)

This API is use to create Secure payment Intent.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.payment_intent_request import PaymentIntentRequest
from openapi_client.models.payment_intent_response import PaymentIntentResponse
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
    api_instance = openapi_client.SecurePaymentIntentApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    payment_intent_request = openapi_client.PaymentIntentRequest() # PaymentIntentRequest | Payment Intent Request (optional)

    try:
        # This API is use to create Secure payment Intent.
        api_response = api_instance.secure_paymentintents_post(x_api_key, x_app_key, x_version, origin, payment_intent_request=payment_intent_request)
        print("The response of SecurePaymentIntentApi->secure_paymentintents_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentIntentApi->secure_paymentintents_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **payment_intent_request** | [**PaymentIntentRequest**](PaymentIntentRequest.md)| Payment Intent Request | [optional] 

### Return type

[**PaymentIntentResponse**](PaymentIntentResponse.md)

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

