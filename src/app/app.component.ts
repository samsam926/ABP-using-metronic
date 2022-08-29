import { eAccountComponents } from '@abp/ng.account';
import { ReplaceableComponentsService } from '@abp/ng.core';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';
import { Component } from '@angular/core';
import { LayoutComponent } from './layout/layout.component';
import { AuthComponent } from './modules/auth/auth.component';
import { LoginComponent } from './modules/auth/components/login/login.component';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
  `,
})
export class AppComponent {
  constructor(private replaceableComponents: ReplaceableComponentsService) {
    this.replaceableComponents.add({
      component: LoginComponent,
      key: eAccountComponents.Login,
    });
    this.replaceableComponents.add({
      component: AuthComponent,
      key: eAccountComponents.AuthWrapper,
    });
    this.replaceableComponents.add({
      component: LayoutComponent,
      key: eThemeBasicComponents.ApplicationLayout,
    });
  }
}
