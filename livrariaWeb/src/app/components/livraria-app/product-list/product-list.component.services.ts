import { Injectable } from "@angular/core"
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { livro } from "./model/livro";

@Injectable()

export class livroService
{
    private url = "https://localhost:44324/api/livraria"

    httpOptions={
        Headers: new HttpHeaders({'content-type': 'application/json'})
    }

    constructor(private http:HttpClient){}

    getLivro(){
        return this.http.get(this.url);
    }
}

