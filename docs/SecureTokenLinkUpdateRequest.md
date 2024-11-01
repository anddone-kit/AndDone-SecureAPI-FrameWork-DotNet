# SecureTokenLinkUpdateRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**token_link_id** | **str** |  | [optional] 
**expire_in** | **float** |  | [optional] 
**response_type** | **str** |  | [optional] 
**expire_in_unit** | **str** |  | [optional] 
**intent** | [**PaymentIntentRequestIntent**](PaymentIntentRequestIntent.md) |  | [optional] 

## Example

```python
from openapi_client.models.secure_token_link_update_request import SecureTokenLinkUpdateRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTokenLinkUpdateRequest from a JSON string
secure_token_link_update_request_instance = SecureTokenLinkUpdateRequest.from_json(json)
# print the JSON string representation of the object
print(SecureTokenLinkUpdateRequest.to_json())

# convert the object into a dict
secure_token_link_update_request_dict = secure_token_link_update_request_instance.to_dict()
# create an instance of SecureTokenLinkUpdateRequest from a dict
secure_token_link_update_request_from_dict = SecureTokenLinkUpdateRequest.from_dict(secure_token_link_update_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


