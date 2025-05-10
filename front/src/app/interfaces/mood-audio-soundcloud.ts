import { BaseResponse } from "./http/base-response";

export interface AudioSoundCloud {
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
    thumbnailUrl: string
    embedUrl: string
}

export interface GetOneAudioSoundCloudDetailsResponse extends BaseResponse {
    audioSoundCloud : AudioSoundCloud
}