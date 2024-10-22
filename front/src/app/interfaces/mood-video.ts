import { BaseResponse } from "./base-response";

export interface Video {
    businessId : number
    created : Date
    modified : Date
    name : string
    description : string
    score : number
    type: number
    size: number
    extension: string
    height: number
    width: number
    duration : number
}

export interface VideoForm {
    title : string
    description : string
    type : number
    size : number
    extension : string
    height : number
    width : number
    duration : number
    sourceFile : string
    url : string
}
export interface GetOneVideoDetailsResponse extends BaseResponse {
    video : Video
}

export interface CreateMoodVideoResponse extends BaseResponse {
    moodId : number
}