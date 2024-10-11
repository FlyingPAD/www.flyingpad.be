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

  resetTopBar() {
    this.showMoods = false
    this.showMoodsByTag = false
    this.showMoodsByModel = false
    this.showMoodsByArtist = false
    this.showMoodsByFranchise = false
    this.showTags = false
    this.showTagsByCategory = false
    this.showTagCategories = false
    this.showArtists = false
    this.showArtistsByStyle = false
    this.showStyles = false
    this.showModels = false
    this.showModelsByFranchise = false
    this.showFranchises = false
    this.showFranchisesByMedia = false
    this.showMedias = false
    this.showLinks = false
    this.showLinksByCategory = false
    this.showLinkCategories = false
  }

  resetBottomBar() {
    this.showMood = true
    this.showTag = false
    this.showTagCategory = false
    this.showArtist = false
    this.showStyle = false
    this.showModel = false
    this.showFranchise = false
    this.showMedia = false
    this.showLink = false
    this.showLinkCategory = false
  }

  // Toggle methods
  toggleMood(): void { this.showMood = !this.showMood }
  toggleMoods(): void { this.showMoods = !this.showMoods }
  toggleMoodsByTag(): void { this.showMoodsByTag = !this.showMoodsByTag }
  toggleMoodsByModel(): void { this.showMoodsByModel = !this.showMoodsByModel }
  toggleMoodsByArtist(): void { this.showMoodsByArtist = !this.showMoodsByArtist }
  toggleMoodsByFranchise(): void { this.showMoodsByFranchise = !this.showMoodsByFranchise }
  toggleTag(): void { this.showTag = !this.showTag }
  toggleTags(): void { this.showTags = !this.showTags }
  toggleTagsByCategory(): void { this.showTagsByCategory = !this.showTagsByCategory }
  toggleTagCategory(): void { this.showTagCategory = !this.showTagCategory }
  toggleTagCategories(): void { this.showTagCategories = !this.showTagCategories }
  toggleArtist(): void { this.showArtist = !this.showArtist }
  toggleArtists(): void { this.showArtists = !this.showArtists }
  toggleArtistsByStyle(): void { this.showArtistsByStyle = !this.showArtistsByStyle }
  toggleStyle(): void { this.showStyle = !this.showStyle }
  toggleStyles(): void { this.showStyles = !this.showStyles }
  toggleModel(): void { this.showModel = !this.showModel }
  toggleModels(): void { this.showModels = !this.showModels }
  toggleModelsByFranchise(): void { this.showModelsByFranchise = !this.showModelsByFranchise }
  toggleFranchise(): void { this.showFranchise = !this.showFranchise }
  toggleFranchises(): void { this.showFranchises = !this.showFranchises }
  toggleFranchisesByMedia(): void { this.showFranchisesByMedia = !this.showFranchisesByMedia }
  toggleMedia(): void { this.showMedia = !this.showMedia }
  toggleMedias(): void { this.showMedias = !this.showMedias }
  toggleLink(): void { this.showLink = !this.showLink }
  toggleLinks(): void { this.showLinks = !this.showLinks }
  toggleLinksByCategory(): void { this.showLinksByCategory = !this.showLinksByCategory }
  toggleLinkCategory(): void { this.showLinkCategory = !this.showLinkCategory }
  toggleLinkCategories(): void { this.showLinkCategories = !this.showLinkCategories }

  updateMoodId(moodId: number): void {
    this.flowService.updateMoodId(moodId);this.showMood = true
  }
  updateTagId(tagId: number): void {
    this.flowService.updateTagId(tagId); this.showTag = true
  }
  updateTagCategoryId(tagCategoryId: number): void {
    this.flowService.updateTagCategoryId(tagCategoryId); this.showTagCategory = true
  }
  updateModelId(modelId: number): void {
    this.flowService.updateModelId(modelId); this.showModel = true
  }
  updateArtistId(artistId: number): void {
    this.flowService.updateArtistId(artistId); this.showArtist = true
  }  
  updateStyleId(styleId: number): void {
    this.flowService.updateStyleId(styleId); this.showStyle = true
  }
  updateFranchiseId(franchiseId: number): void {
    this.flowService.updateFranchiseId(franchiseId); this.showFranchise = true
  }
  updateMediaId(mediaId: number): void {
    this.flowService.updateMediumId(mediaId); this.showMedia = true
  }
  updateLinkCategoryId(linkCategoryId: number): void {
    this.flowService.updateLinkCategoryId(linkCategoryId); this.showLinkCategory = true
  }
  updateLinkId(linkId: number): void {
    this.flowService.updateLinkId(linkId); this.showLink = true
  }

  goBack(): void {
    this.#router.navigateByUrl('/dashboard')
  }

  goToURL(): void {
    const url = this.flow()?.link?.url
    if (url) 
    {
      window.open(url, '_blank')
    } 
  }

  showMoodsByArtistId(): void {
    this.resetTopBar()
    this.showMoodsByArtist = true
  }
  showMoodsByModelId(): void {
    this.resetTopBar()
    this.showMoodsByModel = true
  }
  showMoodsByTagId(): void {
    this.resetTopBar()
    this.showMoodsByTag = true
  }
  showMoodsByFranchiseId(): void {
    this.resetTopBar()
    this.showMoodsByFranchise = true
  }
}