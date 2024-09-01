import { BaseResponse } from "./base-response";

export interface TagCategoryLight {
    businessId : number
    name :       string
}
export interface TagCategoryLightWithCheckBox extends TagCategoryLight {
    isChecked : boolean
}
export interface TagCategoryFull {
    businessId :  number
    created :     Date
    modified :    Date
    name :        string
    description : string
}

export interface GetAllTagCategoriesResponse extends BaseResponse {
    tagCategories : TagCategoryLight[]
}
export interface GetTagCategoryByIdResponse extends BaseResponse {
    tagCategory : TagCategoryFull
}