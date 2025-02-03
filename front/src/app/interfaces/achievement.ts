export interface Achievement {
    id: number
    name: string
    description: string
    category: string
    obtained: Date | undefined
    isTrue: boolean
}