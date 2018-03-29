import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    public forecasts: Blockchain[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Blockchain/All').subscribe(result => {
            this.forecasts = result.json() as Blockchain[];
        }, error => console.error(error));
    }
}

interface Blockchain {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}