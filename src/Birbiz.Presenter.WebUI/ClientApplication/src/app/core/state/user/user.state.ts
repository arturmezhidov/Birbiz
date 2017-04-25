export interface IUserState {
    userName: string;
    isLoading: boolean;
}

export const USER_INITIAL_STATE: IUserState = {
    userName: '',
    isLoading: false
}