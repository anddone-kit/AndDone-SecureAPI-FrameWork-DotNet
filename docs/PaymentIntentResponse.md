# PaymentIntentResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_token** | **str** |  | [optional] 
**amount** | **float** |  | [optional] 
**title** | **str** |  | [optional] 
**short_description** | **str** |  | [optional] 
**payment_description** | **str** |  | [optional] 
**invoice_number** | **str** |  | [optional] 
**expires_on** | **str** |  | [optional] 
**intent** | [**PaymentIntentRequestIntent**](PaymentIntentRequestIntent.md) |  | [optional] 

## Example

```python
from openapi_client.models.payment_intent_response import PaymentIntentResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentIntentResponse from a JSON string
payment_intent_response_instance = PaymentIntentResponse.from_json(json)
# print the JSON string representation of the object
print(PaymentIntentResponse.to_json())

# convert the object into a dict
payment_intent_response_dict = payment_intent_response_instance.to_dict()
# create an instance of PaymentIntentResponse from a dict
payment_intent_response_from_dict = PaymentIntentResponse.from_dict(payment_intent_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


