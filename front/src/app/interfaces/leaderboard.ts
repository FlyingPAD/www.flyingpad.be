import { BaseResponse } from "./http/base-response"

export interface LeaderboardEntry {
    businessId: number
    userName: string
    level: number
    experience: number
    seasonScore: number
    leagueName: string
}

export interface GetLeaderBoardReponse extends BaseResponse {
    entries: LeaderboardEntry[]
}