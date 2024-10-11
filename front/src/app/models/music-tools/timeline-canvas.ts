import { TimelineEvent } from "./timeline-event"
import { Graduation } from "./timeline-graduation"
import { TimelinePeriod } from "./timeline-period"
import { CustomDate } from "./timeline-custom-date"

export class TimelineCanvas {
    id: number
    name: string
    startDate: CustomDate
    endDate: CustomDate
    currentYear: number
    selectedYear: number
    timelineWidth: number
    pixelsPerYear: number
    margin: number
    zoomLevels: number[]
    currentZoomLevel: number
    graduations: Graduation[]
    events: TimelineEvent[]
    periods: TimelinePeriod[]
    private ctx: CanvasRenderingContext2D
    private canvas: HTMLCanvasElement

    constructor(
        ctx: CanvasRenderingContext2D,
        canvas: HTMLCanvasElement,
        id: number = 1,
        name: string = 'Timeline',
        startDate: CustomDate = new CustomDate(-40500, 0),
        endDate: CustomDate = new CustomDate(new Date().getFullYear() + 500, new Date().getMonth()),
        events: TimelineEvent[] = [],
        periods: TimelinePeriod[] = [],
    ) {
        this.ctx = ctx
        this.canvas = canvas
        this.id = id
        this.name = name
        this.startDate = startDate
        this.endDate = endDate
        this.currentYear = new Date().getFullYear()
        this.selectedYear = new Date().getFullYear()
        this.pixelsPerYear = 100
        this.margin = 50
        this.zoomLevels = [1 / 12, 1, 10, 50, 100, 500]
        this.currentZoomLevel = 5
        this.timelineWidth = this.calculateTimelineWidth()
        this.graduations = []
        this.events = events
        this.periods = periods
    }

    drawTimeline(): void {
        const { ctx, canvas } = this
        ctx.clearRect(0, 0, canvas.width, canvas.height)
    
        ctx.setTransform(1, 0, 0, 1, 0, 0)
        
        this.drawBaseLine()
        this.drawGraduations()
        this.drawEvents()
        this.drawPeriods()
    }

    drawBaseLine(): void {
        const { ctx } = this
        ctx.beginPath()
        ctx.moveTo(0, 150)
        ctx.lineTo(this.timelineWidth, 150)
        ctx.strokeStyle = 'black'
        ctx.lineWidth = 5
        ctx.stroke()
    }

    drawGraduations(): void {
        const { ctx } = this
        const graduations = this.generateGraduations(this.zoomLevels[this.currentZoomLevel])
        
        graduations.forEach(graduation => {
            ctx.beginPath()
            ctx.moveTo(graduation.position, 130)
            ctx.lineTo(graduation.position, 170)
            ctx.stroke()
            ctx.fillStyle = 'black'
            ctx.textAlign = 'center'
            ctx.font = '17px Arial'
            ctx.fillText(String(graduation.label), graduation.position, 190)
        })
    }

    drawEvents(): void {
        const { ctx } = this
        const events = this.generateEventPositions(this.zoomLevels[this.currentZoomLevel])

        events.forEach(event => {
            if (event.isActive) {
                const eventY = 150 - event.displayLevel * 30
                ctx.beginPath()
                ctx.moveTo(event.position, eventY)
                ctx.lineTo(event.position - 6.5, eventY + 13)
                ctx.lineTo(event.position + 6.5, eventY + 13)
                ctx.closePath()
                ctx.fillStyle = 'white'
                ctx.fill()
                ctx.stroke()
                ctx.fillStyle = 'black'
                ctx.textAlign = 'center'
                ctx.fillText(event.name, event.position, eventY - 15)
            }
        })
    }

    drawPeriods(): void {
        const { ctx } = this
        const periods = this.generatePeriodPositions(this.zoomLevels[this.currentZoomLevel])

        periods.forEach(period => {
            ctx.fillStyle = period.color
            ctx.fillRect(period.startPosition, 200, period.width, 20)
            ctx.strokeRect(period.startPosition, 200, period.width, 20)

            if (period.isActive) {
                ctx.fillStyle = 'black'
                ctx.textAlign = 'center'
                ctx.fillText(period.name, period.startPosition + period.width / 2, 235)
            }
        })
    }

    calculateTimelineWidth(): number {
        const totalYears = this.endDate.year - this.startDate.year + (this.endDate.month - this.startDate.month) / 12
        const totalIntervals = totalYears / this.zoomLevels[this.currentZoomLevel]
        return (totalIntervals * this.pixelsPerYear) + this.margin
    }

    zoomIn(): void {
        if (this.currentZoomLevel > 0) {
            this.currentZoomLevel--
            this.updateZoom()
        }
    }

    zoomOut(): void {
        if (this.currentZoomLevel < this.zoomLevels.length - 1) {
            this.currentZoomLevel++
            this.updateZoom()
        }
    }

    updateZoom(): void {
        this.timelineWidth = this.calculateTimelineWidth()
        this.drawTimeline()
    }

    generateGraduations(scale: number): Graduation[] {
        this.graduations = []
        let currentDate = this.startDate.clone()
        let position = this.margin

        while (currentDate.isBefore(this.endDate)) {
            let label = currentDate.year
            const year = currentDate.year
            let month: number | undefined = undefined

            if (scale === 1 / 12) {
                month = currentDate.month
                label = month + 1
                currentDate = currentDate.addMonths(1)
            } else {
                currentDate = currentDate.addYears(scale)
            }

            this.graduations.push({ position, label, year, month })
            position += this.pixelsPerYear
        }
        return this.graduations
    }

    generateEventPositions(scale: number): TimelineEvent[] {
        this.events.forEach(event => {
            const yearsFromStart = event.date.year - this.startDate.year + (event.date.month - this.startDate.month) / 12
            const position = this.margin + (yearsFromStart / scale) * this.pixelsPerYear
            event.position = position
        })
        return this.events
    }

    generatePeriodPositions(scale: number): TimelinePeriod[] {
        this.periods.forEach(period => {
            const startYears = period.startDate.year - this.startDate.year + (period.startDate.month - this.startDate.month) / 12
            const endYears = period.endDate.year - this.startDate.year + (period.endDate.month - this.startDate.month) / 12

            period.startPosition = this.margin + (startYears / scale) * this.pixelsPerYear
            const endPosition = this.margin + (endYears / scale) * this.pixelsPerYear
            period.width = endPosition - period.startPosition
        })
        return this.periods
    }

    getPositionForDate(date: CustomDate): number {
        const scale = this.zoomLevels[this.currentZoomLevel]
        const yearsFromStart = date.year - this.startDate.year + (date.month - this.startDate.month) / 12
        return this.margin + (yearsFromStart / scale) * this.pixelsPerYear
    }

    handleCanvasClick(x: number, y: number): void {
        this.events.forEach(event => {
            const eventY = 150 - event.displayLevel * 30
            if (Math.abs(x - event.position) < 10 && Math.abs(y - eventY) < 10) {
                event.isActive = !event.isActive
            }
        })

        this.periods.forEach(period => {
            const periodY = 200
            if (x >= period.startPosition && x <= period.startPosition + period.width && y >= periodY && y <= periodY + 20) {
                period.isActive = !period.isActive
            }
        })
    }
}