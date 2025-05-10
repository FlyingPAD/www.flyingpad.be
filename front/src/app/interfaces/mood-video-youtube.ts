import { BaseResponse } from "./http/base-response";

export interface VideoYouTube {
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
    url: string
}

export interface GetOneVideoYoutubeDetailsResponse extends BaseResponse {
    videoYouTube : VideoYouTube
}