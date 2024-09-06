import { BaseResponse } from "./base-response";

export class Image {
    businessId : number = 0
    created : Date = new Date()
    modified : Date = new Date()
    name : string = ''
    description : string = ''
    score : number = 0
    type: number = 0
    size: number = 0
    extension: string = ''
    height: number = 0
    width: number = 0
}
export interface ImageForm {
    title : string
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