import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../shared/employee.service';
import { Epmloyee } from '../shared/epmloyee.model';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {

  constructor(public empService:EmployeeService , public datepipe:DatePipe) { }

  ngOnInit(): void {
    this.empService.getEmployee().subscribe(data=>{
      this.empService.listEmployee=data;
    });
  }
  populateEmployee(selectedEmployee:Epmloyee){
    console.log(selectedEmployee.doj);
    let df= this.datepipe.transform(selectedEmployee.doj,'yyyy-MM-dd');
    selectedEmployee.doj = df;
    this.empService.employeeData =selectedEmployee;
  }

  delete(id:number){
    if(confirm('Are you really want to delete record?')){
      this.empService.deleteEmployee(id).subscribe(data=>{
        console.log('Record deleted....');
        this.empService.getEmployee().subscribe(data=>{
          this.empService.listEmployee=data;
        });
      },
      err=>{
        console.log('Record does not deleted');
      });
    }
  }
}
