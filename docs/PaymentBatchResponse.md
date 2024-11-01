# PaymentBatchResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**total_row_counts** | **float** |  | [optional] 
**data** | [**List[PaymentBatchResponseDataInner]**](PaymentBatchResponseDataInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.payment_batch_response import PaymentBatchResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentBatchResponse from a JSON string
payment_batch_response_instance = PaymentBatchResponse.from_json(json)
# print the JSON string representation of the object
print(PaymentBatchResponse.to_json())

# convert the object into a dict
payment_batch_response_dict = payment_batch_response_instance.to_dict()
# create an instance of PaymentBatchResponse from a dict
payment_batch_response_from_dict = PaymentBatchResponse.from_dict(payment_batch_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


