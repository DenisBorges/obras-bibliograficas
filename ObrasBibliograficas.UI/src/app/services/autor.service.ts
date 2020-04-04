import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class AutorService {

    uri = 'https://localhost:44338/api';

    constructor(private http: HttpClient) { }

    //POST
    addAutor(nome, nomedoMeio, sobrenome) {

        const registro = {
            nome, nomedoMeio, sobrenome
        };

        return this.http
            .post(`${this.uri}/Autor`, registro)
            .pipe(
                catchError(this.handleError)
            );
    }

    //GET
    getListAutors() {
        return this.http.get(`${this.uri}/Autor`);
    }

    //DELETE
    deleteAutor(id) {
        debugger;
        return this.http.delete(`${this.uri}/Autor?id=${id}`);
    }

    private handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) {
            console.error('Um erro ocorreu:', error.error.message);
        } else {
            console.error(
                `Backend returned code ${error.status}, ` +
                `body was: ${error.error}`);
        }

        if (error.status == 400)
            return throwError(error.message);
        // return an observable with a user-facing error message
        return throwError(
            'Houve um erro durante sua requisição. Por favor tente novamente.');
    };

}