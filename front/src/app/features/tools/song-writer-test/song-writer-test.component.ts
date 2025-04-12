import { Component } from '@angular/core'
import { Song } from '../../../interfaces/music-tools/song'

@Component({
  selector: 'app-song-writer-test',
  templateUrl: './song-writer-test.component.html',
  styleUrls: ['./song-writer-test.component.scss']
})
export class SongWriterTestComponent {
  mode: 'edition' | 'sectionEdit' | 'preview' = 'edition'
  currentSectionIndex: number | null = null
  song: Song = {
    title: 'Song title',
    createdBy: 'Unknown',
    description: 'Song description',
    bpm: 120,
    timeSignature: '4/4',
    sections: [
      { name: 'Intro', bpm: 120, timeSignature: '4/4', measures: [] },
      { name: 'Verse', bpm: 120, timeSignature: '4/4', measures: [] },
      { name: 'Chorus', bpm: 120, timeSignature: '4/4', measures: [] },
      { name: 'Verse', bpm: 120, timeSignature: '4/4', measures: [] },
      { name: 'Chorus', bpm: 120, timeSignature: '4/4', measures: [] },
      { name: 'Outro', bpm: 120, timeSignature: '4/4', measures: [] }
    ]
  }
  addSection() {
    this.song.sections.push({ name: 'New section', bpm: 120, timeSignature: '4/4', measures: [] })
  }
  deleteSection(index: number) {
    this.song.sections.splice(index, 1)
  }
  editSection(index: number) {
    this.currentSectionIndex = index
    this.mode = 'sectionEdit'
  }
  duplicateSection(index: number) {
    const sectionCopy = JSON.parse(JSON.stringify(this.song.sections[index]))
    this.song.sections.splice(index + 1, 0, sectionCopy)
  }
  moveSectionUp(index: number) {
    if (index === 0) return
    const temp = this.song.sections[index - 1]
    this.song.sections[index - 1] = this.song.sections[index]
    this.song.sections[index] = temp
  }
  moveSectionDown(index: number) {
    if (index === this.song.sections.length - 1) return
    const temp = this.song.sections[index + 1]
    this.song.sections[index + 1] = this.song.sections[index]
    this.song.sections[index] = temp
  }
  get commonBpm() {
    if (!this.song.sections.length) return ''
    const bpm = this.song.sections[0].bpm
    return this.song.sections.every(s => s.bpm === bpm) ? bpm : 'Variable'
  }
  get commonTimeSignature() {
    if (!this.song.sections.length) return ''
    const ts = this.song.sections[0].timeSignature
    return this.song.sections.every(s => s.timeSignature === ts) ? ts : 'Variable'
  }
}