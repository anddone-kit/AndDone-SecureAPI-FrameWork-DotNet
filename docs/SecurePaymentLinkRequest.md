# SecurePaymentLinkRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_link_id** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_link_request import SecurePaymentLinkRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentLinkRequest from a JSON string
secure_payment_link_request_instance = SecurePaymentLinkRequest.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentLinkRequest.to_json())

# convert the object into a dict
secure_payment_link_request_dict = secure_payment_link_request_instance.to_dict()
# create an instance of SecurePaymentLinkRequest from a dict
secure_payment_link_request_from_dict = SecurePaymentLinkRequest.from_dict(secure_payment_link_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


