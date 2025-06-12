import { BaseResponse } from "./http/base-response";
import { FranchiseLight } from "./franchise";

export interface ModelLight {
    businessId: number
    pseudonym: string
    gender: string
    description: string
}
export interface ModelCheckBox extends ModelLight {
    isChecked: boolean
}

export interface ModelFull {
    businessId: number
    created?: Date
    createdBy: string
    modified: Date
    modifiedBy: string
    pseudonym: string
    firstName: string
    lastName: string
    gender: string
    description: string
    relatedFranchises?: FranchiseLight[]
}

export interface GetAllModelsResponse extends BaseResponse {
    models: ModelLight[]
}
export interface GetModelsByFranchiseResponse extends BaseResponse {
    modelsByFranchise: ModelLight[]
}
export interface GetModelsByMoodResponse extends BaseResponse {
    models: ModelCheckBox[]
}
export interface GetModelResponse extends BaseResponse {
    model: ModelFull
}
export interface GetModelsCheckBoxesByMoodResponse extends BaseResponse {
    models: ModelCheckBox[]
}