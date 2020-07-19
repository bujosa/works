const server = require('http').createServer();
const fs = require('fs');

server.on('request', (req, res) => {
    // Solution 1
    //fs.readFile('text-file.txt', (err, data) => {
     //   if (err) console.log(err);
     //   res.end(data);
    //});

    // Solution 2: streams
    //const readable = fs.createReadStream('text-file.txt');
    //   resreadable.on('data', chunk => {
      //  res.write(chunk);
    //});

    //readable.on('end', () => {  
    //    res.end();
    // });

    //readable.on('error', err => {
    //    console.log(err);
     //   res.statusCode = 500;
    //    res.end("File not found");
    //});

    // solution 3 Pipe Solution
    const readable = fs.createReadStream('text-file.txt');
    readable.pipe(res); // is the best solution // is used by consumer data
    // readbleSource.pipe(writableDest)

});

server.listen(8000, '127.0.0.1', () => {
    console.log("Listening........");
});