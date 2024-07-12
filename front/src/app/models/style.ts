import { BaseResponse } from "./base-response";

// Models.
export interface StyleLight {
    businessId : number
    name: string
    isChecked? : boolean
}
export interface StyleFull {
    businessId : number
    name : string
    createdDate : Date
    createdBy : string
    modifiedDate : Date
    modifiedBy : string
}

// Calls.
export interface StyleCreateForm {
    name : string
}

// Responses.
export interface GetStyleResponse extends BaseResponse {
    style : StyleFull
}
export interface GetStylesResponse extends BaseResponse {
    styles : StyleLight[]
}
export interface CreateStyleResponse extends BaseResponse {
    styleId : number
}