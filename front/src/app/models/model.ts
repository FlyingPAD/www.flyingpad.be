import { BaseResponse } from "./base-response";

// Models.
export interface ModelLight {
    businessId : number
    pseudonym : string
    gender : string
}
export interface ModelFull {
    businessId : number
    created : Date
    createdBy : string
    modified : Date
    modifiedBy : string
    pseudonym : string
    firstName : string
    lastName : string
    gender : string
    description : string
}
export interface ModelCheckBox {
    businessId : number
    pseudonym : string
    isChecked : boolean
}

// Calls.
export interface ModelForm {
    pseudonym : string
    firstName : string
    lastName : string
    gender : string
    description : string
}
export interface ModelCheckForm {
    firstName : string
    lastName : string
    aka : string
    gender : string
    isChecked : boolean
}

// Responses.
export interface GetModelsResponse extends BaseResponse {
    models : ModelLight[]
}
export interface GetModelsByMoodResponse extends BaseResponse {
    models : ModelCheckBox[]
}
export interface GetModelResponse extends BaseResponse {
    model : ModelFull
}