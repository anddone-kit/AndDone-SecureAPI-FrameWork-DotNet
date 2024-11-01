# PaymentRequestCustomerIndentityRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**d_ob** | **str** |  | [optional] 
**s_sn** | **str** |  | [optional] 
**driving_license_number** | **str** |  | [optional] 
**driving_license_state** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_request_customer_indentity_request import PaymentRequestCustomerIndentityRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentRequestCustomerIndentityRequest from a JSON string
payment_request_customer_indentity_request_instance = PaymentRequestCustomerIndentityRequest.from_json(json)
# print the JSON string representation of the object
print(PaymentRequestCustomerIndentityRequest.to_json())

# convert the object into a dict
payment_request_customer_indentity_request_dict = payment_request_customer_indentity_request_instance.to_dict()
# create an instance of PaymentRequestCustomerIndentityRequest from a dict
payment_request_customer_indentity_request_from_dict = PaymentRequestCustomerIndentityRequest.from_dict(payment_request_customer_indentity_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


