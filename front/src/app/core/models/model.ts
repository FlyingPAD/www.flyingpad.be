import { BaseResponse } from "./base-response";

// Models :

export class ModelLight
{
    businessId : number = 0
    pseudonym : string = ''
    gender : string = ''
}

export class ModelDetails
{
    businessId : number = 0
    created : Date = new Date()
    createdBy : string = ''
    modified : Date = new Date()
    modifiedBy : string = ''
    firstName : string = ''
    lastName : string = ''
    pseudonym : string = ''
    gender : string = ''
    description : string = ''
}

// Calls :

export interface ModelForm
{
    firstName : string;
    lastName : string;
    aka : string;
    gender : string;
}

export interface ModelCheckForm
{
    firstName : string;
    lastName : string;
    aka : string;
    gender : string;
    isChecked : boolean;
}

// Responses :

export interface GetOneModelDetailsResponse extends BaseResponse
{
    model : ModelDetails
}

export interface GetModelsByMoodResponse extends BaseResponse
{
    modelsByMood : ModelLight[]
}

export interface GetModelsByFranchiseResponse extends BaseResponse
{
    modelsByFranchise : ModelLight[]
}