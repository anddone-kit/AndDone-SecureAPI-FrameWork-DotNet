# TransactionDetailResponseTransactionResult


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**success** | **bool** |  | [optional] 
**processor_auth_code** | **str** |  | [optional] 
**trace_number** | **str** |  | [optional] 
**reason_code** | **str** |  | [optional] 
**reason_message** | **str** |  | [optional] 
**addition_result_data** | **str** |  | [optional] 
**addition_result_data2** | **str** |  | [optional] 
**verification_status** | **bool** |  | [optional] 
**verification1_code** | **str** |  | [optional] 
**verification2_code** | **str** |  | [optional] 
**error_code** | **str** |  | [optional] 
**error_message** | **str** |  | [optional] 
**merchant_reference** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.transaction_detail_response_transaction_result import TransactionDetailResponseTransactionResult

# TODO update the JSON string below
json = "{}"
# create an instance of TransactionDetailResponseTransactionResult from a JSON string
transaction_detail_response_transaction_result_instance = TransactionDetailResponseTransactionResult.from_json(json)
# print the JSON string representation of the object
print(TransactionDetailResponseTransactionResult.to_json())

# convert the object into a dict
transaction_detail_response_transaction_result_dict = transaction_detail_response_transaction_result_instance.to_dict()
# create an instance of TransactionDetailResponseTransactionResult from a dict
transaction_detail_response_transaction_result_from_dict = TransactionDetailResponseTransactionResult.from_dict(transaction_detail_response_transaction_result_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


