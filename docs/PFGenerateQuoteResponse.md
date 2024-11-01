# PFGenerateQuoteResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**is_success** | **bool** | Indicates if the quote generation was successful. | [optional] 
**message** | **str** | A message related to the quote generation. | [optional] 
**integration_id** | **str** | The integration ID associated with the quote generation. | [optional] 
**item** | [**PFGenerateQuoteResponseItem**](PFGenerateQuoteResponseItem.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_generate_quote_response import PFGenerateQuoteResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PFGenerateQuoteResponse from a JSON string
pf_generate_quote_response_instance = PFGenerateQuoteResponse.from_json(json)
# print the JSON string representation of the object
print(PFGenerateQuoteResponse.to_json())

# convert the object into a dict
pf_generate_quote_response_dict = pf_generate_quote_response_instance.to_dict()
# create an instance of PFGenerateQuoteResponse from a dict
pf_generate_quote_response_from_dict = PFGenerateQuoteResponse.from_dict(pf_generate_quote_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


