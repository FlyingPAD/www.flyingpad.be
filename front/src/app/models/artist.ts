import { BaseResponse } from "./base-response";
import { PaginationResponse } from "./pagination-response";

export interface ArtistLight {
    businessId : number
    name : string
}
export interface ArtistFull {
    businessId : number
    name : string
    created : Date
    createdBy : string
    modified : Date
    modifiedBy : string
}

export interface ArtistCheckBox {
    businessId : number
    name : string
    isChecked : boolean
}

export interface ArtistsCountResponse extends BaseResponse {
    artistsCount : number
}

export interface GetAllArtistsResponse extends BaseResponse {
    artists : ArtistCheckBox[]
}

export interface GetOneArtistResponse extends BaseResponse {
    artist : ArtistLight
}

export interface GetArtistByIdResponse extends BaseResponse {
    artist : ArtistFull
}

export interface GetArtistsByStyleResponse extends BaseResponse {
    artists : ArtistLight[]
}

export interface GetArtistsByMoodResponse extends BaseResponse {
    artistsByMood : ArtistLight[]
}

export class ArtistsGetPageResponse implements BaseResponse, PaginationResponse {
    success: boolean = false
    message: string = ''
    validationErrors: string[] = []
    totalItems: number = 0
    itemPosition: number = 0
    previousId: number = 0
    nextId: number = 0
    artistsPage: ArtistLight[] = []
}

export interface GetArtistsCheckBoxesByMoodResponse extends BaseResponse{
   artists : ArtistCheckBox[]
}