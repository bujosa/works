const fs = require("fs");
const crypto = require("crypto");

const start = Date.now();
process.env.UV_THREADPOOL_SIZE = 2;

setTimeout(() => console.log("Timer 1 finished"), 0);
setImmediate(() => console.log("Inmmediate 1 finished"));

fs.readFile("text-file.txt", () => {

    console.log("I/O finished");

    setTimeout(() => console.log("Timer 2 finished"), 0);
    setTimeout(() => console.log("Timer 3 finished"), 3000);
    setImmediate(() => console.log("Inmmediate 2 finished"));

    process.nextTick(() => console.log("Process.nextTick"));

    crypto.pbkdf2Sync('password','salt',100000,1024,'sha512'); // codeblo
    console.log(Date.now() - start, " Password encrypted");
    
    crypto.pbkdf2Sync('password','salt',100000,1024,'sha512');
    console.log(Date.now() - start, " Password encrypted");
    
    crypto.pbkdf2Sync('password','salt',100000,1024,'sha512');
    console.log(Date.now() - start, " Password encrypted");
    
    crypto.pbkdf2Sync('password','salt',100000,1024,'sha512');
    console.log(Date.now() - start, " Password encrypted");

});

console.log("Hello From the top-level code");

// video 5 unit 4