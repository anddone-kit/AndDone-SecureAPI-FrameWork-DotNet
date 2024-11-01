# PaymentRequestBillingContactName


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**title** | **str** |  | [optional] 
**first_name** | **str** |  | [optional] 
**middle_name** | **str** |  | [optional] 
**last_name** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_request_billing_contact_name import PaymentRequestBillingContactName

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentRequestBillingContactName from a JSON string
payment_request_billing_contact_name_instance = PaymentRequestBillingContactName.from_json(json)
# print the JSON string representation of the object
print(PaymentRequestBillingContactName.to_json())

# convert the object into a dict
payment_request_billing_contact_name_dict = payment_request_billing_contact_name_instance.to_dict()
# create an instance of PaymentRequestBillingContactName from a dict
payment_request_billing_contact_name_from_dict = PaymentRequestBillingContactName.from_dict(payment_request_billing_contact_name_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


