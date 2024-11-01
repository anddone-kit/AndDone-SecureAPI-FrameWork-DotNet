# PFCheckEndorsementsRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_number** | **str** | This denotes the loan account number. | 
**quote_key** | **str** | This denotes the quoteKey. | [optional] 
**is_commercial** | **bool** | This denotes the flag which identifies if the agreement is commercial LOB or Personal LOB. | [optional] 

## Example

```python
from openapi_client.models.pf_check_endorsements_request import PFCheckEndorsementsRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFCheckEndorsementsRequest from a JSON string
pf_check_endorsements_request_instance = PFCheckEndorsementsRequest.from_json(json)
# print the JSON string representation of the object
print(PFCheckEndorsementsRequest.to_json())

# convert the object into a dict
pf_check_endorsements_request_dict = pf_check_endorsements_request_instance.to_dict()
# create an instance of PFCheckEndorsementsRequest from a dict
pf_check_endorsements_request_from_dict = PFCheckEndorsementsRequest.from_dict(pf_check_endorsements_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


