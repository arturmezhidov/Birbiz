export abstract class BaseResponse {
    public isSuccess: boolean;
    public hasError: boolean;
    public statusCode: number;
}