import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student } from './student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private httpClient:HttpClient)  { }

  get() {
    return this.httpClient.get<Student[]>('/api/students')
  }

  post(payload: Student) {
    return this.httpClient.post<Student>(
      '/api/students',
      payload
    );
  }
  update(payload: Student) {
    return this.httpClient.put<Student>(
      '/api/students',
      payload
    );
  }
  delete(studentId: number) {
    return this.httpClient.delete(
      `/api/students/${studentId}`
    );
  }
}
