import { NgRedux } from 'ng2-redux';
import { appReducer } from './app.reducer';
import { IAppState, APP_INITIAL_STATE } from './app.state';

declare var devToolsExtension: any;

export function configureStore(ngRedux: NgRedux<IAppState>): void {
    ngRedux.configureStore(
        appReducer,
        APP_INITIAL_STATE,
        null,
        devToolsExtension && devToolsExtension());
}