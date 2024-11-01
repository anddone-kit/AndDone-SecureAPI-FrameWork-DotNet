# PaymentRequestTenderInfo


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bank_name** | **str** |  | [optional] 
**account_number** | **str** |  | [optional] 
**routing_number** | **str** |  | [optional] 
**raw_micr_line** | **str** |  | [optional] 
**account_type** | **str** |  | [optional] 
**check_number** | **str** |  | [optional] 
**account_category** | **str** |  | [optional] 
**account_holder_name** | **str** |  | [optional] 
**name_on_check** | **str** |  | [optional] 
**card_holder_name** | **str** |  | [optional] 
**card_type** | **str** |  | [optional] 
**card_number** | **str** |  | [optional] 
**card_expiry** | **str** |  | [optional] 
**c_v_data** | **str** |  | [optional] 
**c_v_data_status** | **str** |  | [optional] 
**track_data** | **str** |  | [optional] 
**health_care_account_type** | **str** |  | [optional] 
**rx_amount** | **float** |  | [optional] 
**vision_amount** | **float** |  | [optional] 
**dental_amount** | **float** |  | [optional] 
**clinic_amount** | **float** |  | [optional] 
**remove_discounting** | **bool** |  | [optional] 
**suppress_commission** | **bool** |  | [optional] 
**amount** | **float** |  | [optional] 
**tip_amount** | **float** |  | [optional] 
**convenience_amount** | **float** |  | [optional] 
**tax_amount** | **float** |  | [optional] 
**tax_percent** | **float** |  | [optional] 
**tax_after_discount** | **bool** |  | [optional] 
**pre_auth_code** | **str** |  | [optional] 
**create_account_token** | **bool** |  | [optional] 
**account_token** | **str** |  | [optional] 
**discount_type** | **str** |  | [optional] 
**discount_percent** | **float** |  | [optional] 
**discount_amount** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.payment_request_tender_info import PaymentRequestTenderInfo

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentRequestTenderInfo from a JSON string
payment_request_tender_info_instance = PaymentRequestTenderInfo.from_json(json)
# print the JSON string representation of the object
print(PaymentRequestTenderInfo.to_json())

# convert the object into a dict
payment_request_tender_info_dict = payment_request_tender_info_instance.to_dict()
# create an instance of PaymentRequestTenderInfo from a dict
payment_request_tender_info_from_dict = PaymentRequestTenderInfo.from_dict(payment_request_tender_info_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


