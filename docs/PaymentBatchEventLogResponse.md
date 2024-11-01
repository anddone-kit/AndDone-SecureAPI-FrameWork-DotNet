# PaymentBatchEventLogResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**batch_id** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**previous_event_status** | **str** |  | [optional] 
**event_status** | **str** |  | [optional] 
**voided_count** | **float** |  | [optional] 
**voided_amount** | **float** |  | [optional] 
**closed_on** | **str** |  | [optional] 
**event_date** | **str** |  | [optional] 
**closing_amount** | **float** |  | [optional] 
**created_on** | **str** |  | [optional] 
**created_by** | **str** |  | [optional] 
**modified_on** | **str** |  | [optional] 
**modified_by** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.payment_batch_event_log_response import PaymentBatchEventLogResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentBatchEventLogResponse from a JSON string
payment_batch_event_log_response_instance = PaymentBatchEventLogResponse.from_json(json)
# print the JSON string representation of the object
print(PaymentBatchEventLogResponse.to_json())

# convert the object into a dict
payment_batch_event_log_response_dict = payment_batch_event_log_response_instance.to_dict()
# create an instance of PaymentBatchEventLogResponse from a dict
payment_batch_event_log_response_from_dict = PaymentBatchEventLogResponse.from_dict(payment_batch_event_log_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


