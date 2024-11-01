# PaymentRequestBillingContactAddress


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_line1** | **str** |  | [optional] 
**address_line2** | **str** |  | [optional] 
**city** | **str** |  | [optional] 
**state** | **str** |  | [optional] 
**country** | **float** |  | [optional] 
**postal_code** | **str** |  | [optional] 
**time_zone** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_request_billing_contact_address import PaymentRequestBillingContactAddress

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentRequestBillingContactAddress from a JSON string
payment_request_billing_contact_address_instance = PaymentRequestBillingContactAddress.from_json(json)
# print the JSON string representation of the object
print(PaymentRequestBillingContactAddress.to_json())

# convert the object into a dict
payment_request_billing_contact_address_dict = payment_request_billing_contact_address_instance.to_dict()
# create an instance of PaymentRequestBillingContactAddress from a dict
payment_request_billing_contact_address_from_dict = PaymentRequestBillingContactAddress.from_dict(payment_request_billing_contact_address_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


