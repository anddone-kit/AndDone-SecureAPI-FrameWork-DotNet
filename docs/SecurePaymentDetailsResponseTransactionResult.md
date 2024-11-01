# SecurePaymentDetailsResponseTransactionResult


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**success** | **bool** |  | [optional] 
**processor_auth_code** | **str** |  | [optional] 
**trace_number** | **str** |  | [optional] 
**reason_code** | **str** |  | [optional] 
**reason_message** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_details_response_transaction_result import SecurePaymentDetailsResponseTransactionResult

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentDetailsResponseTransactionResult from a JSON string
secure_payment_details_response_transaction_result_instance = SecurePaymentDetailsResponseTransactionResult.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentDetailsResponseTransactionResult.to_json())

# convert the object into a dict
secure_payment_details_response_transaction_result_dict = secure_payment_details_response_transaction_result_instance.to_dict()
# create an instance of SecurePaymentDetailsResponseTransactionResult from a dict
secure_payment_details_response_transaction_result_from_dict = SecurePaymentDetailsResponseTransactionResult.from_dict(secure_payment_details_response_transaction_result_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


