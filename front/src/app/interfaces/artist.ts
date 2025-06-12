import { BaseResponse } from "./http/base-response";

export interface ArtistLight {
    businessId: number
    name: string
    description: string
}
export interface ArtistCheckBox extends ArtistLight {
    isChecked: boolean
}

export interface ArtistFull {
    businessId: number
    name: string
    description: string
    created: Date
    createdBy: string
    modified: Date
    modifiedBy: string
}

export interface StyleLight {
    businessId: number
    name: string
    description: string
}
export interface StyleCheckBox extends StyleLight {
    isChecked: boolean
}

export interface StyleFull {
    businessId: number
    name: string
    description: string
    createdDate: Date
    createdBy: string
    modifiedDate: Date
    modifiedBy: string
}

export interface GetAllArtistsResponse extends BaseResponse {
    artists: ArtistCheckBox[]
}

export interface GetArtistByIdResponse extends BaseResponse {
    artist: ArtistFull
}

export interface GetArtistsByStyleResponse extends BaseResponse {
    artists: ArtistLight[]
}

export interface GetArtistsByMoodResponse extends BaseResponse {
    artistsByMood: ArtistLight[]
}

export interface GetArtistsCheckBoxesByMoodResponse extends BaseResponse {
    artists: ArtistCheckBox[]
}

export interface GetStyleByIdResponse extends BaseResponse {
    style: StyleFull
}

export interface GetAllStylesResponse extends BaseResponse {
    styles: StyleLight[]
}

export interface GetStylesCheckBoxesByArtistResponse extends BaseResponse {
    styles: StyleCheckBox[]
}