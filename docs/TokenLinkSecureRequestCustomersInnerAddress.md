# TokenLinkSecureRequestCustomersInnerAddress


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_line1** | **str** |  | [optional] 
**address_line2** | **str** |  | [optional] 
**city** | **str** |  | [optional] 
**state** | **str** |  | [optional] 
**country** | **float** |  | [optional] 
**postal_code** | **str** |  | [optional] 
**time_zone** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.token_link_secure_request_customers_inner_address import TokenLinkSecureRequestCustomersInnerAddress

# TODO update the JSON string below
json = "{}"
# create an instance of TokenLinkSecureRequestCustomersInnerAddress from a JSON string
token_link_secure_request_customers_inner_address_instance = TokenLinkSecureRequestCustomersInnerAddress.from_json(json)
# print the JSON string representation of the object
print(TokenLinkSecureRequestCustomersInnerAddress.to_json())

# convert the object into a dict
token_link_secure_request_customers_inner_address_dict = token_link_secure_request_customers_inner_address_instance.to_dict()
# create an instance of TokenLinkSecureRequestCustomersInnerAddress from a dict
token_link_secure_request_customers_inner_address_from_dict = TokenLinkSecureRequestCustomersInnerAddress.from_dict(token_link_secure_request_customers_inner_address_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


