import { BaseResponse } from "./base-response";
import { PaginationResponse } from "./pagination-response";

// Models.
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

export class ArtistCheckBox {
    businessId : number = 0
    name : string = 'new artist'
    isChecked : boolean = false
}

export interface StyleLight {
    businessId : number
    name: string
    isChecked? : boolean
}
export interface StyleFull {
    businessId : number
    name : string
    createdDate : Date
    createdBy : string
    modifiedDate : Date
    modifiedBy : string
}

// API Calls

export interface ArtistCreateFormGroup {
    name : string
    styles : StyleLight[]
}
export interface ArtistCreateForm {
    name : string
}

// API Responses

export interface ArtistsCountResponse extends BaseResponse {
    artistsCount : number
}

export interface ArtistsCreateResponse extends BaseResponse {
    artist : ArtistLight
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

export interface ArtistDeleteResponse extends BaseResponse {}

export interface GetArtistsCheckBoxesByMoodResponse extends BaseResponse
{
   artists : ArtistCheckBox[]
}

export interface GetStyleResponse extends BaseResponse {
    style : StyleFull
}
export interface GetStylesResponse extends BaseResponse {
    styles : StyleLight[]
}
export interface CreateStyleResponse extends BaseResponse {
    styleId : number
}