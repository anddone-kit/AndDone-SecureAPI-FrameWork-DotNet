# SecureCancelledTransactionResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_status** | **str** |  | [optional] 
**message** | **str** |  | [optional] 
**is_cancelled** | **bool** |  | [optional] 
**transaction_id** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_cancelled_transaction_response import SecureCancelledTransactionResponse

# TODO update the JSON string below
json = "{}"
# create an instance of SecureCancelledTransactionResponse from a JSON string
secure_cancelled_transaction_response_instance = SecureCancelledTransactionResponse.from_json(json)
# print the JSON string representation of the object
print(SecureCancelledTransactionResponse.to_json())

# convert the object into a dict
secure_cancelled_transaction_response_dict = secure_cancelled_transaction_response_instance.to_dict()
# create an instance of SecureCancelledTransactionResponse from a dict
secure_cancelled_transaction_response_from_dict = SecureCancelledTransactionResponse.from_dict(secure_cancelled_transaction_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


