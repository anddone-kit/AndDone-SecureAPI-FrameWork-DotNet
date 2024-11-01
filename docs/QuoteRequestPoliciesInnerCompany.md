# QuoteRequestPoliciesInnerCompany


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**best_number** | **str** |  | [optional] 
**name** | **str** |  | [optional] 
**unique_id** | **str** |  | [optional] 
**address1** | **str** |  | [optional] 
**address2** | **str** |  | [optional] 
**city** | **str** |  | [optional] 
**state** | **str** |  | [optional] 
**zip** | **str** |  | [optional] 
**phone** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.quote_request_policies_inner_company import QuoteRequestPoliciesInnerCompany

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteRequestPoliciesInnerCompany from a JSON string
quote_request_policies_inner_company_instance = QuoteRequestPoliciesInnerCompany.from_json(json)
# print the JSON string representation of the object
print(QuoteRequestPoliciesInnerCompany.to_json())

# convert the object into a dict
quote_request_policies_inner_company_dict = quote_request_policies_inner_company_instance.to_dict()
# create an instance of QuoteRequestPoliciesInnerCompany from a dict
quote_request_policies_inner_company_from_dict = QuoteRequestPoliciesInnerCompany.from_dict(quote_request_policies_inner_company_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


