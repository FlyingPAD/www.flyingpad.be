import { BaseResponse } from "./base-response";

// Models.
export interface TagLight {
    businessId : number
    name :       string
}
export interface MiniTag {
    businessId : number
    name :       string
}
export interface TagsCheckBoxes extends MiniTag {
    isChecked : boolean
}
export class Tag {
    businessId : number = 0
    name :       string = '# All Files'
    description: string = ''
    created :    Date = new Date
    createdBy :  string = ''
    modified :   Date = new Date
    modifiedBy : string = ''
}
export interface TagFull {
    businessId : number
    name :       string
    description: string
    created :    Date
    createdBy :  string
    modified :   Date
    modifiedBy : string
}
export class TagList {
    category : MiniTagCategory = new MiniTagCategory()
    tags :     MiniTag[] = []
}
export class TagsCheckBoxesList {
    category : MiniTagCategory = new MiniTagCategory()
    tagsCheckBoxes : TagsCheckBoxes[] = []
}
export class MiniTagCategory {
    businessId : number = 0
    name :       string = ''
}
export class TagCategory  {
    businessId :  number = 0
    created :     Date = new Date
    modified :    Date = new Date
    name :        string = ''
    description : string = ''
}
export interface TagCategoryFull {
    businessId :  number
    created :     Date
    modified :    Date
    name :        string
    description : string
}

// Calls.
export interface TagCreateForm {
    name :        string
    description : string
}
export interface TagUpdateForm {
    tagId : number
    name : string
    description : string
}
export interface TagCategoryCreateForm {
    name :        string
    description : string
}

// Responses.
export interface GetAllTagsResponse extends BaseResponse {
    tags : MiniTag[]
}
export interface GetTagsByCategoryResponse extends BaseResponse {
    tags : MiniTag[]
}
export interface GetOneTagDetailsResponse extends BaseResponse {
    tag : Tag
}
export interface GetTagByIdResponse extends BaseResponse {
    tag : TagFull
}
export interface TagsGetFullListResponse extends BaseResponse {
    categoriesWithTags : TagList[]
}
export interface GetTagsByMoodResponse extends BaseResponse {
    tagsByMood : MiniTag[]
}
export interface GetTagsCheckBoxesByMoodResponse extends BaseResponse {
   tagsCheckBoxesList : TagsCheckBoxesList[]
}
export interface GetAllTagCategoriesResponse extends BaseResponse {
    tagCategories : MiniTagCategory[]
}
export interface GetTagCategoryByIdResponse extends BaseResponse {
    tagCategory : TagCategoryFull
}
export interface CreateTagResponse extends BaseResponse {
    link : Tag
}