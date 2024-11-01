# PaymentLinkRequestSettings


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**additional_details_preference** | **str** |  | [optional] 
**intent** | [**PaymentLinkRequestSettingsIntent**](PaymentLinkRequestSettingsIntent.md) |  | [optional] 
**selected_customer_fields** | **str** |  | [optional] 
**display_summary** | **bool** |  | [optional] 
**accept_customer_info** | **bool** |  | [optional] 
**remove_header** | **bool** |  | [optional] 
**accept_card** | **bool** |  | [optional] 
**accept_bank_account** | **bool** |  | [optional] 
**save_customer** | **bool** |  | [optional] 
**save_customer_account** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_request_settings import PaymentLinkRequestSettings

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkRequestSettings from a JSON string
payment_link_request_settings_instance = PaymentLinkRequestSettings.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkRequestSettings.to_json())

# convert the object into a dict
payment_link_request_settings_dict = payment_link_request_settings_instance.to_dict()
# create an instance of PaymentLinkRequestSettings from a dict
payment_link_request_settings_from_dict = PaymentLinkRequestSettings.from_dict(payment_link_request_settings_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


