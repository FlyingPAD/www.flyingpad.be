import { BaseResponse } from "./base-response";

export interface LoginQueryResponse extends BaseResponse
{
    token : string
}

export interface RegisterCommandResponse extends BaseResponse
{
    token : string
}