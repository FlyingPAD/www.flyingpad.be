import { CustomDate } from "./timeline-custom-date"

export class TimelineEvent {
    id: number
    name: string
    description : string
    date: CustomDate
    position: number = 0
    isActive: boolean
    displayLevel: number

    constructor(id: number, name: string, description : string, date: CustomDate, displayLevel: number, isActive: boolean = false) {
        this.id = id
        this.name = name
        this.description = description
        this.date = date
        this.displayLevel = displayLevel
        this.isActive = isActive
    }

    toggle(): void {
        this.isActive = !this.isActive
    }
}