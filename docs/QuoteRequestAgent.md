# QuoteRequestAgent


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**unique_id** | **str** |  | 
**email** | **str** |  | 
**address** | [**QuoteRequestInsuredAddress**](QuoteRequestInsuredAddress.md) |  | 

## Example

```python
from openapi_client.models.quote_request_agent import QuoteRequestAgent

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteRequestAgent from a JSON string
quote_request_agent_instance = QuoteRequestAgent.from_json(json)
# print the JSON string representation of the object
print(QuoteRequestAgent.to_json())

# convert the object into a dict
quote_request_agent_dict = quote_request_agent_instance.to_dict()
# create an instance of QuoteRequestAgent from a dict
quote_request_agent_from_dict = QuoteRequestAgent.from_dict(quote_request_agent_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


