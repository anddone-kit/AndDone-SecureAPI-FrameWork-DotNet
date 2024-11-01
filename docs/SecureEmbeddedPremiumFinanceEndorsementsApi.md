# openapi_client.SecureEmbeddedPremiumFinanceEndorsementsApi

All URIs are relative to *https://api.uat.anddone.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**secure_epf_endorsements_post**](SecureEmbeddedPremiumFinanceEndorsementsApi.md#secure_epf_endorsements_post) | **POST** /secure/epf/endorsements | This API will do a check of eligibility of account
[**secure_epf_quote_endorsement_booking_put**](SecureEmbeddedPremiumFinanceEndorsementsApi.md#secure_epf_quote_endorsement_booking_put) | **PUT** /secure/epf/quote/endorsement/booking | This API will update PFA to book a endorsement quote.
[**secure_epf_quote_endorsement_post**](SecureEmbeddedPremiumFinanceEndorsementsApi.md#secure_epf_quote_endorsement_post) | **POST** /secure/epf/quote/endorsement | This API will do return a quote for an existing policy or new policy for an existing account


# **secure_epf_endorsements_post**
> PFCheckEndorsementsResponse secure_epf_endorsements_post(x_api_key, x_app_key, x_version, origin, pf_check_endorsements_request)

This API will do a check of eligibility of account

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.pf_check_endorsements_request import PFCheckEndorsementsRequest
from openapi_client.models.pf_check_endorsements_response import PFCheckEndorsementsResponse
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceEndorsementsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    pf_check_endorsements_request = openapi_client.PFCheckEndorsementsRequest() # PFCheckEndorsementsRequest | PF Check Endorsement Request details

    try:
        # This API will do a check of eligibility of account
        api_response = api_instance.secure_epf_endorsements_post(x_api_key, x_app_key, x_version, origin, pf_check_endorsements_request)
        print("The response of SecureEmbeddedPremiumFinanceEndorsementsApi->secure_epf_endorsements_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi->secure_epf_endorsements_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **pf_check_endorsements_request** | [**PFCheckEndorsementsRequest**](PFCheckEndorsementsRequest.md)| PF Check Endorsement Request details | 

### Return type

[**PFCheckEndorsementsResponse**](PFCheckEndorsementsResponse.md)

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

# **secure_epf_quote_endorsement_booking_put**
> PFUpdatePFAResponse secure_epf_quote_endorsement_booking_put(x_api_key, x_app_key, x_version, origin, pf_quote_booking_request)

This API will update PFA to book a endorsement quote.

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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceEndorsementsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    pf_quote_booking_request = openapi_client.PFQuoteBookingRequest() # PFQuoteBookingRequest | PFQuoteBooking Request details

    try:
        # This API will update PFA to book a endorsement quote.
        api_response = api_instance.secure_epf_quote_endorsement_booking_put(x_api_key, x_app_key, x_version, origin, pf_quote_booking_request)
        print("The response of SecureEmbeddedPremiumFinanceEndorsementsApi->secure_epf_quote_endorsement_booking_put:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi->secure_epf_quote_endorsement_booking_put: %s\n" % e)
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

# **secure_epf_quote_endorsement_post**
> PFEndorsementResponse secure_epf_quote_endorsement_post(x_api_key, x_app_key, x_version, origin, pf_endorsement_request)

This API will do return a quote for an existing policy or new policy for an existing account

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.pf_endorsement_request import PFEndorsementRequest
from openapi_client.models.pf_endorsement_response import PFEndorsementResponse
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
    api_instance = openapi_client.SecureEmbeddedPremiumFinanceEndorsementsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    pf_endorsement_request = openapi_client.PFEndorsementRequest() # PFEndorsementRequest | PF Endorsement Request details

    try:
        # This API will do return a quote for an existing policy or new policy for an existing account
        api_response = api_instance.secure_epf_quote_endorsement_post(x_api_key, x_app_key, x_version, origin, pf_endorsement_request)
        print("The response of SecureEmbeddedPremiumFinanceEndorsementsApi->secure_epf_quote_endorsement_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureEmbeddedPremiumFinanceEndorsementsApi->secure_epf_quote_endorsement_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **pf_endorsement_request** | [**PFEndorsementRequest**](PFEndorsementRequest.md)| PF Endorsement Request details | 

### Return type

[**PFEndorsementResponse**](PFEndorsementResponse.md)

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

