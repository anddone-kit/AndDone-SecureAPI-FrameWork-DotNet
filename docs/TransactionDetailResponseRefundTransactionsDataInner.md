# TransactionDetailResponseRefundTransactionsDataInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_id** | **str** |  | [optional] 
**masked_merchant_id** | **str** |  | [optional] 
**ip_address** | **str** |  | [optional] 
**transaction_date** | **str** |  | [optional] 
**operation_type** | **str** |  | [optional] 
**channel_type** | **str** |  | [optional] 
**process_method** | **str** |  | [optional] 
**is_debit** | **bool** |  | [optional] 
**reference_transaction_id** | **str** |  | [optional] 
**reference_customer_id** | **int** |  | [optional] 
**masked_reference_customer_id** | **str** |  | [optional] 
**customer_account_id** | **int** |  | [optional] 
**masked_customer_account_id** | **str** |  | [optional] 
**recurring_id** | **int** |  | [optional] 
**masked_recurring_id** | **str** |  | [optional] 
**batch_id** | **int** |  | [optional] 
**transaction_status** | **str** |  | [optional] 
**settlement_date** | **str** |  | [optional] 
**auth_code** | **str** |  | [optional] 
**card_number** | **str** |  | [optional] 
**account_number** | **str** |  | [optional] 
**bin_number** | **str** |  | [optional] 
**cheque_number** | **str** |  | [optional] 
**routing_number** | **str** |  | [optional] 
**name_on_check_or_card** | **str** |  | [optional] 
**account_holder_name** | **str** |  | [optional] 
**account_category** | **str** |  | [optional] 
**training_mode** | **bool** |  | [optional] 
**amount** | **float** |  | [optional] 
**tip_amount** | **float** |  | [optional] 
**convenience_amount** | **float** |  | [optional] 
**capture_amount** | **float** |  | [optional] 
**tax_percent** | **float** |  | [optional] 
**tax_amount** | **float** |  | [optional] 
**surchage_percent** | **float** |  | [optional] 
**surchage_amount** | **float** |  | [optional] 
**cash_discount_percent** | **float** |  | [optional] 
**cash_discount_amount** | **float** |  | [optional] 
**cash_incentive_type** | **str** |  | [optional] 
**cash_incentive_percent** | **float** |  | [optional] 
**cash_incentive_amount** | **float** |  | [optional] 
**clinic_amount** | **float** |  | [optional] 
**dental_amount** | **float** |  | [optional] 
**rx_amount** | **float** |  | [optional] 
**vision_amount** | **float** |  | [optional] 
**card_type** | **str** |  | [optional] 
**created_on** | **str** |  | [optional] 
**created_by** | **str** |  | [optional] 
**modified_on** | **str** |  | [optional] 
**modified_by** | **str** |  | [optional] 
**customer_name** | **str** |  | [optional] 
**partner_id** | **int** |  | [optional] 
**masked_partner_id** | **str** |  | [optional] 
**partner_name** | **str** |  | [optional] 
**order_id** | **int** |  | [optional] 
**masked_order_id** | **str** |  | [optional] 
**invoice_id** | **int** |  | [optional] 
**masked_invoice_id** | **str** |  | [optional] 
**payment_link_id** | **int** |  | [optional] 
**masked_payment_link_id** | **str** |  | [optional] 
**reference_no** | **str** |  | [optional] 
**processor_name** | **str** |  | [optional] 
**processor_display_name** | **str** |  | [optional] 
**processor_code** | **str** |  | [optional] 
**verification2_code** | **str** |  | [optional] 
**transaction_origin** | **str** |  | [optional] 
**previous_transaction_status** | **str** |  | [optional] 
**trace_number** | **str** |  | [optional] 
**merchant_reference** | **str** |  | [optional] 
**additiona_fields** | **str** |  | [optional] 
**adjustment_value** | **float** |  | [optional] 
**adjustment_fixed_value** | **float** |  | [optional] 
**adjustment_amount** | **float** |  | [optional] 
**adjustment_display_name** | **str** |  | [optional] 
**adjustment_descriptor_message** | **str** |  | [optional] 
**payment_adjustment_type** | **str** |  | [optional] 
**commission_type** | **str** |  | [optional] 
**commission_value** | **float** |  | [optional] 
**commission_fixed_value** | **float** |  | [optional] 
**account_token** | **str** |  | [optional] 
**payment_type** | **str** |  | [optional] 
**payment_category** | **str** |  | [optional] 
**refund_reason** | **str** |  | [optional] 
**refund_detail** | **str** |  | [optional] 
**refund_type** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.transaction_detail_response_refund_transactions_data_inner import TransactionDetailResponseRefundTransactionsDataInner

# TODO update the JSON string below
json = "{}"
# create an instance of TransactionDetailResponseRefundTransactionsDataInner from a JSON string
transaction_detail_response_refund_transactions_data_inner_instance = TransactionDetailResponseRefundTransactionsDataInner.from_json(json)
# print the JSON string representation of the object
print(TransactionDetailResponseRefundTransactionsDataInner.to_json())

# convert the object into a dict
transaction_detail_response_refund_transactions_data_inner_dict = transaction_detail_response_refund_transactions_data_inner_instance.to_dict()
# create an instance of TransactionDetailResponseRefundTransactionsDataInner from a dict
transaction_detail_response_refund_transactions_data_inner_from_dict = TransactionDetailResponseRefundTransactionsDataInner.from_dict(transaction_detail_response_refund_transactions_data_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


