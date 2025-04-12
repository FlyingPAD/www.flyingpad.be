import { ArtistLight } from "./artist";
import { BaseResponse } from "./base-response";
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
  extension: string
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