import { BaseResponse } from "./base-response";

// Models.
export interface LinkLight {
    businessId :  number
    name :        string
    description : string
    url :         string
}
export interface LinkFull {
    businessId :  number
    name :        string
    description : string
    url :         string
    created :     Date
    createdBy :   string
    modified :    Date
    modifiedBy :  string
}
export interface LinkCategoryLight {
    businessId : number
    name :       string
}
export interface LinkCategoryFull {
    businessId :  number
    name :        string
    description : string
    created :     Date
    createdBy :   string
    modified :    Date
    modifiedBy :  string
}

// Calls.
export interface LinkCreateForm {
    name :        string
    description : string
    url :         string
}
export interface LinkUpdateForm {
    businessId :  number
    name :        string
    description : string
    url :         string
}
export interface LinkCategoryCreateForm {
    name :        string
    description : string
}

// Responses.
export interface GetLinkResponse extends BaseResponse {
    link : LinkFull
}
export interface GetLinksResponse extends BaseResponse  {
    links : LinkLight[]
}
export interface GetLinkCategoryResponse extends BaseResponse {
    linkCategory : LinkCategoryFull
}
export interface GetLinkCategoriesResponse extends BaseResponse {
    linkCategories : LinkCategoryLight[]
}
export interface CreateLinkResponse extends BaseResponse {
    linkId : number
}