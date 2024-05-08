import { BaseResponse } from "./base-response";
import { PaginationResponse } from "./pagination-response";
import { StyleCheck } from "./style";

// Models

export class ArtistLight
{
    businessId : number = 0
    name : string = 'new artist'
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

export class ArtistCheckBox
{
    businessId : number = 0
    name : string = 'new artist'
    isChecked : boolean = false
}

// API Calls

export interface ArtistCreateFormGroup
{
    name : string
    styles : StyleCheck[]
}
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

export interface GetAllArtistsResponse extends BaseResponse {}

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

export interface ArtistDeleteResponse extends BaseResponse {}

export interface GetArtistsCheckBoxesByMoodResponse extends BaseResponse
{
   artists : ArtistCheckBox[]
}