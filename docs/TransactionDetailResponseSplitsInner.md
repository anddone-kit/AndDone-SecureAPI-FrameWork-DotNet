# TransactionDetailResponseSplitsInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**virtual_account** | **str** |  | [optional] 
**amount** | **float** |  | [optional] 
**account_number** | **str** |  | [optional] 
**charge_indicator** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.transaction_detail_response_splits_inner import TransactionDetailResponseSplitsInner

# TODO update the JSON string below
json = "{}"
# create an instance of TransactionDetailResponseSplitsInner from a JSON string
transaction_detail_response_splits_inner_instance = TransactionDetailResponseSplitsInner.from_json(json)
# print the JSON string representation of the object
print(TransactionDetailResponseSplitsInner.to_json())

# convert the object into a dict
transaction_detail_response_splits_inner_dict = transaction_detail_response_splits_inner_instance.to_dict()
# create an instance of TransactionDetailResponseSplitsInner from a dict
transaction_detail_response_splits_inner_from_dict = TransactionDetailResponseSplitsInner.from_dict(transaction_detail_response_splits_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


