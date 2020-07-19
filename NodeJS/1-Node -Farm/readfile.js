const hello = 'Hola Mundo';
// console.log(hello);

const fs = require('fs');

// Blocking, synchronous way
const textIn = fs.readFileSync('text.txt' ,'utf-8'); // Expulsar lo que contiene
console.log(textIn);
const textOut = `This is what we Know about DB : ${textIn}.\nCreated on ${Date.now()}`;
fs.writeFileSync('output.txt', textOut); // Si existe lo crea y sino lo modifica
console.log('File Written!');

// Non-Blocking, asynchronous way
fs.readFile('start.txt', 'utf-8', (err, data) => {

    if (err) return console.log('ERROR  ');

 fs.readFile(`${data}.txt`, 'utf-8', (err, data2) => {
    console.log(data2);
    fs.readFile(`append.txt`, 'utf-8', (err, data3) => {
        console.log(data3);

        fs.writeFile('final.txt', `${data2}\n${data3}`,'utf-8' , err=> {
            console.log('Y  our file has been written');
        })
       });
   });
   
});
console.log('Will read file!'); // se va ejecutando lo otro mienstra se procesa ejemplo de fs

// tener cuidado con los comillas entre ` y esta '

