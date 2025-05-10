import { HttpErrorResponse } from "@angular/common/http";

export interface CustomError {
    original: HttpErrorResponse;
    needV2: boolean;
}