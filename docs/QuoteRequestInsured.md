# QuoteRequestInsured


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**agent_customer_number** | **str** |  | 
**email** | **str** |  | 
**care_of** | **str** |  | 
**unique_id** | **str** |  | [optional] 
**address** | [**QuoteRequestInsuredAddress**](QuoteRequestInsuredAddress.md) |  | 

## Example

```python
from openapi_client.models.quote_request_insured import QuoteRequestInsured

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteRequestInsured from a JSON string
quote_request_insured_instance = QuoteRequestInsured.from_json(json)
# print the JSON string representation of the object
print(QuoteRequestInsured.to_json())

# convert the object into a dict
quote_request_insured_dict = quote_request_insured_instance.to_dict()
# create an instance of QuoteRequestInsured from a dict
quote_request_insured_from_dict = QuoteRequestInsured.from_dict(quote_request_insured_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


