# PFLiteSecureQuoteRequestPoliciesInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**policy_number** | **str** |  | 
**premium** | **float** |  | [optional] 
**coverage_type** | **str** |  | [optional] 
**effective_date** | **str** |  | 
**minimum_earned_percent** | **float** |  | 
**carrier** | [**PFLiteSecureQuoteRequestPoliciesInnerCarrier**](PFLiteSecureQuoteRequestPoliciesInnerCarrier.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_lite_secure_quote_request_policies_inner import PFLiteSecureQuoteRequestPoliciesInner

# TODO update the JSON string below
json = "{}"
# create an instance of PFLiteSecureQuoteRequestPoliciesInner from a JSON string
pf_lite_secure_quote_request_policies_inner_instance = PFLiteSecureQuoteRequestPoliciesInner.from_json(json)
# print the JSON string representation of the object
print(PFLiteSecureQuoteRequestPoliciesInner.to_json())

# convert the object into a dict
pf_lite_secure_quote_request_policies_inner_dict = pf_lite_secure_quote_request_policies_inner_instance.to_dict()
# create an instance of PFLiteSecureQuoteRequestPoliciesInner from a dict
pf_lite_secure_quote_request_policies_inner_from_dict = PFLiteSecureQuoteRequestPoliciesInner.from_dict(pf_lite_secure_quote_request_policies_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


