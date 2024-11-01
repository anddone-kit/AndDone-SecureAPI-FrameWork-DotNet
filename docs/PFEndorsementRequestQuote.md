# PFEndorsementRequestQuote


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_reference** | **str** | This denotes the unique merchantReference of the agent. | [optional] 
**account_number** | **str** | This denotes the accountNumber received in check endorsement API. | [optional] 
**agreement_id** | **str** | This denotes the agreementId received in check endorsement API. | 
**policies** | [**List[PFEndorsementRequestQuotePoliciesInner]**](PFEndorsementRequestQuotePoliciesInner.md) |  | 
**details** | [**PFEndorsementRequestQuoteDetails**](PFEndorsementRequestQuoteDetails.md) |  | [optional] 
**insured** | [**PFEndorsementRequestQuoteInsured**](PFEndorsementRequestQuoteInsured.md) |  | 
**agent** | [**PFEndorsementRequestQuoteAgent**](PFEndorsementRequestQuoteAgent.md) |  | [optional] 
**communication** | [**PFEndorsementRequestQuoteCommunication**](PFEndorsementRequestQuoteCommunication.md) |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote import PFEndorsementRequestQuote

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuote from a JSON string
pf_endorsement_request_quote_instance = PFEndorsementRequestQuote.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuote.to_json())

# convert the object into a dict
pf_endorsement_request_quote_dict = pf_endorsement_request_quote_instance.to_dict()
# create an instance of PFEndorsementRequestQuote from a dict
pf_endorsement_request_quote_from_dict = PFEndorsementRequestQuote.from_dict(pf_endorsement_request_quote_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


