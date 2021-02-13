
# Backend Car Quiz

Backend for Car Quiz App

Flutter App -> https://github.com/tomazinimetz/app_car_quiz
  
## Getting Started

### Prerequisites

SDK do .NET Core 3.0 or later

MongoDB

### Prepare you environment

Choose a directory on your development machine for storing the data.

Open a command shell. Run the following command to connect to MongoDB on default port 27017.

`mongod --dbpath <data_directory_path>`

Open another command shell instance. Connect to the default test database by running the following command:

`mongo`

`use QuizDb`

`db.createCollection('CarQuiz')`

Define a schema for the CarQuiz collection and insert data using the following command:

`db.CarQuiz.insert(<data.json file>)`

The database is ready. You can build and run the app.
