import { BaseResponse } from "./base-response";

export interface UserRegisterForm {
    pseudonym: string
    firstName: string
    lastName: string
    birthdate: Date
    email: string
    pass: string
    confirmPass: string
}

export interface UserLoginForm {
    email: string
    password: string
}

export interface RegisterCommandResponse extends BaseResponse {
    token : string
}

export interface LoginQueryResponse extends BaseResponse {
    token : string
}