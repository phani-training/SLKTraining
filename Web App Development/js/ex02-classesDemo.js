class Customer{
    anything = "Apple123" //Use this syntax for creating fields in class of JS. 

    get CurrentData(){
        return this.anything;
    }
    constructor(id, name, address){
        this.id = id;
        this.name = name;
        this.address = address;
    }
}

const cst = new Customer(123, "TestName", "Bangalore");
console.log(cst.CurrentData);