import { BaseResponse } from "./base-response"

export interface RelationsArtistStyleForm {
    artistId : number
    styleIds : number[]
}
export interface RelationsMoodTagForm {
    moodId : number
    tagIds : number[]
}
export interface RelationsMoodArtistForm {
    moodId : number
    artistIds : number[]
}
export interface RelationsMoodModelForm {
    moodId : number
    modelIds : number[]
}


export interface CheckRelationsArtistStyleByStyleResponse extends BaseResponse {
    numberOfRelations : number
}
export interface CheckRelationsArtistStyleByArtistResponse extends BaseResponse {
    numberOfRelations : number
}