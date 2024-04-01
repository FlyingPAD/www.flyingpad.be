import { BaseResponse } from "./base-response"

// Models :

export class User
{
    created : Date = new Date
    modified : Date = new Date
    businessId : number = 0
    firstName : string = ''
    lastName : string = ''
    email : string = ''
    birthdate : Date = new Date
    role : number = 0
}

// Calls :

export interface UserRegisterForm
{
    firstName: string;
    lastName: string;
    birthdate : Date;
    email:string;
    pass: string;
    confirmPass : string;
}

export interface UserLoginForm
{
    email : string;
    password : string;
}

export interface UserUpdateForm
{
    created : Date;
    modified : Date;
    businessId : number;
    firstName : string;
    lastName : string;
    birthdate : Date;
}

// Responses :

export interface UserUpdateResponse extends BaseResponse
{
    updatedUser : User
}