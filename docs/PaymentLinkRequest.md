# PaymentLinkRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**title** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**short_description** | **str** |  | [optional] 
**save_for_future** | **bool** |  | [optional] 
**payment_description** | **str** |  | [optional] 
**amount** | **float** |  | [optional] 
**invoice_number** | **str** |  | [optional] 
**enable_partial_payment** | **bool** |  | [optional] 
**enable_multiple_payment** | **bool** |  | [optional] 
**enable_protection** | **bool** |  | [optional] 
**display_receipt** | **bool** |  | [optional] 
**expire_in** | **int** |  | [optional] 
**expire_by** | **int** |  | [optional] 
**expire_on** | **str** |  | [optional] 
**reference_type** | **str** |  | [optional] 
**expire_in_unit** | **str** |  | [optional] 
**reference_number** | **str** |  | [optional] 
**reference_key** | **str** |  | [optional] 
**enable_premium_finance** | **bool** |  | [optional] 
**platform_settlement_status** | **str** |  | [optional] 
**reference_data_list** | [**List[PaymentLinkRequestReferenceDataListInner]**](PaymentLinkRequestReferenceDataListInner.md) |  | [optional] 
**account_number** | **str** |  | [optional] 
**response_type** | **str** |  | [optional] 
**callback_parameters** | [**PaymentLinkRequestCallbackParameters**](PaymentLinkRequestCallbackParameters.md) |  | [optional] 
**payment_link_type** | **str** |  | [optional] 
**apply_payment_adjustments** | **bool** |  | [optional] 
**quote_key** | **str** |  | [optional] 
**customers** | [**List[PaymentLinkRequestCustomersInner]**](PaymentLinkRequestCustomersInner.md) |  | [optional] 
**splits** | [**List[PaymentLinkRequestSplitsInner]**](PaymentLinkRequestSplitsInner.md) |  | [optional] 
**line_items** | [**List[PaymentLinkRequestLineItemsInner]**](PaymentLinkRequestLineItemsInner.md) |  | [optional] 
**settings** | [**PaymentLinkRequestSettings**](PaymentLinkRequestSettings.md) |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_request import PaymentLinkRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkRequest from a JSON string
payment_link_request_instance = PaymentLinkRequest.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkRequest.to_json())

# convert the object into a dict
payment_link_request_dict = payment_link_request_instance.to_dict()
# create an instance of PaymentLinkRequest from a dict
payment_link_request_from_dict = PaymentLinkRequest.from_dict(payment_link_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


