import { Achievement } from "./achievement"
import { BaseResponse } from "./base-response"

export interface User {
    created: Date
    modified: Date
    email: string
    businessId: number
    pseudonym: string
    firstName: string
    lastName: string
    birthdate: Date
    role: number
    level: number
    experience: number
    achievements: Achievement[]
}

export interface GetUserResponse extends BaseResponse {
    user: User
}
export interface UserUpdateResponse extends BaseResponse {
    updatedUser: User
}