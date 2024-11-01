# PFGenerateQuoteResponseItem


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **int** | The key associated with the quote. | [optional] 
**premium** | **float** | The premium amount. | [optional] 
**down_amount** | **float** | The down payment amount. | [optional] 
**amount_financed** | **float** | The amount financed. | [optional] 
**finance_charge** | **float** | The finance charge. | [optional] 
**total_payments** | **float** | The total payments. | [optional] 
**payment_amount** | **float** | The payment amount. | [optional] 
**doc_stamp** | **float** | The document stamp amount. | [optional] 
**first_due_date** | **str** | The first due date. | [optional] 
**apr** | **float** | The annual percentage rate (APR). | [optional] 
**installments** | **int** | The number of installments. | [optional] 
**batch_id** | **str** | The batch ID. | [optional] 
**payments_retained** | **int** | The number of payments retained. | [optional] 
**payment_retained_amount** | **float** | The amount retained from the payment. | [optional] 
**unsigned_pfa_url** | **str** | The URL for the unsigned PFA document. | [optional] 
**retail_agent_register_login_url** | **str** | The URL for the retail agent register login. | [optional] 
**e_sign_result** | [**PFGenerateQuoteResponseItemESignResult**](PFGenerateQuoteResponseItemESignResult.md) |  | [optional] 
**errors** | **str** | Any errors associated with the quote generation. | [optional] 
**p_fa** | **str** | The PFA document content. | [optional] 
**electronic_signature_url** | **str** | The URL for the electronic signature. | [optional] 

## Example

```python
from openapi_client.models.pf_generate_quote_response_item import PFGenerateQuoteResponseItem

# TODO update the JSON string below
json = "{}"
# create an instance of PFGenerateQuoteResponseItem from a JSON string
pf_generate_quote_response_item_instance = PFGenerateQuoteResponseItem.from_json(json)
# print the JSON string representation of the object
print(PFGenerateQuoteResponseItem.to_json())

# convert the object into a dict
pf_generate_quote_response_item_dict = pf_generate_quote_response_item_instance.to_dict()
# create an instance of PFGenerateQuoteResponseItem from a dict
pf_generate_quote_response_item_from_dict = PFGenerateQuoteResponseItem.from_dict(pf_generate_quote_response_item_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


