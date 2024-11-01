# PaymentRequestBillingContact


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | [**PaymentRequestBillingContactName**](PaymentRequestBillingContactName.md) |  | [optional] 
**company_name** | **str** |  | [optional] 
**department** | **str** |  | [optional] 
**fax** | **str** |  | [optional] 
**phone** | **str** |  | [optional] 
**alternate_phone** | **str** |  | [optional] 
**mobile** | **str** |  | [optional] 
**email** | **str** |  | [optional] 
**u_rl** | **str** |  | [optional] 
**address** | [**PaymentRequestBillingContactAddress**](PaymentRequestBillingContactAddress.md) |  | [optional] 

## Example

```python
from openapi_client.models.payment_request_billing_contact import PaymentRequestBillingContact

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentRequestBillingContact from a JSON string
payment_request_billing_contact_instance = PaymentRequestBillingContact.from_json(json)
# print the JSON string representation of the object
print(PaymentRequestBillingContact.to_json())

# convert the object into a dict
payment_request_billing_contact_dict = payment_request_billing_contact_instance.to_dict()
# create an instance of PaymentRequestBillingContact from a dict
payment_request_billing_contact_from_dict = PaymentRequestBillingContact.from_dict(payment_request_billing_contact_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


