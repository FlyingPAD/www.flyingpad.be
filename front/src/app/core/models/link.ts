import { BaseResponse } from "./base-response";

// Models :

export class Link
{
    businessId :    number = 0
    name :          string = ''
    description :   string = ''
    url :           string = ''
}

// Responses :

export interface LinksCountResponse extends BaseResponse 
{
    linksCount : number
}

export interface LinksGetAllResponse extends BaseResponse 
{
    linksList : Link[]
}

export interface LinksGetByCategoryResponse extends BaseResponse 
{
    linksListByCategory : Link[]
}