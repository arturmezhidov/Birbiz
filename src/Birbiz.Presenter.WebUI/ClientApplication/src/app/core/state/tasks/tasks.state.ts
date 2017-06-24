export enum TaskStateType {
    Success,
    Danger,
    Warning,
    Info
}

export interface ITask {
    title: string;
    progress: number;
    state: TaskStateType;
}

export interface ITasksState {
    isAvailable: boolean;
    tasks: Array<ITask>;
}

export const TASKS_INITIAL_STATE: ITasksState = {
    isAvailable: true,
    tasks: [
        {
            title: 'New release v1.2',
            progress: .30,
            state: TaskStateType.Info
        },
        {
            title: 'Application deployment',
            progress: .65,
            state: TaskStateType.Danger
        },
        {
            title: 'Mobile app release',
            progress: .95,
            state: TaskStateType.Success
        },
        {
            title: 'Database migration',
            progress: .10,
            state: TaskStateType.Warning
        }
    ]
}