import { BaseResponse } from "./base-response"

export interface User {
    created : Date
    modified : Date
    businessId : number
    firstName : string
    lastName : string
    email : string
    birthdate : Date
    role : number
}

export interface UserRegisterForm {
    firstName: string;
    lastName: string;
    birthdate : Date;
    email:string;
    pass: string;
    confirmPass : string;
}
export interface UserLoginForm {
    email : string;
    password : string;
}
export interface UserUpdateForm {
    created : Date;
    modified : Date;
    businessId : number;
    firstName : string;
    lastName : string;
    birthdate : Date;
}

export interface UserUpdateResponse extends BaseResponse {
    updatedUser : User
}