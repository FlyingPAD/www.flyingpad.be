import { BaseResponse } from "./base-response";
import { ModelLight } from "./model";

// Models :

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

// Responses :

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