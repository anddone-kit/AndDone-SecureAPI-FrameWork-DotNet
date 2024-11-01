# PFPolicyUpdateResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**message** | **str** |  | [optional] 
**is_success** | **bool** |  | [optional] 
**integration_id** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.pf_policy_update_response import PFPolicyUpdateResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PFPolicyUpdateResponse from a JSON string
pf_policy_update_response_instance = PFPolicyUpdateResponse.from_json(json)
# print the JSON string representation of the object
print(PFPolicyUpdateResponse.to_json())

# convert the object into a dict
pf_policy_update_response_dict = pf_policy_update_response_instance.to_dict()
# create an instance of PFPolicyUpdateResponse from a dict
pf_policy_update_response_from_dict = PFPolicyUpdateResponse.from_dict(pf_policy_update_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


