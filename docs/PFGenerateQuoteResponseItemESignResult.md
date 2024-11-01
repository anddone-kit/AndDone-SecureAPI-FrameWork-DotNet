# PFGenerateQuoteResponseItemESignResult


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**processed** | **bool** | Indicates if the eSign process was successful. | [optional] 
**message** | **str** | A message related to the eSign process. | [optional] 
**batch_id** | **str** | The batch ID associated with the eSign process. | [optional] 
**agent_url** | **str** | The URL for the agent to sign. | [optional] 
**insured_url** | **str** | The URL for the insured to sign. | [optional] 
**e_sign_option** | **int** | The option chosen for eSign. | [optional] 

## Example

```python
from openapi_client.models.pf_generate_quote_response_item_e_sign_result import PFGenerateQuoteResponseItemESignResult

# TODO update the JSON string below
json = "{}"
# create an instance of PFGenerateQuoteResponseItemESignResult from a JSON string
pf_generate_quote_response_item_e_sign_result_instance = PFGenerateQuoteResponseItemESignResult.from_json(json)
# print the JSON string representation of the object
print(PFGenerateQuoteResponseItemESignResult.to_json())

# convert the object into a dict
pf_generate_quote_response_item_e_sign_result_dict = pf_generate_quote_response_item_e_sign_result_instance.to_dict()
# create an instance of PFGenerateQuoteResponseItemESignResult from a dict
pf_generate_quote_response_item_e_sign_result_from_dict = PFGenerateQuoteResponseItemESignResult.from_dict(pf_generate_quote_response_item_e_sign_result_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


