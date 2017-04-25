import { IUserState, USER_INITIAL_STATE } from './user.state';
import { USER_LOADING, USER_LOADED, USER_CLEAR } from './user.constants';

export function userReducer(state: IUserState = USER_INITIAL_STATE, action: any): IUserState {
    let newState: IUserState = Object.assign({}, state);
    switch (action.type) {
        case USER_LOADING: {
            newState.isLoading = true;
            break;
        }
        case USER_LOADED: {
            newState.isLoading = false;
            newState.userName = action.payload.userName;
            break;
        }
        case USER_CLEAR: {
            return USER_INITIAL_STATE;
        }
        default: {
            return state;
        }
    }
    return newState;
}