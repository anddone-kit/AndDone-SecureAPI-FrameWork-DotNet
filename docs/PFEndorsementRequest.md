# PFEndorsementRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote** | [**PFEndorsementRequestQuote**](PFEndorsementRequestQuote.md) |  | 

## Example

```python
from openapi_client.models.pf_endorsement_request import PFEndorsementRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequest from a JSON string
pf_endorsement_request_instance = PFEndorsementRequest.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequest.to_json())

# convert the object into a dict
pf_endorsement_request_dict = pf_endorsement_request_instance.to_dict()
# create an instance of PFEndorsementRequest from a dict
pf_endorsement_request_from_dict = PFEndorsementRequest.from_dict(pf_endorsement_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


