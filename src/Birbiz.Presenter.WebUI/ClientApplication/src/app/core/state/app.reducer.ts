import { combineReducers } from 'redux';
import { IAppState } from './app.state';
import { authReducer } from './auth';
import { userReducer } from './user';

export const appReducer = combineReducers<IAppState>({
    auth: authReducer,
    user: userReducer
});