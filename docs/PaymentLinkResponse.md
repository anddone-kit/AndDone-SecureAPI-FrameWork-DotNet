# PaymentLinkResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** | The unique identifier for the payment link. | [optional] 
**merchant_id** | **str** | The merchant identifier associated with the payment link. | [optional] 
**title** | **str** | The title or name of the payment link. | [optional] 
**payment_link** | **str** | The URL for the payment link. | [optional] 
**short_link** | **str** | A shortened version of the payment link. | [optional] 
**amount** | **float** | The amount to be paid. | [optional] 
**payment_description** | **str** | A description of the payment. | [optional] 
**expire_in** | **int** | The time in units after which the payment link expires. | [optional] 
**expire_in_unit** | **str** |  | [optional] 
**expire_on** | **str** | The exact expiry date of the payment link (ISO 8601 format). | [optional] 
**apply_payment_adjustments** | **bool** | Indicates whether payment adjustments are applied. | [optional] 
**enable_partial_payment** | **bool** | Indicates whether partial payment is allowed. | [optional] 
**enable_multiple_payment** | **bool** | Indicates whether multiple payments are allowed. | [optional] 
**no_of_payment_made** | **int** | The number of payments made. | [optional] 
**total_paid_amount** | **float** | The total amount paid so far. | [optional] 
**enable_protection** | **bool** | Indicates whether protection is enabled. | [optional] 
**protection_mode** | **str** |  | [optional] 
**display_receipt** | **bool** | Indicates whether a receipt should be displayed. | [optional] 
**link_status** | **str** |  | [optional] 
**invoice_number** | **str** | The invoice number associated with the payment link. | [optional] 
**created_on** | **str** | The date and time when the payment link was created (ISO 8601 format). | [optional] 
**created_by** | **str** | The identifier of the user who created the payment link. | [optional] 
**modified_on** | **str** | The date and time when the payment link was last modified (ISO 8601 format). | [optional] 
**modified_by** | **str** | The identifier of the user who last modified the payment link. | [optional] 
**short_description** | **str** | A brief description of the payment link. | [optional] 
**response_type** | **str** |  | [optional] 
**callback_parameters** | [**PaymentLinkResponseCallbackParameters**](PaymentLinkResponseCallbackParameters.md) |  | [optional] 
**display_settings** | [**PaymentLinkResponseDisplaySettings**](PaymentLinkResponseDisplaySettings.md) |  | [optional] 
**splits** | [**List[PaymentLinkResponseSplitsInner]**](PaymentLinkResponseSplitsInner.md) |  | [optional] 
**save_for_future** | **bool** |  | [optional] 
**quote_key** | **str** |  | [optional] 
**account_number** | **str** |  | [optional] 
**reference_type** | **str** |  | [optional] 
**reference_number** | **str** |  | [optional] 
**reference_key** | **str** |  | [optional] 
**reference_data_list** | [**List[PaymentLinkResponseReferenceDataListInner]**](PaymentLinkResponseReferenceDataListInner.md) |  | [optional] 
**enable_premium_finance** | **bool** |  | [optional] 
**suppress_technology_fee** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_response import PaymentLinkResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkResponse from a JSON string
payment_link_response_instance = PaymentLinkResponse.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkResponse.to_json())

# convert the object into a dict
payment_link_response_dict = payment_link_response_instance.to_dict()
# create an instance of PaymentLinkResponse from a dict
payment_link_response_from_dict = PaymentLinkResponse.from_dict(payment_link_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


