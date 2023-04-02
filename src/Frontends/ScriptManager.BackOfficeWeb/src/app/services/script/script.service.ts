import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ScriptModel } from 'src/app/models/ScriptModel';

@Injectable({
  providedIn: 'root'
})
export class ScriptService {

  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get<ScriptModel[]>('https://localhost:7131/api/script');
  }
  getById(id:number) {
    return this.http.get<ScriptModel>(`https://localhost:7131/api/script/${id}`);
  }
}
