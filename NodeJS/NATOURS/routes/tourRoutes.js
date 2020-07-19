const express = require('express');
const tourController = require(`${__dirname}/../controllers/tourController`);
const router = express.Router();

router.param('id', tourController.checkId); 

// Create a checkbody middleware function
// check if body the name and prince property
// if not, send back 400 (bad request)
// add it to the post handler stack

router
    .route('/')
    .get(tourController.getAllTours)
    .post(tourController.checkBody,tourController.createTour);

router
    .route('/:id')
    .get(tourController.getTour)
    .patch(tourController.updateTour)
    .delete(tourController.deleteTour);


module.exports = router;