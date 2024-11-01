# PFEndorsementRequestQuoteAgent


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**unique_id** | **str** | This denotes the Unique ID. | [optional] 
**email** | **str** | This denotes the email of the agent. | 
**address** | [**PFEndorsementRequestQuoteAgentAddress**](PFEndorsementRequestQuoteAgentAddress.md) |  | 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote_agent import PFEndorsementRequestQuoteAgent

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuoteAgent from a JSON string
pf_endorsement_request_quote_agent_instance = PFEndorsementRequestQuoteAgent.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuoteAgent.to_json())

# convert the object into a dict
pf_endorsement_request_quote_agent_dict = pf_endorsement_request_quote_agent_instance.to_dict()
# create an instance of PFEndorsementRequestQuoteAgent from a dict
pf_endorsement_request_quote_agent_from_dict = PFEndorsementRequestQuoteAgent.from_dict(pf_endorsement_request_quote_agent_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


