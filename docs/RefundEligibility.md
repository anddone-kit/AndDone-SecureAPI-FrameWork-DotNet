# RefundEligibility


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**refund_eligible** | **bool** |  | [optional] 
**message** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.refund_eligibility import RefundEligibility

# TODO update the JSON string below
json = "{}"
# create an instance of RefundEligibility from a JSON string
refund_eligibility_instance = RefundEligibility.from_json(json)
# print the JSON string representation of the object
print(RefundEligibility.to_json())

# convert the object into a dict
refund_eligibility_dict = refund_eligibility_instance.to_dict()
# create an instance of RefundEligibility from a dict
refund_eligibility_from_dict = RefundEligibility.from_dict(refund_eligibility_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


