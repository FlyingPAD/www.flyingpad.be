import { BaseResponse } from "./base-response";

// Models :

export interface MoodLight
{
    businessId : number
    name : string
    type : number
    description : string
    extension : string
    score : number
}

export class MoodFull
{
    businessId : number = 0
    created : Date = new Date()
    createdBy : string = ''
    modified : Date = new Date()
    modifiedBy : string = ''
    type: number = 0
    name : string = 'Empty Mood'
    description : string = ''
    score : number = 0
    extension: string = ''
}

// Calls :

export interface MoodUpdateForm
{
    moodId : number
    name : string
    description : string
}

export class UpdateMoodScoreCall
{
    businessId : number = 0
    value : number = 0
}

// Responses :

export interface MoodsCountResponse extends BaseResponse {}

export interface MoodsCountByTagResponse extends BaseResponse {}

export interface GetAllMoodsResponse extends BaseResponse
{
    moodsList : MoodLight[]
}

export interface MoodsGetOneDetailsResponse extends BaseResponse
{
    mood : MoodFull
}

export interface GetMoodsByTagResponse extends BaseResponse 
{
    moods : MoodLight[]
}

export interface GetMoodsByArtistResponse extends BaseResponse 
{
    moods : MoodLight[]
}

export interface GetMoodsByModelResponse extends BaseResponse 
{
    moods : MoodLight[]
}

export interface GetMoodsByFranchiseResponse extends BaseResponse 
{
    moods : MoodLight[]
}

export interface MoodUpdateResponse extends BaseResponse 
{
    updatedMood : MoodLight
}

export interface MoodsUpdateOneScoreResponse extends BaseResponse {}

export interface UpdateMoodScoreResponse extends BaseResponse {}