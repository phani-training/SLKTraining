const products = [];//creates a blank array called products. 

products.push({id : 111, name : "Tomatoes", price : 45});//adds the element to the bottom of the list. 
products.push({id : 112, name : "Onions", price : 25});
products.push({id : 113, name : "Potatoes", price : 35});
products.push({id : 114, name : "Mangoes", price : 145});
products.push({id : 115, name : "Brinjal", price : 65});

products.unshift({id : 110, name : "Gauva", price : 50})//add the element to the begining of the list. 
for(let i =0; i < products.length; i++){
    console.log(products[i].name)
}

//splice is a very smart method that allows U to delete, replace or add items in the collection. Todo: Find how this works....

products.splice(3, 1)//remove the 4th element from the list. 
console.log("After removing...................")
for(let i =0; i < products.length; i++){
    console.log(products[i].name)
}
for(let item of products)
    console.log(item)

//Friday : DOM Structure and use FETCH API. 
