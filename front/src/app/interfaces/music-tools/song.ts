export interface Song {
    title: string
    createdBy: string
    description: string
    bpm: number
    timeSignature: string
    sections: Section[]
}

export interface Section {
    name: string
    bpm: number
    timeSignature: string
    measures: Measure[]
}

export interface Measure {
    name: string
    chords: Chord[]
}

export interface Chord {
    name: string
    notes: string[]
}