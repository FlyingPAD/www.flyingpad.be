import { BaseResponse } from "./base-response";

export interface CreateMoodImageResponse extends BaseResponse {
    moodId?: number
}

export interface CreateMoodVideoResponse extends BaseResponse {
    moodId?: number
}

export interface CreateMoodYouTubeVideoResponse extends BaseResponse {
    moodId?: number
}

export interface CreateMoodSoundCloudAudioResponse extends BaseResponse {
    moodId?: number
}

export interface CreateTagCategoryResponse extends BaseResponse {
    tagCategoryId?: number
}

export interface CreateTagResponse extends BaseResponse {
    tagId?: number
}

export interface CreateModelResponse extends BaseResponse {
    modelId?: number
}

export interface CreateStyleResponse extends BaseResponse {
    styleId?: number
}

export interface CreateArtistResponse extends BaseResponse {
    artistId?: number
}

export interface CreateMediumResponse extends BaseResponse {
    mediumId?: number
}

export interface CreateFranchiseResponse extends BaseResponse {
    franchiseId?: number
}

export interface CreateLinkCategoryResponse extends BaseResponse {
    linkCategoryId?: number
}

export interface CreateLinkResponse extends BaseResponse {
    linkId?: number
}