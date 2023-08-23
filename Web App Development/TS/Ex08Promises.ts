//Promise provides a feature of async programming in JS. 
const userName : string = "Phaniraj";
const trainer : string = "Phaniraj123";

let promise = new Promise(function(resolve, reject){
    if(userName == trainer){
        resolve("Welcome to trainer");
    }else{
        reject("Only Trainers are allowed")
    }
});

console.log("Testing async programming");

promise.then(function(data){
    console.log(data);
}).catch(function(err){
    console.error(err)
})