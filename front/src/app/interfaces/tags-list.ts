import { BaseResponse } from "./base-response"
import { TagLight, TagLightWithCheckBox } from "./tag"
import { TagCategoryLight } from "./tag-category"

export interface TagList {
    category : TagCategoryLight
    tags :     TagLight[]
}
export interface TagsCheckBoxesList {
    category : TagCategoryLight
    tagsCheckBoxes : TagLightWithCheckBox[]
}

export interface TagsGetFullListResponse extends BaseResponse {
    categoriesWithTags : TagList[]
}

export interface GetTagsCheckBoxesByMoodResponse extends BaseResponse {
    tagsCheckBoxesList : TagsCheckBoxesList[]
}