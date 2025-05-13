import { BaseResponse } from "./http/base-response"

export interface Season {
    name: string
    startsAt: Date
    endsAt: Date
}

export interface GetCurrentSeasonResponse extends BaseResponse {
    currentSeason: Season 
}