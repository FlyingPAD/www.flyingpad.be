import { BaseResponse } from "./http/base-response"

export interface Achievement {
    id: number
    title: string
    goal: string
    done: string
    category: string
    date: Date | undefined
    unlocked: boolean
    xpValue: number
}

export interface NewAchievement {
    businessId: number;
    title: string;
    goal: string;
    doneMessage: string;
    category: string;
    xpReward: number;
    unlockedAt?: Date;
}

export interface GetUserAchievementsResponse extends BaseResponse {
    achievements: NewAchievement[]
}