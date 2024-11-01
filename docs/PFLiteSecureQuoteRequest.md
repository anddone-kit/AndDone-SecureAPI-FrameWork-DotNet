# PFLiteSecureQuoteRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_id** | **str** |  | [optional] 
**merchant** | [**PFLiteSecureQuoteRequestMerchant**](PFLiteSecureQuoteRequestMerchant.md) |  | [optional] 
**insured** | [**PFLiteSecureQuoteRequestInsured**](PFLiteSecureQuoteRequestInsured.md) |  | [optional] 
**program** | [**PFLiteSecureQuoteRequestProgram**](PFLiteSecureQuoteRequestProgram.md) |  | [optional] 
**policies** | [**List[PFLiteSecureQuoteRequestPoliciesInner]**](PFLiteSecureQuoteRequestPoliciesInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_lite_secure_quote_request import PFLiteSecureQuoteRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFLiteSecureQuoteRequest from a JSON string
pf_lite_secure_quote_request_instance = PFLiteSecureQuoteRequest.from_json(json)
# print the JSON string representation of the object
print(PFLiteSecureQuoteRequest.to_json())

# convert the object into a dict
pf_lite_secure_quote_request_dict = pf_lite_secure_quote_request_instance.to_dict()
# create an instance of PFLiteSecureQuoteRequest from a dict
pf_lite_secure_quote_request_from_dict = PFLiteSecureQuoteRequest.from_dict(pf_lite_secure_quote_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


