import { IAuthState, AUTH_INITIAL_STATE } from './auth';
import { IUserState, USER_INITIAL_STATE } from './user';

export interface IAppState {
    auth?: IAuthState;
    user?: IUserState;
}

export const APP_INITIAL_STATE: IAppState = {
    auth: AUTH_INITIAL_STATE,
    user: USER_INITIAL_STATE
}