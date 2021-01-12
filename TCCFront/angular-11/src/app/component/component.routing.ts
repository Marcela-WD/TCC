import { Routes } from '@angular/router';

import { NgbdAlertBasicComponent } from './alert/alert.component';
import { NgbdCarouselBasicComponent } from './carousel/carousel.component';
import { NgbdModalBasicComponent } from './modal/modal.component';
import { ButtonsComponent } from './buttons/buttons.component';
import { CardsComponent } from './card/card.component';
import { ProdutosComponent } from './produtos/produtos.component';


export const ComponentsRoutes: Routes = [
	{
		path: '',
		children: [
			{
				path: 'produtos',
				component: ProdutosComponent,
				data: {
					title: 'Produtos',
					urls: [
						{ title: 'ngComponent' },
						{ title: 'Produtos' }
					]
				}
			},
			{
				path: 'card',
				component: CardsComponent,
				data: {
					title: 'Receitas',
					urls: [
						{ title: 'ngComponent' },
						{ title: 'Cards' }
					]
				}
			},
			{
				path: 'alert',
				component: NgbdAlertBasicComponent,
				data: {
					title: 'Alert',
					urls: [
						{ title: 'ngComponent' },
						{ title: 'Alert' }
					]
				}
			},
			{
				path: 'carousel',
				component: NgbdCarouselBasicComponent,
				data: {
					title: 'Carousel',
					urls: [
						{ title: 'ngComponent' },
						{ title: 'Carousel' }
					]
				}
			},
			{
				path: 'modal',
				component: NgbdModalBasicComponent,
				data: {
					title: 'Modal',
					urls: [
						{ title: 'ngComponent' },
						{ title: 'Modal' }
					]
				}
			},
			{
				path: 'buttons',
				component: ButtonsComponent,
				data: {
					title: 'Button',
					urls: [
						{ title: 'ngComponent' },
						{ title: 'Button' }
					]
				}
			}
		]
	}
];
