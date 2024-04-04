// Models :

import { BaseResponse } from "./base-response";

export class VideoYouTube
{
    businessId : number = 0
    created : Date = new Date()
    createdBy : string = ''
    modified : Date = new Date()
    modifiedBy : string = ''
    type: number = 0
    name : string = ''
    description : string = ''
    score : number = 0
    extension: string = ''
    url: string = ''
}

// Responses :

export interface GetOneVideoYoutubeDetailsResponse extends BaseResponse
{
    videoYouTube : VideoYouTube
}