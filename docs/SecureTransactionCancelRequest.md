# SecureTransactionCancelRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_id** | **str** |  | [optional] 
**void_reason** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_transaction_cancel_request import SecureTransactionCancelRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTransactionCancelRequest from a JSON string
secure_transaction_cancel_request_instance = SecureTransactionCancelRequest.from_json(json)
# print the JSON string representation of the object
print(SecureTransactionCancelRequest.to_json())

# convert the object into a dict
secure_transaction_cancel_request_dict = secure_transaction_cancel_request_instance.to_dict()
# create an instance of SecureTransactionCancelRequest from a dict
secure_transaction_cancel_request_from_dict = SecureTransactionCancelRequest.from_dict(secure_transaction_cancel_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


