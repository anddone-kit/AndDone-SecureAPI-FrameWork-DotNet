# PaymentBatchCancellationRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_id** | **str** |  | [optional] 
**batch_id** | **str** |  | [optional] 
**void_reason** | **str** |  | [optional] 
**transaction_ids** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.payment_batch_cancellation_request import PaymentBatchCancellationRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentBatchCancellationRequest from a JSON string
payment_batch_cancellation_request_instance = PaymentBatchCancellationRequest.from_json(json)
# print the JSON string representation of the object
print(PaymentBatchCancellationRequest.to_json())

# convert the object into a dict
payment_batch_cancellation_request_dict = payment_batch_cancellation_request_instance.to_dict()
# create an instance of PaymentBatchCancellationRequest from a dict
payment_batch_cancellation_request_from_dict = PaymentBatchCancellationRequest.from_dict(payment_batch_cancellation_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


