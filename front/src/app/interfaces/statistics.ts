import { BaseResponse } from "./http/base-response";

export interface Statistics {
    totalMoods: number
    totalImages: number
    imagesPercentage: number
    totalVideos: number
    videosPercentage: number
    totalTags: number
    totalTagCategories: number
    totalArtists: number
    totalStyles: number
    totalMedia: number
    totalFranchises: number
    totalModels: number
    totalMales: number
    malesPercentage: number
    totalFemales: number
    femalesPercentage: number
    totalLinks: number
    totalLinkCategories: number
    totalUsers: number
    totalRelationsArtistStyle: number
    totalRelationsFranchiseMedium: number
    totalRelationsFranchiseModel: number
    totalRelationsLinkArtist: number
    totalRelationsLinkCategory: number
    totalRelationsLinkModel: number
    totalRelationsMoodArtist: number
    totalRelationsMoodFranchise: number
    totalRelationsMoodModel: number
    totalRelationsMoodTag: number
}

export interface GetStatisticsResponse extends BaseResponse {
    statistics: Statistics
}