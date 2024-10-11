import { CustomDate } from "./timeline-custom-date"

export class TimelinePeriod {
    id: number
    startDate: CustomDate
    endDate: CustomDate
    name: string
    description : string
    color: string
    startPosition: number = 0
    width: number = 0
    displayLevel: number
    isActive: boolean

    constructor(id: number, startDate: CustomDate, endDate: CustomDate, name: string, description : string, color: string, displayLevel: number, isActive: boolean = false) {
        this.id = id
        this.startDate = startDate
        this.endDate = endDate
        this.name = name
        this.description = description
        this.color = color
        this.displayLevel = displayLevel
        this.isActive = isActive
    }

    toggle(): void {
        this.isActive = !this.isActive
    }
}