# GetQuoteKeyRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.get_quote_key_request import GetQuoteKeyRequest

# TODO update the JSON string below
json = "{}"
# create an instance of GetQuoteKeyRequest from a JSON string
get_quote_key_request_instance = GetQuoteKeyRequest.from_json(json)
# print the JSON string representation of the object
print(GetQuoteKeyRequest.to_json())

# convert the object into a dict
get_quote_key_request_dict = get_quote_key_request_instance.to_dict()
# create an instance of GetQuoteKeyRequest from a dict
get_quote_key_request_from_dict = GetQuoteKeyRequest.from_dict(get_quote_key_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


