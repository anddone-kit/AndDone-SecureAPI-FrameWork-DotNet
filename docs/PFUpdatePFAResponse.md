# PFUpdatePFAResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**message** | **str** |  | [optional] 
**is_success** | **bool** |  | [optional] 
**integration_id** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.pf_update_pfa_response import PFUpdatePFAResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PFUpdatePFAResponse from a JSON string
pf_update_pfa_response_instance = PFUpdatePFAResponse.from_json(json)
# print the JSON string representation of the object
print(PFUpdatePFAResponse.to_json())

# convert the object into a dict
pf_update_pfa_response_dict = pf_update_pfa_response_instance.to_dict()
# create an instance of PFUpdatePFAResponse from a dict
pf_update_pfa_response_from_dict = PFUpdatePFAResponse.from_dict(pf_update_pfa_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


