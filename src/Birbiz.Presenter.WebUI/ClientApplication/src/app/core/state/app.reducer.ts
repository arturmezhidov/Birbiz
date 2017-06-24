import { combineReducers } from 'redux';
import { IAppState } from './app.state';
import { userReducer } from './user';
import { eventReducer } from './event';
import { notificationsReducer } from './notifications';
import { messagesReducer } from './messages';
import { tasksReducer } from './tasks';

export const appReducer = combineReducers<IAppState>({
    user: userReducer,
    event: eventReducer,
    notifications: notificationsReducer,
    messages: messagesReducer,
    tasks: tasksReducer
});