import { ModuleWithProviders, NgModule } from '@angular/core';
import { BANKER_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class BankerConfigModule {
  static forRoot(): ModuleWithProviders<BankerConfigModule> {
    return {
      ngModule: BankerConfigModule,
      providers: [BANKER_ROUTE_PROVIDERS],
    };
  }
}
