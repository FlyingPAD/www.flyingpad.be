import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

export interface Note {
  name: string
  frequency: number
}

@Component({
  selector: 'app-guitar-tuner',
  templateUrl: './guitar-tuner.component.html',
  styleUrl: './guitar-tuner.component.scss'
})
export class GuitarTunerComponent implements OnInit, OnDestroy {
  #toastr = inject(ToastrService)
  private audioContext: AudioContext
  private analyser: AnalyserNode
  private dataArray: Float32Array
  private bufferLength: number
  private streamSource: MediaStreamAudioSourceNode | null = null
  currentFrequency: number = 0
  frequencyDifference: number = 0
  targetNote: Note | null = null
  audioBuffers: { [note: string]: AudioBuffer } = {}

  constructor() {
    this.audioContext = new AudioContext()
    this.analyser = this.audioContext.createAnalyser()
    this.analyser.fftSize = 2048
    this.bufferLength = this.analyser.fftSize
    this.dataArray = new Float32Array(this.bufferLength)

    this.loadAudioFiles()
  }

  standardTuning: Note[] = [
    { name: 'E2', frequency: 82.41 },
    { name: 'A2', frequency: 110.00 },
    { name: 'D3', frequency: 146.83 },
    { name: 'G3', frequency: 196.00 },
    { name: 'B3', frequency: 246.94 },
    { name: 'E4', frequency: 329.63 }
  ]

  dadaddTuning: Note[] = [
    { name: 'D2', frequency: 73.42 },
    { name: 'A2', frequency: 110.00 },
    { name: 'D3', frequency: 146.83 },
    { name: 'A3', frequency: 220.00 },
    { name: 'D4', frequency: 293.66 },
    { name: 'D4', frequency: 293.66 }
  ]

  dadadaTuning: Note[] = [
    { name: 'D2', frequency: 73.42 },
    { name: 'A2', frequency: 110.00 },
    { name: 'D3', frequency: 146.83 },
    { name: 'A3', frequency: 220.00 },
    { name: 'D4', frequency: 293.66 },
    { name: 'A4', frequency: 440.00 }
  ]

  dropCTuning: Note[] = [
    { name: 'C2', frequency: 65.41 },
    { name: 'G2', frequency: 97.99 },
    { name: 'C3', frequency: 130.81 },
    { name: 'F3', frequency: 174.61 },
    { name: 'A3', frequency: 220.00 },
    { name: 'D4', frequency: 293.66 }
  ]

  dropDTuning: Note[] = [
    { name: 'D2', frequency: 73.42 },
    { name: 'A2', frequency: 110.00 },
    { name: 'D3', frequency: 146.83 },
    { name: 'G3', frequency: 196.00 },
    { name: 'B3', frequency: 246.94 },
    { name: 'E4', frequency: 329.63 }
  ]

  dadadfsharpTuning: Note[] = [
    { name: 'D2', frequency: 73.42 },
    { name: 'A2', frequency: 110.00 },
    { name: 'D3', frequency: 146.83 },
    { name: 'A3', frequency: 220.00 },
    { name: 'D4', frequency: 293.66 },
    { name: 'F#4', frequency: 369.99 }
  ]

  currentTuning: Note[] = this.standardTuning

  ngOnInit(): void {
    this.startTuning()
  }

  ngOnDestroy(): void {
    if (this.streamSource) {
      this.streamSource.disconnect()
    }
    if (this.audioContext) {
      this.audioContext.close()
    }
    if (this.streamSource && this.streamSource.mediaStream) {
      const tracks = this.streamSource.mediaStream.getTracks()
      tracks.forEach(track => track.stop())
    }
  }

  async loadAudioFiles() {
    const noteFilenames = {
      'E4': 'E4.mp3',
      'B3': 'B3.mp3',
      'G3': 'G3.mp3',
      'D3': 'D3.mp3',
      'A2': 'A2.mp3',
      'E2': 'E2.mp3',
      'D2': 'D2.mp3',
      'A3': 'A3.mp3',
      'D4': 'D4.mp3',
      'A4': 'A4.mp3',
      'C2': 'C2.mp3',
      'G2': 'G2.mp3',
      'C3': 'C3.mp3',
      'F3': 'F3.mp3',
      'F#4': 'Fs4.mp3'
    }

    for (const [note, filename] of Object.entries(noteFilenames)) {
      const response = await fetch(`assets/guitar-tuner/sounds/${filename}`)
      const arrayBuffer = await response.arrayBuffer()
      this.audioBuffers[note] = await this.audioContext.decodeAudioData(arrayBuffer)
    }
  }

  async startTuning(): Promise<void> {
    try {
      const stream = await navigator.mediaDevices.getUserMedia({ audio: true })
      this.streamSource = this.audioContext.createMediaStreamSource(stream)
      this.streamSource.connect(this.analyser)
      this.updatePitch()
    }
    catch (error) {
      this.#toastr.error(`Failed to access microphone : ${error}`)
    }
  }

  updatePitch(): void {
    requestAnimationFrame(() => this.updatePitch())
    this.analyser.getFloatTimeDomainData(this.dataArray)
    this.currentFrequency = this.yin(this.dataArray, this.audioContext.sampleRate)
    if (this.currentFrequency !== -1) {
      this.targetNote = this.getClosestStandardTuning(this.currentFrequency)
      this.frequencyDifference = this.currentFrequency - this.targetNote.frequency
    }
  }

  yin(buffer: Float32Array, sampleRate: number): number {
    const threshold = 0.1
    const tau_max = buffer.length / 2
    const yinBuffer = new Float32Array(tau_max)
    let tau, j
    let runningSum = 0

    yinBuffer[0] = 1

    for (tau = 1; tau < tau_max; tau++) {
      yinBuffer[tau] = 0
      for (j = 0; j < tau_max; j++) {
        yinBuffer[tau] += Math.pow(buffer[j] - buffer[j + tau], 2)
      }
      runningSum += yinBuffer[tau]
      yinBuffer[tau] *= tau / runningSum
    }

    let minTau = -1

    for (tau = 1; tau < tau_max; tau++) {
      if (yinBuffer[tau] < threshold) {
        while (tau + 1 < tau_max && yinBuffer[tau + 1] < yinBuffer[tau]) {
          tau++
        }
        minTau = tau
        break
      }
    }

    if (minTau === -1) {
      return -1
    }

    let betterTau

    const x1 = yinBuffer[minTau - 1]
    const x2 = yinBuffer[minTau]
    const x3 = yinBuffer[minTau + 1]

    if (x1 < x3) {
      betterTau = minTau - 1 + (x1 - x2) / (x1 - 2 * x2 + x3)
    }
    else {
      betterTau = minTau + (x3 - x2) / (x1 - 2 * x2 + x3)
    }

    return sampleRate / betterTau
  }

  getClosestStandardTuning(frequency: number): Note {
    let closestNote: Note | null = null
    let minDifference = Infinity
    for (const note of this.currentTuning) {
      const difference = Math.abs(frequency - note.frequency)
      if (difference < minDifference) {
        minDifference = difference
        closestNote = note
      }
    }
    return closestNote!
  }

  playNote(noteName: string): void {
    if (noteName && this.audioBuffers[noteName]) {
      const source = this.audioContext.createBufferSource()
      source.buffer = this.audioBuffers[noteName]
      source.connect(this.audioContext.destination)
      source.start()
    }
  }

  onTuningChange(event: Event): void {
    const selectElement = event.target as HTMLSelectElement
    const tuning = selectElement.value
    if (tuning === 'standard') {
      this.currentTuning = this.standardTuning
    }
    else if (tuning === 'DADADD') {
      this.currentTuning = this.dadaddTuning
    }
    else if (tuning === 'DADADA') {
      this.currentTuning = this.dadadaTuning
    }
    else if (tuning === 'dropC') {
      this.currentTuning = this.dropCTuning
    }
    else if (tuning === 'dropD') {
      this.currentTuning = this.dropDTuning
    }
    else if (tuning === 'DADADF#') {
      this.currentTuning = this.dadadfsharpTuning
    }
    this.updatePitch()
  }
}