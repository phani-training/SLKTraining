import Employee from "./Ex03ClassesAndObjects";
//Annotation interfaces which is used to represent only the data but no functions in it...
interface Product{
    productId: number;
    productName : string;
    productPrice : number;
}

//FunctionalType Interfaces
interface TestInterface{
    (arg1 : number, arg2: number) : number
}
//functional interfaces have only one method to implement. 
const TestClass : TestInterface = function(arg1 : number, arg2 : number){
    return arg1 + arg2;
}
//Lambda version of the interface implementation..
const SubtractFunc : TestInterface = (arg1, arg2) => arg1 - arg2;


console.log(TestClass(123, 234));

console.log(SubtractFunc(123, 23));

//In Ang apps, the interfaces are widely used to create models for the app. Models are entites of the Application in an MVC Design pattern. 
const p1 : Product = {
    productId : 111, productName : "Cricket Bat", productPrice : 2400
}

console.log(p1.productName);

////////////////////////////Real time interfaces//////////////////////////////////////
interface DBComponent{
    getAllEmployees() : Employee[];
    addEmployee(emp : Employee) : void;
}

class MyDBComponent implements DBComponent{
    private arr : Employee[] = [];
    getAllEmployees(): Employee[] {
        return this.arr;
    }
    addEmployee(emp: Employee): void {
        this.arr.push(emp);
    }
}

const obj = new MyDBComponent();
obj.addEmployee(new Employee(123, "Phaniraj", "Bangalore", 56000));
obj.addEmployee(new Employee(123, "Phaniraj", "Bangalore", 56000));
obj.addEmployee(new Employee(123, "Phaniraj", "Bangalore", 56000));
obj.addEmployee(new Employee(123, "Phaniraj", "Bangalore", 56000));
const data = obj.getAllEmployees();
data.forEach((rec)=>{
    console.log(rec.empName);
});