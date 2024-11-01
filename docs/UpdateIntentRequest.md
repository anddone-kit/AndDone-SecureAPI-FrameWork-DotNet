# UpdateIntentRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_intent_id** | **str** |  | [optional] 
**quote_key** | **str** |  | [optional] 
**merchant_token** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.update_intent_request import UpdateIntentRequest

# TODO update the JSON string below
json = "{}"
# create an instance of UpdateIntentRequest from a JSON string
update_intent_request_instance = UpdateIntentRequest.from_json(json)
# print the JSON string representation of the object
print(UpdateIntentRequest.to_json())

# convert the object into a dict
update_intent_request_dict = update_intent_request_instance.to_dict()
# create an instance of UpdateIntentRequest from a dict
update_intent_request_from_dict = UpdateIntentRequest.from_dict(update_intent_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


