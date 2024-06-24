import { BaseResponse } from "./base-response";

// Models.
export interface Model
{
    businessId? : number
    created? : Date
    createdBy? : string
    modified? : Date
    modifiedBy? : string
    firstName : string
    lastName : string
    pseudonym : string
    gender : string
    description? : string
    isChecked? : boolean
}

// Calls.
export interface ModelForm
{
    businessId? : number
    firstName : string
    lastName : string
    pseudonym : string
    gender : string
    isChecked? : boolean
}

// Responses.
export interface GetAllModelsResponse extends BaseResponse
{
    models : Model[]
}

export interface CreateModelResponse extends BaseResponse
{
    modelId : number
}