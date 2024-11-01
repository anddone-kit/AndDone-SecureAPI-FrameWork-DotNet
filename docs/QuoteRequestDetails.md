# QuoteRequestDetails


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**coupon_invoice_printed** | **bool** |  | [optional] 
**installments** | **float** |  | [optional] 
**program_ids** | **List[float]** |  | 
**batch_id** | **str** |  | [optional] 
**commercial** | **str** |  | [optional] 
**coupon** | **str** |  | [optional] 
**interval** | **str** |  | [optional] 
**down_payment_method** | **str** |  | [optional] 
**down_payment_paid_by** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.quote_request_details import QuoteRequestDetails

# TODO update the JSON string below
json = "{}"
# create an instance of QuoteRequestDetails from a JSON string
quote_request_details_instance = QuoteRequestDetails.from_json(json)
# print the JSON string representation of the object
print(QuoteRequestDetails.to_json())

# convert the object into a dict
quote_request_details_dict = quote_request_details_instance.to_dict()
# create an instance of QuoteRequestDetails from a dict
quote_request_details_from_dict = QuoteRequestDetails.from_dict(quote_request_details_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


