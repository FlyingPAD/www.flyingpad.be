export class CustomDate {
    year: number
    month: number

    constructor(year: number, month: number = 0) {
        this.year = year
        this.month = month
    }

    addYears(years: number): CustomDate {
        return new CustomDate(this.year + years, this.month)
    }

    addMonths(months: number): CustomDate {
        const newMonth = this.month + months
        const yearsToAdd = Math.floor(newMonth / 12)
        const month = newMonth % 12
        return new CustomDate(this.year + yearsToAdd, month)
    }

    isBefore(other: CustomDate): boolean {
        return this.year < other.year || (this.year === other.year && this.month < other.month)
    }

    clone(): CustomDate {
        return new CustomDate(this.year, this.month)
    }
}