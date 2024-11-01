# QuoteRequestInsuredAddress


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **str** |  | [optional] 
**address1** | **str** |  | [optional] 
**address2** | **str** |  | [optional] 
**city** | **str** |  | [optional] 
**state** | **str** |  | [optional] 
**zip** | **str** |  | [optional] 
**phone** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.quote_request_insured_address import QuoteRequestInsuredAddress

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteRequestInsuredAddress from a JSON string
quote_request_insured_address_instance = QuoteRequestInsuredAddress.from_json(json)
# print the JSON string representation of the object
print(QuoteRequestInsuredAddress.to_json())

# convert the object into a dict
quote_request_insured_address_dict = quote_request_insured_address_instance.to_dict()
# create an instance of QuoteRequestInsuredAddress from a dict
quote_request_insured_address_from_dict = QuoteRequestInsuredAddress.from_dict(quote_request_insured_address_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


