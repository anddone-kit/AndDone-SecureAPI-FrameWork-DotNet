# SecureTransactionRefundRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**invoice_number** | **str** |  | [optional] 
**p_o_number** | **str** |  | [optional] 
**refund_amount** | **float** |  | [optional] 
**transaction_id** | **str** |  | [optional] 
**remarks** | **str** |  | [optional] 
**refund_reason** | **str** |  | [optional] 
**refund_detail** | **str** |  | [optional] 
**refund_type** | **str** |  | [optional] 
**splits** | [**List[PaymentRequestSplitsInner]**](PaymentRequestSplitsInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.secure_transaction_refund_request import SecureTransactionRefundRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTransactionRefundRequest from a JSON string
secure_transaction_refund_request_instance = SecureTransactionRefundRequest.from_json(json)
# print the JSON string representation of the object
print(SecureTransactionRefundRequest.to_json())

# convert the object into a dict
secure_transaction_refund_request_dict = secure_transaction_refund_request_instance.to_dict()
# create an instance of SecureTransactionRefundRequest from a dict
secure_transaction_refund_request_from_dict = SecureTransactionRefundRequest.from_dict(secure_transaction_refund_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


