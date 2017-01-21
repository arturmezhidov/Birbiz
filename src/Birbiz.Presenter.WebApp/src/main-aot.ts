import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.module';

// Create dynamic platform
const platform = platformBrowserDynamic();

// Load application
platform.bootstrapModule(AppModule);