# SecureMerchantTokenShortResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**token_link_id** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**self_token** | **str** |  | [optional] 
**token_provider** | **str** |  | [optional] 
**account_holder_name** | **str** |  | [optional] 
**card_number** | **str** |  | [optional] 
**card_expiry** | **str** |  | [optional] 
**routing_number** | **str** |  | [optional] 
**masked_account_number** | **str** |  | [optional] 
**process_method** | **str** |  | [optional] 
**channel_type** | **str** |  | [optional] 
**address** | [**PaymentRequestBillingContactAddress**](PaymentRequestBillingContactAddress.md) |  | [optional] 

## Example

```python
from openapi_client.models.secure_merchant_token_short_response import SecureMerchantTokenShortResponse

# TODO update the JSON string below
json = "{}"
# create an instance of SecureMerchantTokenShortResponse from a JSON string
secure_merchant_token_short_response_instance = SecureMerchantTokenShortResponse.from_json(json)
# print the JSON string representation of the object
print(SecureMerchantTokenShortResponse.to_json())

# convert the object into a dict
secure_merchant_token_short_response_dict = secure_merchant_token_short_response_instance.to_dict()
# create an instance of SecureMerchantTokenShortResponse from a dict
secure_merchant_token_short_response_from_dict = SecureMerchantTokenShortResponse.from_dict(secure_merchant_token_short_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


