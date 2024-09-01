export interface MoodUpdateForm {
    moodId : number
    name : string
    description : string
}

export class MoodScoreUpdate {
    businessId : number = 0
    value : number = 0
}

export interface TagCategoryUpdateForm {
    tagCategoryId : number
    name : string
    description : string
}

export interface TagUpdateForm {
    tagId : number
    name : string
    description : string
    tagCategoryId : number
}

export interface ModelUpdateForm {
    modelId : number
    pseudonym : string
    firstName : string
    lastName : string
    gender : string
    description : string
}

export interface StyleUpdateForm {
    styleId : number
    name : string
    description : string
}

export interface ArtistUpdateForm {
    artistId : number
    name : string
    description : string
}

export interface MediaUpdateForm {
    mediaId : number
    name : string
    description : string
}

export interface FranchiseUpdateForm {
    franchiseId : number
    name : string
    description : string
}

export interface LinkCategoryUpdateForm {
    linkCategoryId : number
    name : string
    description : string
}

export interface LinkUpdateForm {
    linkId : number
    name : string
    description : string
    url : string
}
