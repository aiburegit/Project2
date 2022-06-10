import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { RouterModule } from '@angular/router';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';
import { ModuleModule } from './module/module.module';
import { UserAppComponent } from './userapp/user-app/user-app.component';

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}


const providers = [
  { provide: 'BASE_URL', useFactory: getBaseUrl, deps: [] }
];

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic(providers).bootstrapModule(ModuleModule)
  .catch(err => console.log(err));
