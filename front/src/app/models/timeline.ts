import { TimelineEvent } from "./timeline-event"
import { Graduation } from "../interfaces/timeline-graduation"
import { TimelinePeriod } from "./timeline-period"
import { CustomDate } from "./timeline-custom-date"

export class Timeline {
    id: number = 1
    name: string = 'Timeline'
    startDate: CustomDate = new CustomDate(-40500, 0) // Date de départ
    endDate: CustomDate = new CustomDate(new Date().getFullYear() + 500, new Date().getMonth()) // Aujourd'hui + 100 ans
    currentYear: number = new Date().getFullYear()
    selectedyear: number = new Date().getFullYear()
    timelineWidth: number = 0
    pixelsPerYear: number = 100
    margin: number = 50
    zoomLevels: number[] = [1 / 12, 1, 10, 50, 100, 500] // Ajout de 500
    currentZoomLevel: number = 5
    graduations: Graduation[] = []
    events: TimelineEvent[] = [
        new TimelineEvent(1, 'Today', 'Current date.', new CustomDate(new Date().getFullYear(), new Date().getMonth()), 1, false),
        new TimelineEvent(2, 'First Hymns in Mesopotamia', 'Early hymns and ritual music are performed in Mesopotamia.', new CustomDate(-1000, 0), 2, false),
        new TimelineEvent(3, 'Ancient Greek Music Develops', 'Development of Greek musical theory, including the Pythagorean scale.', new CustomDate(-600, 0), 3, false),
        new TimelineEvent(4, 'Founding of Rome', 'According to legend, Rome was founded in 753 BC.', new CustomDate(-753, 3), 1, false),
        new TimelineEvent(5, 'Theory of Harmonics', 'Pythagoras develops the theory of harmonics, linking math and music.', new CustomDate(-500, 0), 2, false),
        new TimelineEvent(6, 'Aristoxenus and Greek Modal Theory', 'Aristoxenus of Italy formalizes Greek modal theory.', new CustomDate(-400, 0), 1, false),
        new TimelineEvent(7, 'Gregorian Chant', 'Pope Gregory I develops the Gregorian Chant, a standardized form of liturgical music.', new CustomDate(600, 0), 1, false),
        new TimelineEvent(8, 'First Polyphonic Music', 'Monasteries in Europe experiment with early forms of polyphony.', new CustomDate(850, 0), 2, false),
        new TimelineEvent(9, 'School of Notre-Dame', 'Léonin and Pérotin establish polyphony at Notre-Dame in Paris.', new CustomDate(1150, 0), 3, false),
        new TimelineEvent(10, 'Ars Nova', 'Philippe de Vitry\'s treatise *Ars Nova* introduces rhythmic innovations.', new CustomDate(1320, 0), 1, false),
        new TimelineEvent(11, 'Printing of Polyphonic Music', 'Ottaviano Petrucci publishes the first printed collection of polyphonic music.', new CustomDate(1501, 0), 2, false),
        new TimelineEvent(12, 'L\'Orfeo Opera', 'The first opera, "L\'Orfeo" by Monteverdi, debuts.', new CustomDate(1607, 0), 3, false),
        new TimelineEvent(13, 'Death of J.S. Bach', 'Marks the end of the Baroque period.', new CustomDate(1750, 6), 1, false),
        new TimelineEvent(14, 'Death of Mozart', 'End of a legendary career of one of the greatest composers.', new CustomDate(1791, 11), 2, false),
        new TimelineEvent(15, 'Beethoven\'s Death', 'Death of Ludwig van Beethoven.', new CustomDate(1827, 2), 3, false),
        new TimelineEvent(16, 'Phonograph Invented', 'Thomas Edison invents the phonograph.', new CustomDate(1877, 6), 1, false),
        new TimelineEvent(17, 'Rite of Spring Premiere', 'Stravinsky\'s *Rite of Spring* causes a scandal.', new CustomDate(1913, 4), 2, false),
        new TimelineEvent(18, 'First Rock and Roll Recording', 'Elvis Presley records "That\'s All Right", marking the beginning of rock and roll.', new CustomDate(1954, 6), 3, false),
        new TimelineEvent(19, 'Beatlemania Begins', 'The Beatles arrive in America, sparking a cultural phenomenon.', new CustomDate(1964, 1), 1, false),
        new TimelineEvent(20, 'Woodstock Festival', 'A music festival symbolizing the hippie movement.', new CustomDate(1969, 7), 2, false),
        new TimelineEvent(21, 'MTV Launch', 'The first music video network is launched.', new CustomDate(1981, 7), 3, false),
        new TimelineEvent(22, 'Live Aid', 'Concerts held worldwide to combat famine in Ethiopia.', new CustomDate(1985, 6), 1, false),
        new TimelineEvent(23, 'Napster Launch', 'Napster changes music distribution online.', new CustomDate(1999, 5), 2, false),
        new TimelineEvent(24, 'iTunes Launch', 'Apple revolutionizes music consumption with iTunes and iPod.', new CustomDate(2001, 0), 3, false),
        new TimelineEvent(25, 'Spotify Launch', 'Spotify pioneers music streaming.', new CustomDate(2008, 9), 1, false),
        new TimelineEvent(26, 'Flûtes de Hohle Fels', 'The oldest musical instruments discovered, dating back 40,000 years, found in Germany.', new CustomDate(-40000, 0), 3, false),
        new TimelineEvent(27, 'Development of Percussion Instruments', 'Ancient humans begin using natural objects as percussive instruments.', new CustomDate(-20000, 0), 2, false),
        new TimelineEvent(28, 'First String Instruments in Siberia', 'Evidence of early string instruments, like musical bows.', new CustomDate(-13000, 0), 1, false),
        new TimelineEvent(29, 'Shamanic Ritual Music', 'Evidence of music used in shamanic rituals for healing and spiritual purposes.', new CustomDate(-10000, 0), 1, false),
        new TimelineEvent(30, 'Development of Metal Instruments', 'Mesopotamians create instruments from metals, expanding musical capabilities.', new CustomDate(-6000, 0), 1, false),
        new TimelineEvent(31, 'Harps and Lyres in Mésopotamie', 'The first use of harps and lyres in royal courts.', new CustomDate(-4000, 0), 1, false),
        new TimelineEvent(32, 'Earliest Egyptian Music', 'Music becomes central to Egyptian rituals with flutes, drums, and other instruments.', new CustomDate(-3500, 0), 1, false),
        new TimelineEvent(33, 'Hymne Hurrite', 'One of the oldest recorded songs from ancient Syria.', new CustomDate(-1400, 0), 1, false),
    ]
    periods: TimelinePeriod[] = [
        new TimelinePeriod(1, new CustomDate(-1000, 0), new CustomDate(-500, 0), 'Ancient Music', 'Earliest known music, including Mesopotamian hymns and Greek theory.', '#FF0000', 1, false),
        new TimelinePeriod(2, new CustomDate(-500, 0), new CustomDate(400, 0), 'Greek and Roman Music', 'Development of scales and theory by Pythagoras and Aristoxenus.', '#FF7F00', 1, false),
        new TimelinePeriod(3, new CustomDate(400, 0), new CustomDate(800, 0), 'Early Christian Music', 'Chants and psalms in early Christian worship.', '#FFFF00', 1, false),
        new TimelinePeriod(4, new CustomDate(800, 0), new CustomDate(1150, 0), 'Medieval Music', 'Gregorian Chant and early polyphony emerge in monasteries.', '#7FFF00', 1, false),
        new TimelinePeriod(5, new CustomDate(1150, 0), new CustomDate(1300, 0), 'Ars Antiqua', 'Notre-Dame School in Paris develops complex polyphony.', '#00FF00', 1, false),
        new TimelinePeriod(6, new CustomDate(1300, 0), new CustomDate(1430, 0), 'Ars Nova', 'Innovations in rhythm and notation in France and Italy.', '#00FF7F', 1, false),
        new TimelinePeriod(7, new CustomDate(1430, 0), new CustomDate(1600, 0), 'Renaissance Music', 'Rediscovery of harmony and elaborate vocal forms.', '#00FFFF', 1, false),
        new TimelinePeriod(8, new CustomDate(1600, 0), new CustomDate(1750, 0), 'Baroque Period', 'Musical period featuring composers like Bach and Vivaldi.', '#007FFF', 1, false),
        new TimelinePeriod(9, new CustomDate(1750, 0), new CustomDate(1820, 0), 'Classical Period', 'Musical period with composers like Mozart and Beethoven.', '#0000FF', 3, false),
        new TimelinePeriod(10, new CustomDate(1820, 0), new CustomDate(1900, 0), 'Romantic Period', 'Musical period with composers like Chopin and Wagner.', '#7F00FF', 1, false),
        new TimelinePeriod(11, new CustomDate(1900, 0), new CustomDate(1945, 0), 'Modern Period', 'Modern era music and jazz emergence.', '#FF00FF', 2, false),
        new TimelinePeriod(12, new CustomDate(1945, 0), new CustomDate(1960, 0), 'Rock and Roll Emergence', 'Birth of rock and roll with artists like Elvis Presley.', '#FF007F', 3, false),
        new TimelinePeriod(13, new CustomDate(1960, 0), new CustomDate(1980, 0), 'Psychedelic and Progressive Rock Era', 'Era of rock with bands like The Beatles and Pink Floyd.', '#FF0000', 1, false),
        new TimelinePeriod(14, new CustomDate(1980, 0), new CustomDate(2000, 0), 'Pop, Hip-Hop, and Electronic Era', 'Pop, hip-hop, and electronic music rise with artists like Michael Jackson.', '#FF7F00', 3, false),
        new TimelinePeriod(15, new CustomDate(2000, 0), new CustomDate(new Date().getFullYear(), new Date().getMonth()), 'Digital and Streaming Era', 'Music distribution shifts to digital platforms and streaming services.', '#FFFF00', 1, false),
        new TimelinePeriod(16, new CustomDate(-40000, 0), new CustomDate(-30000, 0), 'Paleolithic Music', 'Earliest known musical artifacts like flutes made from bird bones.', '#8B4513', 1, false),
        new TimelinePeriod(17, new CustomDate(-30000, 0), new CustomDate(-20000, 0), 'Early Percussion Era', 'Development of primitive percussion sounds.', '#8B0000', 1, false),
        new TimelinePeriod(18, new CustomDate(-20000, 0), new CustomDate(-10000, 0), 'Invention of String Instruments', 'Introduction of early string instruments.', '#CD853F', 1, false),
        new TimelinePeriod(19, new CustomDate(-10000, 0), new CustomDate(-6000, 0), 'Shamanic Ritual Music', 'Music used in spiritual rituals.', '#D2691E', 1, false),
        new TimelinePeriod(20, new CustomDate(-6000, 0), new CustomDate(-4000, 0), 'Mesopotamian Music', 'Metal instruments and harps created.', '#FFD700', 1, false),
        new TimelinePeriod(21, new CustomDate(-4000, 0), new CustomDate(-1000, 0), 'Egyptian and Sumerian Music', 'Music flourishes in early civilizations.', '#FF8C00', 1, false),
    ]

    constructor(
        id?: number,
        name?: string,
        startDate?: CustomDate,
        endDate?: CustomDate,
        currentYear?: number,
        selectedyear?: number
    ) {
        this.id = id || this.id
        this.name = name || this.name
        this.startDate = startDate || this.startDate
        this.endDate = endDate || this.endDate
        this.currentYear = currentYear || this.currentYear
        this.selectedyear = selectedyear || this.selectedyear
        this.timelineWidth = this.calculateTimelineWidth()
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
        const scale = this.zoomLevels[this.currentZoomLevel]
        this.timelineWidth = this.calculateTimelineWidth()
        this.generateGraduations(scale)
        this.generateEventPositions(scale)
        this.generatePeriodPositions(scale)
    
        // Mise à jour de l'état d'affichage des événements et périodes en fonction du niveau de zoom
        if (scale === 10 || scale === 1 || scale === 1 / 12) {
            // Zoom niveau mois ou années, afficher tous les événements et périodes
            this.events.forEach(event => event.isActive = true)
            this.periods.forEach(period => period.isActive = true)
        } else {
            // Zoom niveau décennies ou plus, masquer tous les événements et périodes
            this.events.forEach(event => event.isActive = false)
            this.periods.forEach(period => period.isActive = false)
        }
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
                label = month + 1 // Mois de 1 à 12
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
}