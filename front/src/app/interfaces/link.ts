import { BaseResponse } from "./http/base-response";

export interface LinkLight {
    businessId : number
    name : string
    description : string
    url : string
}

export interface LinkFull {
    businessId : number
    name : string
    description : string
    url : string
    created : Date
    createdBy : string
    modified : Date
    modifiedBy : string
}

export interface LinkCategoryLight {
    businessId : number
    name : string
}
export interface LinkCategoryCheckBox extends LinkCategoryLight {
    isChecked : boolean
}

export interface LinkCategoryFull {
    businessId : number
    name : string
    description : string
    created : Date
    createdBy : string
    modified : Date
    modifiedBy : string
}

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

export interface GetLinkCategoriesCheckBoxesResponse extends BaseResponse{
    linkCategories : LinkCategoryCheckBox[]
}