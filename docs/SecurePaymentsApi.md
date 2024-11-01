# openapi_client.SecurePaymentsApi

All URIs are relative to *https://api.uat.anddone.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**secure_payments_export_post**](SecurePaymentsApi.md#secure_payments_export_post) | **POST** /secure/payments/export | This API gets Secure payment by search criteria for the merchant.
[**secure_payments_post**](SecurePaymentsApi.md#secure_payments_post) | **POST** /secure/payments | This API posts new Secure payment request for the merchant.
[**secure_payments_search_post**](SecurePaymentsApi.md#secure_payments_search_post) | **POST** /secure/payments/search | This API gets Secure payment by search criteria for the merchant.
[**secure_paymentsdetails_post**](SecurePaymentsApi.md#secure_paymentsdetails_post) | **POST** /secure/paymentsdetails | This API is used for getting details of Payments


# **secure_payments_export_post**
> secure_payments_export_post(x_api_key, x_app_key, x_version, origin, start_date=start_date, end_date=end_date, transaction_id=transaction_id, reference_transaction_id=reference_transaction_id, transaction_statuses=transaction_statuses, customer_ids=customer_ids, transaction_type=transaction_type, auth_code=auth_code, card_holder_name=card_holder_name, shopper_name=shopper_name, amount=amount, from_amount=from_amount, to_amount=to_amount, channel_types=channel_types, mask_account=mask_account, customer_name=customer_name, bin_number=bin_number, reference_no=reference_no, recurring_id=recurring_id, transaction_source_type=transaction_source_type, reseller_ids=reseller_ids, merchant_ids=merchant_ids, trace_numbers=trace_numbers, search_text=search_text, merchant_reference=merchant_reference, additional_fields=additional_fields, payment_method=payment_method, export_to_csv=export_to_csv, export_to_pdf=export_to_pdf, skip_record_count=skip_record_count, total_record_count=total_record_count, batch_size=batch_size, payment_types=payment_types, merchant_dba_name=merchant_dba_name, payment_category=payment_category, sort_field=sort_field, email_id_to_receive_exported_transactions=email_id_to_receive_exported_transactions, is_transaction_cost_break_down=is_transaction_cost_break_down, batch_id=batch_id, suppress_technology_fee=suppress_technology_fee, start_row=start_row, page_size=page_size, asc=asc)

This API gets Secure payment by search criteria for the merchant.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
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
    api_instance = openapi_client.SecurePaymentsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    start_date = 'start_date_example' # str | Start date for the transaction search (optional)
    end_date = 'end_date_example' # str | End date for the transaction search (optional)
    transaction_id = 'transaction_id_example' # str | Transaction identifier (optional)
    reference_transaction_id = 'reference_transaction_id_example' # str | Reference transaction identifier (optional)
    transaction_statuses = 'transaction_statuses_example' # str | Status of the transaction (optional)
    customer_ids = 'customer_ids_example' # str | Customer IDs associated with the transaction (optional)
    transaction_type = 'transaction_type_example' # str | Type of the transaction (optional)
    auth_code = 'auth_code_example' # str | Authorization code of the transaction (optional)
    card_holder_name = 'card_holder_name_example' # str | Name of the cardholder (optional)
    shopper_name = 'shopper_name_example' # str | ShopperName of the cardholder (optional)
    amount = 3.4 # float | Transaction amount (optional)
    from_amount = 3.4 # float | Minimum transaction amount (optional)
    to_amount = 3.4 # float | Maximum transaction amount (optional)
    channel_types = 'channel_types_example' # str | Channel types used for the transaction (optional)
    mask_account = 'mask_account_example' # str | Masked account number (optional)
    customer_name = 'customer_name_example' # str | Name of the customer (optional)
    bin_number = 'bin_number_example' # str | BinNumber (optional)
    reference_no = 'reference_no_example' # str | Reference number (optional)
    recurring_id = 'recurring_id_example' # str | Recurring payment ID (optional)
    transaction_source_type = 'transaction_source_type_example' # str | Transaction source type of the transaction (optional)
    reseller_ids = 'reseller_ids_example' # str | Reseller IDs associated with the transaction (optional)
    merchant_ids = 'merchant_ids_example' # str | Merchant IDs associated with the transaction (optional)
    trace_numbers = 'trace_numbers_example' # str | TraceNumbers associated with the transaction (optional)
    search_text = 'search_text_example' # str | SearchText of the transaction (optional)
    merchant_reference = 'merchant_reference_example' # str | Merchant Reference of the transaction (optional)
    additional_fields = 'additional_fields_example' # str | Additional Fields (optional)
    payment_method = 'payment_method_example' # str | Payment Method (optional)
    export_to_csv = True # bool | Export To Csv (optional)
    export_to_pdf = True # bool | Export To PDF (optional)
    skip_record_count = 56 # int | SkipRecordCount (optional)
    total_record_count = 56 # int | TotalRecordCount (optional)
    batch_size = 56 # int | BatchSize (optional)
    payment_types = 'payment_types_example' # str | Type of payment used in the transaction (optional)
    merchant_dba_name = 'merchant_dba_name_example' # str | MerchantDBAName (optional)
    payment_category = 'payment_category_example' # str | Category of payment used in the transaction (optional)
    sort_field = 'sort_field_example' # str | SortField (optional)
    email_id_to_receive_exported_transactions = 'email_id_to_receive_exported_transactions_example' # str | EmailIdToReceiveExportedTransactions (optional)
    is_transaction_cost_break_down = True # bool | IsTransactionCostBreakDown (optional)
    batch_id = 'batch_id_example' # str | BatchId (optional)
    suppress_technology_fee = True # bool | SuppressTechnologyFee (optional)
    start_row = 3.4 # float | Set StartRow (optional)
    page_size = 3.4 # float | Set PageSize (optional)
    asc = True # bool | Set Asc (optional)

    try:
        # This API gets Secure payment by search criteria for the merchant.
        api_instance.secure_payments_export_post(x_api_key, x_app_key, x_version, origin, start_date=start_date, end_date=end_date, transaction_id=transaction_id, reference_transaction_id=reference_transaction_id, transaction_statuses=transaction_statuses, customer_ids=customer_ids, transaction_type=transaction_type, auth_code=auth_code, card_holder_name=card_holder_name, shopper_name=shopper_name, amount=amount, from_amount=from_amount, to_amount=to_amount, channel_types=channel_types, mask_account=mask_account, customer_name=customer_name, bin_number=bin_number, reference_no=reference_no, recurring_id=recurring_id, transaction_source_type=transaction_source_type, reseller_ids=reseller_ids, merchant_ids=merchant_ids, trace_numbers=trace_numbers, search_text=search_text, merchant_reference=merchant_reference, additional_fields=additional_fields, payment_method=payment_method, export_to_csv=export_to_csv, export_to_pdf=export_to_pdf, skip_record_count=skip_record_count, total_record_count=total_record_count, batch_size=batch_size, payment_types=payment_types, merchant_dba_name=merchant_dba_name, payment_category=payment_category, sort_field=sort_field, email_id_to_receive_exported_transactions=email_id_to_receive_exported_transactions, is_transaction_cost_break_down=is_transaction_cost_break_down, batch_id=batch_id, suppress_technology_fee=suppress_technology_fee, start_row=start_row, page_size=page_size, asc=asc)
    except Exception as e:
        print("Exception when calling SecurePaymentsApi->secure_payments_export_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **start_date** | **str**| Start date for the transaction search | [optional] 
 **end_date** | **str**| End date for the transaction search | [optional] 
 **transaction_id** | **str**| Transaction identifier | [optional] 
 **reference_transaction_id** | **str**| Reference transaction identifier | [optional] 
 **transaction_statuses** | **str**| Status of the transaction | [optional] 
 **customer_ids** | **str**| Customer IDs associated with the transaction | [optional] 
 **transaction_type** | **str**| Type of the transaction | [optional] 
 **auth_code** | **str**| Authorization code of the transaction | [optional] 
 **card_holder_name** | **str**| Name of the cardholder | [optional] 
 **shopper_name** | **str**| ShopperName of the cardholder | [optional] 
 **amount** | **float**| Transaction amount | [optional] 
 **from_amount** | **float**| Minimum transaction amount | [optional] 
 **to_amount** | **float**| Maximum transaction amount | [optional] 
 **channel_types** | **str**| Channel types used for the transaction | [optional] 
 **mask_account** | **str**| Masked account number | [optional] 
 **customer_name** | **str**| Name of the customer | [optional] 
 **bin_number** | **str**| BinNumber | [optional] 
 **reference_no** | **str**| Reference number | [optional] 
 **recurring_id** | **str**| Recurring payment ID | [optional] 
 **transaction_source_type** | **str**| Transaction source type of the transaction | [optional] 
 **reseller_ids** | **str**| Reseller IDs associated with the transaction | [optional] 
 **merchant_ids** | **str**| Merchant IDs associated with the transaction | [optional] 
 **trace_numbers** | **str**| TraceNumbers associated with the transaction | [optional] 
 **search_text** | **str**| SearchText of the transaction | [optional] 
 **merchant_reference** | **str**| Merchant Reference of the transaction | [optional] 
 **additional_fields** | **str**| Additional Fields | [optional] 
 **payment_method** | **str**| Payment Method | [optional] 
 **export_to_csv** | **bool**| Export To Csv | [optional] 
 **export_to_pdf** | **bool**| Export To PDF | [optional] 
 **skip_record_count** | **int**| SkipRecordCount | [optional] 
 **total_record_count** | **int**| TotalRecordCount | [optional] 
 **batch_size** | **int**| BatchSize | [optional] 
 **payment_types** | **str**| Type of payment used in the transaction | [optional] 
 **merchant_dba_name** | **str**| MerchantDBAName | [optional] 
 **payment_category** | **str**| Category of payment used in the transaction | [optional] 
 **sort_field** | **str**| SortField | [optional] 
 **email_id_to_receive_exported_transactions** | **str**| EmailIdToReceiveExportedTransactions | [optional] 
 **is_transaction_cost_break_down** | **bool**| IsTransactionCostBreakDown | [optional] 
 **batch_id** | **str**| BatchId | [optional] 
 **suppress_technology_fee** | **bool**| SuppressTechnologyFee | [optional] 
 **start_row** | **float**| Set StartRow | [optional] 
 **page_size** | **float**| Set PageSize | [optional] 
 **asc** | **bool**| Set Asc | [optional] 

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
**200** | Successful operation - SSE stream initiated |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_payments_post**
> TransactionDetailResponse secure_payments_post(x_api_key, x_app_key, x_version, origin, payment_request)

This API posts new Secure payment request for the merchant.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.payment_request import PaymentRequest
from openapi_client.models.transaction_detail_response import TransactionDetailResponse
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
    api_instance = openapi_client.SecurePaymentsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    payment_request = openapi_client.PaymentRequest() # PaymentRequest | Payment Detail

    try:
        # This API posts new Secure payment request for the merchant.
        api_response = api_instance.secure_payments_post(x_api_key, x_app_key, x_version, origin, payment_request)
        print("The response of SecurePaymentsApi->secure_payments_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentsApi->secure_payments_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **payment_request** | [**PaymentRequest**](PaymentRequest.md)| Payment Detail | 

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
**201** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_payments_search_post**
> AdminTransactionEntityResponse secure_payments_search_post(x_api_key, x_app_key, x_version, origin, start_date=start_date, end_date=end_date, transaction_id=transaction_id, reference_transaction_id=reference_transaction_id, transaction_statuses=transaction_statuses, customer_ids=customer_ids, transaction_type=transaction_type, auth_code=auth_code, card_holder_name=card_holder_name, shopper_name=shopper_name, amount=amount, from_amount=from_amount, to_amount=to_amount, channel_types=channel_types, mask_account=mask_account, customer_name=customer_name, bin_number=bin_number, reference_no=reference_no, recurring_id=recurring_id, transaction_source_type=transaction_source_type, reseller_ids=reseller_ids, merchant_ids=merchant_ids, trace_numbers=trace_numbers, search_text=search_text, merchant_reference=merchant_reference, additional_fields=additional_fields, payment_method=payment_method, export_to_csv=export_to_csv, export_to_pdf=export_to_pdf, skip_record_count=skip_record_count, total_record_count=total_record_count, batch_size=batch_size, payment_types=payment_types, merchant_dba_name=merchant_dba_name, payment_category=payment_category, sort_field=sort_field, email_id_to_receive_exported_transactions=email_id_to_receive_exported_transactions, is_transaction_cost_break_down=is_transaction_cost_break_down, batch_id=batch_id, suppress_technology_fee=suppress_technology_fee, start_row=start_row, page_size=page_size, asc=asc)

This API gets Secure payment by search criteria for the merchant.

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.admin_transaction_entity_response import AdminTransactionEntityResponse
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
    api_instance = openapi_client.SecurePaymentsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    start_date = 'start_date_example' # str | Start date for the transaction search (optional)
    end_date = 'end_date_example' # str | End date for the transaction search (optional)
    transaction_id = 'transaction_id_example' # str | Transaction identifier (optional)
    reference_transaction_id = 'reference_transaction_id_example' # str | Reference transaction identifier (optional)
    transaction_statuses = 'transaction_statuses_example' # str | Status of the transaction (optional)
    customer_ids = 'customer_ids_example' # str | Customer IDs associated with the transaction (optional)
    transaction_type = 'transaction_type_example' # str | Type of the transaction (optional)
    auth_code = 'auth_code_example' # str | Authorization code of the transaction (optional)
    card_holder_name = 'card_holder_name_example' # str | Name of the cardholder (optional)
    shopper_name = 'shopper_name_example' # str | ShopperName of the cardholder (optional)
    amount = 3.4 # float | Transaction amount (optional)
    from_amount = 3.4 # float | Minimum transaction amount (optional)
    to_amount = 3.4 # float | Maximum transaction amount (optional)
    channel_types = 'channel_types_example' # str | Channel types used for the transaction (optional)
    mask_account = 'mask_account_example' # str | Masked account number (optional)
    customer_name = 'customer_name_example' # str | Name of the customer (optional)
    bin_number = 'bin_number_example' # str | BinNumber (optional)
    reference_no = 'reference_no_example' # str | Reference number (optional)
    recurring_id = 'recurring_id_example' # str | Recurring payment ID (optional)
    transaction_source_type = 'transaction_source_type_example' # str | Transaction source type of the transaction (optional)
    reseller_ids = 'reseller_ids_example' # str | Reseller IDs associated with the transaction (optional)
    merchant_ids = 'merchant_ids_example' # str | Merchant IDs associated with the transaction (optional)
    trace_numbers = 'trace_numbers_example' # str | TraceNumbers associated with the transaction (optional)
    search_text = 'search_text_example' # str | SearchText of the transaction (optional)
    merchant_reference = 'merchant_reference_example' # str | Merchant Reference of the transaction (optional)
    additional_fields = 'additional_fields_example' # str | Additional Fields (optional)
    payment_method = 'payment_method_example' # str | Payment Method (optional)
    export_to_csv = True # bool | Export To Csv (optional)
    export_to_pdf = True # bool | Export To PDF (optional)
    skip_record_count = 56 # int | SkipRecordCount (optional)
    total_record_count = 56 # int | TotalRecordCount (optional)
    batch_size = 56 # int | BatchSize (optional)
    payment_types = 'payment_types_example' # str | Type of payment used in the transaction (optional)
    merchant_dba_name = 'merchant_dba_name_example' # str | MerchantDBAName (optional)
    payment_category = 'payment_category_example' # str | Category of payment used in the transaction (optional)
    sort_field = 'sort_field_example' # str | SortField (optional)
    email_id_to_receive_exported_transactions = 'email_id_to_receive_exported_transactions_example' # str | EmailIdToReceiveExportedTransactions (optional)
    is_transaction_cost_break_down = True # bool | IsTransactionCostBreakDown (optional)
    batch_id = 'batch_id_example' # str | BatchId (optional)
    suppress_technology_fee = True # bool | SuppressTechnologyFee (optional)
    start_row = 3.4 # float | Set StartRow (optional)
    page_size = 3.4 # float | Set PageSize (optional)
    asc = True # bool | Set Asc (optional)

    try:
        # This API gets Secure payment by search criteria for the merchant.
        api_response = api_instance.secure_payments_search_post(x_api_key, x_app_key, x_version, origin, start_date=start_date, end_date=end_date, transaction_id=transaction_id, reference_transaction_id=reference_transaction_id, transaction_statuses=transaction_statuses, customer_ids=customer_ids, transaction_type=transaction_type, auth_code=auth_code, card_holder_name=card_holder_name, shopper_name=shopper_name, amount=amount, from_amount=from_amount, to_amount=to_amount, channel_types=channel_types, mask_account=mask_account, customer_name=customer_name, bin_number=bin_number, reference_no=reference_no, recurring_id=recurring_id, transaction_source_type=transaction_source_type, reseller_ids=reseller_ids, merchant_ids=merchant_ids, trace_numbers=trace_numbers, search_text=search_text, merchant_reference=merchant_reference, additional_fields=additional_fields, payment_method=payment_method, export_to_csv=export_to_csv, export_to_pdf=export_to_pdf, skip_record_count=skip_record_count, total_record_count=total_record_count, batch_size=batch_size, payment_types=payment_types, merchant_dba_name=merchant_dba_name, payment_category=payment_category, sort_field=sort_field, email_id_to_receive_exported_transactions=email_id_to_receive_exported_transactions, is_transaction_cost_break_down=is_transaction_cost_break_down, batch_id=batch_id, suppress_technology_fee=suppress_technology_fee, start_row=start_row, page_size=page_size, asc=asc)
        print("The response of SecurePaymentsApi->secure_payments_search_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentsApi->secure_payments_search_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **start_date** | **str**| Start date for the transaction search | [optional] 
 **end_date** | **str**| End date for the transaction search | [optional] 
 **transaction_id** | **str**| Transaction identifier | [optional] 
 **reference_transaction_id** | **str**| Reference transaction identifier | [optional] 
 **transaction_statuses** | **str**| Status of the transaction | [optional] 
 **customer_ids** | **str**| Customer IDs associated with the transaction | [optional] 
 **transaction_type** | **str**| Type of the transaction | [optional] 
 **auth_code** | **str**| Authorization code of the transaction | [optional] 
 **card_holder_name** | **str**| Name of the cardholder | [optional] 
 **shopper_name** | **str**| ShopperName of the cardholder | [optional] 
 **amount** | **float**| Transaction amount | [optional] 
 **from_amount** | **float**| Minimum transaction amount | [optional] 
 **to_amount** | **float**| Maximum transaction amount | [optional] 
 **channel_types** | **str**| Channel types used for the transaction | [optional] 
 **mask_account** | **str**| Masked account number | [optional] 
 **customer_name** | **str**| Name of the customer | [optional] 
 **bin_number** | **str**| BinNumber | [optional] 
 **reference_no** | **str**| Reference number | [optional] 
 **recurring_id** | **str**| Recurring payment ID | [optional] 
 **transaction_source_type** | **str**| Transaction source type of the transaction | [optional] 
 **reseller_ids** | **str**| Reseller IDs associated with the transaction | [optional] 
 **merchant_ids** | **str**| Merchant IDs associated with the transaction | [optional] 
 **trace_numbers** | **str**| TraceNumbers associated with the transaction | [optional] 
 **search_text** | **str**| SearchText of the transaction | [optional] 
 **merchant_reference** | **str**| Merchant Reference of the transaction | [optional] 
 **additional_fields** | **str**| Additional Fields | [optional] 
 **payment_method** | **str**| Payment Method | [optional] 
 **export_to_csv** | **bool**| Export To Csv | [optional] 
 **export_to_pdf** | **bool**| Export To PDF | [optional] 
 **skip_record_count** | **int**| SkipRecordCount | [optional] 
 **total_record_count** | **int**| TotalRecordCount | [optional] 
 **batch_size** | **int**| BatchSize | [optional] 
 **payment_types** | **str**| Type of payment used in the transaction | [optional] 
 **merchant_dba_name** | **str**| MerchantDBAName | [optional] 
 **payment_category** | **str**| Category of payment used in the transaction | [optional] 
 **sort_field** | **str**| SortField | [optional] 
 **email_id_to_receive_exported_transactions** | **str**| EmailIdToReceiveExportedTransactions | [optional] 
 **is_transaction_cost_break_down** | **bool**| IsTransactionCostBreakDown | [optional] 
 **batch_id** | **str**| BatchId | [optional] 
 **suppress_technology_fee** | **bool**| SuppressTechnologyFee | [optional] 
 **start_row** | **float**| Set StartRow | [optional] 
 **page_size** | **float**| Set PageSize | [optional] 
 **asc** | **bool**| Set Asc | [optional] 

### Return type

[**AdminTransactionEntityResponse**](AdminTransactionEntityResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Successful operation |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **secure_paymentsdetails_post**
> SecurePaymentDetailsResponse secure_paymentsdetails_post(x_api_key, x_app_key, x_version, origin, secure_payment_details_request)

This API is used for getting details of Payments

### Example

* Api Key Authentication (x-api-key):
* Api Key Authentication (x-app-key):

```python
import openapi_client
from openapi_client.models.secure_payment_details_request import SecurePaymentDetailsRequest
from openapi_client.models.secure_payment_details_response import SecurePaymentDetailsResponse
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
    api_instance = openapi_client.SecurePaymentsApi(api_client)
    x_api_key = 'x_api_key_example' # str | an authorization header
    x_app_key = 'x_app_key_example' # str | an authorization header
    x_version = 'x_version_example' # str | x-version
    origin = 'origin_example' # str | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
    secure_payment_details_request = openapi_client.SecurePaymentDetailsRequest() # SecurePaymentDetailsRequest | Payment Details Request

    try:
        # This API is used for getting details of Payments
        api_response = api_instance.secure_paymentsdetails_post(x_api_key, x_app_key, x_version, origin, secure_payment_details_request)
        print("The response of SecurePaymentsApi->secure_paymentsdetails_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SecurePaymentsApi->secure_paymentsdetails_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x_api_key** | **str**| an authorization header | 
 **x_app_key** | **str**| an authorization header | 
 **x_version** | **str**| x-version | 
 **origin** | **str**| an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration | 
 **secure_payment_details_request** | [**SecurePaymentDetailsRequest**](SecurePaymentDetailsRequest.md)| Payment Details Request | 

### Return type

[**SecurePaymentDetailsResponse**](SecurePaymentDetailsResponse.md)

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

