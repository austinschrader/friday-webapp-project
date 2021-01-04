## Independent Project - Bakery Project Part #2 - C#/.Net Web Application - Week 9

C# & .NET program that allows Pierre's to manage his bakery's network of vendors and their respective orders. The program will allow Pierre to enter in the data for all of his customers, and their sub orders. This program harnesses the power of Object-Oriented Programming to organize and encapsulate data. For example, the Order objects are objects-within-objects of the Vendor object.

By Austin Schrader

## Description

This project was created by Austin Schrader for the week 9 of independent project using C# and uses C#/.NET. The objective was to build a bakery web application.

## Setup

_C# and .NET needs to be installed for this project to work. If you do not have it, please go to [here for Windows](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) and [here for MacOS](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer)._

1. Download this repository by clicking the "Clone or Download" button
2. Navigate to the folder where it downloaded
3. Now open your terminal and navigate to ForSale.Solution > ForSale.Tests
4. Type in `dotnet restore` to download necessary packages
5. Navigate to ForSale.Solution > ForSale
6. Then type in `dotnet run` to run the application
7. Congratulations, this is the program!

## Specs

Describe: Order Object

Test: "should correctly create an order object when the required parameters are passed in"
Given 1: Order newOrder = new Order("Order One", "Pastries order", 50, "12/22/2020");
Given 2: string myOrder = "Pastries order";
Expect: Assert.AreEqual(myOrder, newOrder.Description);

Describe: Vendor Object

Test: "should correctly create a vendor object when the required parameters are passed in"
Given 1: Vendor newVendor = new Vendor("Marie's Cafe", "Marie started her bakery in 1950.");
Given 2: string myVendorsDescription = "Marie started her bakery in 1950";
Expect: Assert.AreEqual(myVendorsDescription, newVendor.Description);

## Known Bugs

At this time, there are no known bugs. If you see spot a bug feel free to make a pull request.

## Technologies Used

- C#
- .NET
- Object Oriented Programming
- MSTest

## License

This repository is licensed under the MIT license.

Copyright (c) 2020 by _Austin Schrader_
