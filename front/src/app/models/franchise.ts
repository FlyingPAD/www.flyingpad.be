import { BaseResponse } from "./base-response";
import { ModelLight } from "./model";

export interface FranchiseLight {
    businessId : number
    name : string
    description : string
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
export interface MediaLight {
    businessId : number
    name : string
}
export interface MediaFull {
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
export interface MediaList {
    businessId : number
    name : string
    franchises : FranchiseList[]
}

export interface GetFranchisesResponse extends BaseResponse {
    franchises : FranchiseLight[]
}
export interface GetFranchisesByMoodResponse extends BaseResponse {
    franchisesByMood : FranchiseLight[]
}
export interface GetFranchisesByModelResponse extends BaseResponse {
    franchisesByModel : FranchiseLight[]
}
export interface GetFranchisesByMediaResponse extends BaseResponse {
    franchises : FranchiseLight[]
}
export interface GetFranchiseResponse extends BaseResponse {
    franchise : FranchiseFull
}

export interface GetMediasResponse extends BaseResponse {
    medias : MediaLight[]
}
export interface GetMediasByMoodResponse extends BaseResponse {
    mediasByMood : MediaLight[]
}
export interface GetMediaResponse extends BaseResponse {
    media : MediaFull
}
export interface GetMediasListResponse extends BaseResponse {
    medias : MediaList[]
}