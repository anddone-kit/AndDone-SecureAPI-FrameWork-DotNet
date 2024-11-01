# SecureTransactionDetailDTOTenderInfo


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bank_name** | **str** |  | [optional] 
**routing_number** | **str** |  | [optional] 
**raw_micr_line** | **str** |  | [optional] 
**account_type** | **str** |  | [optional] 
**check_type** | **str** |  | [optional] 
**check_number** | **str** |  | [optional] 
**account_category** | **str** |  | [optional] 
**account_holder_name** | **str** |  | [optional] 
**name_on_check** | **str** |  | [optional] 
**card_holder_name** | **str** |  | [optional] 
**card_type** | **str** |  | [optional] 
**mask_card_number** | **str** |  | [optional] 
**bin_number** | **str** |  | [optional] 
**card_expiry** | **str** |  | [optional] 
**c_v_data** | **str** |  | [optional] 
**c_v_data_status** | **str** |  | [optional] 
**track_data** | **str** |  | [optional] 
**rx_amount** | **float** |  | [optional] 
**vision_amount** | **float** |  | [optional] 
**dental_amount** | **float** |  | [optional] 
**clinic_amount** | **float** |  | [optional] 
**is_check_card** | **bool** |  | [optional] 
**capture_amount** | **float** |  | [optional] 
**amount** | **float** |  | [optional] 
**tip_amount** | **float** |  | [optional] 
**convenience_amount** | **float** |  | [optional] 
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
**mask_account** | **str** |  | [optional] 
**e_pb** | **str** |  | [optional] 
**k_sn** | **str** |  | [optional] 
**cash_back_amount** | **float** |  | [optional] 
**account_token** | **str** |  | [optional] 
**account_token_message** | **str** |  | [optional] 
**create_account_token** | **bool** |  | [optional] 
**discount_type** | **str** |  | [optional] 
**discount_percent** | **float** |  | [optional] 
**discount_amount** | **float** |  | [optional] 
**commission_type** | **str** |  | [optional] 
**commission_value** | **float** |  | [optional] 
**commission_fixed_value** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.secure_transaction_detail_dto_tender_info import SecureTransactionDetailDTOTenderInfo

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTransactionDetailDTOTenderInfo from a JSON string
secure_transaction_detail_dto_tender_info_instance = SecureTransactionDetailDTOTenderInfo.from_json(json)
# print the JSON string representation of the object
print(SecureTransactionDetailDTOTenderInfo.to_json())

# convert the object into a dict
secure_transaction_detail_dto_tender_info_dict = secure_transaction_detail_dto_tender_info_instance.to_dict()
# create an instance of SecureTransactionDetailDTOTenderInfo from a dict
secure_transaction_detail_dto_tender_info_from_dict = SecureTransactionDetailDTOTenderInfo.from_dict(secure_transaction_detail_dto_tender_info_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


