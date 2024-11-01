# SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_alias** | **str** |  | [optional] 
**amount** | **float** |  | [optional] 
**charge_indicator** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_details_response_transaction_entity_split_responses_inner import SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner from a JSON string
secure_payment_details_response_transaction_entity_split_responses_inner_instance = SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner.to_json())

# convert the object into a dict
secure_payment_details_response_transaction_entity_split_responses_inner_dict = secure_payment_details_response_transaction_entity_split_responses_inner_instance.to_dict()
# create an instance of SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner from a dict
secure_payment_details_response_transaction_entity_split_responses_inner_from_dict = SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner.from_dict(secure_payment_details_response_transaction_entity_split_responses_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


