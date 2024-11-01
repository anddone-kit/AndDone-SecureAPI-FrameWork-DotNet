# SecurePaymentDetailsResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_id** | **str** |  | [optional] 
**billing_contact** | [**PaymentRequestBillingContact**](PaymentRequestBillingContact.md) |  | [optional] 
**transaction_date** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**process_method** | **str** |  | [optional] 
**transaction_origin** | **str** |  | [optional] 
**refund_origin** | **str** |  | [optional] 
**ach_tender_info** | [**SecurePaymentDetailsResponseAchTenderInfo**](SecurePaymentDetailsResponseAchTenderInfo.md) |  | [optional] 
**cc_tender_info** | [**SecurePaymentDetailsResponseCcTenderInfo**](SecurePaymentDetailsResponseCcTenderInfo.md) |  | [optional] 
**debit_card_tender_info** | **str** |  | [optional] 
**reference_customer_id** | **str** |  | [optional] 
**customer_account_id** | **str** |  | [optional] 
**invoice_no** | **str** |  | [optional] 
**remarks** | **str** |  | [optional] 
**transaction_status** | **str** |  | [optional] 
**transaction_result** | [**SecurePaymentDetailsResponseTransactionResult**](SecurePaymentDetailsResponseTransactionResult.md) |  | [optional] 
**invoice_id** | **str** |  | [optional] 
**payment_link_id** | **str** |  | [optional] 
**additional_fields** | **Dict[str, str]** |  | [optional] 
**payment_type** | **str** |  | [optional] 
**payment_category** | **str** |  | [optional] 
**transaction_entity_split_responses** | [**List[SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner]**](SecurePaymentDetailsResponseTransactionEntitySplitResponsesInner.md) |  | [optional] 

## Example

```python
from openapi_client.models.secure_payment_details_response import SecurePaymentDetailsResponse

# TODO update the JSON string below
json = "{}"
# create an instance of SecurePaymentDetailsResponse from a JSON string
secure_payment_details_response_instance = SecurePaymentDetailsResponse.from_json(json)
# print the JSON string representation of the object
print(SecurePaymentDetailsResponse.to_json())

# convert the object into a dict
secure_payment_details_response_dict = secure_payment_details_response_instance.to_dict()
# create an instance of SecurePaymentDetailsResponse from a dict
secure_payment_details_response_from_dict = SecurePaymentDetailsResponse.from_dict(secure_payment_details_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


