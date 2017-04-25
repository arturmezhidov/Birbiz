import { IAuthState, AUTH_INITIAL_STATE } from './auth.state';
import { LOGIN_USER, LOGIN_USER_SUCCESS, LOGOUT_USER, TOKEN_UPDATE } from './auth.constants';

export function authReducer(state: IAuthState = AUTH_INITIAL_STATE, action: any): IAuthState {
    let newState: IAuthState = Object.assign({}, state);
    switch (action.type) {
        case LOGIN_USER: {
            newState.isLoading = true;
            newState.isAuthenticated = false;
            break;
        }
        case LOGIN_USER_SUCCESS: {
            newState.isLoading = false;
            newState.isAuthenticated = true;
            newState.token = action.payload;
            break;
        }
        case TOKEN_UPDATE: {
            newState.isLoading = false;
            newState.isAuthenticated = true;
            newState.token = action.payload;
            break;
        }
        case LOGOUT_USER: {
            return AUTH_INITIAL_STATE;
        }
        default: {
            return state;
        }
    }
    return newState;
}