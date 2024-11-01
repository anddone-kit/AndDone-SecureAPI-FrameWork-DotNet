# TransactionRefundEligibilityRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**invoice_number** | **str** |  | [optional] 
**p_o_number** | **str** |  | [optional] 
**refund_amount** | **float** |  | [optional] 
**transaction_id** | **str** |  | [optional] 
**remarks** | **str** |  | [optional] 
**splits** | [**List[PaymentRequestSplitsInner]**](PaymentRequestSplitsInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.transaction_refund_eligibility_request import TransactionRefundEligibilityRequest

# TODO update the JSON string below
json = "{}"
# create an instance of TransactionRefundEligibilityRequest from a JSON string
transaction_refund_eligibility_request_instance = TransactionRefundEligibilityRequest.from_json(json)
# print the JSON string representation of the object
print(TransactionRefundEligibilityRequest.to_json())

# convert the object into a dict
transaction_refund_eligibility_request_dict = transaction_refund_eligibility_request_instance.to_dict()
# create an instance of TransactionRefundEligibilityRequest from a dict
transaction_refund_eligibility_request_from_dict = TransactionRefundEligibilityRequest.from_dict(transaction_refund_eligibility_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


