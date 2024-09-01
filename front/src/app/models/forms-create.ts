import { StyleLight } from "./style"

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
}

export interface StyleCreateForm {
    name : string
    description : string
}

export interface ArtistCreateForm {
    name : string
    description : string
    styles : StyleLight[]
}

export interface MediaCreateForm {
    name : string
    description : string
}

export interface FranchiseCreateForm {
    name : string
    description : string
}

export interface LinkCategoryCreateForm {
    name : string
    description : string
}

export interface LinkCreateForm {
    name : string
    description : string
    url : string
}
