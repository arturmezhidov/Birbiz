import { Component, Input, Output, EventEmitter, OnDestroy, ElementRef } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';
import { select } from 'ng2-redux';

import { IUserState, UserActions } from '../../../core/state/user';
import { INotificationsState, NotificationType } from '../../../core/state/notifications';
import { IMessagesState } from '../../../core/state/messages';
import { ITasksState, TaskStateType } from '../../../core/state/tasks';
import { EventService, DOCUMENT_CLICK } from '../../../core/state/event';

@Component({
    selector: 'top-menu',
    templateUrl: './top-menu.component.html'
})
export class TopMenuComponent implements OnDestroy {

    @Input()
    public user: IUserState;

    @Input()
    public notifications: INotificationsState;

    @Input()
    public messages: IMessagesState;

    @Input()
    public tasks: ITasksState;

    @Output()
    public onLocked = new EventEmitter();

    @Output()
    public onLogout = new EventEmitter();

    private openedItem: string;
    private eventSubscription: Subscription;
    private userActions: UserActions;

    constructor(eventService: EventService, userActions: UserActions, element: ElementRef) {
        this.userActions = userActions;
        this.eventSubscription = eventService.watch(DOCUMENT_CLICK).subscribe((event: MouseEvent) => {
            if (!element.nativeElement.contains(event.target)) {
                this.closeItems();
            }
        });
    }

    public onLockClick(): void {
        this.userActions.screenLock();
        if (this.onLocked) {
            this.onLocked.next();
        }
    }

    public onLogoutClick(): void {
        this.userActions.logout();
        if (this.onLogout) {
            this.onLogout.next();
        }
    }

    ngOnDestroy(): void {
        if (this.eventSubscription) {
            this.eventSubscription.unsubscribe();
        }
    }

    private toggleItem(item: string): void {
        this.openedItem = this.openedItem === item
            ? null
            : item;
    }

    private closeItems(): void {
        this.openedItem = null;
    }

    private isOpenedItem(item: string): boolean {
        return this.openedItem === item;
    }

    private notificationsStyles(type: NotificationType): any {
        switch (type) {
            case NotificationType.Success:
                return {
                    label: 'label-success',
                    icon: 'fa-plus'
                }
            case NotificationType.Warning:
                return {
                    label: 'label-warning',
                    icon: 'fa-bell-o'
                }
            case NotificationType.Danger:
                return {
                    label: 'label-danger',
                    icon: 'fa-bolt'
                }
            default:
                return {
                    label: 'label-info',
                    icon: 'fa-bullhorn'
                }
        }
    }

    private tasksStyles(type: TaskStateType): string {
        switch (type) {
            case TaskStateType.Success:
                return 'success';
            case TaskStateType.Warning:
                return 'warning';
            case TaskStateType.Danger:
                return 'danger';
            case TaskStateType.Info:
                return 'info';
            default:
                return '';
        }
    }
}