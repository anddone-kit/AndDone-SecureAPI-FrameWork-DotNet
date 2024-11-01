# PFEndorsementRequestQuoteInsured


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**agent_customer_number** | **str** | This denotes the Agent Customer Number. | [optional] 
**email** | **str** | This denotes the email. | 
**care_of** | **str** | This denotes the care of. | [optional] 
**address** | [**PFEndorsementRequestQuoteInsuredAddress**](PFEndorsementRequestQuoteInsuredAddress.md) |  | 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote_insured import PFEndorsementRequestQuoteInsured

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuoteInsured from a JSON string
pf_endorsement_request_quote_insured_instance = PFEndorsementRequestQuoteInsured.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuoteInsured.to_json())

# convert the object into a dict
pf_endorsement_request_quote_insured_dict = pf_endorsement_request_quote_insured_instance.to_dict()
# create an instance of PFEndorsementRequestQuoteInsured from a dict
pf_endorsement_request_quote_insured_from_dict = PFEndorsementRequestQuoteInsured.from_dict(pf_endorsement_request_quote_insured_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


