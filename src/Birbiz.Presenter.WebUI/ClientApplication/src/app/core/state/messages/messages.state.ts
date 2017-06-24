export interface IMessage {
    userName: string;
    text: string;
    avatar: string;
    date: Date;
}

export interface IMessagesState {
    isAvailable: boolean;
    messages: Array<IMessage>;
}

export const MESSAGES_INITIAL_STATE: IMessagesState = {
    isAvailable: true,
    messages: [
        {
            userName: 'Lisa Wong',
            text: 'Vivamus sed auctor nibh congue nibh. auctor nibh auctor nibh...',
            avatar: '/assets/img/avatar-small.jpg',
            date: new Date()
        },
        {
            userName: 'Richard Doe',
            text: 'Vivamus sed auctor nibh congue nibh. auctor nibh auctor nibh...',
            avatar: '/assets/img/avatar-small.jpg',
            date: new Date()
        },
        {
            userName: 'Bob Nilson',
            text: 'Vivamus sed auctor nibh congue nibh. auctor nibh auctor nibh...',
            avatar: '/assets/img/avatar-small.jpg',
            date: new Date()
        }
    ]
}