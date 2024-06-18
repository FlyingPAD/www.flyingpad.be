import { BaseResponse } from "./base-response";
import { ModelLight } from "./model";

// Models :

export class FranchiseLight
{
    businessId : number = 0
    name : string = ''
}
export class FranchiseDetails
{
    businessId : number = 0
    created : Date = new Date()
    createdBy : string = ''
    modified : Date = new Date()
    modifiedBy : string = ''
    name : string = ''
    description : string = ''
}

export class MediaLight
{
    businessId : number = 0
    name : string = ''
}
export class MediaDetails
{
    businessId : number = 0
    created : Date = new Date()
    createdBy : string = ''
    modified : Date = new Date()
    modifiedBy : string = ''
    name : string = ''
    description : string = ''
}
export class MediaFullList
{
    businessId : number = 0
    name : string = ''
    franchises : FranchiseList[] = []
}
export class FranchiseList
{
    businessId : number = 0
    name : string = ''
    models : ModelLight[] = []
}

// Calls :

export interface FranchiseCreateForm
{
    name :        string
    description : string
}
export interface MediaCreateForm
{
    name :        string
    description : string
}

// Responses :

export interface GetAllFranchises extends BaseResponse
{
    franchises : FranchiseLight[]
}
export interface GetOneFranchiseDetailsResponse extends BaseResponse
{
    franchise : FranchiseDetails
}
export interface GetFranchisesByMoodResponse extends BaseResponse
{
    franchisesByMood : FranchiseLight[]
}
export interface GetFranchisesByModelResponse extends BaseResponse
{
    franchisesByModel : FranchiseLight[]
}
export interface GetFranchisesByMediaResponse extends BaseResponse
{
    franchises : FranchiseLight[]
}
export interface GetAllFranchisesResponse extends BaseResponse
{
    franchises : FranchiseLight[]
}
export interface CreateFranchiseResponse extends BaseResponse
{
    franchise : FranchiseDetails
}

export interface GetAllMediasResponse extends BaseResponse
{
    medias : MediaLight[]
}
export interface GetMediasByMoodResponse extends BaseResponse
{
    mediasByMood : MediaLight[]
}
export interface GetOneMediaDetailsResponse extends BaseResponse
{
    media : MediaDetails
}
export interface GetMediaByModelResponse extends BaseResponse
{
    media : MediaDetails
}
export interface GetMediasFullListResponse extends BaseResponse
{
    medias : MediaFullList[]
}