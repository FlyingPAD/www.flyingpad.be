// API Call Forms

import { BaseResponse } from "./base-response"

export interface RelationsArtistStyleForm
{
    artistId : number
    styleIds : number[]
}

// API Responses

export interface CreateRelationsArtistStyleResponse extends BaseResponse {}

export interface CheckRelationsArtistStyleByStyleResponse extends BaseResponse
{
    numberOfRelations : number
}

export interface CheckRelationsArtistStyleByArtistResponse extends BaseResponse
{
    numberOfRelations : number
}