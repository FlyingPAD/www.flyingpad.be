import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { AudioService } from '../../../services/audio.service';
import { StorageService } from '../../../services/storage.service';
import { UserService } from '../../../services/http/user.service';
import { Router } from '@angular/router';
import { DashboardService } from '../../../services/dashboard.service';
import { AuthenticationService } from '../../../services/http/authentication.service';
import { GameResult } from '../../../interfaces/music-tools/game-result';
import { NoteTrainer } from '../../../interfaces/music-tools/note-trainer';
import { DashboardViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-trainer-notes',
  templateUrl: './trainer-notes.component.html',
  styleUrl: './trainer-notes.component.scss'
})
export class TrainerNotesComponent implements OnInit, OnDestroy {
  #audioService = inject(AudioService)
  #storageService = inject(StorageService)
  #userService= inject(UserService)
  #routerService = inject(Router)
  #dashboardService = inject(DashboardService)
  #authService = inject(AuthenticationService)

  private intervalId: any | undefined = undefined
  public user = this.#userService.user
  public timer: number = 15
  public run: number = 0
  public gameStart: boolean = false
  public gameEnd: boolean = false
  public clefBass: boolean = false
  public clefTreble: boolean = false
  public clefAlto: boolean = false
  public score: number = 0
  public pic: boolean | undefined = false
  public note: boolean = false
  public randomNote: NoteTrainer = new NoteTrainer()
  public previousRandomNote: NoteTrainer = new NoteTrainer()
  public userNote: NoteTrainer = new NoteTrainer()
  public message: string = 'Get Ready !'
  public notes: NoteTrainer[] = []
  public info: boolean = false
  public scoreboard: boolean = false
  public gameResults: GameResult[] = []
  public playerName: string = ''
  public naming: boolean = false
  public notesREF: NoteTrainer[] = [
      { name: 'C', freq: 261.63, row: 1, alteration: false, extension: true, doubleUp: undefined },
      { name: 'C#', freq: 277.18, row: 1, alteration: true, extension: true, doubleUp: undefined },
      { name: 'D', freq: 293.66, row: 2, alteration: false, extension: false, doubleUp: undefined },
      { name: 'D#', freq: 311.13, row: 2, alteration: true, extension: false, doubleUp: undefined },
      { name: 'E', freq: 329.63, row: 3, alteration: false, extension: false, doubleUp: undefined },
      { name: 'F', freq: 349.23, row: 4, alteration: false, extension: false, doubleUp: undefined },
      { name: 'F#', freq: 369.99, row: 4, alteration: true, extension: false, doubleUp: undefined },
      { name: 'G', freq: 392, row: 5, alteration: false, extension: false, doubleUp: undefined },
      { name: 'G#', freq: 415.3, row: 5, alteration: true, extension: false, doubleUp: undefined },
      { name: 'A', freq: 440, row: 6, alteration: false, extension: false, doubleUp: undefined },
      { name: 'A#', freq: 466.16, row: 6, alteration: true, extension: false, doubleUp: undefined },
      { name: 'B', freq: 493.88, row: 7, alteration: false, extension: false, doubleUp: undefined },
    ]

  ngOnInit(): void {
    this.updateScoreboard()
  }
  ngOnDestroy(): void {
    this.timerStop()
  }

  public toggleInfo() {
    this.info = !this.info
  }
  public toggleScoreBoard() {
    this.scoreboard = !this.scoreboard
  }

  public handleOverlayToggle(): void {
    if (this.info) {
      this.toggleInfo()
    }
    if (this.scoreboard) {
      this.toggleScoreBoard()
    }
  }

  reset() {
    this.timerStop()
    this.timer = 15
    this.run = 0

    this.gameStart = false
    this.gameEnd = false

    this.clefBass = false
    this.clefTreble = false
    this.clefAlto = false

    this.score = 0

    this.pic = false
    this.note = false
    this.randomNote = new NoteTrainer()
    this.previousRandomNote = new NoteTrainer()

    this.userNote = new NoteTrainer()
    this.message = 'Get Ready !'

    this.info = false
    this.naming = false
  }

  start() {
    if (this.clefBass || this.clefAlto || this.clefTreble) {
      this.initializeNotes()
      this.gameStart = true
      this.generateRandomNote()
      this.timerStart()
      this.message = "Let's Go !"
    }
    else
      this.message = 'You must select a clef first !'
  }

  resetStorage() {
    this.#storageService.removeItem('gameResults')
    this.updateScoreboard()
  }

  timerStart(): void {
    this.intervalId = setInterval(() => {
      if (this.timer > 0) {
        this.timer -= 1
        this.run += 1
      }
      else {
        // Game ends
        this.gameEnd = true
        this.message = this.score > 0 ? 'Congratulations !' : '...'
        this.timerStop()
        if(this.#authService.isConnected()) {
          if(this.clefBass) {
            if(this.run > 10) {
              if(this.#userService.user().achievements[1].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(1)
              }
            }
            if(this.run > 20) {
              if(this.#userService.user().achievements[2].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(2)
              }
            }
            if(this.run > 30) {
              if(this.#userService.user().achievements[3].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(3)
              }
            }
            if(this.run > 40) {
              if(this.#userService.user().achievements[4].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(4)
              }
            }
            if(this.run > 50) {
              if(this.#userService.user().achievements[5].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(5)
              }
            }
          }
          if(this.clefAlto) {
            if(this.run > 10) {
              if(this.#userService.user().achievements[6].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(6)
              }
            }
            if(this.run > 20) {
              if(this.#userService.user().achievements[7].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(7)
              }
            }
            if(this.run > 30) {
              if(this.#userService.user().achievements[8].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(8)
              }
            }
            if(this.run > 40) {
              if(this.#userService.user().achievements[9].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(9)
              }
            }
            if(this.run > 50) {
              if(this.#userService.user().achievements[10].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(10)
              }
            }
          }
          if(this.clefTreble) {
            if(this.run > 10) {
              if(this.#userService.user().achievements[11].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(11)
              }
            }
            if(this.run > 20) {
              if(this.#userService.user().achievements[12].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(12)
              }
            }
            if(this.run > 30) {
              if(this.#userService.user().achievements[13].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(13)
              }
            }
            if(this.run > 40) {
              if(this.#userService.user().achievements[14].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(14)
              }
            }
            if(this.run > 50) {
              if(this.#userService.user().achievements[15].unlocked === false) {
                this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
                this.#routerService.navigateByUrl('/')
                this.#userService.obtainAchievement(15)
              }
            }
          }
        }
      }
    }, 1000)
  }

  public timerStop(): void {
    if (this.intervalId !== undefined) {
      clearInterval(this.intervalId)
      this.intervalId = undefined
    }
  }

  public getName() {
    this.naming = true
    this.scoreboard = true
  }

  public saveGame() {
    let result: GameResult =
    {
      playerName: this.playerName,
      score: this.score,
      duration: this.run,
      timestamp: new Date().toISOString(),
      clef: this.clefBass ? 'Bass' : this.clefAlto ? 'Alto' : 'Treble'
    }
    this.saveGameResult(result)
    this.updateScoreboard()
    this.reset()
    this.naming = false
    this.scoreboard = true
  }

  public clefBassTrigger() {
    this.clefBass = true
    this.clefTreble = false
    this.clefAlto = false
  }

  public clefTrebleTrigger() {
    this.clefBass = false
    this.clefTreble = true
    this.clefAlto = false
  }

  public clefAltoTrigger() {
    this.clefBass = false
    this.clefTreble = false
    this.clefAlto = true
  }

  public updateUserNote(note: NoteTrainer) {
    this.userNote = note
    this.checkNote()
    this.generateRandomNote()
  }

  public generateRandomNote() {
    let randomIndex = Math.floor(Math.random() * this.notes.length);
    this.randomNote = this.notes[randomIndex];
    this.previousRandomNote = this.notes[randomIndex]
    this.playNote(this.randomNote.freq);
  }

  public checkNote() {
    if (this.userNote.name === this.randomNote.name) {
      this.timer += 1
      this.message = 'Yeah ! Keep Going !'
      this.score += 5
    }
    if (this.userNote.name !== this.randomNote.name) {
      this.timer -= 2
      this.message = 'Wrong !! It was ' + this.previousRandomNote.name + ' !!'
      this.score -= 6
    }
  }

  public playNote(freq: number) {
    this.#audioService.playFrequencyWithEnvelope(freq, 1, 1)
  }

  public initializeNotes() {
    if (this.clefBass === true) {
      this.notes = [
          { name: 'D', freq: 73.415, row: 0, alteration: false, extension: false, doubleUp: true },
          { name: 'D#', freq: 77.783, row: 0, alteration: true, extension: false, doubleUp: true },
          { name: 'E', freq: 82.408, row: 1, alteration: false, extension: true, doubleUp: undefined },
          { name: 'F', freq: 87.308, row: 2, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F#', freq: 92.5, row: 2, alteration: true, extension: false, doubleUp: undefined },
          { name: 'G', freq: 98, row: 3, alteration: false, extension: false, doubleUp: undefined },
          { name: 'G#', freq: 103.825, row: 3, alteration: true, extension: false, doubleUp: undefined },
          { name: 'A', freq: 110, row: 4, alteration: false, extension: false, doubleUp: undefined },
          { name: 'A#', freq: 116.54, row: 4, alteration: true, extension: false, doubleUp: undefined },
          { name: 'B', freq: 123.47, row: 5, alteration: false, extension: false, doubleUp: undefined },
          { name: 'C', freq: 130.815, row: 6, alteration: false, extension: false, doubleUp: undefined },
          { name: 'C#', freq: 138.59, row: 6, alteration: true, extension: false, doubleUp: undefined },
          { name: 'D', freq: 146.83, row: 7, alteration: false, extension: false, doubleUp: undefined },
          { name: 'D#', freq: 155.565, row: 7, alteration: true, extension: false, doubleUp: undefined },
          { name: 'E', freq: 164.815, row: 8, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F', freq: 174.615, row: 9, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F#', freq: 184.995, row: 9, alteration: true, extension: false, doubleUp: undefined },
          { name: 'G', freq: 196, row: 10, alteration: false, extension: false, doubleUp: undefined },
          { name: 'G#', freq: 207.65, row: 10, alteration: true, extension: false, doubleUp: undefined },
          { name: 'A', freq: 220, row: 11, alteration: false, extension: false, doubleUp: undefined },
          { name: 'A#', freq: 233.08, row: 11, alteration: true, extension: false, doubleUp: undefined },
          { name: 'B', freq: 246.94, row: 12, alteration: false, extension: false, doubleUp: undefined }
        ]
    }
    if (this.clefAlto === true) {
      this.notes = [
          { name: 'C', freq: 130.815, row: 0, alteration: false, extension: false, doubleUp: true },
          { name: 'C#', freq: 138.59, row: 0, alteration: true, extension: false, doubleUp: true },
          { name: 'D', freq: 146.83, row: 1, alteration: false, extension: true, doubleUp: undefined },
          { name: 'D#', freq: 155.565, row: 1, alteration: true, extension: true, doubleUp: undefined },
          { name: 'E', freq: 164.815, row: 2, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F', freq: 174.615, row: 3, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F#', freq: 184.995, row: 3, alteration: true, extension: false, doubleUp: undefined },
          { name: 'G', freq: 196, row: 4, alteration: false, extension: false, doubleUp: undefined },
          { name: 'G#', freq: 207.65, row: 4, alteration: true, extension: false, doubleUp: undefined },
          { name: 'A', freq: 220, row: 5, alteration: false, extension: false, doubleUp: undefined },
          { name: 'A#', freq: 233.08, row: 5, alteration: true, extension: false, doubleUp: undefined },
          { name: 'B', freq: 246.94, row: 6, alteration: false, extension: false, doubleUp: undefined },
          { name: 'C', freq: 261.63, row: 7, alteration: false, extension: false, doubleUp: undefined },
          { name: 'C#', freq: 277.18, row: 7, alteration: true, extension: false, doubleUp: undefined },
          { name: 'D', freq: 293.66, row: 8, alteration: false, extension: false, doubleUp: undefined },
          { name: 'D#', freq: 311.13, row: 8, alteration: true, extension: false, doubleUp: undefined },
          { name: 'E', freq: 329.63, row: 9, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F', freq: 349.23, row: 10, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F#', freq: 369.99, row: 10, alteration: true, extension: false, doubleUp: undefined },
          { name: 'G', freq: 392, row: 11, alteration: false, extension: false, doubleUp: undefined },
          { name: 'G#', freq: 415.3, row: 11, alteration: true, extension: false, doubleUp: undefined },
          { name: 'A', freq: 440, row: 12, alteration: false, extension: false, doubleUp: undefined },
          { name: 'A#', freq: 466.16, row: 12, alteration: true, extension: false, doubleUp: undefined },
          // { name: 'B', freq: 493.88, row: 13, alteration: false, extension: false, doubleUp : undefined },
        ]
    }
    if (this.clefTreble === true) {
      this.notes = [
          // { name: 'A', freq: 220, row: -1, alteration: false, extension: true, doubleUp: false },
          // { name: 'A#', freq: 233.08, row: -1, alteration: true, extension: true, doubleUp: false },
          { name: 'B', freq: 246.94, row: 0, alteration: false, extension: false, doubleUp: true },
          { name: 'C', freq: 261.63, row: 1, alteration: false, extension: true, doubleUp: undefined },
          { name: 'C#', freq: 277.18, row: 1, alteration: true, extension: true, doubleUp: undefined },
          { name: 'D', freq: 293.66, row: 2, alteration: false, extension: false, doubleUp: undefined },
          { name: 'D#', freq: 311.13, row: 2, alteration: true, extension: false, doubleUp: undefined },
          { name: 'E', freq: 329.63, row: 3, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F', freq: 349.23, row: 4, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F#', freq: 369.99, row: 4, alteration: true, extension: false, doubleUp: undefined },
          { name: 'G', freq: 392, row: 5, alteration: false, extension: false, doubleUp: undefined },
          { name: 'G#', freq: 415.3, row: 5, alteration: true, extension: false, doubleUp: undefined },
          { name: 'A', freq: 440, row: 6, alteration: false, extension: false, doubleUp: undefined },
          { name: 'A#', freq: 466.16, row: 6, alteration: true, extension: false, doubleUp: undefined },
          { name: 'B', freq: 493.88, row: 7, alteration: false, extension: false, doubleUp: undefined },
          { name: 'C', freq: 523.26, row: 8, alteration: false, extension: false, doubleUp: undefined },
          { name: 'C#', freq: 554.36, row: 8, alteration: true, extension: false, doubleUp: undefined },
          { name: 'D', freq: 587.32, row: 9, alteration: false, extension: false, doubleUp: undefined },
          { name: 'D#', freq: 622.26, row: 9, alteration: true, extension: false, doubleUp: undefined },
          { name: 'E', freq: 659.26, row: 10, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F', freq: 698.46, row: 11, alteration: false, extension: false, doubleUp: undefined },
          { name: 'F#', freq: 739.98, row: 11, alteration: true, extension: false, doubleUp: undefined },
          { name: 'G', freq: 784, row: 12, alteration: false, extension: false, doubleUp: undefined },
          { name: 'G#', freq: 830.6, row: 12, alteration: true, extension: false, doubleUp: undefined },
          // { name: 'A', freq: 880, row: 13, alteration: false, extension: true, doubleUp : undefined },
          // { name: 'A#', freq: 932.32, row: 13, alteration: true, extension: true, doubleUp : undefined },
          // { name: 'B', freq: 987.76, row: 14, alteration: false, extension: false, doubleUp : true }
        ]
    }
  }

  public saveGameResult(result: GameResult): void {
    let results: GameResult[] = this.#storageService.getItem<GameResult[]>('gameResults') || []
    results.push(result)
    this.#storageService.setItem('gameResults', results)
  }

  public getGameResults(): GameResult[] {
    return this.#storageService.getItem<GameResult[]>('gameResults') || []
  }

  public updateScoreboard(): void {
    let gameResults = this.getGameResults()
    this.gameResults = gameResults.sort((a, b) => b.score - a.score)
  }
}