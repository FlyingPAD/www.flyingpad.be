import { BaseResponse } from "./base-response";
import { PaginationResponse } from "./pagination-response";

// Models

export class Style
{
    businessId : number = 0
    name: string = 'new style'
}

export class StyleDetails
{
    businessId : number = 0
    name : string = ''
    createdDate : Date = new Date()
    createdBy : string = ''
    modifiedDate : Date = new Date()
    modifiedBy : string = ''
}

export interface StyleCheck
{
    businessId : number
    name : string
    isChecked : boolean
}

// API Calls

export interface StyleCreateForm
{
    name : string
}

export interface StyleUpdateForm extends Style {}

// API Responses

export interface StylesCountResponse extends BaseResponse
{
    stylesCount : number
}

export interface StylesCreateResponse extends BaseResponse 
{
    style : StyleCheck
}

export interface StylesGetAllResponse extends BaseResponse 
{
    stylesList : StyleCheck[]
}

export interface StylesGetOneResponse extends BaseResponse
{
    style : Style
}

export interface StylesGetOneDetailsResponse extends BaseResponse
{
    style : StyleDetails
}

export interface StylesCheckResponse extends BaseResponse
{
    stylesCheck : StyleCheck[]
}

export interface StylesGetStylesResponse extends BaseResponse {}

export interface StylesGetPageResponse extends BaseResponse, PaginationResponse
{
    stylesPage : Style[]
}

export interface StylesUpdateResponse extends BaseResponse {}

export interface StylesDeleteResponse extends BaseResponse {}