# QuoteResponseIntent


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** | The unique identifier for the quote. | [optional] 
**quote_key** | **str** | The key associated with the quote. | [optional] 
**p_f_type** | **str** | The type of premium finance. | [optional] 
**is_endorsement** | **bool** | Indicates if the quote is an endorsement. | [optional] 
**merchant_id** | **str** | The ID of the merchant. | [optional] 
**program_id** | **int** | The ID of the program. | [optional] 
**payment_intent_id** | **str** | The ID of the payment intent. | [optional] 
**account_number** | **str** | The account number. | [optional] 
**quote_status** | **str** | The status of the quote. | [optional] 
**is_active** | **bool** | Indicates if the quote is active. | [optional] [default to True]
**premium** | **float** | The premium amount. | [optional] 
**additional_fees** | **float** | Additional fees associated with the quote. | [optional] 
**down_amount** | **float** | The down payment amount. | [optional] 
**amount_financed** | **float** | The amount financed. | [optional] 
**finance_charge** | **float** | The finance charge. | [optional] 
**total_payments** | **float** | The total payments. | [optional] 
**payment_amount** | **float** | The payment amount. | [optional] 
**doc_stamp** | **float** | The document stamp. | [optional] 
**first_due_date** | **str** | The first due date. | [optional] 
**apr** | **float** | The annual percentage rate (APR). | [optional] 
**installments** | **int** | The number of installments. | [optional] 
**batch_id** | **str** | The batch ID. | [optional] 
**payments_retained** | **int** | The number of payments retained. | [optional] 
**payment_retained_amount** | **float** | The amount retained from the payment. | [optional] 
**retail_agent_register_login_url** | **str** | The URL for the retail agent register login. | [optional] 
**insured_name** | **str** | The name of the insured. | [optional] 
**is_esign_pfa** | **bool** | Indicates if eSign is required for the PFA. | [optional] 
**next_payment_due_date** | **str** | The next payment due date. | [optional] 
**last_payment_date** | **str** | The last payment date. | [optional] 
**is_down_payment_required** | **bool** | Indicates if a down payment is required. | [optional] 
**is_esign_required** | **bool** | Indicates if eSign is required. | [optional] 
**is_deleted** | **bool** | Indicates if the quote is deleted. | [optional] 
**created_on** | **str** | The date when the quote was created. | [optional] 
**created_by** | **str** | The user who created the quote. | [optional] 
**modified_on** | **str** | The date when the quote was last modified. | [optional] 
**modified_by** | **str** | The user who last modified the quote. | [optional] 
**un_sign_pfa** | **str** | The unsigned PFA document. | [optional] 
**sign_pfa** | **str** | The signed PFA document. | [optional] 

## Example

```python
from openapi_client.models.quote_response_intent import QuoteResponseIntent

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteResponseIntent from a JSON string
quote_response_intent_instance = QuoteResponseIntent.from_json(json)
# print the JSON string representation of the object
print(QuoteResponseIntent.to_json())

# convert the object into a dict
quote_response_intent_dict = quote_response_intent_instance.to_dict()
# create an instance of QuoteResponseIntent from a dict
quote_response_intent_from_dict = QuoteResponseIntent.from_dict(quote_response_intent_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


