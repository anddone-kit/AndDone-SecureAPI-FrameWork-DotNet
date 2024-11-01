# PFEndorsementRequestQuotePoliciesInnerCompany


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**best_number** | **str** |  | [optional] 
**unique_id** | **str** |  | 
**name** | **str** |  | 
**care_of** | **str** |  | [optional] 
**address1** | **str** |  | 
**address2** | **str** |  | [optional] 
**city** | **str** |  | 
**state** | **str** |  | 
**zip** | **str** |  | 
**phone** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote_policies_inner_company import PFEndorsementRequestQuotePoliciesInnerCompany

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuotePoliciesInnerCompany from a JSON string
pf_endorsement_request_quote_policies_inner_company_instance = PFEndorsementRequestQuotePoliciesInnerCompany.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuotePoliciesInnerCompany.to_json())

# convert the object into a dict
pf_endorsement_request_quote_policies_inner_company_dict = pf_endorsement_request_quote_policies_inner_company_instance.to_dict()
# create an instance of PFEndorsementRequestQuotePoliciesInnerCompany from a dict
pf_endorsement_request_quote_policies_inner_company_from_dict = PFEndorsementRequestQuotePoliciesInnerCompany.from_dict(pf_endorsement_request_quote_policies_inner_company_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


