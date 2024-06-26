import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-flow',
  templateUrl: './flow.component.html',
  styleUrl: './flow.component.scss'
})
export class FlowComponent 
{
  flowService = inject(FlowService)  
  flow = this.flowService.flow

  environment = environment.apiBaseUrl

  // Boolean toggles for showing or hiding elements
  showMood = false
  showMoods = false
  showMoodsByTag = false
  showMoodsByModel = false
  showMoodsByArtist = false
  showMoodsByFranchise = false
  showTag = false
  showTags = false
  showTagsByCategory = false
  showTagCategory = false
  showTagCategories = false
  showArtist = false
  showArtists = false
  showArtistsByStyle = false
  showStyle = false
  showStyles = false
  showModel = false
  showModels = false
  showModelsByFranchise = false
  showFranchise = false
  showFranchises = false
  showFranchisesByMedia = false
  showMedia = false
  showMedias = false
  showLink = false
  showLinks = false
  showLinksByCategory = false
  showLinkCategory = false
  showLinkCategories = false

  // Toggle methods
  toggleMood() { this.showMood = !this.showMood }
  toggleMoods() { this.showMoods = !this.showMoods }
  toggleMoodsByTag() { this.showMoodsByTag = !this.showMoodsByTag }
  toggleMoodsByModel() { this.showMoodsByModel = !this.showMoodsByModel }
  toggleMoodsByArtist() { this.showMoodsByArtist = !this.showMoodsByArtist }
  toggleMoodsByFranchise() { this.showMoodsByFranchise = !this.showMoodsByFranchise }
  toggleTag() { this.showTag = !this.showTag }
  toggleTags() { this.showTags = !this.showTags }
  toggleTagsByCategory() { this.showTagsByCategory = !this.showTagsByCategory }
  toggleTagCategory() { this.showTagCategory = !this.showTagCategory }
  toggleTagCategories() { this.showTagCategories = !this.showTagCategories }
  toggleArtist() { this.showArtist = !this.showArtist }
  toggleArtists() { this.showArtists = !this.showArtists }
  toggleArtistsByStyle() { this.showArtistsByStyle = !this.showArtistsByStyle }
  toggleStyle() { this.showStyle = !this.showStyle }
  toggleStyles() { this.showStyles = !this.showStyles }
  toggleModel() { this.showModel = !this.showModel }
  toggleModels() { this.showModels = !this.showModels }
  toggleModelsByFranchise() { this.showModelsByFranchise = !this.showModelsByFranchise }
  toggleFranchise() { this.showFranchise = !this.showFranchise }
  toggleFranchises() { this.showFranchises = !this.showFranchises }
  toggleFranchisesByMedia() { this.showFranchisesByMedia = !this.showFranchisesByMedia }
  toggleMedia() { this.showMedia = !this.showMedia }
  toggleMedias() { this.showMedias = !this.showMedias }
  toggleLink() { this.showLink = !this.showLink }
  toggleLinks() { this.showLinks = !this.showLinks }
  toggleLinksByCategory() { this.showLinksByCategory = !this.showLinksByCategory }
  toggleLinkCategory() { this.showLinkCategory = !this.showLinkCategory }
  toggleLinkCategories() { this.showLinkCategories = !this.showLinkCategories }

  updateMoodId(moodId: number) {
    this.flowService.updateMoodId(moodId);
  }
  updateTagId(tagId: number) {
    this.flowService.updateTagId(tagId);
  }
  updateTagCategoryId(tagCategoryId: number) {
    this.flowService.updateTagCategoryId(tagCategoryId);
  }
  updateModelId(modelId: number) {
    this.flowService.updateModelId(modelId);
  }
  updateArtistId(artistId: number) {
    this.flowService.updateArtistId(artistId);
  }  
  updateStyleId(styleId: number) {
    this.flowService.updateStyleId(styleId);
  }
  updateFranchiseId(franchiseId: number) {
    this.flowService.updateFranchiseId(franchiseId);
  }
  updateMediaId(mediaId: number) {
    this.flowService.updateMediaId(mediaId);
  }
  updateLinkCategoryId(linkCategoryId: number) {
    this.flowService.updateLinkCategoryId(linkCategoryId);
  }
  updateLinkId(linkId: number) {
    this.flowService.updateLinkId(linkId);
  }

  handleMoodId(moodId : number) {
    this.updateMoodId(moodId)
  }
}
