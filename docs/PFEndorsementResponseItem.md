# PFEndorsementResponseItem


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**save_status** | **str** |  | [optional] 
**quote** | [**PFEndorsementResponseItemQuote**](PFEndorsementResponseItemQuote.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_response_item import PFEndorsementResponseItem

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementResponseItem from a JSON string
pf_endorsement_response_item_instance = PFEndorsementResponseItem.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementResponseItem.to_json())

# convert the object into a dict
pf_endorsement_response_item_dict = pf_endorsement_response_item_instance.to_dict()
# create an instance of PFEndorsementResponseItem from a dict
pf_endorsement_response_item_from_dict = PFEndorsementResponseItem.from_dict(pf_endorsement_response_item_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


