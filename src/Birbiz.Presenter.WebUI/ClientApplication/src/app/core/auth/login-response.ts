import { BaseResponse, Token } from '../http';

export class LoginResponse extends BaseResponse {
    public token: Token;
}