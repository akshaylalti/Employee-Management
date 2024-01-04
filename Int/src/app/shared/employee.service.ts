import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Epmloyee, Designation } from './epmloyee.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  constructor(private myhttp:HttpClient) { }
  employeeUrl:string="https://localhost:44355/api/Employee";
  designationUrl:string="https://localhost:44355/api/desigination";
  listEmployee:Epmloyee[]=[];
  listDesignation:Designation[]=[];
  employeeData:Epmloyee=new Epmloyee();

  saveEmployee(){
      return this.myhttp.post(this.employeeUrl,this.employeeData);
  }
  updateEmployee(){
    return this.myhttp.put(`${this.employeeUrl}/${this.employeeData.id}`,this.employeeData);
  }
  getEmployee():Observable<Epmloyee[]>
  {
    return this.myhttp.get<Epmloyee[]>(this.employeeUrl);
  }
  getDesignation():Observable<Designation[]>
  {
    return this.myhttp.get<Designation[]>(this.designationUrl);
  }
  deleteEmployee(id:number){
    return this.myhttp.delete(`${this.employeeUrl}/${id}`);
  }
}




