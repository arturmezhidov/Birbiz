import { Routes, RouterModule } from "@angular/router";

import { AccountContainer } from "./account.container";
import { LoginContainer } from "./login/login.container";
import { RegisterContainer } from "./register/register.container";
import { ForgotPasswordContainer } from "./forgot-password/forgot-password.container";
import { LockScreenContainer } from "./lock-screen/lock-screen.container";
import { LockAccountContainer } from "./lock-account/lock-account.container";

export const AccountRoutes: Routes = [
    {
        path: "",
        component: AccountContainer,
        children: [
            {
                path: "",
                redirectTo: "login",
                pathMatch: "full"
            },
            {
                path: "login",
                component: LoginContainer,
            },
            {
                path: "register",
                component: RegisterContainer
            },
            {
                path: "forgot-password",
                component: ForgotPasswordContainer
            },
            {
                path: "lock-screen",
                component: LockScreenContainer
            },
            {
                path: "lock-account",
                component: LockAccountContainer
            }
        ]
    }
];

export const AccountRouting = RouterModule.forChild(AccountRoutes);