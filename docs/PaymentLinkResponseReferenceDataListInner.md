# PaymentLinkResponseReferenceDataListInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**reference_type** | **str** |  | [optional] 
**reference_number** | **str** |  | [optional] 
**reference_key** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_response_reference_data_list_inner import PaymentLinkResponseReferenceDataListInner

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkResponseReferenceDataListInner from a JSON string
payment_link_response_reference_data_list_inner_instance = PaymentLinkResponseReferenceDataListInner.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkResponseReferenceDataListInner.to_json())

# convert the object into a dict
payment_link_response_reference_data_list_inner_dict = payment_link_response_reference_data_list_inner_instance.to_dict()
# create an instance of PaymentLinkResponseReferenceDataListInner from a dict
payment_link_response_reference_data_list_inner_from_dict = PaymentLinkResponseReferenceDataListInner.from_dict(payment_link_response_reference_data_list_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


