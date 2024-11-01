# PFRetrievePFARequestDTO


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **str** |  | [optional] 
**merchant_token** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.pf_retrieve_pfa_request_dto import PFRetrievePFARequestDTO

# TODO update the JSON string below
json = "{}"
# create an instance of PFRetrievePFARequestDTO from a JSON string
pf_retrieve_pfa_request_dto_instance = PFRetrievePFARequestDTO.from_json(json)
# print the JSON string representation of the object
print(PFRetrievePFARequestDTO.to_json())

# convert the object into a dict
pf_retrieve_pfa_request_dto_dict = pf_retrieve_pfa_request_dto_instance.to_dict()
# create an instance of PFRetrievePFARequestDTO from a dict
pf_retrieve_pfa_request_dto_from_dict = PFRetrievePFARequestDTO.from_dict(pf_retrieve_pfa_request_dto_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


