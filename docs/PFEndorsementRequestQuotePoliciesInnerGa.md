# PFEndorsementRequestQuotePoliciesInnerGa


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
from openapi_client.models.pf_endorsement_request_quote_policies_inner_ga import PFEndorsementRequestQuotePoliciesInnerGa

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuotePoliciesInnerGa from a JSON string
pf_endorsement_request_quote_policies_inner_ga_instance = PFEndorsementRequestQuotePoliciesInnerGa.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuotePoliciesInnerGa.to_json())

# convert the object into a dict
pf_endorsement_request_quote_policies_inner_ga_dict = pf_endorsement_request_quote_policies_inner_ga_instance.to_dict()
# create an instance of PFEndorsementRequestQuotePoliciesInnerGa from a dict
pf_endorsement_request_quote_policies_inner_ga_from_dict = PFEndorsementRequestQuotePoliciesInnerGa.from_dict(pf_endorsement_request_quote_policies_inner_ga_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


