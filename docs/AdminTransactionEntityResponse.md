# AdminTransactionEntityResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_id** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**merchant_name** | **str** |  | [optional] 
**transaction_date** | **str** |  | [optional] 
**operation_type** | **str** |  | [optional] 
**channel_type** | **str** |  | [optional] 
**process_method** | **str** |  | [optional] 
**is_debit** | **bool** |  | [optional] 
**reference_transaction_id** | **str** |  | [optional] 
**reference_customer_id** | **str** |  | [optional] 
**customer_account_id** | **str** |  | [optional] 
**recurring_id** | **str** |  | [optional] 
**batch_id** | **str** |  | [optional] 
**transaction_status** | **str** |  | [optional] 
**settlement_date** | **str** |  | [optional] 
**auth_code** | **str** |  | [optional] 
**card_number** | **str** |  | [optional] 
**account_number** | **str** |  | [optional] 
**cheque_number** | **str** |  | [optional] 
**routing_number** | **str** |  | [optional] 
**name_on_check_or_card** | **str** |  | [optional] 
**account_holder_name** | **str** |  | [optional] 
**account_category** | **str** |  | [optional] 
**amount** | **float** |  | [optional] 
**convenience_amount** | **float** |  | [optional] 
**capture_amount** | **float** |  | [optional] 
**tax_percent** | **float** |  | [optional] 
**tax_amount** | **float** |  | [optional] 
**card_type** | **str** |  | [optional] 
**customer_name** | **str** |  | [optional] 
**masked_invoice_id** | **str** |  | [optional] 
**masked_payment_link_id** | **str** |  | [optional] 
**reference_no** | **str** |  | [optional] 
**processor_name** | **str** |  | [optional] 
**processor_display_name** | **str** |  | [optional] 
**processor_code** | **str** |  | [optional] 
**verification2_code** | **str** |  | [optional] 
**transaction_origin** | **str** |  | [optional] 
**commission_type** | **str** |  | [optional] 
**commission_value** | **float** |  | [optional] 
**commission_fixed_value** | **float** |  | [optional] 
**adjustment_fixed_value** | **float** |  | [optional] 
**adjustment_value** | **float** |  | [optional] 
**adjustment_value_type** | **str** |  | [optional] 
**adjustment_amount** | **float** |  | [optional] 
**adjustment_display_name** | **str** |  | [optional] 
**adjustment_descriptor_message** | **str** |  | [optional] 
**payment_adjustment_type** | **str** |  | [optional] 
**trace_number** | **str** |  | [optional] 
**created_on** | **str** |  | [optional] 
**created_by** | **str** |  | [optional] 
**modified_on** | **str** |  | [optional] 
**modified_by** | **str** |  | [optional] 
**merchant_reference** | **str** |  | [optional] 
**additiona_fields** | **str** |  | [optional] 
**payment_type** | **str** |  | [optional] 
**payment_category** | **str** |  | [optional] 
**merchant_dba_name** | **str** |  | [optional] 
**full_account_number** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.admin_transaction_entity_response import AdminTransactionEntityResponse

# TODO update the JSON string below
json = "{}"
# create an instance of AdminTransactionEntityResponse from a JSON string
admin_transaction_entity_response_instance = AdminTransactionEntityResponse.from_json(json)
# print the JSON string representation of the object
print(AdminTransactionEntityResponse.to_json())

# convert the object into a dict
admin_transaction_entity_response_dict = admin_transaction_entity_response_instance.to_dict()
# create an instance of AdminTransactionEntityResponse from a dict
admin_transaction_entity_response_from_dict = AdminTransactionEntityResponse.from_dict(admin_transaction_entity_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


