import { Component, OnInit } from '@angular/core';
import { Student } from './student';
import { StudentService } from './student.service';
declare var window: any;

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {
  addorupdatemodal: any;
  studentForm: Student = {
    id: 0,
    username: 'SaritaDream',
    firstName: 'Sarita',
    lastName: 'Dream',
    age: 25,
    career: 'Dancer',
  };

  addorupdatemodalTitle: string = '';

  students: Student[] = [];
  constructor(private studentService: StudentService) { }

  ngOnInit(): void {
    this.get();

    this.addorupdatemodal = new window.bootstrap.Modal(
      document.getElementById('addorupdatemodal')
    );
  }

  get() {
    this.studentService.get().subscribe({
      next: (data) => {
        this.students = data;
      },
      error: (err) => {
        console.log(err);
      }
    })
  }
  openAddOrUpdateModal(studentId: number) {
    if (studentId === 0) {
      this.addorupdatemodalTitle = 'Add';
      this.studentForm = {
        id: 0,
        username: 'SaritaDream',
        firstName: 'Sarita',
        lastName: 'Dream',
        age: 25,
        career: 'Dancer',
      };
      this.addorupdatemodal.show();
    }
  }

  createorUpdateStudent() {
    if (this.studentForm.id == 0) {
      this.studentService.post(this.studentForm).subscribe({
        next: (data) => {
          this.students.unshift(data);
          this.addorupdatemodal.hide();
        },
        error: (error) => {
          console.log(error);
        },
      });
    }
  }
}
