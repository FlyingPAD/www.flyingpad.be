import { BaseResponse } from "./base-response";

// Models :

export interface MiniTag
{
    businessId : number
    name :       string
}

export class Tag
{
    businessId : number = 0
    name :       string = '# All Files'
    description: string = ''
    created :    Date = new Date
    createdBy :  string = ''
    modified :   Date = new Date
    modifiedBy : string = ''
}

export class TagList
{
    category : MiniTagCategory = new MiniTagCategory()
    tags :     MiniTag[] = []
}

export class MiniTagCategory
{
    businessId : number = 0
    name :       string = ''
}

export class TagCategory
{
    businessId :  number = 0
    created :     Date = new Date
    modified :    Date = new Date
    name :        string = ''
    description : string = ''
}

// Response :

export interface GetOneTagDetailsResponse extends BaseResponse
{
    tag : Tag
}

export interface TagsGetFullListResponse extends BaseResponse
{
    categoriesWithTags : TagList[]
}

export interface GetTagsByMoodResponse extends BaseResponse
{
    tagsByMood : MiniTag[]
}