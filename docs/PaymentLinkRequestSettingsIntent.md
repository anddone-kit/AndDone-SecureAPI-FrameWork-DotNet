# PaymentLinkRequestSettingsIntent


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_types** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_request_settings_intent import PaymentLinkRequestSettingsIntent

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkRequestSettingsIntent from a JSON string
payment_link_request_settings_intent_instance = PaymentLinkRequestSettingsIntent.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkRequestSettingsIntent.to_json())

# convert the object into a dict
payment_link_request_settings_intent_dict = payment_link_request_settings_intent_instance.to_dict()
# create an instance of PaymentLinkRequestSettingsIntent from a dict
payment_link_request_settings_intent_from_dict = PaymentLinkRequestSettingsIntent.from_dict(payment_link_request_settings_intent_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


