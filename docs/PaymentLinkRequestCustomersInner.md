# PaymentLinkRequestCustomersInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**first_name** | **str** |  | [optional] 
**last_name** | **str** |  | [optional] 
**email** | **str** |  | [optional] 
**phone** | **str** |  | [optional] 
**notify_via_sms** | **bool** |  | [optional] 
**notify_via_email** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_request_customers_inner import PaymentLinkRequestCustomersInner

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkRequestCustomersInner from a JSON string
payment_link_request_customers_inner_instance = PaymentLinkRequestCustomersInner.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkRequestCustomersInner.to_json())

# convert the object into a dict
payment_link_request_customers_inner_dict = payment_link_request_customers_inner_instance.to_dict()
# create an instance of PaymentLinkRequestCustomersInner from a dict
payment_link_request_customers_inner_from_dict = PaymentLinkRequestCustomersInner.from_dict(payment_link_request_customers_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


