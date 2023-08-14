
class ProductManager{
    products = []; //blank array in JS...
    constructor(){
        this.addProduct({id : 123, name : "iPhone", price : 45000, pic : '../images/iPhone13pro.jpg' });
        this.addProduct({id : 124, name : "iPhone", price : 45000, pic : '../images/iPhone13pro.jpg' });
        this.addProduct({id : 125, name : "iPhone", price : 45000, pic : '../images/iPhone13pro.jpg' });
        this.addProduct({id : 126, name : "iPhone", price : 45000, pic : '../images/iPhone13pro.jpg' });
    }

    addProduct(product){
        this.products.push(product);//push is a builtin function of JS Arrays to add item to the bottom of the list
    }

    getAllProducts = () => this.products;

    findProduct = (id) =>{
        for(const prod of this.products){
            if(prod.id == id){
                return prod;
            }
        }
        throw `Product with Id ${id} not found`;
    };

}