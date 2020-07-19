const mongoose = require('mongoose');
const dotenv = require('dotenv');
const app = require('./app');

dotenv.config({path: './config.env'});

const DB = process.env.DATABASE.replace(
    '<PASSWORD>',process.env.DATABASE_PASSWORD
    );

    // if you want to use local database
    // you need to use process.env.DATABASE_LOCAL
mongoose.connect(DB, {
    useNewUrlParser: true,
    useCreateIndex: true,
    useFindAndModify: false
}).then(() => { console.log('DB connection successfull');});

const tourSchema = new mongoose.Schema({
    name: {
        type: String,
        required: (true, 'A tour must have a name'),
        unique: true
    },
    rating: {
        type: Number,
        default: 4.5
    },
    price: {
        type: Number,
        required: (true, 'A tour must have a price')
    }
});

const Tour = mongoose.model('Tour', tourSchema);

const testTour = new Tour({ 
    name: 'Camisama',
    rating: 4.7,
    price: 10
});

testTour.save().then(doc => {
    console.log(doc);

}).catch(err => {
    console.log('ERROR:',err);
});
const port = process.env.PORT || 3000;
app.listen(port, () => {
    console.log(`App running on port ${port}...`);
});