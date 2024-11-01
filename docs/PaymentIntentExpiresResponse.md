# PaymentIntentExpiresResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**message** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_intent_expires_response import PaymentIntentExpiresResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentIntentExpiresResponse from a JSON string
payment_intent_expires_response_instance = PaymentIntentExpiresResponse.from_json(json)
# print the JSON string representation of the object
print(PaymentIntentExpiresResponse.to_json())

# convert the object into a dict
payment_intent_expires_response_dict = payment_intent_expires_response_instance.to_dict()
# create an instance of PaymentIntentExpiresResponse from a dict
payment_intent_expires_response_from_dict = PaymentIntentExpiresResponse.from_dict(payment_intent_expires_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


