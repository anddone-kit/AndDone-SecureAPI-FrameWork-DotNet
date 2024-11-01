# PaymentIntentRequestIntent


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_types** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.payment_intent_request_intent import PaymentIntentRequestIntent

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentIntentRequestIntent from a JSON string
payment_intent_request_intent_instance = PaymentIntentRequestIntent.from_json(json)
# print the JSON string representation of the object
print(PaymentIntentRequestIntent.to_json())

# convert the object into a dict
payment_intent_request_intent_dict = payment_intent_request_intent_instance.to_dict()
# create an instance of PaymentIntentRequestIntent from a dict
payment_intent_request_intent_from_dict = PaymentIntentRequestIntent.from_dict(payment_intent_request_intent_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


