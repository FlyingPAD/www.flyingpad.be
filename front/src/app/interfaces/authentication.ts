import { BaseResponse } from "./http/base-response";

export type CaptchaType = 'v2' | 'v3'

export interface UserRegisterForm {
    userName: string
    firstName: string
    lastName: string
    birthdate: Date
    email: string
    pass: string
    confirmPass: string
    captchaToken: string
    captchaType: CaptchaType
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

export interface ConfirmEmailResponse extends BaseResponse {
    
}