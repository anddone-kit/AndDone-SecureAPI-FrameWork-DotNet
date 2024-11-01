# PFRetrievePFARequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **str** | This denotes the quoteKey. | [optional] 

## Example

```python
from openapi_client.models.pf_retrieve_pfa_request import PFRetrievePFARequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFRetrievePFARequest from a JSON string
pf_retrieve_pfa_request_instance = PFRetrievePFARequest.from_json(json)
# print the JSON string representation of the object
print(PFRetrievePFARequest.to_json())

# convert the object into a dict
pf_retrieve_pfa_request_dict = pf_retrieve_pfa_request_instance.to_dict()
# create an instance of PFRetrievePFARequest from a dict
pf_retrieve_pfa_request_from_dict = PFRetrievePFARequest.from_dict(pf_retrieve_pfa_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


