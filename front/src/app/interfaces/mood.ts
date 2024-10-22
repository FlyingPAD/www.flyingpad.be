import { BaseResponse } from "./base-response";

export interface MoodLight {
    businessId : number
    type : number
    name : string
    description : string
    extension : string
    score : number
}
export interface MoodFull {
    businessId : number
    created : Date
    createdBy : string
    modified : Date
    modifiedBy : string
    type: number
    name : string
    description : string
    score : number
    extension: string
}

export interface GetMoodsResponse extends BaseResponse {
    moods : MoodLight[]
}
export interface GetMoodResponse extends BaseResponse {
    mood : MoodFull
}