# README Boilerplate

Claire's Salon. Tracks clients and 

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Support](#support)
- [Contributing](#contributing)

## User stipulations
* As the salon owner, I need to be able to see a list of all stylists.
* As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
* As the salon owner, I need to add new stylists to our system when they are hired.
* As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.


## Installation

Download to a directory, navigate to "Salon" inside of "Salon.Solution" and use ```dotnet run``` in the terminal.

## Documentation
Here is the full series of Create commands used to create the database:

~~~~sql
CREATE DATABASE `hair_salon`; 

CREATE TABLE `hair_salon`.`clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `StylistId` int,
  `First_Name` varchar(45),
  `Last_Name` varchar(45),
  `Name` varchar(45),
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `hair_salon`.`stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `First_Name` varchar(45),
  `Last_Name` varchar(45),
  `Name` varchar(45),
  PRIMARY KEY (`StylistId`)
);

~~~~

## Support

Please [open an issue](https://github.com/Riverface/HairSalon/issues/new) for support.

## Contributing

Please contribute using [Github Flow](https://guides.github.com/introduction/flow/). Create a branch, add commits, and [open a pull request](https://github.com/Riverface/HairSalon/compare/).