import { Token } from '../../auth';

export interface IAuthState {
    token: Token;
    isAuthenticated: boolean;
    isLoading: boolean;
}

export const AUTH_INITIAL_STATE: IAuthState = {
    token: {
        accessToken: '',
        refreshToken: '',
        tokenType: '',
        expiresIn: 0
    },
    isAuthenticated: false,
    isLoading: false
}