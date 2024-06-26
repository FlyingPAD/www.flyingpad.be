import { BaseResponse } from "./base-response";

// Models.
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

// Calls.
export interface MoodUpdateForm {
    moodId : number
    name : string
    description : string
}
export class UpdateMoodScoreCall {
    businessId : number = 0
    value : number = 0
}

// Responses.
export interface GetMoodsResponse extends BaseResponse {
    moods : MoodLight[]
}
export interface GetMoodByIdResponse extends BaseResponse {
    mood : MoodFull
}
export interface MoodUpdateResponse extends BaseResponse {
    updatedMood : MoodLight
}
export interface UpdateMoodScoreResponse extends BaseResponse {}