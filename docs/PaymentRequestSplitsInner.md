# PaymentRequestSplitsInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**virtual_account** | **str** |  | [optional] 
**amount** | **float** |  | [optional] 
**reference** | **str** |  | [optional] 
**account_type** | **str** |  | [optional] 
**charge_indicator** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.payment_request_splits_inner import PaymentRequestSplitsInner

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentRequestSplitsInner from a JSON string
payment_request_splits_inner_instance = PaymentRequestSplitsInner.from_json(json)
# print the JSON string representation of the object
print(PaymentRequestSplitsInner.to_json())

# convert the object into a dict
payment_request_splits_inner_dict = payment_request_splits_inner_instance.to_dict()
# create an instance of PaymentRequestSplitsInner from a dict
payment_request_splits_inner_from_dict = PaymentRequestSplitsInner.from_dict(payment_request_splits_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


