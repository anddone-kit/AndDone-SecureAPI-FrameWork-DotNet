# SecurePaymentBatchDetailsRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**batch_id** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_batch_details_request import SecurePaymentBatchDetailsRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentBatchDetailsRequest from a JSON string
secure_payment_batch_details_request_instance = SecurePaymentBatchDetailsRequest.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentBatchDetailsRequest.to_json())

# convert the object into a dict
secure_payment_batch_details_request_dict = secure_payment_batch_details_request_instance.to_dict()
# create an instance of SecurePaymentBatchDetailsRequest from a dict
secure_payment_batch_details_request_from_dict = SecurePaymentBatchDetailsRequest.from_dict(secure_payment_batch_details_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


