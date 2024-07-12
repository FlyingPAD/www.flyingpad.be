import { BaseResponse } from "./base-response";

// Models.
export class ModelLight {
    businessId : number = 0
    pseudonym : string = ''
    gender : string = ''
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
export class ModelCheckBox {
    businessId : number = 0
    pseudonym : string = ''
    isChecked : boolean = false
}

// Calls.
export interface ModelForm {
    pseudonym : string
    firstName : string
    lastName : string
    gender : string
    description : string
}
export interface ModelUpdateForm {
    modelId : number
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
export interface GetAllModelsResponse {
    models : ModelCheckBox[]
}
export interface GetModelResponse extends BaseResponse {
    model : ModelFull
}
export interface GetModelsResponse extends BaseResponse {
    models : ModelLight[]
}
export interface GetModelsCheckBoxesByMoodResponse extends BaseResponse {
    models : ModelCheckBox[]
}