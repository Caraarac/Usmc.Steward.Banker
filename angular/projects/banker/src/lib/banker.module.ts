import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { BankerComponent } from './components/banker.component';
import { BankerRoutingModule } from './banker-routing.module';

@NgModule({
  declarations: [BankerComponent],
  imports: [CoreModule, ThemeSharedModule, BankerRoutingModule],
  exports: [BankerComponent],
})
export class BankerModule {
  static forChild(): ModuleWithProviders<BankerModule> {
    return {
      ngModule: BankerModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<BankerModule> {
    return new LazyModuleFactory(BankerModule.forChild());
  }
}
