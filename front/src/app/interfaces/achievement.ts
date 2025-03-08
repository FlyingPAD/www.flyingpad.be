export interface Achievement {
    id: number
    title: string
    goal: string
    done: string
    category: string
    date: Date | undefined
    unlocked: boolean
    xpValue: number
}