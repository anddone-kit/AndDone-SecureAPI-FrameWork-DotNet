# TokenLinkSecureRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_id** | **str** |  | [optional] 
**title** | **str** |  | [optional] 
**expire_in** | **float** |  | [optional] 
**expire_in_unit** | **str** |  | [optional] 
**response_type** | **str** |  | [optional] 
**intent** | [**PaymentIntentRequestIntent**](PaymentIntentRequestIntent.md) |  | [optional] 
**callback_parameters** | [**PaymentLinkResponseCallbackParameters**](PaymentLinkResponseCallbackParameters.md) |  | [optional] 
**customers** | [**List[TokenLinkSecureRequestCustomersInner]**](TokenLinkSecureRequestCustomersInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.token_link_secure_request import TokenLinkSecureRequest

# TODO update the JSON string below
json = "{}"
# create an instance of TokenLinkSecureRequest from a JSON string
token_link_secure_request_instance = TokenLinkSecureRequest.from_json(json)
# print the JSON string representation of the object
print(TokenLinkSecureRequest.to_json())

# convert the object into a dict
token_link_secure_request_dict = token_link_secure_request_instance.to_dict()
# create an instance of TokenLinkSecureRequest from a dict
token_link_secure_request_from_dict = TokenLinkSecureRequest.from_dict(token_link_secure_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


