abstract class Account{
    /**
     *
     */
    constructor(private accNo: number, private name : string, protected balance : number) {
        
    }

    credit = (amount : number) => this.balance += amount;

    debit = (amount : number) =>{
        if(amount > this.balance) throw "Insufficient funds";
        this.balance -= amount;
    }

    public get Name() : string{
        return this.name;
    }

    public get Balance() : number{
        return this.balance;
    }

    public abstract calcInterest() : void;
}

class SBAccount extends Account{
    public calcInterest(): void {
        const principal = this.balance;
        const term = 0.25;
        const rate = 0.06;
        const interest = principal * term * rate;
        this.credit(interest);
    }
}
//Abstract classes cannot be instantiated. 
const acc : Account = new SBAccount(111, "Phaniraj", 6000);
acc.credit(5000);
acc.debit(400);
console.log(acc.Balance);
acc.calcInterest();
console.log(acc.Balance);


