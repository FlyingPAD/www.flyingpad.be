export interface MoodCreateForm {
    name : string
    description : string
}

export interface TagCategoryCreateForm {
    name : string
    description : string
}

export interface TagCreateForm {
    name : string
    description : string
    tagCategoryId : number
}

export interface ModelCreateForm {
    pseudonym : string
    firstName : string
    lastName : string
    gender : string
    description : string
    franchisesIds : number[]
}

export interface StyleCreateForm {
    name : string
    description : string
}

export interface ArtistCreateForm {
    name : string
    description : string
    styleIds : number[]
}

export interface MediumCreateForm {
    name : string
    description : string
}

export interface FranchiseCreateForm {
    name : string
    description : string
    mediaIds : number[]
}

export interface LinkCategoryCreateForm {
    name : string
    description : string
}

export interface LinkCreateForm {
    name : string
    description : string
    url : string
    linkCategoryIds : number[]
}

export interface UserCreateForm {
    firstName : string
    lastName : string
}