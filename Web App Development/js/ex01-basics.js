console.log("Display on Console")
//There is more than one way of creating and running JS code. Traditional way is to create the JS file and make it a part of the HTML document and execute the page in the Browser. 
//With installation of NODEJS, we can run the JS code from the Terminal. However, as there is no DOM feature on a Terminal, U cannot run code that works on an UI. UI based functions: prompt, alert, confirm, document.getElementById and many more that are used for interaction with HTML elements. 

//let name = prompt("Enter ur name");
//console.log(name);

//JS supports 2 ways of creating variables:
//const is used to create constants and let is used to create local variables. 

//var value = 123;//old style, not recommended.
let value = 123; //let makes the variable scoped so that any redeclaration will be halted and ensures the data integrity. 

console.log(typeof(value))
value = "Apple123";
console.log(typeof(value))
value = true;
console.log(typeof(value))
value = { test : "Apple123"};
console.log(typeof(value));
//Even though, internally there are various data types supported by JS, let is the only way of declaring the variable.
//Data types of JS: number, string, boolean, object, undefined and null. 

let test = "Test";
console.log(typeof(test));//undefined happens when U create a variable but dont assign any value to it. 
//typeof operator is used to get the internal data type of the variable in JS. 

//////////////////Understanding functions/////////////////////////
//Named functions:
function addFunc(v1, v2){
    return v1 + v2;
}

const addedvalue = addFunc(123, 23);
console.log(addedvalue)

//Anonymous functions:
const subFunc = function(v1, v2){
    return v1 - v2;
}

const subValue = subFunc(123, 23);
console.log(subValue);

//lambda Expressions:
const mulFunc = (v1, v2) => v1 * v2;
const mulValue = mulFunc(12,3);
console.log(mulValue)

//////////////////////////////how to create classes and objects in JS/////////////
//Singleton objects: 
const empRec = {
    id : 123, name : "Phaniraj", salary : 45000, address : "Bangalore"
}
empRec.emailAddress = "phani@gmail.com"
console.log(empRec);
console.log(`The Name is ${empRec.name} from ${empRec.address} and earns a salary of ${empRec.salary}`);

const anotherObj = empRec;//reference of the same object, so no new object is created. 
anotherObj.name = "Another Name";
console.log(empRec);
////Old syntax of JS to create class and object
const Employee = function(id, name, address){
    this.empName = name;
    this.empAddress = address;
    this.empId = id;
}

let emp1 = new Employee(123, "Phaniraj", "Bangalore");
let emp2 = new Employee(234, "Suresh", "Mysore");
console.log(emp1);
console.log(emp2);

//A class in JS is like a collection. It can be treated like a Dictionary. 
for (const attr in emp1) {
    let str = `${attr} has the value ${emp1[attr]}`
    console.log(str);
}
////////////////////////new syntax of class creation
//Named class syntax. 
class Customer{
    constructor(id, name, address){
        this.cstId = id;
        this.cstName = name;
        this.cstAddress = address;
    }
}
//using the new syntax as a Anonymous class. 
const Book = class{
    constructor(id, title, price){
        this.bookId = id;
        this.title = title;
        this.cost = price;
    }
}

const cst1 = new Customer(123, "Phaniraj", "Bangalore");
console.log("The Customer name is " + cst1.cstName);

const book1 = new Book(111, "2 States", 500);
console.log(book1.title);


