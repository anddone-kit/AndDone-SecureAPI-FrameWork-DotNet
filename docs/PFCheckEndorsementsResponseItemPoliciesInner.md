# PFCheckEndorsementsResponseItemPoliciesInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**policy_id** | **float** |  | [optional] 
**company_name** | **str** |  | [optional] 
**policy_number** | **str** |  | [optional] 
**premium** | **float** |  | [optional] 
**coverage_type** | **str** |  | [optional] 
**coverage_type_description** | **str** |  | [optional] 
**company_type_id** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.pf_check_endorsements_response_item_policies_inner import PFCheckEndorsementsResponseItemPoliciesInner

# TODO update the JSON string below
json = "{}"
# create an instance of PFCheckEndorsementsResponseItemPoliciesInner from a JSON string
pf_check_endorsements_response_item_policies_inner_instance = PFCheckEndorsementsResponseItemPoliciesInner.from_json(json)
# print the JSON string representation of the object
print(PFCheckEndorsementsResponseItemPoliciesInner.to_json())

# convert the object into a dict
pf_check_endorsements_response_item_policies_inner_dict = pf_check_endorsements_response_item_policies_inner_instance.to_dict()
# create an instance of PFCheckEndorsementsResponseItemPoliciesInner from a dict
pf_check_endorsements_response_item_policies_inner_from_dict = PFCheckEndorsementsResponseItemPoliciesInner.from_dict(pf_check_endorsements_response_item_policies_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


