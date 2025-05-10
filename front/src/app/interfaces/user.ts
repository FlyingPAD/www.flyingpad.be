import { Achievement } from "./achievement"
import { BaseResponse } from "./http/base-response"
import { League } from "./league";
import { Season } from "./season";

export interface User {
    // Identité & contact
    businessId: number;
    userName: string;
    firstName: string;
    lastName: string;
    email: string;
    isEmailVerified: boolean;

    // Profil
    birthdate: Date;
    role: number;

    // Gamification
    level: number;
    experience: number;
    seasonScore: number
    season?: Season;
    league?: League;
    achievements: Achievement[];

    // Auditing
    created: Date;
    createdBy?: string;
    modified: Date;
    modifiedBy?: string;
}

export interface GetUserResponse extends BaseResponse {
    user: User
}

export interface UserUpdateResponse extends BaseResponse {
    updatedUser: User
}

export interface GetAllUsersResponse extends BaseResponse {
    users: User[]
}