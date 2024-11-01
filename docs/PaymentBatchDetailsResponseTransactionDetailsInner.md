# PaymentBatchDetailsResponseTransactionDetailsInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_id** | **str** |  | [optional] 
**transaction_status** | **str** |  | [optional] 
**transaction_date_time** | **str** |  | [optional] 
**transaction_amount** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.payment_batch_details_response_transaction_details_inner import PaymentBatchDetailsResponseTransactionDetailsInner

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentBatchDetailsResponseTransactionDetailsInner from a JSON string
payment_batch_details_response_transaction_details_inner_instance = PaymentBatchDetailsResponseTransactionDetailsInner.from_json(json)
# print the JSON string representation of the object
print(PaymentBatchDetailsResponseTransactionDetailsInner.to_json())

# convert the object into a dict
payment_batch_details_response_transaction_details_inner_dict = payment_batch_details_response_transaction_details_inner_instance.to_dict()
# create an instance of PaymentBatchDetailsResponseTransactionDetailsInner from a dict
payment_batch_details_response_transaction_details_inner_from_dict = PaymentBatchDetailsResponseTransactionDetailsInner.from_dict(payment_batch_details_response_transaction_details_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


