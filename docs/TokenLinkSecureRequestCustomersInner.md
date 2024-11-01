# TokenLinkSecureRequestCustomersInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**first_name** | **str** |  | [optional] 
**last_name** | **str** |  | [optional] 
**email** | **str** |  | [optional] 
**phone** | **str** |  | [optional] 
**phone_country_code** | **str** |  | [optional] 
**address** | [**TokenLinkSecureRequestCustomersInnerAddress**](TokenLinkSecureRequestCustomersInnerAddress.md) |  | [optional] 

## Example

```python
from openapi_client.models.token_link_secure_request_customers_inner import TokenLinkSecureRequestCustomersInner

# TODO update the JSON string below
json = "{}"
# create an instance of TokenLinkSecureRequestCustomersInner from a JSON string
token_link_secure_request_customers_inner_instance = TokenLinkSecureRequestCustomersInner.from_json(json)
# print the JSON string representation of the object
print(TokenLinkSecureRequestCustomersInner.to_json())

# convert the object into a dict
token_link_secure_request_customers_inner_dict = token_link_secure_request_customers_inner_instance.to_dict()
# create an instance of TokenLinkSecureRequestCustomersInner from a dict
token_link_secure_request_customers_inner_from_dict = TokenLinkSecureRequestCustomersInner.from_dict(token_link_secure_request_customers_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


