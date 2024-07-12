import { BaseResponse } from "./base-response"

// API Calls

export interface RelationsArtistStyleForm
{
    artistId : number
    styleIds : number[]
}

export class RelationsMoodTagForm
{
    moodId : number = 0
    tagIds : number[] = []
}

export class RelationsMoodArtistForm
{
    moodId : number = 0
    artistIds : number[] = []
}

export class RelationsMoodModelForm
{
    moodId : number = 0
    modelIds : number[] = []
}

// API Responses

export interface CreateRelationsArtistStyleResponse extends BaseResponse {}

export interface CreateRelationsMoodTagResponse extends BaseResponse {}
export interface CreateRelationsMoodArtistResponse extends BaseResponse {}
export interface CreateRelationsMoodModelResponse extends BaseResponse {}

export interface CheckRelationsArtistStyleByStyleResponse extends BaseResponse
{
    numberOfRelations : number
}

export interface CheckRelationsArtistStyleByArtistResponse extends BaseResponse
{
    numberOfRelations : number
}