import { Component, HostListener, OnDestroy, OnInit } from '@angular/core'

@Component({
  selector: 'app-metronome',
  templateUrl: './metronome.component.html',
  styleUrls: ['./metronome.component.scss']
})
export class MetronomeComponent implements OnInit, OnDestroy {
  bpm: number = 120
  bpmMIN: number = 10
  bpmMAX: number = 300

  volume: number = 0.5
  volumeMIN: number = 0.0
  volumeMAX: number = 1.0

  private audioContext: AudioContext = new AudioContext()
  private tickBuffer!: AudioBuffer
  private nextTickTime: number = 0
  private schedulerTimer: any
  private scheduleAheadTime: number = 0.1
  private lookahead: number = 25

  public isPlaying: boolean = false
  public imgTik: boolean = false


  ngOnInit(): void {
    this.loadTickSound()
  }

  ngOnDestroy(): void {
    this.stop()
    if (this.audioContext) {
      this.audioContext.close()
    }
  }

  private async loadTickSound() {
    try {
      const response = await fetch('assets/audio/metronome-tik.mp3')
      const arrayBuffer = await response.arrayBuffer()
      this.tickBuffer = await this.audioContext.decodeAudioData(arrayBuffer)
    }
    catch (error) {
      console.error('Error loading tick sound', error)
    }
  }

  private scheduler() {
    while (this.nextTickTime < this.audioContext.currentTime + this.scheduleAheadTime) {
      this.scheduleTick(this.nextTickTime)
      this.nextTickTime += 60 / this.bpm
    }
  }

  private scheduleTick(time: number) {
    const tickSource = this.audioContext.createBufferSource()
    tickSource.buffer = this.tickBuffer

    const gainNode = this.audioContext.createGain()
    gainNode.gain.value = this.volume

    tickSource.connect(gainNode).connect(this.audioContext.destination)
    tickSource.start(time)

    const delay = (time - this.audioContext.currentTime) * 1000
    setTimeout(() => {
      this.tik()
    }, delay)
  }

  private tik() {
    this.imgTik = true
    setTimeout(() => {
      this.imgTik = false
    }, 125)
  }

  public start() {
    if (!this.isPlaying && this.tickBuffer) {
      this.isPlaying = true
      this.nextTickTime = this.audioContext.currentTime + 0.05
      this.schedulerTimer = setInterval(() => this.scheduler(), this.lookahead)
    }
  }

  public stop() {
    if (this.isPlaying) {
      this.isPlaying = false
      clearInterval(this.schedulerTimer)
      this.schedulerTimer = null
      this.imgTik = false
    }
  }

  public bpmSet(value: number) {
    this.bpm = value
  }

  public bpmIncrement(value: number) {
    this.bpm = Math.min(this.bpm + value, this.bpmMAX)
  }

  public bpmDecrement(value: number) {
    this.bpm = Math.max(this.bpm - value, this.bpmMIN)
  }

  public reset(): void {
    this.stop()
    this.bpm = 120
    this.volume = 0.5
  }

  private setVolume(value: number): void {
    this.volume += value

    if (this.volume > this.volumeMAX) {
      this.volume = this.volumeMAX
    }
    else if (this.volume < this.volumeMIN) {
      this.volume = this.volumeMIN
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.code) {
      case 'NumpadAdd':
        this.setVolume(0.1)
        break
      case 'NumpadSubtract':
        this.setVolume(-0.1)
        break
      case 'Space':
        !this.isPlaying ? this.start() : this.stop()
        break
      case 'Numpad0':
        this.reset()
        break
      case 'ArrowLeft':
        this.bpmDecrement(0.01)
        break
      case 'ArrowRight':
        this.bpmIncrement(0.01)
        break
    }
  }
}