# SecureTokenLinkResponseCustomersInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**first_name** | **str** |  | [optional] 
**last_name** | **str** |  | [optional] 
**email** | **str** |  | [optional] 
**phone** | **str** |  | [optional] 
**address** | [**TokenLinkSecureRequestCustomersInnerAddress**](TokenLinkSecureRequestCustomersInnerAddress.md) |  | [optional] 

## Example

```python
from openapi_client.models.secure_token_link_response_customers_inner import SecureTokenLinkResponseCustomersInner

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTokenLinkResponseCustomersInner from a JSON string
secure_token_link_response_customers_inner_instance = SecureTokenLinkResponseCustomersInner.from_json(json)
# print the JSON string representation of the object
print(SecureTokenLinkResponseCustomersInner.to_json())

# convert the object into a dict
secure_token_link_response_customers_inner_dict = secure_token_link_response_customers_inner_instance.to_dict()
# create an instance of SecureTokenLinkResponseCustomersInner from a dict
secure_token_link_response_customers_inner_from_dict = SecureTokenLinkResponseCustomersInner.from_dict(secure_token_link_response_customers_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


