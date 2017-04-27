export interface IUserState {
    userName: string;
    isAdminDashboardAvailable: boolean;
    isLoading: boolean;
}

export const USER_INITIAL_STATE: IUserState = {
    userName: '',
    isAdminDashboardAvailable: false,
    isLoading: false
}