import { BaseResponse } from "./base-response";

// Models :

export class FranchiseLight
{
    businessId : number = 0
    name : string = ''
}

export class FranchiseDetails
{
    businessId : number = 0
    created : Date = new Date()
    createdBy : string = ''
    modified : Date = new Date()
    modifiedBy : string = ''
    name : string = ''
    description : string = ''
}

// Responses :

export interface GetOneFranchiseDetailsResponse extends BaseResponse
{
    franchise : FranchiseDetails
}

export interface GetFranchisesByMoodResponse extends BaseResponse
{
    franchisesByMood : FranchiseLight[]
}

export interface GetFranchisesByModelResponse extends BaseResponse
{
    franchisesByModel : FranchiseLight[]
}

export interface GetFranchisesByMediaResponse extends BaseResponse
{
    franchises : FranchiseLight[]
}

export interface GetAllFranchisesResponse extends BaseResponse
{
    franchises : FranchiseLight[]
}