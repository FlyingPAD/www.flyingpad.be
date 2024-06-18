import { BaseResponse } from "./base-response"

// Models
export interface Model
{
    businessId : number
    pseudonym : string
    gender : string
}

// Responses
export interface GetAllModelsResponse extends BaseResponse
{
    models : Model[]
}