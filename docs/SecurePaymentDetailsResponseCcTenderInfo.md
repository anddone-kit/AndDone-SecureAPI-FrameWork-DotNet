# SecurePaymentDetailsResponseCcTenderInfo


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_holder_name** | **str** |  | [optional] 
**mask_card_number** | **str** |  | [optional] 
**card_expiry** | **str** |  | [optional] 
**capture_amount** | **float** |  | [optional] 
**amount** | **float** |  | [optional] 
**bin_number** | **str** |  | [optional] 
**tax_amount** | **float** |  | [optional] 
**tax_after_discount** | **bool** |  | [optional] 
**tax_percent** | **float** |  | [optional] 
**adjustment_percent_value** | **float** |  | [optional] 
**adjustment_fixed_value** | **float** |  | [optional] 
**adjustment_amount** | **float** |  | [optional] 
**adjustment_display_name** | **str** |  | [optional] 
**adjustment_descriptor_message** | **str** |  | [optional] 
**payment_adjustment_type** | **str** |  | [optional] 
**pre_auth_code** | **str** |  | [optional] 
**mask_account** | **float** |  | [optional] 
**account_token** | **str** |  | [optional] 
**account_token_message** | **str** |  | [optional] 
**create_account_token** | **bool** |  | [optional] 
**discount_type** | **str** |  | [optional] 
**discount_percent** | **float** |  | [optional] 
**discount_amount** | **float** |  | [optional] 
**convenience_amount** | **float** |  | [optional] 
**commission_type** | **str** |  | [optional] 
**commission_value** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_details_response_cc_tender_info import SecurePaymentDetailsResponseCcTenderInfo

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentDetailsResponseCcTenderInfo from a JSON string
secure_payment_details_response_cc_tender_info_instance = SecurePaymentDetailsResponseCcTenderInfo.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentDetailsResponseCcTenderInfo.to_json())

# convert the object into a dict
secure_payment_details_response_cc_tender_info_dict = secure_payment_details_response_cc_tender_info_instance.to_dict()
# create an instance of SecurePaymentDetailsResponseCcTenderInfo from a dict
secure_payment_details_response_cc_tender_info_from_dict = SecurePaymentDetailsResponseCcTenderInfo.from_dict(secure_payment_details_response_cc_tender_info_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


