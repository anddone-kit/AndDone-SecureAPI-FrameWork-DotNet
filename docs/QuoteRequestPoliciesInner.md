# QuoteRequestPoliciesInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**policy_id** | **int** |  | 
**policy_number** | **int** |  | [optional] 
**premium** | **float** |  | 
**fee** | **float** |  | [optional] 
**tax** | **float** |  | [optional] 
**coverage** | **str** |  | 
**effective_date** | **str** |  | 
**expiration_date** | **str** |  | [optional] 
**term** | **int** |  | 
**minimum_earned** | **float** |  | [optional] 
**minimum_liability** | **float** |  | [optional] 
**maximum_liability** | **float** |  | [optional] 
**invoice_number** | **str** |  | [optional] 
**policy_fees** | [**List[QuoteRequestPoliciesInnerPolicyFeesInner]**](QuoteRequestPoliciesInnerPolicyFeesInner.md) |  | [optional] 
**company** | [**QuoteRequestPoliciesInnerCompany**](QuoteRequestPoliciesInnerCompany.md) |  | 

## Example

```python
from openapi_client.models.quote_request_policies_inner import QuoteRequestPoliciesInner

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteRequestPoliciesInner from a JSON string
quote_request_policies_inner_instance = QuoteRequestPoliciesInner.from_json(json)
# print the JSON string representation of the object
print(QuoteRequestPoliciesInner.to_json())

# convert the object into a dict
quote_request_policies_inner_dict = quote_request_policies_inner_instance.to_dict()
# create an instance of QuoteRequestPoliciesInner from a dict
quote_request_policies_inner_from_dict = QuoteRequestPoliciesInner.from_dict(quote_request_policies_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


