export enum NotificationType {
    Success,
    Danger,
    Warning,
    Info
}

export interface INotification {
    type: NotificationType;
    title: string;
    date: Date;
}

export interface INotificationsState {
    isAvailable: boolean;
    notifications: Array<INotification>;
}

export const NOTIFICATIONS_INITIAL_STATE: INotificationsState = {
    isAvailable: true,
    notifications: [
        {
            title: 'New user registered.',
            type: NotificationType.Success,
            date: new Date()
        },
        {
            title: 'Server #12 overloaded.',
            type: NotificationType.Danger,
            date: new Date()
        },
        {
            title: 'Server #2 not responding.',
            type: NotificationType.Warning,
            date: new Date()
        },
        {
            title: 'Application error.',
            type: NotificationType.Info,
            date: new Date()
        }
    ]
}