import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    public blockchains: Blockchain[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Blockchain/All').subscribe(result => {
            this.blockchains = result.json() as Blockchain[];
        }, error => console.error(error));
    }
}

interface Blockchain {
    name: string;
    description: string;
    organizationAvatarUrl: string;
    language: string;
    openIssues: string;
    forks: string;
    homepage: string;
}