# PFLiteGetQuoteRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchant_token** | **str** | This denotes the merchant token. | 
**payment_link_id** | **str** | This denotes the payment link id. | 

## Example

```python
from openapi_client.models.pf_lite_get_quote_request import PFLiteGetQuoteRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFLiteGetQuoteRequest from a JSON string
pf_lite_get_quote_request_instance = PFLiteGetQuoteRequest.from_json(json)
# print the JSON string representation of the object
print(PFLiteGetQuoteRequest.to_json())

# convert the object into a dict
pf_lite_get_quote_request_dict = pf_lite_get_quote_request_instance.to_dict()
# create an instance of PFLiteGetQuoteRequest from a dict
pf_lite_get_quote_request_from_dict = PFLiteGetQuoteRequest.from_dict(pf_lite_get_quote_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


