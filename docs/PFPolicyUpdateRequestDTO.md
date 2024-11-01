# PFPolicyUpdateRequestDTO


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **float** | This denotes the quote key. | 
**account_number** | **str** | This denotes the loan account number. | [optional] 
**premium** | **float** | This denotes the premium amount. | 
**category** | **str** | This denotes the coverage type. | 
**new_policy_number** | **str** | This denotes the new policy number. | 

## Example

```python
from openapi_client.models.pf_policy_update_request_dto import PFPolicyUpdateRequestDTO

# TODO update the JSON string below
json = "{}"
# create an instance of PFPolicyUpdateRequestDTO from a JSON string
pf_policy_update_request_dto_instance = PFPolicyUpdateRequestDTO.from_json(json)
# print the JSON string representation of the object
print(PFPolicyUpdateRequestDTO.to_json())

# convert the object into a dict
pf_policy_update_request_dto_dict = pf_policy_update_request_dto_instance.to_dict()
# create an instance of PFPolicyUpdateRequestDTO from a dict
pf_policy_update_request_dto_from_dict = PFPolicyUpdateRequestDTO.from_dict(pf_policy_update_request_dto_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


