import { MoodFull, MoodLight } from "./mood";

export interface State {
    currentMood: MoodFull
    currentMoodsByTag : MoodLight[]
    currentMoodsByTagCategory : MoodLight[]
    currentMoodsByModel : MoodLight[]
    currentMoodsByFranchise : MoodLight[]
}