# Order Tracker

#### By Cory Nordenbrock
##### 12/18/20

## _What_ does it do?

* This app allows a user to create a list of vendors and add specific orders placed by each vendor to neatly manage and track sales.

## _Why_ does it do?

* This project was prompted by the wonderful people at [Epicodus](https://www.epicodus.com/) as an exercise in the architectural style of Model-View-Controller development. An added emphasis of TDD was implemented as well.

## Setup Instructions

   _**Note**: [.NET Core](https://dotnet.microsoft.com/download) must be installed for the following instructions (v 2.2 for current source code, later versions may be used by editing the ` <TargetFramework> ` element in OrderTracker.csproj to reflect the correct version)._

* To run program:

1. Clone this repository: ` git clone https://github.com/cordenbrock/OrderTracker.Solution `
2. Navigate to this specific directory from project folder root: ` cd OrderTracker.Solution/OrderTracker `
3. From the terminal, pass a ` dotnet run ` command. This will install all the necessary dependencies, build the app, and run the app on a local server.
4. From the web browser, go to http://localhost:5000 to use app.



* To run program tests:

1. Navigate to this specific directory from project folder root: ` cd OrderTracker/OrderTracker.Tests `. If navigating from the aforementioned directory, be sure to first navigate "up" a folder, i.e. prepend a ` ../ ` to the path.
2. Run the tests with a ` dotnet test ` command.

## Built with/Tools used

* _C#_
* _ASP.NET Core Razor MVC_
* _MSTests_

### Known Bugs/Future Improvements

* No known bugs at this time
* Edit/delete functionality could be added

### Legal

MIT License, (c) 2020 Cory Nordenbrock