import { BaseResponse } from "./base-response"

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

export interface GetStyleByIdResponse extends BaseResponse {
    style : StyleFull
}
export interface GetAllStylesResponse extends BaseResponse {
    styles : StyleLight[]
}