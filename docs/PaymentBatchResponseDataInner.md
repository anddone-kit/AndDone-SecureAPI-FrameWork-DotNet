# PaymentBatchResponseDataInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**batch_status** | **str** |  | [optional] 
**process_methods** | **str** |  | [optional] 
**processor_name** | **str** |  | [optional] 
**is_default** | **bool** |  | [optional] 
**executed_on_demand** | **bool** |  | [optional] 
**execution_time** | **str** |  | [optional] 
**completion_time** | **str** |  | [optional] 
**created_on** | **str** |  | [optional] 
**created_by** | **str** |  | [optional] 
**modified_on** | **str** |  | [optional] 
**modified_by** | **str** |  | [optional] 
**capture_count** | **float** |  | [optional] 
**capture_amount** | **float** |  | [optional] 
**voided_count** | **float** |  | [optional] 
**voided_amount** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.payment_batch_response_data_inner import PaymentBatchResponseDataInner

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentBatchResponseDataInner from a JSON string
payment_batch_response_data_inner_instance = PaymentBatchResponseDataInner.from_json(json)
# print the JSON string representation of the object
print(PaymentBatchResponseDataInner.to_json())

# convert the object into a dict
payment_batch_response_data_inner_dict = payment_batch_response_data_inner_instance.to_dict()
# create an instance of PaymentBatchResponseDataInner from a dict
payment_batch_response_data_inner_from_dict = PaymentBatchResponseDataInner.from_dict(payment_batch_response_data_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


