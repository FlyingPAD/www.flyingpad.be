import { BaseResponse } from "./base-response";
import { ModelLight } from "./model";

export interface FranchiseLight {
    businessId : number
    name : string
    description : string
}

export interface FranchiseCheckBox extends FranchiseLight {
    isChecked? : boolean
}
export interface FranchiseFull {
    businessId : number
    created : Date
    createdBy : string
    modified : Date
    modifiedBy : string
    name : string
    description : string
}
export interface MediumLight {
    businessId : number
    name : string
}
export interface MediumCheckBox extends MediumLight {
    isChecked? : boolean
}
export interface MediumFull {
    businessId : number
    created : Date
    createdBy : string
    modified : Date
    modifiedBy : string
    name : string
    description : string
}
export interface FranchiseList {
    businessId : number
    name : string
    models : ModelLight[]
}
export interface MediumList {
    businessId : number
    name : string
    franchises : FranchiseList[]
}

export interface GetAllFranchisesResponse extends BaseResponse {
    franchises : FranchiseLight[]
}
export interface GetFranchisesByMoodResponse extends BaseResponse {
    franchisesByMood : FranchiseLight[]
}
export interface GetFranchisesByModelResponse extends BaseResponse {
    franchisesByModel : FranchiseLight[]
}
export interface GetFranchisesByMediumResponse extends BaseResponse {
    franchises : FranchiseLight[]
}
export interface GetFranchiseByIdResponse extends BaseResponse {
    franchise : FranchiseFull
}
export interface GetAllMediaResponse extends BaseResponse {
    media : MediumLight[]
}
export interface GetMediaByMoodResponse extends BaseResponse {
    mediaByMood : MediumLight[]
}
export interface GetMediumByIdResponse extends BaseResponse {
    medium : MediumFull
}
export interface GetMediumListResponse extends BaseResponse {
    media : MediumList[]
}

export interface GetMediaCheckBoxesByFranchiseResponse extends BaseResponse{
    media : MediumCheckBox[]
}

export interface GetFranchisesCheckBoxesByModelResponse extends BaseResponse{
    franchises : FranchiseCheckBox[]
}