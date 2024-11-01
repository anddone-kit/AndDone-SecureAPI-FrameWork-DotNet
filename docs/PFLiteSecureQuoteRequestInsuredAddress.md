# PFLiteSecureQuoteRequestInsuredAddress


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address1** | **str** |  | 
**address2** | **str** |  | 
**city** | **str** |  | 
**state** | **str** |  | 
**zip** | **str** |  | 
**phone** | **str** |  | 

## Example

```python
from openapi_client.models.pf_lite_secure_quote_request_insured_address import PFLiteSecureQuoteRequestInsuredAddress

# TODO update the JSON string below
json = "{}"
# create an instance of PFLiteSecureQuoteRequestInsuredAddress from a JSON string
pf_lite_secure_quote_request_insured_address_instance = PFLiteSecureQuoteRequestInsuredAddress.from_json(json)
# print the JSON string representation of the object
print(PFLiteSecureQuoteRequestInsuredAddress.to_json())

# convert the object into a dict
pf_lite_secure_quote_request_insured_address_dict = pf_lite_secure_quote_request_insured_address_instance.to_dict()
# create an instance of PFLiteSecureQuoteRequestInsuredAddress from a dict
pf_lite_secure_quote_request_insured_address_from_dict = PFLiteSecureQuoteRequestInsuredAddress.from_dict(pf_lite_secure_quote_request_insured_address_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


