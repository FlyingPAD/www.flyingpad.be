import { BaseResponse } from "./http/base-response";

export interface Video {
    businessId: number
    created: Date
    modified: Date
    name: string
    description: string
    score: number
    type: number
    size: number
    extension: string
    height: number
    width: number
    duration: number
}

export interface GetOneVideoDetailsResponse extends BaseResponse {
    video: Video
}