import { Component, HostListener, inject, OnDestroy } from '@angular/core';
import { environment } from '../../../environments/environment';
import { MultiTagService } from '../../services/multi-tag.service';
import { NotificationService } from '../../services/notification.service';
import { MoodScoreUpdate } from '../../interfaces/forms-update';
import { Subject, takeUntil } from 'rxjs';
import { MoodService } from '../../services/http/mood.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-multi-tag',
  templateUrl: './multi-tag.component.html',
  styleUrl: './multi-tag.component.scss'
})
export class MultiTagComponent implements OnDestroy {
  #multiTagService = inject(MultiTagService)
  #notificationService = inject(NotificationService)
  #moodService = inject(MoodService)
  #router = inject(Router)

  #destroy$ = new Subject<void>()

  public moodsFlow = this.#moodService.moodsFlow
  public selectedMoods = this.#multiTagService.selectedMoods

  public itemsPerPage: number = 36
  public currentPage: number = 1
  public environment = environment.apiBaseUrl


  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public selectionToggle(moodId: number): void {
    this.#multiTagService.selectionToggle(moodId)
  }

  public checkIfSelected(moodId: number): boolean {
    return this.#multiTagService.checkIfSelected(moodId)
  }

  public selectAll(): void {
    const allIds = this.moodsFlow()?.moods.map(mood => mood.businessId)
    if (allIds) this.#multiTagService.selectAll(allIds)
  }

  public invertSelection(): void {
    const allIds = this.moodsFlow()?.moods.map(mood => mood.businessId)
    if (allIds) this.#multiTagService.invertSelection(allIds)
  }

  public resetSelection(): void {
    this.#multiTagService.resetSelection()
  }

  public multiScore(score: number): void {
    const currentSelection = this.selectedMoods()

    if (currentSelection.length === 0) this.#notificationService.warning('No Moods Selected')
    else {
      currentSelection.forEach(moodId => {
        let form: MoodScoreUpdate = { moodId: moodId, value: score }

        this.#moodService.updateMoodScore(form)
          .pipe(takeUntil(this.#destroy$))
          .subscribe()
      })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Backspace':
        this.#router.navigateByUrl('/central-gallery')
        break
    }
  }
}