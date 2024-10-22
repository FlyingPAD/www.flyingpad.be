import { DisplayModes } from "../enumerations/display-modes"
import { DisplayOrientations } from "../enumerations/display-orientations"

export interface DisplayInfo {
    width: number
    height: number
    mode: DisplayModes
    orientation: DisplayOrientations
}