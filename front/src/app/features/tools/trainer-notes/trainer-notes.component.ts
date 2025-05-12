import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { AudioService } from '../../../services/audio.service';
import { StorageService } from '../../../services/storage.service';
import { UserService } from '../../../services/http/user.service';
import { Router } from '@angular/router';
import { DashboardService } from '../../../services/user-interface/dashboard.service';
import { AuthenticationService } from '../../../services/http/authentication.service';
import { GameResult } from '../../../interfaces/music-tools/game-result';
import { NoteTrainer } from '../../../interfaces/music-tools/note-trainer';
import { DashboardViewMode } from '../../../enumerations/view-modes';
import { getNotesForClef, notesREF } from '../../../data/trainer-notes-data';
import { Subject } from 'rxjs';
import { NewAchievement } from '../../../interfaces/achievement';
import { AchievementCode } from '../../../types/AchievementCode';

@Component({
  selector: 'app-trainer-notes',
  templateUrl: './trainer-notes.component.html',
  styleUrls: ['./trainer-notes.component.scss']
})
export class TrainerNotesComponent implements OnInit, OnDestroy {
  #audioService    = inject(AudioService);
  #storageService  = inject(StorageService);
  #userService     = inject(UserService);
  #routerService   = inject(Router);
  #dashboardService= inject(DashboardService);
  #authService     = inject(AuthenticationService);

  #destroy$ = new Subject<void>();
  private intervalId?: number;

  public user = this.#userService.user;
  public achievements = this.#userService.achievements;

  // ⏺ jeu
  public timer = 15;
  public run = 0;
  public score = 0;
  public gameStart = false;
  public gameEnd = false;
  public clefBass = false;
  public clefAlto = false;
  public clefTreble = false;

  // ⏺ affichage
  public message = 'Get Ready !';
  public info = false;
  public scoreboard = false;
  public naming = false;
  public playerName = '';
  public gameResults: GameResult[] = [];
  /** titres des achievements débloqués */
  public unlockedAchievements: string[] = [];

  // ⏺ notes
  public notesREF = notesREF;
  public notes: NoteTrainer[] = [];
  public randomNote = new NoteTrainer();
  public previousRandomNote = new NoteTrainer();
  public userNote = new NoteTrainer();

  // ⏺ paliers de déblocage
  private thresholds: number[] = [10, 20, 30, 40, 50];

  ngOnInit(): void {
    this.updateScoreboard();
    const biz = this.user().businessId;
    if (this.#authService.isConnected()) {
      this.#userService.getUserAchievements(biz).subscribe();
    }
  }

  ngOnDestroy(): void {
    this.timerStop();
    this.#destroy$.next();
    this.#destroy$.complete();
  }

  public clefBassTrigger()  { this.clefBass  = true; this.clefAlto = this.clefTreble = false; }
  public clefAltoTrigger()  { this.clefAlto  = true; this.clefBass = this.clefTreble = false; }
  public clefTrebleTrigger(){ this.clefTreble = true; this.clefBass = this.clefAlto   = false; }

  public start(): void {
    if (!this.clefBass && !this.clefAlto && !this.clefTreble) {
      this.message = 'You must select a clef first !';
      return;
    }
    this.reset();
    this.gameStart = true;
    this.initializeNotes();
    this.generateRandomNote();
    this.timerStart();
    this.message = "Let's Go !";
  }

  public reset(): void {
    this.timer = 15; this.run = 0; this.score = 0;
    this.gameStart = false; this.gameEnd = false;
    this.randomNote = new NoteTrainer();
    this.previousRandomNote = new NoteTrainer();
    this.userNote = new NoteTrainer();
    this.message = 'Get Ready !';
    this.info = false; this.naming = false;
    this.unlockedAchievements = [];
  }

  public resetStorage(): void {
    this.#storageService.removeItem('gameResults');
    this.updateScoreboard();
  }

  private timerStart(): void {
    this.intervalId = window.setInterval(() => {
      if (this.timer > 0) {
        this.timer--; this.run++;
      } else {
        this.onGameEnd();
      }
    }, 1000);
  }

  private timerStop(): void {
    if (this.intervalId != null) {
      clearInterval(this.intervalId);
      this.intervalId = undefined;
    }
  }

  private onGameEnd(): void {
    this.gameEnd = true;
    this.timerStop();
    this.message = this.score > 0 ? 'Congratulations !' : '…';

    if (!this.#authService.isConnected()) return;

    const biz = this.user().businessId;
    const clef = this.clefBass ? 'bass'
               : this.clefAlto ? 'alto'
               : this.clefTreble ? 'treble'
               : null;
    if (!clef) return;

    // 1) ne conserver que les seuils atteints
    const achievedThresholds = this.thresholds.filter(th => this.run >= th);

    // 2) repérer les achievements à débloquer
    const toUnlock: AchievementCode[] = achievedThresholds
      .map(th => this.achievements().find(a =>
        !a.unlockedAt &&
        a.category === 'note-master' &&
        a.title.toLowerCase().includes(clef) &&
        a.goal.includes(`${th} seconds`)
      ))
      .filter((a): a is NewAchievement => !!a)
      .map(a => a.code); // Utilisation du code des achievements

    // ** Appel batch unique ** 
    if (toUnlock.length > 0) {
      this.#userService.unlockAchievements(biz, toUnlock)
        .subscribe({
          next: () => this.afterUnlock(toUnlock),
          error: err => console.error('Erreur unlock achievements', err)
        });
    } else {
      this.afterUnlock([]);
    }
  }

  /** Factorisation de la mise à jour du score de saison et du message */
  private afterUnlock(unlockedCodes: AchievementCode[]): void {
    const unlockedTitles = unlockedCodes.map(code => code.replace(/([A-Z])/g, ' $1').trim()); // Transforme les codes en titres lisibles
    this.#userService.gainSeasonScore(this.user().businessId, this.score)
      .subscribe({
        next: () => {
          this.unlockedAchievements = unlockedTitles;
          if (unlockedTitles.length) {
            this.message = `Vous avez débloqué ${unlockedTitles.length} succès !`;
          }
        },
        error: err => console.error('Échec mise à jour score de saison', err)
      });
  }

  public updateUserNote(note: NoteTrainer): void {
    this.userNote = note;
    this.checkNote();
    this.generateRandomNote();
  }

  public generateRandomNote(): void {
    const idx = Math.floor(Math.random() * this.notes.length);
    this.previousRandomNote = this.randomNote;
    this.randomNote = this.notes[idx];
    this.playNote(this.randomNote.freq);
  }

  public checkNote(): void {
    if (this.userNote.name === this.randomNote.name) {
      this.timer++; this.score += 5; this.message = 'Yeah ! Keep Going !';
    } else {
      this.timer = Math.max(0, this.timer - 2);
      this.score -= 6;
      this.message = `Wrong !! It was ${this.previousRandomNote.name} !!`;
    }
  }

  public playNote(freq: number): void {
    this.#audioService.playFrequencyWithEnvelope(freq, 1, 1);
  }

  public initializeNotes(): void {
    const clef = this.clefBass ? 'bass'
               : this.clefAlto ? 'alto'
               : this.clefTreble ? 'treble'
               : null;
    if (clef) this.notes = getNotesForClef(clef);
  }

  public updateScoreboard(): void {
    const results = this.#storageService.getItem<GameResult[]>('gameResults') || [];
    this.gameResults = results.sort((a, b) => b.score - a.score);
  }

  public getName(): void {
    this.naming = true; this.scoreboard = true;
  }

  public saveGame(): void {
    const result: GameResult = {
      playerName: this.playerName,
      score: this.score,
      duration: this.run,
      timestamp: new Date().toISOString(),
      clef: this.clefBass ? 'Bass' : this.clefAlto ? 'Alto' : 'Treble'
    };
    this.#storageService.setItem('gameResults', [...this.getGameResults(), result]);
    this.updateScoreboard();
    this.reset();
    this.naming = false; this.scoreboard = true;
  }

  private getGameResults(): GameResult[] {
    return this.#storageService.getItem<GameResult[]>('gameResults') || [];
  }

  public goToAchievements(): void {
    this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements);
    this.#routerService.navigateByUrl('/');
  }

  public toggleInfo(): void { this.info = !this.info; }
  public toggleScoreBoard(): void { this.scoreboard = !this.scoreboard; }
}
