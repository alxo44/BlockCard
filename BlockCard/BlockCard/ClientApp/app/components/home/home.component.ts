import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent {
    public repositories: Repository[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Repository/All').subscribe(result => {
            this.repositories = result.json() as Repository[];
        }, error => console.error(error));
    }
}

interface Repository {
    name: string;
    description: string;
    organizationAvatarUrl: string;
    language: string;
    openIssues: string;
    forks: string;
    homepage: string;
}