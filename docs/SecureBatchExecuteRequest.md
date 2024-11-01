# SecureBatchExecuteRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**batch_id** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_batch_execute_request import SecureBatchExecuteRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecureBatchExecuteRequest from a JSON string
secure_batch_execute_request_instance = SecureBatchExecuteRequest.from_json(json)
# print the JSON string representation of the object
print(SecureBatchExecuteRequest.to_json())

# convert the object into a dict
secure_batch_execute_request_dict = secure_batch_execute_request_instance.to_dict()
# create an instance of SecureBatchExecuteRequest from a dict
secure_batch_execute_request_from_dict = SecureBatchExecuteRequest.from_dict(secure_batch_execute_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


