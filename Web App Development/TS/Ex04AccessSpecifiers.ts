//TS has 3 modifers: private, public and protected, Default is public

class Customer{
    private cstId : number;
    private cstName : string;
    private cstPhone : number;

    constructor(id : number, name : string, phone : number) {
             this.cstId = id;
             this.cstName = name;
             this.cstPhone = phone  
    }

    getAllDetails() : string{
        return `${this.cstId} with phoneno ${this.cstPhone} and name ${this.cstName}`;
    }
}
{
    const obj = new Customer(123, "John", 34535);
    console.log(obj.getAllDetails());
}
