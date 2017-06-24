import { EVENT_INITIAL_STATE, IEventState } from './event.state';

export function eventReducer(state: IEventState = EVENT_INITIAL_STATE, action: any): IEventState {
    let newState: IEventState = {
        action: action.type,
        data: action.payload
    };
    return newState;
}