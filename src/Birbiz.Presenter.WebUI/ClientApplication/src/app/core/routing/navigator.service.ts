import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable()
export class NavigatorService {

    private router: Router;

    constructor(router: Router) {
        this.router = router;
    }

    public goLogin(): void {
        this.router.navigate(['account', 'login']);
    }

    public goLockScreen(): void {
        this.router.navigate(['account', 'lock-screen']);
    }

    public goAdminDashboard(): void {
        this.router.navigate(['admin']);
    }
}