# Memory Game - Witcher Style

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Features](#features)
- [Class Overview](#class-overview)
- [Project Status](#project-status)
- [Layout of Applcation](#Layout-of-Application)

## Introduction
**Memory Game** is a simple card-matching game inspired by the Witcher universe, built using C# and WPF. The project was created primarily to explore and familiarize myself with the WPF framework and C# fundamentals. In this game, players flip cards to find matching pairs, challenging their memory skills. The design follows WPF standards to achieve a clean interface and user experience.

## Technologies
The project was developed using the following technologies:
- **Programming Language**: C# (.NET Framework)
- **Framework**: WPF (Windows Presentation Foundation)



## Features
The game offers a straightforward gameplay experience with the following features:

Two screens:
Main Menu: Includes instructions on how to play and a "Play Game" option to start the game.
Gameplay Screen: Where the main game takes place, with cards laid out in a grid to be flipped and matched.
Simple game mechanics: Flip cards to reveal images, match pairs, and try to clear the grid.

## Class Overview
This section describes the main classes and their roles in the project:

BackSideCard: Manages the properties and appearance of the card backs in the game.
FrontSideCard: Manages the properties and appearance of the card fronts, including assigned images for matching.
CardFlippingManager: Contains the core logic for card interactions, such as verifying matches, blocking actions during flips, and tracking flipped cards.
FlippingCard: Implements the flip animation for cards, integrating the back and front sides visually.
FourxThreeGamePanel: Manages the gameplay layout, handling random image assignment to cards, managing end-of-game scenarios, resetting the game, and overseeing player turns and scores.
MainWindow: The main entry point of the application, featuring the main menu and handling navigation to different screens like the game panel and instructions.


## Project Status
Current status: Complete
This project serves as a learning exercise and a demonstration of WPF capabilities. No further development is planned at this time.

## Layout of Application

<img width="960" alt="363367502-9f2749f7-a213-4e81-ad2f-68eaa08d4652" src="https://github.com/user-attachments/assets/6e8e76d4-613e-40b3-acd2-60c5608b53c6">

<img width="959" alt="363367576-7d3571ff-d3c3-4305-b5f0-cba4914b4157" src="https://github.com/user-attachments/assets/6be73378-89d7-40c6-805a-7b416d03d545">
