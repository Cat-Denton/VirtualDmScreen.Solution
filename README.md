# _Virtual DM Screen_

#### _A database-backed web app that to enable players to Roleplay with each other online. Users may choose either a DM or Player role. DMs can choose background pictures and music. DMs and Players may chat and roll dice. WiP. Refresh the page to see chat and dice roll messages._

#### By _**Shanen Cross**_, _**Cat Denton**_, _**Juan Hasbun**_

## Technologies Used

* C#
* .NET V5
* ASPNET CORE MVC
* Razor
* Entity Framework Core
* Identity
* MySql

## Description

_An Epicodus Teamweek project for the January 2021 Part Time Cohort. This is a WiP application that uses a MySQL database to allow users to register with a character name, a character portrait, and choose to be either the DM or a Player. The DM can set background music and a background picture from hard-coded choices. The DM or Players can enter chat messages or dice rolls. If the other users refresh their browser after changes are made, they can see the updated background picture and see new chat messages and dice rolls. Further work planned for this application is to implement Ajax to allow the DOM to update in real time when users make changes to the database._

<!-- ![Relationship Chart](https://i.imgur.com/9XYbJ4p.png) -->

## Setup/Installation Requirements

* Install microsoft .NET V5
* Clone repository to local drive
* Open code with a text editor
* Open terminal
* Change directory to VirtualDmScreen.Solution/VirtualDmScreen
* Type "dotnet touch appsettings.json"
* Enter the following code into appsettings.json, change the password to your MySql server password and save
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=cat_denton;uid=root;pwd=[yourPwHere];"
  }
}
```
* Type "dotnet build" in terminal and hit enter
* Type "dotnet ef database update"
* Type "dotnet run" in the terminal and hit enter

## Known Bugs

* Remote users need to refresh browser to see changes to database information

## License

Copyright 2021 Cat Denton, Shanen Cross, Juan Hasbun

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



## Contact Information

_Cat Denton <cat.denton.dev@gmail.com>_
