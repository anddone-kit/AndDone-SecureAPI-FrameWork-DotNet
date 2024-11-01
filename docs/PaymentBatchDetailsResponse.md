# PaymentBatchDetailsResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**batch_id** | **str** |  | [optional] 
**batch_status** | **str** |  | [optional] 
**execution_time** | **str** |  | [optional] 
**completion_time** | **str** |  | [optional] 
**transaction_details** | [**List[PaymentBatchDetailsResponseTransactionDetailsInner]**](PaymentBatchDetailsResponseTransactionDetailsInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.payment_batch_details_response import PaymentBatchDetailsResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentBatchDetailsResponse from a JSON string
payment_batch_details_response_instance = PaymentBatchDetailsResponse.from_json(json)
# print the JSON string representation of the object
print(PaymentBatchDetailsResponse.to_json())

# convert the object into a dict
payment_batch_details_response_dict = payment_batch_details_response_instance.to_dict()
# create an instance of PaymentBatchDetailsResponse from a dict
payment_batch_details_response_from_dict = PaymentBatchDetailsResponse.from_dict(payment_batch_details_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


