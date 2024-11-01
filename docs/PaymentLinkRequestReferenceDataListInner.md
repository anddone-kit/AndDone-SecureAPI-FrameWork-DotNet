# PaymentLinkRequestReferenceDataListInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**reference_type** | **str** |  | [optional] 
**reference_number** | **str** |  | [optional] 
**reference_key** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_request_reference_data_list_inner import PaymentLinkRequestReferenceDataListInner

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkRequestReferenceDataListInner from a JSON string
payment_link_request_reference_data_list_inner_instance = PaymentLinkRequestReferenceDataListInner.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkRequestReferenceDataListInner.to_json())

# convert the object into a dict
payment_link_request_reference_data_list_inner_dict = payment_link_request_reference_data_list_inner_instance.to_dict()
# create an instance of PaymentLinkRequestReferenceDataListInner from a dict
payment_link_request_reference_data_list_inner_from_dict = PaymentLinkRequestReferenceDataListInner.from_dict(payment_link_request_reference_data_list_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


