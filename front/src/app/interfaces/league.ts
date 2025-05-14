import { BaseResponse } from "./http/base-response";

export interface League {
  businessId: number
  name: string
  minExperience: number
  maxExperience?: number
  order: number
  iconCssClass?: string
}
export interface LeagueMemberDto {
  businessId: number
  userName: string
  seasonScore: number
}

export interface LeagueWithRankingDto {
  businessId: number
  leagueName: string
  minExperience: number
  maxExperience: number
  iconCssClass?: string
  order: number
  members: LeagueMemberDto[]
}

export interface GetLeagueByNameResponse extends BaseResponse {
  league: LeagueWithRankingDto
}