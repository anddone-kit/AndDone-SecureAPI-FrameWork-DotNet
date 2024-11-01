# GetQuoteRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_intent_id** | **str** | This denotes the payment intent id. | 
**merchant_token** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.get_quote_request import GetQuoteRequest

# TODO update the JSON string below
json = "{}"
# create an instance of GetQuoteRequest from a JSON string
get_quote_request_instance = GetQuoteRequest.from_json(json)
# print the JSON string representation of the object
print(GetQuoteRequest.to_json())

# convert the object into a dict
get_quote_request_dict = get_quote_request_instance.to_dict()
# create an instance of GetQuoteRequest from a dict
get_quote_request_from_dict = GetQuoteRequest.from_dict(get_quote_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


