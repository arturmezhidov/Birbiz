import { IUserState, USER_INITIAL_STATE } from './user.state';
import {
    LOGIN_USER,
    LOGIN_USER_SUCCESS,
    LOGOUT_USER,
    TOKEN_UPDATE,
    USER_LOADING,
    USER_LOADED,
    ACCOUNT_LOCK,
    ACCOUNT_UNLOCK,
    SCREEN_LOCK,
    SCREEN_UNLOCK
} from './user.constants';

export function userReducer(state: IUserState = USER_INITIAL_STATE, action: any): IUserState {
    let newState: IUserState = Object.assign({}, state);
    switch (action.type) {
        case LOGIN_USER: {
            newState.isAuthenticating = true;
            newState.isAuthenticated = false;
            break;
        }
        case LOGIN_USER_SUCCESS: {
            newState.isAuthenticating = false;
            newState.isAuthenticated = true;
            newState.token = action.payload;
            break;
        }
        case USER_LOADING: {
            newState.isProfileLoading = true;
            break;
        }
        case USER_LOADED: {
            newState.isProfileLoading = false;
            newState.roles = action.payload.roles;
            newState.profile.userName = action.payload.userName;
            newState.isAccountLocked = action.payload.isAccountLocked;
            newState.isAdminDashboardAvailable = action.payload.isAdminDashboardAvailable;
            break;
        }
        case TOKEN_UPDATE: {
            newState.isAuthenticating = false;
            newState.isAuthenticated = true;
            newState.token = action.payload;
            break;
        }
        case LOGOUT_USER: {
            return USER_INITIAL_STATE;
        }
        case ACCOUNT_LOCK: {
            newState.isAccountLocked = true;
            break;
        }
        case ACCOUNT_UNLOCK: {
            newState.isAccountLocked = false;
            break;
        }
        case SCREEN_LOCK: {
            let lockState: IUserState = Object.assign({}, USER_INITIAL_STATE);
            lockState.isScreenLocked = true;
            lockState.profile.userName = state.profile.userName;
            lockState.profile.avatar = state.profile.avatar;
            return lockState;
        }
        case SCREEN_UNLOCK: {
            newState.isScreenLocked = false;
            break;
        }
        default: {
            return state;
        }
    }
    return newState;
}