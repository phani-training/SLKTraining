let msg : string = "Testing TS code";

console.log(msg);

let num  : number = 234;

let check : boolean = false;

console.log(check);

//////////////////////Arrays in TS////////////////////////
const fruits : string [] = ["Apples", "Mangoes", "Oranges"];

let values : (string | number)[] = ["Rajesh", 234, 234];
for(const val of fruits) console.log(val);
for(const val of values) console.log(val);

let names :Array<string> =[ "Phaniraj", "Teja", "Kumar"];
for(const name of names) console.log(name);

/////////////////Tuples///////////////////////////////
let empid : number = 123;
let empName : string = "Phaniraj"

let empDetails : [number, string, string] = [ 123, "Phaniraj", "Bangalore" ];

console.log(empDetails);

let empList: [number, string][];
empList = [
    [124, "Phaniraj"],
    [125, "Suresh"],
    [126, "Gopal"],
    [127, "Amar"],
    [128, "Tony"]
];

empList.push([129, "Albert"]);

for (const emp of empList)
    console.log(emp);

/////////////////////////Enums in Ts//////////////////////////
enum WeekDays{
    Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat
};
console.log(WeekDays.Sun);//1
console.log(WeekDays.Tue);//3
console.log(WeekDays.Fri);//6

const day : string = WeekDays[WeekDays.Sat]; //Typecasting in TS....
console.log(WeekDays[WeekDays.Mon]);//Mon
console.log(WeekDays[WeekDays.Fri]);//Fri
console.log(WeekDays[WeekDays.Sat]);//Sat

const days = Object.keys(WeekDays);
console.log(days);

///////////////////////////any///////////////////////
let somevalue : any = "Apples";
console.log("The data type: " + typeof(somevalue));

somevalue = 123;
console.log("The data type: " + typeof(somevalue));

/////////////////////Type inference///////////////
let code  = 12345; //Similar to CS's var keyword...In type inference, the variable will automatically have the data type of what it is assigned with. 

//code = "Some value"; =>This will give error as code is of the type number.
//use let,const and var to declare the variables in TS. Good with let and const. 



