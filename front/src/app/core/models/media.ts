import { BaseResponse } from "./base-response";

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