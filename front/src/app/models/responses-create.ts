import { BaseResponse } from "./base-response";

export interface CreateMoodResponse extends BaseResponse {
    moodId : number
}

export interface CreateTagResponse extends BaseResponse {
    tagId : number
}

export interface CreateLinkResponse extends BaseResponse {
    linkId : number
}

export interface CreateFranchiseResponse extends BaseResponse {
    franchiseId : number
}