# Fast4X

Fast4X is game inspired by the original Master of Orion game and its streamlined version of [4X](https://en.wikipedia.org/wiki/4X) style of gameplay. This project is also testing TDD ([Test Driven Development](https://en.wikipedia.org/wiki/Test-driven_development)) in the context of game development. The book ["Growing Object-Oriented Software, Guided by Tests"](http://www.growing-object-oriented-software.com/), which combines both unit testing and end-to-end testing in an advanced form of TDD, was the main reference used. Please note that this project is just my interpretation of the book's ideas in to game development and not a canonical example.

## Project structure

The project is currently split in to 3 parts (projects in Visual Studio):
* Core is the main game logic, without UI. It creates a DLL of the game, for a UI implementation to use.
* Assembly-CSharp is the [Unity](https://unity.com/) project, which is currently the only way to render the game.
* Test contains the tests created during the TDD process for the Core.

## Game

TODO: Describe game mechanics

