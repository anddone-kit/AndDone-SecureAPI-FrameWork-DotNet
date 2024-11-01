# PFLitePaymentLinkRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **str** |  | [optional] 
**is_pay_in_full** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.pf_lite_payment_link_request import PFLitePaymentLinkRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFLitePaymentLinkRequest from a JSON string
pf_lite_payment_link_request_instance = PFLitePaymentLinkRequest.from_json(json)
# print the JSON string representation of the object
print(PFLitePaymentLinkRequest.to_json())

# convert the object into a dict
pf_lite_payment_link_request_dict = pf_lite_payment_link_request_instance.to_dict()
# create an instance of PFLitePaymentLinkRequest from a dict
pf_lite_payment_link_request_from_dict = PFLitePaymentLinkRequest.from_dict(pf_lite_payment_link_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


