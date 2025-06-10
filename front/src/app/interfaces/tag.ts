import { BaseResponse } from "./http/base-response";

export interface TagList {
    category: TagCategoryLight
    tags: TagLight[]
}

export interface TagsCheckBoxesList {
    category: TagCategoryLight
    tagsCheckBoxes: TagLightWithCheckBox[]
}

export interface TagLight {
    businessId: number
    name: string
    description: string
}
export interface TagLightWithCheckBox extends TagLight {
    isChecked: boolean
}

export interface TagFull {
    businessId: number
    name: string
    description: string
    created: Date
    createdBy: string
    modified: Date
    modifiedBy: string
    tagCategoryId: number
}

export interface TagCategoryLight {
    businessId: number
    name: string
}

export interface TagCategoryFull {
    businessId: number
    created: Date
    modified: Date
    name: string
    description: string
}

export interface GetAllTagsResponse extends BaseResponse {
    tags: TagLight[]
}

export interface GetTagsByCategoryResponse extends BaseResponse {
    tags: TagLight[]
}

export interface GetTagByIdResponse extends BaseResponse {
    tag: TagFull
}

export interface GetTagsByMoodResponse extends BaseResponse {
    tagsByMood: TagLight[]
}

export interface GetAllTagCategoriesResponse extends BaseResponse {
    tagCategories: TagCategoryLight[]
}

export interface GetTagCategoryByIdResponse extends BaseResponse {
    tagCategory: TagCategoryFull
}

export interface TagsGetFullListResponse extends BaseResponse {
    categoriesWithTags: TagList[]
}

export interface GetTagsCheckBoxesByMoodResponse extends BaseResponse {
    tagsCheckBoxesList: TagsCheckBoxesList[]
}