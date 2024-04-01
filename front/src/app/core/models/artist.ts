import { BaseResponse } from "./base-response";
import { PaginationResponse } from "./pagination-response";

// Models

export class ArtistLight
{
    businessId : number = 0
    name : string = ''
}

export class ArtistDetails
{
    businessId : number = 0
    name : string = ''
    created : Date = new Date()
    createdBy : string = ''
    modified : Date = new Date()
    modifiedBy : string = ''
}

// API Calls

export interface ArtistCreateForm
{
    name : string
}

export interface ArtistUpdateForm extends ArtistLight {}

// API Responses

export interface ArtistsCountResponse extends BaseResponse
{
    artistsCount : number
}

export interface ArtistsCreateResponse extends BaseResponse 
{
    artist : ArtistLight
}

export interface ArtistsGetAllResponse extends BaseResponse {}

export interface GetOneArtistResponse extends BaseResponse
{
    artist : ArtistLight
}

export interface GetOneArtistDetailsResponse extends BaseResponse
{
    artist : ArtistDetails
}

export interface GetArtistsByStyleResponse extends BaseResponse 
{
    artistsList : ArtistLight[]
}

export interface GetArtistsByMoodResponse extends BaseResponse 
{
    artistsByMood : ArtistLight[]
}

export class ArtistsGetPageResponse implements BaseResponse, PaginationResponse
{
    success: boolean = false
    message: string = ''
    validationErrors: string[] = []
    totalItems: number = 0
    itemPosition: number = 0
    previousId: number = 0
    nextId: number = 0
    artistsPage: ArtistLight[] = []
}

export interface ArtistsUpdateResponse extends BaseResponse {}

export interface ArtistsDeleteResponse extends BaseResponse {}