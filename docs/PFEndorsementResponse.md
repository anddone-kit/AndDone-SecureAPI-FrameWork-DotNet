# PFEndorsementResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**integration_id** | **str** |  | [optional] 
**is_success** | **bool** |  | [optional] 
**message** | **str** |  | [optional] 
**item** | [**PFEndorsementResponseItem**](PFEndorsementResponseItem.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_response import PFEndorsementResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementResponse from a JSON string
pf_endorsement_response_instance = PFEndorsementResponse.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementResponse.to_json())

# convert the object into a dict
pf_endorsement_response_dict = pf_endorsement_response_instance.to_dict()
# create an instance of PFEndorsementResponse from a dict
pf_endorsement_response_from_dict = PFEndorsementResponse.from_dict(pf_endorsement_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


