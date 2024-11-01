# TransactionDetailResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_id** | **str** |  | [optional] 
**transaction_code** | **str** |  | [optional] 
**transaction_origin** | **str** |  | [optional] 
**refund_origin** | **str** |  | [optional] 
**billing_contact** | [**PaymentRequestBillingContact**](PaymentRequestBillingContact.md) |  | [optional] 
**reference_transaction_id** | **str** |  | [optional] 
**transaction_date** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**ip_address** | **str** |  | [optional] 
**operation_type** | **str** |  | [optional] 
**channel_type** | **str** |  | [optional] 
**process_method** | **str** |  | [optional] 
**payment_type** | **str** |  | [optional] 
**payment_category** | **str** |  | [optional] 
**processor_name** | **str** |  | [optional] 
**tender_info** | [**TransactionDetailResponseTenderInfo**](TransactionDetailResponseTenderInfo.md) |  | [optional] 
**reference_customer_id** | **str** |  | [optional] 
**customer_account_id** | **str** |  | [optional] 
**invoice_no** | **str** |  | [optional] 
**reference_no** | **str** |  | [optional] 
**remarks** | **str** |  | [optional] 
**terminal_id** | **str** |  | [optional] 
**transaction_status** | **str** |  | [optional] 
**previous_transaction_status** | **str** |  | [optional] 
**transaction_result** | [**TransactionDetailResponseTransactionResult**](TransactionDetailResponseTransactionResult.md) |  | [optional] 
**partner_id** | **int** |  | [optional] 
**order_id** | **int** |  | [optional] 
**invoice_id** | **int** |  | [optional] 
**masked_invoice_id** | **str** |  | [optional] 
**payment_link_id** | **int** |  | [optional] 
**masked_token_link_id** | **int** |  | [optional] 
**masked_payment_link_id** | **int** |  | [optional] 
**additional_fields** | **str** |  | [optional] 
**settlement_date** | **str** |  | [optional] 
**issuer** | **str** |  | [optional] 
**merchant_name** | **str** |  | [optional] 
**merchant_dba_name** | **str** |  | [optional] 
**splits** | [**List[TransactionDetailResponseSplitsInner]**](TransactionDetailResponseSplitsInner.md) |  | [optional] 
**payment_description** | **str** |  | [optional] 
**refund_transactions** | [**TransactionDetailResponseRefundTransactions**](TransactionDetailResponseRefundTransactions.md) |  | [optional] 
**total_refund_amount** | **float** |  | [optional] 
**remaining_amount** | **float** |  | [optional] 
**chargeback_reason** | **str** |  | [optional] 
**chargeback_reason_code** | **str** |  | [optional] 
**chargeback_date_time** | **str** |  | [optional] 
**sub_total_amount** | **float** |  | [optional] 
**company_name** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.transaction_detail_response import TransactionDetailResponse

# TODO update the JSON string below
json = "{}"
# create an instance of TransactionDetailResponse from a JSON string
transaction_detail_response_instance = TransactionDetailResponse.from_json(json)
# print the JSON string representation of the object
print(TransactionDetailResponse.to_json())

# convert the object into a dict
transaction_detail_response_dict = transaction_detail_response_instance.to_dict()
# create an instance of TransactionDetailResponse from a dict
transaction_detail_response_from_dict = TransactionDetailResponse.from_dict(transaction_detail_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


