

# Claire's Salon


Claire's Salon. Tracks Clients and Stylists.

## Table of Contents

- [Installation](#installation)
- [Support](#support)
- [Contributing](#contributing)

## User stipulations
* As the salon owner, I need to be able to see a list of all Stylists.
* As the salon owner, I need to be able to select a Stylist, see their details, and see a list of all Clients that belong to that Stylist.
* As the salon owner, I need to add new Stylists to our system when they are hired.
* As the salon owner, I need to be able to add new Clients to a specific Stylist. I should not be able to add a client if no Stylists have been added.

## Installation

* Clone or Download repo to a directory.
* Open Terminal.
* Start MySql.
* Here is the full series of Create commands used to create the database:

~~~~sql
CREATE DATABASE `robert_smith`; 

CREATE TABLE `robert_smith`.`clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `StylistId` int,
  `FirstName` varchar(45),
  `LastName` varchar(45),
  PRIMARY KEY (`ClientId`)
); 
CREATE TABLE `robert_smith`.`stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45),
  `LastName` varchar(45),

  PRIMARY KEY (`StylistId`)
);
~~~~

* navigate to "HairSalon" inside of "HairSalon.Solution" and use ```dotnet run``` in the terminal.

## Support

Please [open an issue](https://github.com/Riverface/HairSalon/issues/new) for support.

## Contributing

Please contribute using [Github Flow](https://guides.github.com/introduction/flow/). Create a branch, add commits, and [open a pull request](https://github.com/Riverface/HairSalon/compare/).

## Technologies Used
    ASP.NET
    Razor
    HTML
    C#
    Bootstrap

## Legal
Copyright (c) 2020 Robert Smith

This software is licensed under Creative Commons 0 license. Use however you want, in fact please do not credit me.