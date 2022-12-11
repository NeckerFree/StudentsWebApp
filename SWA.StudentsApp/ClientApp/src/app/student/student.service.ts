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
  update(payload: Student) {
    return this.httpClient.put<Student>(
      'https://localhost:7210/api/students',
      payload
    );
  }
  delete(studentId: number) {
    return this.httpClient.delete(
      `https://localhost:7210/api/students/${studentId}`
    );
  }
}
