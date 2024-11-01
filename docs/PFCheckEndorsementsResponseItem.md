# PFCheckEndorsementsResponseItem


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**agreement_id** | **float** |  | [optional] 
**client_id** | **float** |  | [optional] 
**account_number** | **str** |  | [optional] 
**client_name** | **str** |  | [optional] 
**is_commercial** | **bool** |  | [optional] 
**policies** | [**List[PFCheckEndorsementsResponseItemPoliciesInner]**](PFCheckEndorsementsResponseItemPoliciesInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_check_endorsements_response_item import PFCheckEndorsementsResponseItem

# TODO update the JSON string below
json = "{}"
# create an instance of PFCheckEndorsementsResponseItem from a JSON string
pf_check_endorsements_response_item_instance = PFCheckEndorsementsResponseItem.from_json(json)
# print the JSON string representation of the object
print(PFCheckEndorsementsResponseItem.to_json())

# convert the object into a dict
pf_check_endorsements_response_item_dict = pf_check_endorsements_response_item_instance.to_dict()
# create an instance of PFCheckEndorsementsResponseItem from a dict
pf_check_endorsements_response_item_from_dict = PFCheckEndorsementsResponseItem.from_dict(pf_check_endorsements_response_item_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


