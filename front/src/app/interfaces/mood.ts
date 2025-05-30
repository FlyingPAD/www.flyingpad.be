import { ArtistLight } from "./artist";
import { BaseResponse } from "./http/base-response";
import { FranchiseLight } from "./franchise";
import { ModelLight } from "./model";
import { TagLight } from "./tag";
import { TagsCheckBoxesList } from "./tag";

export interface MoodLight {
  businessId: number
  type: number
  name: string
  description: string
  extension: string
  score: number
  position: number
  url?: string
  width?: number
  height?: number
  duration?: number
  size?: number
  thumbnailUrl?: string
  embedUrl?: string
}

export interface MoodFull {
  businessId: number
  created: Date
  createdBy: string
  modified: Date
  modifiedBy: string
  type: number
  name: string
  description: string
  score: number
  position: number
  extension: string
  url?: string
  thumbnailUrl?: string
  embedUrl?: string
}

export interface DetailedMood extends MoodFull {
  relatedArtists: ArtistLight[]
  relatedModels: ModelLight[]
  relatedFranchises: FranchiseLight[]
  relatedTags: TagLight[]
}

export interface GetMoodsResponse extends BaseResponse {
  moods: MoodLight[]
}

export interface GetMoodResponse extends BaseResponse {
  mood: MoodFull
}

export interface GetCommonTagsByMoodsResponse extends BaseResponse {
  commonTags: TagsCheckBoxesList[]
}

export interface CommonTagsByMoodsForm {
  moodIds: number[]
}