# PFQuoteEsignRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_token** | **str** | This denotes the merchant token. | 
**quote_key** | **str** | This denotes the quoteKey. | 
**insured_name** | **str** | This denotes the name of the insured. | 
**ip_address** | **str** | This denotes the IP address of the client. | 
**mac_address** | **str** | This denotes the MAC address of the client. | 
**captcha_token** | **str** | This denotes the captchaToken. | [optional] 
**action_name** | **str** | This denotes the action name. | [optional] 

## Example

```python
from openapi_client.models.pf_quote_esign_request import PFQuoteEsignRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFQuoteEsignRequest from a JSON string
pf_quote_esign_request_instance = PFQuoteEsignRequest.from_json(json)
# print the JSON string representation of the object
print(PFQuoteEsignRequest.to_json())

# convert the object into a dict
pf_quote_esign_request_dict = pf_quote_esign_request_instance.to_dict()
# create an instance of PFQuoteEsignRequest from a dict
pf_quote_esign_request_from_dict = PFQuoteEsignRequest.from_dict(pf_quote_esign_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


