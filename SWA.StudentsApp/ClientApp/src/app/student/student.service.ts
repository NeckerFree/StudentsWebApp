import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student } from './student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private httpClient:HttpClient)  { }

  get() {
    return this.httpClient.get<Student[]>('https://localhost:7210/api/students')
  }

  post(payload: Student) {
    return this.httpClient.post<Student>(
      'https://localhost:7210/api/students',
      payload
    );
  }
}
