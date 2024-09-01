import { BaseResponse } from "./base-response";

export interface TagLight {
    businessId : number
    name :       string
}
export interface TagLightWithCheckBox extends TagLight {
    isChecked : boolean
}
export interface TagFull {
    businessId : number
    name :       string
    description: string
    created :    Date
    createdBy :  string
    modified :   Date
    modifiedBy : string
    tagCategoryId : number
}

export interface GetAllTagsResponse extends BaseResponse {
    tags : TagLight[]
}
export interface GetTagsByCategoryResponse extends BaseResponse {
    tags : TagLight[]
}
export interface GetOneTagDetailsResponse extends BaseResponse {
    tag : TagFull
}
export interface GetTagByIdResponse extends BaseResponse {
    tag : TagFull
}
export interface GetTagsByMoodResponse extends BaseResponse {
    tagsByMood : TagLight[]
}