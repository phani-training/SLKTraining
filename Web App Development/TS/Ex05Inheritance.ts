class Person{
    constructor(private fName : string, private lName : string) {
        //private in constructor makes it a field of the class. 
    }

    getFullname () : string {
        return `${this.fName} ${this.lName}`
    }
}

class EmpData extends Person{
    constructor(fName : string, lName : string, private jobTitle : string){
        super(fName, lName);
    }

    getFullname(): string {//method overriding in TS
        return super.getFullname() + " works as " + this.jobTitle;
    }
}

{
    let obj = new Person("Phani", "Raj");
    console.log(obj.getFullname());

    obj = new EmpData("Phani", "Raj", "Trainer");
    console.log(obj.getFullname());
}

//todo: Create a Interactive Web App that makes calls to the EmpData object and perform the data display on the browser. 
//If U want singleton feature, make the class as static. Members of the static class are refered by their classname. 

