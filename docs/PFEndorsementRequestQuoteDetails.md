# PFEndorsementRequestQuoteDetails


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**commercial** | **str** | This denotes the Commercial. | [optional] 
**coupon** | **str** | This denotes the Coupon. | [optional] 
**coupon_invoice_printed** | **bool** | This denotes the flag if invoice printed or not. | [optional] 
**crd** | **float** | This denotes the Crd. | [optional] 
**interval** | **str** | This denotes the Interval. | [optional] 
**installments** | **float** | This denotes the number of installments. | [optional] 
**program_id** | **float** | This denotes the program ID. | [optional] 
**broker_fee** | **float** | This denotes the broker fees. | [optional] 
**e_sign_option** | **str** | This denotes the eSign Option. | [optional] 
**process_down_payment** | **bool** | This denotes the flag that down payment is processed or not. | [optional] 
**process_down_payment_no_reason** | **str** | This denotes the Process Down Payment No Reason. | [optional] 
**down_payment_method** | **str** | This denotes the Down Payment Method. | [optional] 
**down_payment_paid_by** | **str** | This denotes the Down Payment Paid by. | [optional] 
**batch_id** | **str** | This denotes the batch ID. | [optional] 
**return_pfa** | **bool** | This denotes the flag whether to return PFA or not. | [optional] 
**equal_payments** | **str** | This denotes the equal payments. | [optional] 
**quote_expiration_days** | **float** | This denotes the number of days to expire. | [optional] 
**bypass_cadnb** | **bool** | This denotes the flag whether to bypass CADNB. | [optional] 
**allow_zero_apr** | **bool** | This denotes the Allow Zero APR. | [optional] 
**associated_account_number** | **str** | This denotes the associated account number. | [optional] 
**channel** | **str** | This denotes the channel. | [optional] 
**channel_version** | **str** | This denotes the channel version. | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote_details import PFEndorsementRequestQuoteDetails

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuoteDetails from a JSON string
pf_endorsement_request_quote_details_instance = PFEndorsementRequestQuoteDetails.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuoteDetails.to_json())

# convert the object into a dict
pf_endorsement_request_quote_details_dict = pf_endorsement_request_quote_details_instance.to_dict()
# create an instance of PFEndorsementRequestQuoteDetails from a dict
pf_endorsement_request_quote_details_from_dict = PFEndorsementRequestQuoteDetails.from_dict(pf_endorsement_request_quote_details_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


