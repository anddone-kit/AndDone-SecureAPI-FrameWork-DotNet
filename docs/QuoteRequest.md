# QuoteRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_id** | **str** |  | [optional] 
**payment_intent_id** | **str** |  | 
**details** | [**QuoteRequestDetails**](QuoteRequestDetails.md) |  | 
**insured** | [**QuoteRequestInsured**](QuoteRequestInsured.md) |  | 
**agent** | [**QuoteRequestAgent**](QuoteRequestAgent.md) |  | 
**policies** | [**List[QuoteRequestPoliciesInner]**](QuoteRequestPoliciesInner.md) |  | 

## Example

```python
from openapi_client.models.quote_request import QuoteRequest

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteRequest from a JSON string
quote_request_instance = QuoteRequest.from_json(json)
# print the JSON string representation of the object
print(QuoteRequest.to_json())

# convert the object into a dict
quote_request_dict = quote_request_instance.to_dict()
# create an instance of QuoteRequest from a dict
quote_request_from_dict = QuoteRequest.from_dict(quote_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


