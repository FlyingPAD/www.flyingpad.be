import { BaseResponse } from "./base-response";

export interface Image {
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
}
export interface ImageForm {
    name : string
    description : string
    type : number
    size : number
    extension : string
    height : number
    width : number
    sourceFile : string
    url : string
}

export interface GetOneImageDetailsResponse extends BaseResponse {
    image : Image
}
export interface CreateMoodImageResponse extends BaseResponse {
    moodId : number
}