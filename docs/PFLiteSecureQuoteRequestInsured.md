# PFLiteSecureQuoteRequestInsured


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**first_name** | **str** |  | 
**last_name** | **str** |  | 
**mobile_phone_number** | **str** |  | [optional] 
**email_address** | **str** |  | [optional] 
**is_cancellation_warning_via_text_enabled** | **bool** |  | [optional] 
**address** | [**PFLiteSecureQuoteRequestInsuredAddress**](PFLiteSecureQuoteRequestInsuredAddress.md) |  | 

## Example

```python
from openapi_client.models.pf_lite_secure_quote_request_insured import PFLiteSecureQuoteRequestInsured

# TODO update the JSON string below
json = "{}"
# create an instance of PFLiteSecureQuoteRequestInsured from a JSON string
pf_lite_secure_quote_request_insured_instance = PFLiteSecureQuoteRequestInsured.from_json(json)
# print the JSON string representation of the object
print(PFLiteSecureQuoteRequestInsured.to_json())

# convert the object into a dict
pf_lite_secure_quote_request_insured_dict = pf_lite_secure_quote_request_insured_instance.to_dict()
# create an instance of PFLiteSecureQuoteRequestInsured from a dict
pf_lite_secure_quote_request_insured_from_dict = PFLiteSecureQuoteRequestInsured.from_dict(pf_lite_secure_quote_request_insured_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


