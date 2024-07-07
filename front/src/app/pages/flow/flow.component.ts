import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { environment } from '../../../environments/environment';
import { Router } from '@angular/router';

@Component({
  selector: 'app-flow',
  templateUrl: './flow.component.html',
  styleUrl: './flow.component.scss'
})
export class FlowComponent 
{
  #router = inject(Router)
  flowService = inject(FlowService)  
  flow = this.flowService.flow

  environment = environment.apiBaseUrl

  // Boolean toggles for showing or hiding elements
  showMood = true
  showMoods = true
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

  goBack()
  {
    this.#router.navigateByUrl('/dashboard')
  }

  goToURL(): void {
    const url = this.flow()?.link?.url
    if (url) 
    {
      window.open(url, '_blank')
    } 
  }

  showMoodsByArtistId()
  {
    this.showMoods = false
    this.showMoodsByTag = false
    this.showMoodsByModel = false
    this.showMoodsByArtist = true
    this.showMoodsByFranchise = false
    this.showTag = false
    this.showTags = false
    this.showTagsByCategory = false
    this.showTagCategory = false
    this.showTagCategories = false
    this.showArtist = false
    this.showArtists = false
    this.showArtistsByStyle = false
    this.showStyle = false
    this.showStyles = false
    this.showModel = false
    this.showModels = false
    this.showModelsByFranchise = false
    this.showFranchise = false
    this.showFranchises = false
    this.showFranchisesByMedia = false
    this.showMedia = false
    this.showMedias = false
    this.showLink = false
    this.showLinks = false
    this.showLinksByCategory = false
    this.showLinkCategory = false
    this.showLinkCategories = false
  }
  showMoodsByModelId()
  {
    this.showMoods = false
    this.showMoodsByTag = false
    this.showMoodsByModel = true
    this.showMoodsByArtist = false
    this.showMoodsByFranchise = false
    this.showTag = false
    this.showTags = false
    this.showTagsByCategory = false
    this.showTagCategory = false
    this.showTagCategories = false
    this.showArtist = false
    this.showArtists = false
    this.showArtistsByStyle = false
    this.showStyle = false
    this.showStyles = false
    this.showModel = false
    this.showModels = false
    this.showModelsByFranchise = false
    this.showFranchise = false
    this.showFranchises = false
    this.showFranchisesByMedia = false
    this.showMedia = false
    this.showMedias = false
    this.showLink = false
    this.showLinks = false
    this.showLinksByCategory = false
    this.showLinkCategory = false
    this.showLinkCategories = false
  }
  showMoodsByTagId()
  {
    this.showMoods = false
    this.showMoodsByTag = true
    this.showMoodsByModel = false
    this.showMoodsByArtist = false
    this.showMoodsByFranchise = false
    this.showTag = false
    this.showTags = false
    this.showTagsByCategory = false
    this.showTagCategory = false
    this.showTagCategories = false
    this.showArtist = false
    this.showArtists = false
    this.showArtistsByStyle = false
    this.showStyle = false
    this.showStyles = false
    this.showModel = false
    this.showModels = false
    this.showModelsByFranchise = false
    this.showFranchise = false
    this.showFranchises = false
    this.showFranchisesByMedia = false
    this.showMedia = false
    this.showMedias = false
    this.showLink = false
    this.showLinks = false
    this.showLinksByCategory = false
    this.showLinkCategory = false
    this.showLinkCategories = false
  }
  showMoodsByFranchiseId()
  {
    this.showMoods = false
    this.showMoodsByTag = false
    this.showMoodsByModel = false
    this.showMoodsByArtist = false
    this.showMoodsByFranchise = true
    this.showTag = false
    this.showTags = false
    this.showTagsByCategory = false
    this.showTagCategory = false
    this.showTagCategories = false
    this.showArtist = false
    this.showArtists = false
    this.showArtistsByStyle = false
    this.showStyle = false
    this.showStyles = false
    this.showModel = false
    this.showModels = false
    this.showModelsByFranchise = false
    this.showFranchise = false
    this.showFranchises = false
    this.showFranchisesByMedia = false
    this.showMedia = false
    this.showMedias = false
    this.showLink = false
    this.showLinks = false
    this.showLinksByCategory = false
    this.showLinkCategory = false
    this.showLinkCategories = false
  }
}