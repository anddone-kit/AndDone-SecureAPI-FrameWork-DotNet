# SecurePaymentDetailsRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**payment_token** | **str** |  | [optional] 
**type** | **str** |  | [optional] 
**include_refund_transactions** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_details_request import SecurePaymentDetailsRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentDetailsRequest from a JSON string
secure_payment_details_request_instance = SecurePaymentDetailsRequest.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentDetailsRequest.to_json())

# convert the object into a dict
secure_payment_details_request_dict = secure_payment_details_request_instance.to_dict()
# create an instance of SecurePaymentDetailsRequest from a dict
secure_payment_details_request_from_dict = SecurePaymentDetailsRequest.from_dict(secure_payment_details_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


