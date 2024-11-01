# PaymentLinkResponseDisplaySettingsIntent


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_types** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_response_display_settings_intent import PaymentLinkResponseDisplaySettingsIntent

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkResponseDisplaySettingsIntent from a JSON string
payment_link_response_display_settings_intent_instance = PaymentLinkResponseDisplaySettingsIntent.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkResponseDisplaySettingsIntent.to_json())

# convert the object into a dict
payment_link_response_display_settings_intent_dict = payment_link_response_display_settings_intent_instance.to_dict()
# create an instance of PaymentLinkResponseDisplaySettingsIntent from a dict
payment_link_response_display_settings_intent_from_dict = PaymentLinkResponseDisplaySettingsIntent.from_dict(payment_link_response_display_settings_intent_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


