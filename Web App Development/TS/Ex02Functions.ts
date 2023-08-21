function testFunc() : void {
 console.log("Testing func in TS");   
}

function addFunc(v1 : number, v2 : number) : number{
    return v1 + v2;
}

function subFunc(v1 : number, v2? : number) : number{
    if(v2 != undefined){
        return v1 - v2;
    }else{
        return v1 - 0;
    }
}

let res = addFunc(123, 34);
console.log(res); //157
console.log(typeof(res)); //number


res = subFunc(123);
console.log(res);//123
res = subFunc(123, 23); //100
console.log(res);

testFunc();

const mulFunc = (v1 : number, v2 : number) : number  => v1 * v2 ;

console.log(mulFunc(12,3));//36