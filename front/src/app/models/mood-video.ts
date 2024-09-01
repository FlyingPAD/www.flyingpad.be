import { BaseResponse } from "./base-response";

export class Video
{
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
    duration : number = 0
}

export interface GetOneVideoDetailsResponse extends BaseResponse
{
    video : Video
}