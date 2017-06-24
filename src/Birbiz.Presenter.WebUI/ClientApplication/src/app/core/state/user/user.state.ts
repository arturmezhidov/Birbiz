import { Token } from '../../auth';

export interface IUserProfileState {
    userName: string;
    email: string;
    avatar: string;
}

export interface IUserState {
    token: Token;
    isAuthenticating: boolean;
    isAuthenticated: boolean;
    isProfileLoading: boolean;
    isScreenLocked: boolean;
    isAccountLocked: boolean;
    isAdminDashboardAvailable: boolean;
    profile: IUserProfileState;
    roles: any;
}

export const USER_INITIAL_STATE: IUserState = {
    token: {
        accessToken: '',
        refreshToken: '',
        tokenType: '',
        expiresIn: 0
    },
    isAuthenticating: false,
    isAuthenticated: false,
    isProfileLoading: false,
    isScreenLocked: false,
    isAccountLocked: false,
    isAdminDashboardAvailable: false,
    roles: {},
    profile: {
        userName: '',
        email: '',
        avatar: '/assets/img/avatar-small.jpg'
    }
}