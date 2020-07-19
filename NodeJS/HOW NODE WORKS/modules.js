//console.log(arguments);
//console.log(require("module").wrappers);

// module.exports
const C = require('./test-module.js');
const calc1 = new C();
console.log(calc1.add(2,5));

// exports
const calc2 = require('./test-module2.js');
console.log(calc2.add(2,5));

// example asafunction
const {add, multiply, divide}= require('./test-module2.js');
console.log(multiply(2,5));

//  caching 
require('./test-module3')();

