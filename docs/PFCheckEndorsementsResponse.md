# PFCheckEndorsementsResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**integration_id** | **str** |  | [optional] 
**is_success** | **bool** |  | [optional] 
**is_endorsement_eligible** | **bool** |  | [optional] 
**message** | **str** |  | [optional] 
**item** | [**PFCheckEndorsementsResponseItem**](PFCheckEndorsementsResponseItem.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_check_endorsements_response import PFCheckEndorsementsResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PFCheckEndorsementsResponse from a JSON string
pf_check_endorsements_response_instance = PFCheckEndorsementsResponse.from_json(json)
# print the JSON string representation of the object
print(PFCheckEndorsementsResponse.to_json())

# convert the object into a dict
pf_check_endorsements_response_dict = pf_check_endorsements_response_instance.to_dict()
# create an instance of PFCheckEndorsementsResponse from a dict
pf_check_endorsements_response_from_dict = PFCheckEndorsementsResponse.from_dict(pf_check_endorsements_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


