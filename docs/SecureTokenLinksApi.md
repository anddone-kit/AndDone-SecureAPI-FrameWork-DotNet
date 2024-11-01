# openapi_client.SecureTokenLinksApi

All URIs are relative to *https://api.uat.anddone.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**secure_tokenlinks_details_post**](SecureTokenLinksApi.md#secure_tokenlinks_details_post) | **POST** /secure/tokenlinks/details | This API is used for getting Token Links by TokenLink ID
[**secure_tokenlinks_expirations_post**](SecureTokenLinksApi.md#secure_tokenlinks_expirations_post) | **POST** /secure/tokenlinks/expirations | This API expires the token link.
[**secure_tokenlinks_list_post**](SecureTokenLinksApi.md#secure_tokenlinks_list_post) | **POST** /secure/tokenlinks/list | This API is used for getting all Token Links for Merchant
[**secure_tokenlinks_post**](SecureTokenLinksApi.md#secure_tokenlinks_post) | **POST** /secure/tokenlinks | This API is use to create Secure Token Links
[**secure_tokenlinks_put**](SecureTokenLinksApi.md#secure_tokenlinks_put) | **PUT** /secure/tokenlinks | This API will update the expireIn and paymentType of Token Link.


# **secure_tokenlinks_details_post**
> SecureTokenLinkByIdResponse secure_tokenlinks_details_post(x_api_key, x_app_key, x_version, origin, secure_token_link_request)

This API is used for getting Token Links by TokenLink ID

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_token_link_by_id_response import SecureTokenLinkByIdResponse
from openapi_client.models.secure_token_link_request import SecureTokenLinkRequest
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
    api_instance = openapi_client.SecureTokenLinksApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_token_link_request = openapi_client.SecureTokenLinkRequest() # SecureTokenLinkRequest | Secure Token Link Id Request

    try:
        # This API is used for getting Token Links by TokenLink ID
        api_response = api_instance.secure_tokenlinks_details_post(x_api_key, x_app_key, x_version, origin, secure_token_link_request)
        print("The response of SecureTokenLinksApi->secure_tokenlinks_details_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureTokenLinksApi->secure_tokenlinks_details_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_token_link_request** | [**SecureTokenLinkRequest**](SecureTokenLinkRequest.md)| Secure Token Link Id Request | 

### Return type

[**SecureTokenLinkByIdResponse**](SecureTokenLinkByIdResponse.md)

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

# **secure_tokenlinks_expirations_post**
> SecureTokenLinkExpiredResponse secure_tokenlinks_expirations_post(x_api_key, x_app_key, x_version, origin, secure_token_link_request)

This API expires the token link.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_token_link_expired_response import SecureTokenLinkExpiredResponse
from openapi_client.models.secure_token_link_request import SecureTokenLinkRequest
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
    api_instance = openapi_client.SecureTokenLinksApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_token_link_request = openapi_client.SecureTokenLinkRequest() # SecureTokenLinkRequest | Secure Token Link Id Request

    try:
        # This API expires the token link.
        api_response = api_instance.secure_tokenlinks_expirations_post(x_api_key, x_app_key, x_version, origin, secure_token_link_request)
        print("The response of SecureTokenLinksApi->secure_tokenlinks_expirations_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureTokenLinksApi->secure_tokenlinks_expirations_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_token_link_request** | [**SecureTokenLinkRequest**](SecureTokenLinkRequest.md)| Secure Token Link Id Request | 

### Return type

[**SecureTokenLinkExpiredResponse**](SecureTokenLinkExpiredResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Successful operation |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_tokenlinks_list_post**
> SecureTokenLinkResponse secure_tokenlinks_list_post(x_api_key, x_app_key, x_version, origin, email=email, status=status, phone=phone, statuses=statuses, title=title, payment_description=payment_description, invoice_number=invoice_number, expiry_date=expiry_date, from_expiry_date=from_expiry_date, free_text_search=free_text_search, token_link_id=token_link_id, to_expiry_date=to_expiry_date, from_date=from_date, to_date=to_date, start_row=start_row, page_size=page_size, sort_field=sort_field, asc=asc)

This API is used for getting all Token Links for Merchant

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_token_link_response import SecureTokenLinkResponse
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
    api_instance = openapi_client.SecureTokenLinksApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    email = 'email_example' # str | email (optional)
    status = 'status_example' # str | status (optional)
    phone = 'phone_example' # str | phone (optional)
    statuses = 'statuses_example' # str | statuses (optional)
    title = 'title_example' # str | title (optional)
    payment_description = 'payment_description_example' # str | paymentDescription (optional)
    invoice_number = 'invoice_number_example' # str | invoiceNumber (optional)
    expiry_date = 'expiry_date_example' # str | expiryDate (optional)
    from_expiry_date = 'from_expiry_date_example' # str | fromExpiryDate (optional)
    free_text_search = 'free_text_search_example' # str | freeTextSearch (optional)
    token_link_id = 'token_link_id_example' # str | tokenLinkId (optional)
    to_expiry_date = 'to_expiry_date_example' # str | toExpiryDate (optional)
    from_date = 'from_date_example' # str | fromDate (optional)
    to_date = 'to_date_example' # str | toDate (optional)
    start_row = 56 # int | Set StartRow (optional)
    page_size = 56 # int | Set PageSize (optional)
    sort_field = 'sort_field_example' # str | Set SortField (optional)
    asc = True # bool | Set Asc (optional)

    try:
        # This API is used for getting all Token Links for Merchant
        api_response = api_instance.secure_tokenlinks_list_post(x_api_key, x_app_key, x_version, origin, email=email, status=status, phone=phone, statuses=statuses, title=title, payment_description=payment_description, invoice_number=invoice_number, expiry_date=expiry_date, from_expiry_date=from_expiry_date, free_text_search=free_text_search, token_link_id=token_link_id, to_expiry_date=to_expiry_date, from_date=from_date, to_date=to_date, start_row=start_row, page_size=page_size, sort_field=sort_field, asc=asc)
        print("The response of SecureTokenLinksApi->secure_tokenlinks_list_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureTokenLinksApi->secure_tokenlinks_list_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **email** | **str**| email | [optional] 
 **status** | **str**| status | [optional] 
 **phone** | **str**| phone | [optional] 
 **statuses** | **str**| statuses | [optional] 
 **title** | **str**| title | [optional] 
 **payment_description** | **str**| paymentDescription | [optional] 
 **invoice_number** | **str**| invoiceNumber | [optional] 
 **expiry_date** | **str**| expiryDate | [optional] 
 **from_expiry_date** | **str**| fromExpiryDate | [optional] 
 **free_text_search** | **str**| freeTextSearch | [optional] 
 **token_link_id** | **str**| tokenLinkId | [optional] 
 **to_expiry_date** | **str**| toExpiryDate | [optional] 
 **from_date** | **str**| fromDate | [optional] 
 **to_date** | **str**| toDate | [optional] 
 **start_row** | **int**| Set StartRow | [optional] 
 **page_size** | **int**| Set PageSize | [optional] 
 **sort_field** | **str**| Set SortField | [optional] 
 **asc** | **bool**| Set Asc | [optional] 

### Return type

[**SecureTokenLinkResponse**](SecureTokenLinkResponse.md)

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

# **secure_tokenlinks_post**
> SecureTokenLinkResponse secure_tokenlinks_post(x_api_key, x_app_key, x_version, origin, token_link_secure_request)

This API is use to create Secure Token Links

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_token_link_response import SecureTokenLinkResponse
from openapi_client.models.token_link_secure_request import TokenLinkSecureRequest
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
    api_instance = openapi_client.SecureTokenLinksApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    token_link_secure_request = openapi_client.TokenLinkSecureRequest() # TokenLinkSecureRequest | Secure Token Link Request

    try:
        # This API is use to create Secure Token Links
        api_response = api_instance.secure_tokenlinks_post(x_api_key, x_app_key, x_version, origin, token_link_secure_request)
        print("The response of SecureTokenLinksApi->secure_tokenlinks_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecureTokenLinksApi->secure_tokenlinks_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **token_link_secure_request** | [**TokenLinkSecureRequest**](TokenLinkSecureRequest.md)| Secure Token Link Request | 

### Return type

[**SecureTokenLinkResponse**](SecureTokenLinkResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**201** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_tokenlinks_put**
> secure_tokenlinks_put(x_api_key, x_app_key, x_version, origin, secure_token_link_update_request)

This API will update the expireIn and paymentType of Token Link.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_token_link_update_request import SecureTokenLinkUpdateRequest
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
    api_instance = openapi_client.SecureTokenLinksApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_token_link_update_request = openapi_client.SecureTokenLinkUpdateRequest() # SecureTokenLinkUpdateRequest | Secure Token Link Update Request

    try:
        # This API will update the expireIn and paymentType of Token Link.
        api_instance.secure_tokenlinks_put(x_api_key, x_app_key, x_version, origin, secure_token_link_update_request)
    except Exception as e:
        print("Exception when calling SecureTokenLinksApi->secure_tokenlinks_put: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_token_link_update_request** | [**SecureTokenLinkUpdateRequest**](SecureTokenLinkUpdateRequest.md)| Secure Token Link Update Request | 

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

