# PaymentLinkResponseDisplaySettings


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**selected_customer_fields** | **str** |  | [optional] 
**additional_details_preference** | **str** |  | [optional] 
**display_summary** | **bool** |  | [optional] 
**accept_customer_info** | **bool** |  | [optional] 
**remove_header** | **bool** |  | [optional] 
**accept_card** | **bool** |  | [optional] 
**accept_bank_account** | **bool** |  | [optional] 
**save_customer** | **bool** |  | [optional] 
**save_customer_account** | **bool** |  | [optional] 
**intent** | [**PaymentLinkResponseDisplaySettingsIntent**](PaymentLinkResponseDisplaySettingsIntent.md) |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_response_display_settings import PaymentLinkResponseDisplaySettings

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkResponseDisplaySettings from a JSON string
payment_link_response_display_settings_instance = PaymentLinkResponseDisplaySettings.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkResponseDisplaySettings.to_json())

# convert the object into a dict
payment_link_response_display_settings_dict = payment_link_response_display_settings_instance.to_dict()
# create an instance of PaymentLinkResponseDisplaySettings from a dict
payment_link_response_display_settings_from_dict = PaymentLinkResponseDisplaySettings.from_dict(payment_link_response_display_settings_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


