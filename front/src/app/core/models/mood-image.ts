// Models :

import { BaseResponse } from "./base-response";

export class Image
{
    businessId : number = 0
    created : Date = new Date()
    modified : Date = new Date()
    name : string = ''
    description : string = ''
    score : number = 0
    type: number = 0
    size: number = 0
    extension: string = ''
    height: number = 0
    width: number = 0
}

// Responses :

export interface GetOneImageDetails extends BaseResponse
{
    image : Image
}