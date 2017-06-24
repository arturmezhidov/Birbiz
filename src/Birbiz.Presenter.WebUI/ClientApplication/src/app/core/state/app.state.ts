import { IUserState, USER_INITIAL_STATE } from './user';
import { IEventState, EVENT_INITIAL_STATE } from './event';
import { INotificationsState, NOTIFICATIONS_INITIAL_STATE } from './notifications';
import { IMessagesState, MESSAGES_INITIAL_STATE } from './messages';
import { ITasksState, TASKS_INITIAL_STATE } from './tasks';

export interface IAppState {
    user?: IUserState;
    event?: IEventState;
    notifications?: INotificationsState;
    messages?: IMessagesState;
    tasks?: ITasksState;
}

export const APP_INITIAL_STATE: IAppState = {
    user: USER_INITIAL_STATE,
    event: EVENT_INITIAL_STATE,
    notifications: NOTIFICATIONS_INITIAL_STATE,
    messages: MESSAGES_INITIAL_STATE,
    tasks: TASKS_INITIAL_STATE
}