# SecurePaymentDetailsResponseAchTenderInfo


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bank_name** | **str** |  | [optional] 
**routing_number** | **str** |  | [optional] 
**check_type** | **str** |  | [optional] 
**check_number** | **str** |  | [optional] 
**name_on_check** | **str** |  | [optional] 
**account_holder_name** | **str** |  | [optional] 
**account_category** | **str** |  | [optional] 
**capture_amount** | **float** |  | [optional] 
**amount** | **float** |  | [optional] 
**convenience_amount** | **float** |  | [optional] 
**bin_number** | **str** |  | [optional] 
**tax_amount** | **float** |  | [optional] 
**tax_after_discount** | **bool** |  | [optional] 
**tax_percent** | **float** |  | [optional] 
**adjustment_percent_value** | **float** |  | [optional] 
**adjustment_fixed_value** | **float** |  | [optional] 
**adjustment_amount** | **float** |  | [optional] 
**adjustment_display_name** | **float** |  | [optional] 
**adjustment_descriptor_message** | **float** |  | [optional] 
**payment_adjustment_type** | **float** |  | [optional] 
**pre_auth_code** | **float** |  | [optional] 
**mask_account** | **float** |  | [optional] 
**account_token** | **float** |  | [optional] 
**account_token_message** | **str** |  | [optional] 
**create_account_token** | **str** |  | [optional] 
**discount_type** | **str** |  | [optional] 
**discount_percent** | **str** |  | [optional] 
**discount_amount** | **float** |  | [optional] 
**commission_type** | **str** |  | [optional] 
**commission_value** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_details_response_ach_tender_info import SecurePaymentDetailsResponseAchTenderInfo

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentDetailsResponseAchTenderInfo from a JSON string
secure_payment_details_response_ach_tender_info_instance = SecurePaymentDetailsResponseAchTenderInfo.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentDetailsResponseAchTenderInfo.to_json())

# convert the object into a dict
secure_payment_details_response_ach_tender_info_dict = secure_payment_details_response_ach_tender_info_instance.to_dict()
# create an instance of SecurePaymentDetailsResponseAchTenderInfo from a dict
secure_payment_details_response_ach_tender_info_from_dict = SecurePaymentDetailsResponseAchTenderInfo.from_dict(secure_payment_details_response_ach_tender_info_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


