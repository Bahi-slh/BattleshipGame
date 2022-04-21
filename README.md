Battleship Game is a .NET Core web API Project

Public endpoint:

https://battleshipgame20220421113109.azurewebsites.net/index.html

Requirements to run Battleship Game:

Visual Studio (.Net Core 3.1 and C# installed), A web browser

Game rules:

The goal is to implement a Battleship state-tracker for a single player that must support the following logic: 
● Create a board  

● Add a battleship to the board 

● Take an “attack” at a given position, and report back whether the attack resulted in a hit or a miss. 

Application does not implement the entire game, just the state tracker. No UI or persistence layer is added. 


Structure:

Battleship Game solution contains two projects


BattleShipGame - contains BattleShip API Controllers along with implementation of Business rules(Game Rules), data models and constant enums
BattleShipGameTestProject - 16 Unit test Project using xunit


Running the code:

Open Battleship Game Project sln file in Visual Studio and Run the code. It will be run in a web-browser where Swagger is used to visualise the APIs. 
Choose an API to try it out. Give arbitrary values in JSON format and press on Excute button. Results will apear.
Put these enum values in JSON format while trying APIs out:

CellStatus:

Filled=0 / Empty=1 / Hit=2 / Miss=3


ShipDirection:

Horizontal=0 / Vertical=1


ShipType:

Destroyer=0 / Cruiser=1 / BattleShip=2 / Carrier=3



Running the Tests:

There are already some values to run the test. These values can be changed in test classes. 
To run tests, right click on the class test you wish to test and click on Run tests. The tests must be passed.
