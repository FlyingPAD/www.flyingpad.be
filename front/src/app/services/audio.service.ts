import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AudioService {
  #gainNode: GainNode
  public audioContext: AudioContext

  constructor() {
    this.audioContext = new (window.AudioContext || (window as any).webkitAudioContext)()
    this.#gainNode = this.audioContext.createGain()
    this.#gainNode.connect(this.audioContext.destination)
  }

  playFrequencyWithEnvelope(frequency: number, durationInSeconds: number, volume: number) {
    const oscillator = this.audioContext.createOscillator()
    oscillator.type = 'sine'
    oscillator.frequency.setValueAtTime(frequency, this.audioContext.currentTime)

    const gainNode = this.audioContext.createGain()
    oscillator.connect(gainNode)
    gainNode.connect(this.#gainNode)

    const now = this.audioContext.currentTime
    const attackTime = 0.1
    const releaseTime = 0.1

    gainNode.gain.setValueAtTime(0, now)
    gainNode.gain.linearRampToValueAtTime(volume, now + attackTime)
    gainNode.gain.linearRampToValueAtTime(0, now + durationInSeconds - releaseTime)

    oscillator.start()
    oscillator.stop(this.audioContext.currentTime + durationInSeconds)
  }
}