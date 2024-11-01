# PFEndorsementResponseItemQuoteESignResult


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**processed** | **bool** |  | [optional] 
**message** | **str** |  | [optional] 
**batch_id** | **str** |  | [optional] 
**agent_url** | **str** |  | [optional] 
**insured_url** | **str** |  | [optional] 
**e_sign_option** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_response_item_quote_e_sign_result import PFEndorsementResponseItemQuoteESignResult

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementResponseItemQuoteESignResult from a JSON string
pf_endorsement_response_item_quote_e_sign_result_instance = PFEndorsementResponseItemQuoteESignResult.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementResponseItemQuoteESignResult.to_json())

# convert the object into a dict
pf_endorsement_response_item_quote_e_sign_result_dict = pf_endorsement_response_item_quote_e_sign_result_instance.to_dict()
# create an instance of PFEndorsementResponseItemQuoteESignResult from a dict
pf_endorsement_response_item_quote_e_sign_result_from_dict = PFEndorsementResponseItemQuoteESignResult.from_dict(pf_endorsement_response_item_quote_e_sign_result_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


