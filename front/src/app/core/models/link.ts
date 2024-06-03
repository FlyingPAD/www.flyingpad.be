import { BaseResponse } from "./base-response";

// Models :
export class Link
{
    businessId :  number = 0
    name :        string = ''
    description : string = ''
    url :         string = ''
    created :     Date = new Date()
    createdBy :   string = ''
    modified :    Date = new Date()
    modifiedBy :  string = ''
}
export class LinkCategoryLight
{
    businessId : number = 0
    name :       string = ''
}
export class LinkCategoryFull
{
    businessId :  number = 0
    name :        string = ''
    description : string = ''
    created :     Date = new Date()
    createdBy :   string = ''
    modified :    Date = new Date()
    modifiedBy :  string = ''
}

// Calls :
export interface LinkCreateForm
{
    name :        string
    description : string
    url :         string
}
export interface LinkUpdateForm
{
    businessId :  number
    name :        string
    description : string
    url :         string
}
export interface LinkCategoryCreateForm
{
    name :        string
    description : string
}

// Responses :
export interface GetAllLinksResponse extends BaseResponse 
{
    linksList : Link[]
}
export interface GetAllLinkCategoriesResponse extends BaseResponse 
{
    linkCategories : LinkCategoryLight[]
}
export interface GetLinksByCategoryResponse extends BaseResponse 
{
    linksListByCategory : Link[]
}
export interface GetOneLinkDetailsResponse extends BaseResponse 
{
    link : Link
}
export interface GetOneLinkCategoryDetailsResponse extends BaseResponse 
{
    linkCategory : LinkCategoryFull
}
export interface CreateLinkResponse extends BaseResponse
{
    link : Link
}

export interface getLinkCategoriesCheckBoxesResponse extends BaseResponse
{
    linkCategoriesCheckBoxes : LinkCategoryLight[]
}