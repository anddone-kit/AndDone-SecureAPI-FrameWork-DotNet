# PFUpdatePFARequestDTO


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **float** | This denotes the quoteKey. | 

## Example

```python
from openapi_client.models.pf_update_pfa_request_dto import PFUpdatePFARequestDTO

# TODO update the JSON string below
json = "{}"
# create an instance of PFUpdatePFARequestDTO from a JSON string
pf_update_pfa_request_dto_instance = PFUpdatePFARequestDTO.from_json(json)
# print the JSON string representation of the object
print(PFUpdatePFARequestDTO.to_json())

# convert the object into a dict
pf_update_pfa_request_dto_dict = pf_update_pfa_request_dto_instance.to_dict()
# create an instance of PFUpdatePFARequestDTO from a dict
pf_update_pfa_request_dto_from_dict = PFUpdatePFARequestDTO.from_dict(pf_update_pfa_request_dto_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


