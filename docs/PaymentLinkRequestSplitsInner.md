# PaymentLinkRequestSplitsInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**virtual_account** | **str** |  | [optional] 
**account_type** | **float** |  | [optional] 
**amount** | **float** |  | [optional] 
**reference** | **str** |  | [optional] 
**charge_indicator** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_request_splits_inner import PaymentLinkRequestSplitsInner

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkRequestSplitsInner from a JSON string
payment_link_request_splits_inner_instance = PaymentLinkRequestSplitsInner.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkRequestSplitsInner.to_json())

# convert the object into a dict
payment_link_request_splits_inner_dict = payment_link_request_splits_inner_instance.to_dict()
# create an instance of PaymentLinkRequestSplitsInner from a dict
payment_link_request_splits_inner_from_dict = PaymentLinkRequestSplitsInner.from_dict(payment_link_request_splits_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


