import { NONE } from './event.constants';

export interface IEventState {
    action: string;
    data?: any;
}

export const EVENT_INITIAL_STATE: IEventState = {
    action: NONE,
    data: {}
}