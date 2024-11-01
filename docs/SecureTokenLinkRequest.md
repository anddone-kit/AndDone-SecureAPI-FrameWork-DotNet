# SecureTokenLinkRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**token_link_id** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_token_link_request import SecureTokenLinkRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTokenLinkRequest from a JSON string
secure_token_link_request_instance = SecureTokenLinkRequest.from_json(json)
# print the JSON string representation of the object
print(SecureTokenLinkRequest.to_json())

# convert the object into a dict
secure_token_link_request_dict = secure_token_link_request_instance.to_dict()
# create an instance of SecureTokenLinkRequest from a dict
secure_token_link_request_from_dict = SecureTokenLinkRequest.from_dict(secure_token_link_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


