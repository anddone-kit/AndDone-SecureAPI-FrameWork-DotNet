# SecureTokenLinkResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_id** | **str** |  | [optional] 
**token_link_id** | **str** |  | [optional] 
**title** | **str** |  | [optional] 
**url** | **str** |  | [optional] 
**expire_on** | **str** |  | [optional] 
**created_on** | **str** |  | [optional] 
**modified_on** | **str** |  | [optional] 
**created_by** | **str** |  | [optional] 
**modified_by** | **str** |  | [optional] 
**token_link_status** | **str** |  | [optional] 
**response_type** | **str** |  | [optional] 
**call_back_parameters** | [**PaymentLinkResponseCallbackParameters**](PaymentLinkResponseCallbackParameters.md) |  | [optional] 
**intent** | [**SecureTokenLinkResponseIntent**](SecureTokenLinkResponseIntent.md) |  | [optional] 
**customers** | [**List[SecureTokenLinkResponseCustomersInner]**](SecureTokenLinkResponseCustomersInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.secure_token_link_response import SecureTokenLinkResponse

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTokenLinkResponse from a JSON string
secure_token_link_response_instance = SecureTokenLinkResponse.from_json(json)
# print the JSON string representation of the object
print(SecureTokenLinkResponse.to_json())

# convert the object into a dict
secure_token_link_response_dict = secure_token_link_response_instance.to_dict()
# create an instance of SecureTokenLinkResponse from a dict
secure_token_link_response_from_dict = SecureTokenLinkResponse.from_dict(secure_token_link_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


