# SecureTokenLinkByIdResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**token_link_id** | **str** |  | [optional] 
**title** | **str** |  | [optional] 
**token_link** | **str** |  | [optional] 
**expire_on** | **str** |  | [optional] 
**created_on** | **str** |  | [optional] 
**modified_on** | **str** |  | [optional] 
**created_by** | **str** |  | [optional] 
**modified_by** | **str** |  | [optional] 
**token_link_status** | **str** |  | [optional] 
**account_token** | [**SecureTokenLinkByIdResponseAccountToken**](SecureTokenLinkByIdResponseAccountToken.md) |  | [optional] 
**intent** | [**SecureTokenLinkByIdResponseIntent**](SecureTokenLinkByIdResponseIntent.md) |  | [optional] 
**customers** | [**List[SecureTokenLinkResponseCustomersInner]**](SecureTokenLinkResponseCustomersInner.md) |  | [optional] 
**time_line** | [**List[SecureTokenLinkByIdResponseTimeLineInner]**](SecureTokenLinkByIdResponseTimeLineInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.secure_token_link_by_id_response import SecureTokenLinkByIdResponse

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTokenLinkByIdResponse from a JSON string
secure_token_link_by_id_response_instance = SecureTokenLinkByIdResponse.from_json(json)
# print the JSON string representation of the object
print(SecureTokenLinkByIdResponse.to_json())

# convert the object into a dict
secure_token_link_by_id_response_dict = secure_token_link_by_id_response_instance.to_dict()
# create an instance of SecureTokenLinkByIdResponse from a dict
secure_token_link_by_id_response_from_dict = SecureTokenLinkByIdResponse.from_dict(secure_token_link_by_id_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


