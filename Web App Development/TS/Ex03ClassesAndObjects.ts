export default class Employee {
    empId : number;
    empName : string;
    empAddress : string;
    empSalary : number;

    constructor(id : number, name : string, address : string, salary : number){
        this.empId = id;
        this.empName = name;
        this.empAddress = address;
        this.empSalary = salary;
    }

    display() : string{
        return `${this.empName} from ${this.empAddress} earns a salary of ${this.empSalary}`
    } 
}

const emp = new Employee(123, "Phaniraj", "Bangalore", 5600);

console.log(emp.display());