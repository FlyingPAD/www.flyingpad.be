import { BaseResponse } from "./base-response";

export interface CreateMoodResponse extends BaseResponse {
    moodId : number
}

export interface CreateTagResponse extends BaseResponse {
    tagId : number
}

export interface CreateTagCategoryResponse extends BaseResponse {
    tagCategoryId : number
}

export interface CreateLinkResponse extends BaseResponse {
    linkId : number
}

export interface CreateFranchiseResponse extends BaseResponse {
    franchiseId : number
}

export interface CreateArtistResponse extends BaseResponse {
    artistId : number
}

export interface CreateStyleResponse extends BaseResponse {
    styleId : number
}