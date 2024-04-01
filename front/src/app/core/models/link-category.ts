import { BaseResponse } from "./base-response";

// Models :

export interface LinkCategoryLight extends BaseResponse
{
    businessId : number;
    name :       string;   
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

// Responses :

export interface LinkCategoriesCountResponse extends BaseResponse 
{
    linkCategoriesCount : number
}

export interface LinkCategoriesGetAllResponse extends BaseResponse 
{
    linkCategories : LinkCategoryLight[]
}

export interface LinkCategoriesGetOneResponse extends BaseResponse 
{
    linkCategory : LinkCategoryFull
}