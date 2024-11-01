# PFEndorsementResponseItemQuote


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pfa** | **str** |  | [optional] 
**quote_key** | **float** |  | [optional] 
**premium** | **float** |  | [optional] 
**down_amount** | **float** |  | [optional] 
**amount_financed** | **float** |  | [optional] 
**finance_charge** | **float** |  | [optional] 
**total_payments** | **float** |  | [optional] 
**payment_amount** | **float** |  | [optional] 
**doc_stamp** | **float** |  | [optional] 
**first_due_date** | **str** |  | [optional] 
**apr** | **float** |  | [optional] 
**installments** | **float** |  | [optional] 
**payments_retained** | **float** |  | [optional] 
**payment_retained_amount** | **float** |  | [optional] 
**e_sign_result** | [**PFEndorsementResponseItemQuoteESignResult**](PFEndorsementResponseItemQuoteESignResult.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_response_item_quote import PFEndorsementResponseItemQuote

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementResponseItemQuote from a JSON string
pf_endorsement_response_item_quote_instance = PFEndorsementResponseItemQuote.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementResponseItemQuote.to_json())

# convert the object into a dict
pf_endorsement_response_item_quote_dict = pf_endorsement_response_item_quote_instance.to_dict()
# create an instance of PFEndorsementResponseItemQuote from a dict
pf_endorsement_response_item_quote_from_dict = PFEndorsementResponseItemQuote.from_dict(pf_endorsement_response_item_quote_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


