# PFLiteQuoteByPaymentLinkResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** | Unique identifier of the quote | [optional] 
**quote_key** | **str** | Key for the quote | [optional] 
**pf_type** | **str** | Type of premium finance | [optional] 
**is_endorsement** | **bool** | Indicates if it is an endorsement | [optional] 
**merchant_id** | **str** | Identifier of the merchant | [optional] 
**program_id** | **int** | Identifier of the program | [optional] 
**payment_link_id** | **str** | Identifier of the payment link | [optional] 
**account_number** | **str** | Account number | [optional] 
**quote_status** | **str** | The status of the quote. | [optional] 
**is_active** | **bool** | Indicates if the quote is active | [optional] [default to True]
**premium** | **float** | Premium amount | [optional] 
**additional_fees** | **float** | Additional fees | [optional] 
**down_amount** | **float** | Down payment amount | [optional] 
**amount_financed** | **float** | Amount financed | [optional] 
**finance_charge** | **float** | Finance charge | [optional] 
**total_payments** | **float** | Total payments | [optional] 
**payment_amount** | **float** | Payment amount | [optional] 
**doc_stamp** | **int** | Document stamp | [optional] 
**first_due_date** | **str** | First due date | [optional] 
**apr** | **float** | Annual percentage rate | [optional] 
**installments** | **int** | Number of installments | [optional] 
**batch_id** | **str** | Batch identifier | [optional] 
**payments_retained** | **int** | Number of payments retained | [optional] 
**payment_retained_amount** | **float** | Amount retained from payments | [optional] 
**retail_agent_register_login_url** | **str** | URL for retail agent registration/login | [optional] 
**insured_name** | **str** | Name of the insured | [optional] 
**is_esign_pfa** | **bool** | Indicates if e-signature for PFA is required | [optional] 
**next_payment_due_date** | **str** | Next payment due date | [optional] 
**last_payment_date** | **str** | Last payment date | [optional] 
**is_down_payment_required** | **bool** | Indicates if down payment is required | [optional] 
**is_esign_required** | **bool** | Indicates if e-signature is required | [optional] 
**is_deleted** | **bool** | Indicates if the quote is deleted | [optional] 
**created_on** | **str** | Creation date and time | [optional] 
**created_by** | **str** | Creator of the quote | [optional] 
**modified_on** | **str** | Modification date and time | [optional] 
**modified_by** | **str** | Modifier of the quote | [optional] 
**un_sign_pfa** | **str** | Un-signed PFA document | [optional] 
**sign_pfa** | **str** | Signed PFA document | [optional] 

## Example

```python
from openapi_client.models.pf_lite_quote_by_payment_link_response import PFLiteQuoteByPaymentLinkResponse

# TODO update the JSON string below
json = "{}"
# create an instance of PFLiteQuoteByPaymentLinkResponse from a JSON string
pf_lite_quote_by_payment_link_response_instance = PFLiteQuoteByPaymentLinkResponse.from_json(json)
# print the JSON string representation of the object
print(PFLiteQuoteByPaymentLinkResponse.to_json())

# convert the object into a dict
pf_lite_quote_by_payment_link_response_dict = pf_lite_quote_by_payment_link_response_instance.to_dict()
# create an instance of PFLiteQuoteByPaymentLinkResponse from a dict
pf_lite_quote_by_payment_link_response_from_dict = PFLiteQuoteByPaymentLinkResponse.from_dict(pf_lite_quote_by_payment_link_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


