# PaymentRequestPFR


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**entity** | **str** |  | [optional] 
**reference** | **str** |  | [optional] 
**quote** | **str** |  | [optional] 
**account_number** | **str** |  | [optional] 
**payment_type** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_request_pfr import PaymentRequestPFR

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentRequestPFR from a JSON string
payment_request_pfr_instance = PaymentRequestPFR.from_json(json)
# print the JSON string representation of the object
print(PaymentRequestPFR.to_json())

# convert the object into a dict
payment_request_pfr_dict = payment_request_pfr_instance.to_dict()
# create an instance of PaymentRequestPFR from a dict
payment_request_pfr_from_dict = PaymentRequestPFR.from_dict(payment_request_pfr_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


