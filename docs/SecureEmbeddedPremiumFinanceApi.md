# openapi_client.SecureEmbeddedPremiumFinanceApi

All URIs are relative to *https://api.uat.anddone.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**secure_epf_quotes_booking_put**](SecureEmbeddedPremiumFinanceApi.md#secure_epf_quotes_booking_put) | **PUT** /secure/epf/quotes/booking | This API will update PFA to book a quote.
[**secure_epf_quotes_captureesign_put**](SecureEmbeddedPremiumFinanceApi.md#secure_epf_quotes_captureesign_put) | **PUT** /secure/epf/quotes/captureesign | This API will eSign the pfa with insured name.
[**secure_epf_quotes_generate_post**](SecureEmbeddedPremiumFinanceApi.md#secure_epf_quotes_generate_post) | **POST** /secure/epf/quotes/generate | This API is used to Generate Quotes
[**secure_epf_quotes_intent_post**](SecureEmbeddedPremiumFinanceApi.md#secure_epf_quotes_intent_post) | **POST** /secure/epf/quotes/intent | This API will return quotes created againsts a payment intent.
[**secure_epf_quotes_post**](SecureEmbeddedPremiumFinanceApi.md#secure_epf_quotes_post) | **POST** /secure/epf/quotes | This API will return quote by QuoteKey.
[**secure_epf_retrievepfa_post**](SecureEmbeddedPremiumFinanceApi.md#secure_epf_retrievepfa_post) | **POST** /secure/epf/retrievepfa | This API will return PFA for given quoteKey.
[**secure_merchants_epf_quotes_policy_put**](SecureEmbeddedPremiumFinanceApi.md#secure_merchants_epf_quotes_policy_put) | **PUT** /secure/merchants/epf/quotes/policy | This API is will update the policy number


# **secure_epf_quotes_booking_put**
> PFUpdatePFAResponse secure_epf_quotes_booking_put(x_api_key, x_app_key, x_version, origin, pf_quote_booking_request)

This API will update PFA to book a quote.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.pf_quote_booking_request import PFQuoteBookingRequest
from openapi_client.models.pf_update_pfa_response import PFUpdatePFAResponse
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    pf_quote_booking_request = openapi_client.PFQuoteBookingRequest() # PFQuoteBookingRequest | PFQuoteBooking Request details

    try:
        # This API will update PFA to book a quote.
        api_response = api_instance.secure_epf_quotes_booking_put(x_api_key, x_app_key, x_version, origin, pf_quote_booking_request)
        print("The response of SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_booking_put:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_booking_put: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **pf_quote_booking_request** | [**PFQuoteBookingRequest**](PFQuoteBookingRequest.md)| PFQuoteBooking Request details | 

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
**200** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_epf_quotes_captureesign_put**
> secure_epf_quotes_captureesign_put(x_api_key, x_app_key, x_version, origin, pf_quote_esign_request=pf_quote_esign_request)

This API will eSign the pfa with insured name.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.pf_quote_esign_request import PFQuoteEsignRequest
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    pf_quote_esign_request = openapi_client.PFQuoteEsignRequest() # PFQuoteEsignRequest | PFQuote Request (optional)

    try:
        # This API will eSign the pfa with insured name.
        api_instance.secure_epf_quotes_captureesign_put(x_api_key, x_app_key, x_version, origin, pf_quote_esign_request=pf_quote_esign_request)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_captureesign_put: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **pf_quote_esign_request** | [**PFQuoteEsignRequest**](PFQuoteEsignRequest.md)| PFQuote Request | [optional] 

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

# **secure_epf_quotes_generate_post**
> List[PFGenerateQuoteResponse] secure_epf_quotes_generate_post(x_api_key, x_app_key, x_version, origin, quote_request=quote_request)

This API is used to Generate Quotes

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.pf_generate_quote_response import PFGenerateQuoteResponse
from openapi_client.models.quote_request import QuoteRequest
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    quote_request = openapi_client.QuoteRequest() # QuoteRequest | Quote Request (optional)

    try:
        # This API is used to Generate Quotes
        api_response = api_instance.secure_epf_quotes_generate_post(x_api_key, x_app_key, x_version, origin, quote_request=quote_request)
        print("The response of SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_generate_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_generate_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **quote_request** | [**QuoteRequest**](QuoteRequest.md)| Quote Request | [optional] 

### Return type

[**List[PFGenerateQuoteResponse]**](PFGenerateQuoteResponse.md)

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

# **secure_epf_quotes_intent_post**
> List[QuoteResponseIntent] secure_epf_quotes_intent_post(x_api_key, x_app_key, x_version, origin, get_quote_request=get_quote_request)

This API will return quotes created againsts a payment intent.

### Example


```python
import openapi_client
from openapi_client.models.get_quote_request import GetQuoteRequest
from openapi_client.models.quote_response_intent import QuoteResponseIntent
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://api.uat.anddone.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://api.uat.anddone.com"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    get_quote_request = openapi_client.GetQuoteRequest() # GetQuoteRequest | Signature Request details (optional)

    try:
        # This API will return quotes created againsts a payment intent.
        api_response = api_instance.secure_epf_quotes_intent_post(x_api_key, x_app_key, x_version, origin, get_quote_request=get_quote_request)
        print("The response of SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_intent_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_intent_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **get_quote_request** | [**GetQuoteRequest**](GetQuoteRequest.md)| Signature Request details | [optional] 

### Return type

[**List[QuoteResponseIntent]**](QuoteResponseIntent.md)

### Authorization

No authorization required

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

# **secure_epf_quotes_post**
> List[QuoteResponse] secure_epf_quotes_post(x_api_key, x_app_key, x_version, origin, get_quote_key_request=get_quote_key_request)

This API will return quote by QuoteKey.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.get_quote_key_request import GetQuoteKeyRequest
from openapi_client.models.quote_response import QuoteResponse
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    get_quote_key_request = openapi_client.GetQuoteKeyRequest() # GetQuoteKeyRequest | Signature Request details (optional)

    try:
        # This API will return quote by QuoteKey.
        api_response = api_instance.secure_epf_quotes_post(x_api_key, x_app_key, x_version, origin, get_quote_key_request=get_quote_key_request)
        print("The response of SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceApi->secure_epf_quotes_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **get_quote_key_request** | [**GetQuoteKeyRequest**](GetQuoteKeyRequest.md)| Signature Request details | [optional] 

### Return type

[**List[QuoteResponse]**](QuoteResponse.md)

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

# **secure_epf_retrievepfa_post**
> str secure_epf_retrievepfa_post(x_api_key, x_app_key, x_version, origin, pf_retrieve_pfa_request_dto=pf_retrieve_pfa_request_dto)

This API will return PFA for given quoteKey.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.pf_retrieve_pfa_request_dto import PFRetrievePFARequestDTO
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    pf_retrieve_pfa_request_dto = openapi_client.PFRetrievePFARequestDTO() # PFRetrievePFARequestDTO | PFRetrieve PFA Request (optional)

    try:
        # This API will return PFA for given quoteKey.
        api_response = api_instance.secure_epf_retrievepfa_post(x_api_key, x_app_key, x_version, origin, pf_retrieve_pfa_request_dto=pf_retrieve_pfa_request_dto)
        print("The response of SecureEmbeddedPremiumFinanceApi->secure_epf_retrievepfa_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceApi->secure_epf_retrievepfa_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **pf_retrieve_pfa_request_dto** | [**PFRetrievePFARequestDTO**](PFRetrievePFARequestDTO.md)| PFRetrieve PFA Request | [optional] 

### Return type

**str**

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

# **secure_merchants_epf_quotes_policy_put**
> PFPolicyUpdateResponse secure_merchants_epf_quotes_policy_put(x_api_key, x_app_key, x_version, origin, pf_policy_update_request_dto=pf_policy_update_request_dto)

This API is will update the policy number

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.pf_policy_update_request_dto import PFPolicyUpdateRequestDTO
from openapi_client.models.pf_policy_update_response import PFPolicyUpdateResponse
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    pf_policy_update_request_dto = openapi_client.PFPolicyUpdateRequestDTO() # PFPolicyUpdateRequestDTO | Signature Request details (optional)

    try:
        # This API is will update the policy number
        api_response = api_instance.secure_merchants_epf_quotes_policy_put(x_api_key, x_app_key, x_version, origin, pf_policy_update_request_dto=pf_policy_update_request_dto)
        print("The response of SecureEmbeddedPremiumFinanceApi->secure_merchants_epf_quotes_policy_put:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceApi->secure_merchants_epf_quotes_policy_put: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **pf_policy_update_request_dto** | [**PFPolicyUpdateRequestDTO**](PFPolicyUpdateRequestDTO.md)| Signature Request details | [optional] 

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
**200** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

