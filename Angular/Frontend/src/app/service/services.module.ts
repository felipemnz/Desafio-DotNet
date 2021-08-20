import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AplicationService } from './aplicationService.service';

@NgModule({
	imports: [
		CommonModule,
	],
	declarations: [],
	providers: [
		AplicationService,
	]
})
export class ServicesModule { }