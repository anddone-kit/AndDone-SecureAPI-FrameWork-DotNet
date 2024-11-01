# TransactionDetailResponseRefundTransactions


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**total_row_counts** | **float** |  | [optional] 
**data** | [**List[TransactionDetailResponseRefundTransactionsDataInner]**](TransactionDetailResponseRefundTransactionsDataInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.transaction_detail_response_refund_transactions import TransactionDetailResponseRefundTransactions

# TODO update the JSON string below
json = "{}"
# create an instance of TransactionDetailResponseRefundTransactions from a JSON string
transaction_detail_response_refund_transactions_instance = TransactionDetailResponseRefundTransactions.from_json(json)
# print the JSON string representation of the object
print(TransactionDetailResponseRefundTransactions.to_json())

# convert the object into a dict
transaction_detail_response_refund_transactions_dict = transaction_detail_response_refund_transactions_instance.to_dict()
# create an instance of TransactionDetailResponseRefundTransactions from a dict
transaction_detail_response_refund_transactions_from_dict = TransactionDetailResponseRefundTransactions.from_dict(transaction_detail_response_refund_transactions_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


