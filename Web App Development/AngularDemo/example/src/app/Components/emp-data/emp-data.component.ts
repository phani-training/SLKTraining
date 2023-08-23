import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-emp-data',
  templateUrl: './emp-data.component.html',
  styleUrls: ['./emp-data.component.css']
})
export class EmpDataComponent implements OnInit {
  ngOnInit(): void {
    this.employees.push({empId : 111, empName : "Phaniraj", empAddress : "Bangalore", empImg : './assets/images/Phani.png'});
    this.employees.push({empId : 112, empName : "Banu Prakash", empAddress : "Bangalore", empImg : './assets/images/Phani.png'});
  }
  employees : Employee[] = [];

}
