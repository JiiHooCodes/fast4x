# Fast4X

Fast4X is game inspired by the original [Master of Orion](https://en.wikipedia.org/wiki/Master_of_Orion) game and its streamlined version 
of [4X](https://en.wikipedia.org/wiki/4X) style of gameplay. This project is also testing TDD ([Test Driven Development](https://en.wikipedia.org/wiki/Test-driven_development)) 
in the context of game development. The book ["Growing Object-Oriented Software, Guided by Tests"](http://www.growing-object-oriented-software.com/), which combines both unit 
testing and end-to-end testing in an advanced form of TDD, was the main reference used. Please note that this project is just my interpretation of the book's ideas in to 
game development and not a canonical example.

## Project structure

The project is currently split in to 4 parts (projects in Visual Studio):
* Fast4XCore is the main game logic, without UI. It creates a DLL of the game, for a UI implementation to use.
* Fast4XTest contains the tests created during the TDD process for the Fast4XCore.
* UnityCode is the [Unity](https://unity.com/) project, which is currently the only way to render the game.
* UnityTests contain acceptance tests, that can be run in Unity Test Runner.


## Game

TODO: Describe game mechanics


## Setup for Development

Programs:
* [Microsoft Visual Studio Community 2019](https://visualstudio.microsoft.com/vs/community/) (Version 16.10.4)
* [Unity](https://store.unity.com/download-nuo) (Version: 2020.3.15f2.723.3)

Steps:
* Open Visual Studio and open Fast4X.sln in the project's root folder
* Build the solution (Menu: Build -> Build solution)
* Open Unity and open the Fast4XUnity project
* Start Playmode in Unity

## Why is this repository public, but not Open Source?

This repository has been made public to allow other developers to study and critique it. TDD is rarely used in game development and hopefully this repository offers insight on 
when and how it should be used. Discussions are open for any comments, critiques and questions.

## Legal

Copyright 2021 Janne Hanhela. All rights reserved. 